using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represents net property and supports common operations.
    /// </summary>
    public sealed class Property<TObject> where TObject : class, new()
    {
        #region Methods
        /// <summary>
        /// Caches specific databse reader get value method.
        /// </summary>
        internal void CacheDataReaderGetValue()
		{
            // If binary type.
            if (SqlDbType == DbType.Binary)
			{
                GetDataReaderValue = (dataReader, ordinal) =>
                {
                    // Get length.
                    var length = (int)dataReader.GetBytes(ordinal, 0, null, 0, 0);

                    // Create byte array.
                    byte[] buffer = new byte[length];

                    // Get bytes.
                    dataReader.GetBytes(ordinal, 0, buffer, 0, length);

                    // Return value.
                    return buffer;
                };
			}

            // Other types (later expand with every single type)
            else
			{
                GetDataReaderValue = (dataReader, ordinal) =>
                {
                    // Get value.
                    dynamic value = dataReader.GetValue(ordinal);

                    // Return value.
                    return value;
                };
            }
		}
        /// <summary>
        /// Cache get by primary key method.
        /// </summary>
        private void CacheDohvatiPrekoPK()
        {
            Type[] types = PropertyType.GetTypeInfo().GetGenericArguments();
            DohvatiPrekoPK = types[0].GetTypeInfo().GetMethod("GetByPrimaryKey");
        }
        /// <summary>
        /// Caches and compiles getter method for fast property operation.
        /// </summary>
        private void CacheGet()
        {
            MethodInfo getMethodInfo = PropertyInfo.GetGetMethod();
            ParameterExpression instance = Expression.Parameter(typeof(object), "instance");

            UnaryExpression instanceCast = null;
            if (DeclaringType.GetTypeInfo().IsValueType)
            {
                instanceCast = Expression.Convert(instance, DeclaringType);
            }
            else instanceCast = Expression.TypeAs(instance, DeclaringType);

            var methodCast = Expression.TypeAs(Expression.Call(instanceCast, getMethodInfo), typeof(object));
            GetDelegate = Expression.Lambda<Func<object, object>>(methodCast, instance).Compile();
        }
        /// <summary>
        /// Caches and compiles setter method for fast property operation.
        /// </summary>
        private void CacheSet()
        {
            MethodInfo setMethodInfo = PropertyInfo.GetSetMethod(true);
            ParameterExpression instance = Expression.Parameter(typeof(object), "instance");
            ParameterExpression value = Expression.Parameter(typeof(object), "value");

            UnaryExpression instanceCast = null;
            if (DeclaringType.GetTypeInfo().IsValueType)
            {
                instanceCast = Expression.Convert(instance, DeclaringType);
            }
            else instanceCast = Expression.TypeAs(instance, DeclaringType);

            UnaryExpression valueCast = null;
            if (PropertyType.GetTypeInfo().IsValueType)
            {
                valueCast = Expression.Convert(value, PropertyType);
            }
            else valueCast = Expression.TypeAs(value, PropertyType);

            SetDelegate = Expression.Lambda<Action<object, object>>(
                Expression.Call(instanceCast, setMethodInfo, valueCast),
                new ParameterExpression[] { instance, value })
                .Compile();
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates instance of property.
        /// </summary>
        public Property(PropertyInfo propertyInfo)
        {
            // Create instances.
            Relations = new Dictionary<string, string>();

            // Assign properties.
            PropertyInfo = propertyInfo;
            PropertyName = propertyInfo.Name;
            PropertyNameWithMonkey = "@" + PropertyName;
            DeclaringType = propertyInfo.DeclaringType;
            PropertyType = propertyInfo.PropertyType;

            // Assign flags.
            Type entityType = typeof(Entity);
            IsEntityChild = DeclaringType.GetTypeInfo().BaseType == entityType;
            IsForeignKey = PropertyType.GetTypeInfo().BaseType == entityType;

            // If property belongs to entity and is it plain field.
            if (!IsForeignKey)
            {
                CacheGet();
                CacheSet();
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Reflection property info.
        /// </summary>
        public PropertyInfo PropertyInfo { get; private set; }
        /// <summary>
        /// Foreign key relations.
        /// </summary>
        public Dictionary<string, string> Relations { get; private set; }
        #endregion

        #region Delegates
        /// <summary>
        /// Getter method delegate.
        /// </summary>
        private Func<object, object> GetDelegate;
        /// <summary>
        /// Setter method delegate.
        /// </summary>
        private Action<object, object> SetDelegate;
        /// <summary>
        /// Database reader specific get method.
        /// </summary>
        private Func<IDataReader, int, dynamic> GetDataReaderValue;
        #endregion

        #region Properties
        public string PropertyName { get; private set; }
        public string PropertyNameWithMonkey { get; private set; }
        public string PropertySqlName { get; private set; }
        public Type DeclaringType { get; private set; }
        public Type PropertyType { get; private set; }
        public DbType SqlDbType { get; private set; }
        private MethodInfo DohvatiPrekoPK { get; set; }
        private object[] ParametersValues { get; set; }
        #endregion

        #region Attributes
        public bool IsBaseProperty { get; private set; }
        public bool IsPrimaryKey { get; private set; }
        public bool IsForeignKey { get; private set; }
        public bool IsUnique { get; private set; }
        public bool IsIdentity { get; private set; }
		public bool IsTimestamp { get; private set; }
        public bool IsRequired { get; private set; }
        public bool IsLanguage { get; private set; }
        public bool IsLanguageCode { get; private set; }
        public bool IsEntityChild { get; private set; }
        #endregion

        #region Public Methods
        internal void AssignFieldProperty(ColumnMetadata fieldMetadata)
        {
            // Assign attributes to property.
            PropertySqlName = fieldMetadata.ColumnSqlName;
            IsPrimaryKey = fieldMetadata.IsPrimaryKey;
            IsIdentity = fieldMetadata.IsIdentity;
			IsTimestamp = fieldMetadata.IsTimestamp;
            IsRequired = fieldMetadata.IsRequired;
            IsLanguage = fieldMetadata.IsLanguage;
            IsLanguageCode = fieldMetadata.IsLanguageCode;
            SqlDbType = fieldMetadata.SqlDbType;
        }
        internal void CacheRelations(IEnumerable<RelationMetadata> relationsMetadata)
        {
            // Assign relations to property.
            if (relationsMetadata.Any())
            {
                Relations = new Dictionary<string, string>();
                foreach (RelationMetadata relationMetadata in relationsMetadata)
                    Relations.Add(relationMetadata.PrimaryKeyProperty, relationMetadata.ForeignKeyProperty);
            }
        }
        internal void SetValueFast(object value, object instance)
        {
            //this.SetValueSafe(value, instance);
            value = DataTools.SqlToNetConvert(value);
            SetDelegate(instance, value);
        }
        public object GetValueFast(object instance)
        {
            // If member parent instance is null return null.
            if (instance == null)
                return null;

            // Get value.
            object value = GetDelegate(instance);
            if (value == null) return DBNull.Value;
            else return value;
        }
        internal void SetValueSafe(object value, object instance)
        {
            value = DataTools.SqlToNetConvert(value);
            PropertyInfo.SetValue(instance, value);
        }
        internal object GetValueSafe(object instance)
        {
            object value = PropertyInfo.GetValue(instance);
            if (value == null) return DBNull.Value;
            else return value;
        }
        internal dynamic GetDbValue(IDataReader dataReader, int ordinal)
		{
            return GetDataReaderValue(dataReader, ordinal);
		}
        #endregion
    }
}
