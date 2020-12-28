using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represents cached net property and sql column with all common operations.
    /// </summary>
    public sealed class Property<TObject> where TObject : class, new()
    {
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
        private Func<TObject, object> GetDelegate;
        /// <summary>
        /// Setter method delegate.
        /// </summary>
        private Action<TObject, object> SetDelegate;
        /// <summary>
        /// Database reader specific get method delegate.
        /// </summary>
        private Func<IDataReader, int, object> GetDataReaderValueDelegate;
        #endregion

        #region Caching methods
        /// <summary>
        /// Caches specific databse reader get value method.
        /// </summary>
        internal void CacheDataReaderGetValue()
		{
            // If binary type.
            if (SqlDbType == DbType.Binary)
            {
                GetDataReaderValueDelegate = (dataReader, ordinal) =>
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

            // If string value.
            else if (SqlDbType == DbType.String || SqlDbType == DbType.AnsiString || SqlDbType == DbType.AnsiStringFixedLength)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetString(ordinal); };
            
            // If signed byte value.
            else if (SqlDbType == DbType.SByte)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetByte(ordinal); };

            // If unsigned byte value.
            else if (SqlDbType == DbType.Byte)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetByte(ordinal); };

            // If Int16 value.
            else if (SqlDbType == DbType.Int16)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetInt16(ordinal); };
            
            // If Int32 value.
            else if (SqlDbType == DbType.Int32)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetInt32(ordinal); };

            // If Int64 value.
            else if (SqlDbType == DbType.Int64)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetInt64(ordinal); };

            // If Boolean value.
            else if (SqlDbType == DbType.Boolean)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetBoolean(ordinal); };

            // If Decimal value.
            else if (SqlDbType == DbType.Decimal)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetDecimal(ordinal); };

            // If Datetime value.
            else if (SqlDbType == DbType.DateTime || SqlDbType == DbType.DateTime2 || SqlDbType == DbType.Date)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetDateTime(ordinal); };

            // If Guid value.
            else if (SqlDbType == DbType.Guid)
                GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetGuid(ordinal); };

            // Other types.
            else GetDataReaderValueDelegate = (dataReader, ordinal) => { return dataReader.GetValue(ordinal); };
        }
        /// <summary>
        /// Caches and compiles getter method for fast property operation.
        /// </summary>
        private void CacheGet()
        {
            // Get GetMethod method info via reflection.
            MethodInfo getMethodInfo = PropertyInfo.GetGetMethod();

            // Create parameter expression.
            ParameterExpression instanceExpression = Expression.Parameter(typeof(TObject));

            // Unary expression for instance conversion.
            UnaryExpression instanceCast = DeclaringType.IsValueType ?
                Expression.Convert(instanceExpression, DeclaringType) :
                Expression.TypeAs(instanceExpression, DeclaringType);        

            // Create method call expression.
            MethodCallExpression methodCallExpression = Expression.Call(instanceCast, getMethodInfo);

            // Create mehod class with cast expression.
            var methodCastExpression = Expression.TypeAs(methodCallExpression, typeof(object));

            // Compile GetMethod method call to get delegate.
            GetDelegate = Expression
                .Lambda<Func<TObject, object>>(methodCastExpression, instanceExpression)
                .Compile();
        }
        /// <summary>
        /// Caches and compiles setter method for fast property operation.
        /// </summary>
        private void CacheSet()
        {
            // Get SetMethod method info via reflection.
            MethodInfo setMethodInfo = PropertyInfo.GetSetMethod(true);

            // Create parameter expression for instance.
            ParameterExpression instanceExpression = Expression.Parameter(DeclaringType);

            // Create parameter expression for value.
            ParameterExpression valueExpression = Expression.Parameter(typeof(object));

            // Unary expression for instance conversion.
            UnaryExpression instanceCast = DeclaringType.IsValueType ?
                Expression.Convert(instanceExpression, DeclaringType) : 
                Expression.TypeAs(instanceExpression, DeclaringType);

			// Unary expression for value conversion.
			UnaryExpression valueCast = PropertyType.IsValueType ? 
                Expression.Convert(valueExpression, PropertyType) : 
                Expression.TypeAs(valueExpression, PropertyType);

            // Create method call expression.
            MethodCallExpression methodCallExpression = Expression.Call(instanceCast, setMethodInfo, valueCast);

            // Create arguments for method.
            var parameters = new ParameterExpression[] { instanceExpression, valueExpression };

            // Compile SetMethod method call to set delegate.
            SetDelegate = Expression
                .Lambda<Action<TObject, object>>(methodCallExpression, parameters)
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
        /// Property .net member name.
        /// </summary>
        public string PropertyName { get; private set; }
        /// <summary>
        /// Property .net member name with monkey representing parameter.
        /// </summary>
        public string PropertyNameWithMonkey { get; private set; }
        /// <summary>
        /// Sql name as an database object name.
        /// </summary>
        public string PropertySqlName { get; private set; }
        /// <summary>
        /// Sql column ordinal position.
        /// </summary>
        public int Oridinal { get; private set; }
        /// <summary>
        /// Property declaring type.
        /// </summary>
        public Type DeclaringType { get; private set; }
        /// <summary>
        /// Property type.
        /// </summary>
        public Type PropertyType { get; private set; }
        /// <summary>
        /// Property database agnostic type.
        /// </summary>
        public DbType SqlDbType { get; private set; }
        #endregion

        #region Attributes
        public bool IsBaseProperty { get; private set; }
        public bool IsPrimaryKey { get; private set; }
        public bool IsForeignKey { get; private set; }
        public bool IsUnique { get; private set; }
        public bool IsIdentity { get; private set; }
		public bool IsTimestamp { get; private set; }
        public bool IsComputed { get; private set; }
        public bool IsRequired { get; private set; }
        public bool IsLanguage { get; private set; }
        public bool IsLanguageCode { get; private set; }
        public bool IsEntityChild { get; private set; }
        #endregion

        #region Internal public methods
        /// <summary>
        /// Assignes property attributes given generated field metadata.
        /// </summary>
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
        /// <summary>
        /// Assignes property foreign key relations given relation metadata.
        /// </summary>
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
		/// <summary>
		/// Sets property value using precompiled setter.
		/// </summary>
		internal void SetValue(object value, TObject instance)
		{
			//value = DataTools.SqlToNetConvert(value);
			SetDelegate(instance, value);
		}
		/// <summary>
		/// Gets property value using precompiled getter.
		/// </summary>
		internal object GetValue(TObject instance)
		{
			// If member parent instance is null return null.
			if (instance == null)
				return null;

			// Get value.
			object value = GetDelegate(instance);
			if (value == null) return DBNull.Value;
			else return value;
		}
		/// <summary>
		/// Sets property value using reflection.
		/// </summary>
		internal void SetValueSafe(object value, TObject instance)
        {
            PropertyInfo.SetValue(instance, value);
        }
        /// <summary>
        /// Gets property value using reflection.
        /// </summary>
        internal object GetValueSafe(TObject instance)
        {
            object value = PropertyInfo.GetValue(instance);
            if (value == null) return DBNull.Value;
            else return value;
        }
        /// <summary>
        /// Gets datareader specific type getter method and reads value.
        /// </summary>
        internal object GetDbValue(IDataReader dataReader, int ordinal)
        {
            // Return data reader value.
            return GetDataReaderValueDelegate(dataReader, ordinal);
        }
        #endregion
    }
}
