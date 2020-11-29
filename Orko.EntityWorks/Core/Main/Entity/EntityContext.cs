using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Contains all database metadata for entity in context.
	/// This object is created only once for particular entity type and it's called from static clr cache for future usage.
	/// </summary>
	public class EntityContext<TEntity> where TEntity : Entity, new()
    {
        #region Constructors
        internal EntityContext()
        {
            // Create instances.
            PrimaryKeyParameters = new List<Parameter>();
            Parameters = new Dictionary<string, Parameter>();
            Properties = new Dictionary<string, Property<TEntity>>();
            RequiredProperties = new List<Property<TEntity>>();

            // Entity static constructor *MUST* be run or runned at this point.
            RunStaticConstrucor();

            // Caching.
            CacheFlags();
            CacheObjectPath();
            CacheProperties();
            CacheParameters();
            CachePrimaryKeyParameters();
            CacheLanguageCodeParameter();
            CacheCrudStrings();
        }
        #endregion

        #region Initialization
        /// <summary>
        /// Runs entity static constructor if not already.
        /// </summary>
        private void RunStaticConstrucor()
        {
            // Run static constructor.
            TypeInfo entityTypeInfo = typeof(TEntity).GetTypeInfo();
            RuntimeHelpers.RunClassConstructor(entityTypeInfo.UnderlyingSystemType.TypeHandle);

            // Cache type info.
            EntityTypeInfo = entityTypeInfo;
        }
        #endregion

        #region Accessor
        /// <summary>
        /// Entity property get method.
        /// </summary>
        /// <returns>Entity object</returns>
        public static TEntity Get<TParent>(ref TEntity memberEntity, TParent parentEntity, string propertyName) where TParent : Entity, new()
        {
            // If member entity not null return same object.
            if (memberEntity != null)
                return memberEntity;

            // Get property primary key parameter values.
            object[] newPkparameters = EntityMechanic<TEntity>.GetPrimaryKeyParameters(memberEntity, parentEntity, propertyName);
            memberEntity = EntityMechanic<TEntity>.GetByPrimaryKey(newPkparameters);
            return memberEntity;
        }
        /// <summary>
        /// Entity property set method.
        /// </summary>
        public static void Set<TParent>(ref TEntity memberEntity, TParent parentEntity, TEntity valueEntity, string propertyName) where TParent : Entity, new()
        {
            // Set primary key values.
            EntityMechanic<TEntity>.SetPrimaryKeyParameters(parentEntity, valueEntity, propertyName);

            // Set member entity value.
            memberEntity = valueEntity;
        }
		#endregion

		#region Parameters
		/// <summary>
		/// List containing only primary key parameters for entity object type.
		/// </summary>
		public List<Parameter> PrimaryKeyParameters { get; private set; }
        /// <summary>
        /// Dictionary containing all entity object parameters.
        /// </summary>
        public Dictionary<string, Parameter> Parameters { get; private set; }
        /// <summary>
        /// Language code parameter.
        /// </summary>
        public Parameter LanguageCodeParameter { get; private set; }
        #endregion

        #region Properties
        /// <summary>
        /// Dictionary containing all entity object properties.
        /// </summary>
        public Dictionary<string, Property<TEntity>> Properties { get; private set; }
        /// <summary>
        /// List containing all required properties.
        /// </summary>
        public IList<Property<TEntity>> RequiredProperties { get; set; }
        /// <summary>
        /// Object full database path prefix.
        /// </summary>
        public string SqlPathPrefix { get; private set; }
        /// <summary>
        /// Object language full database path prefix.
        /// </summary>
        public string SqlLanguagePathPrefix { get; private set; }
        /// <summary>
        /// Indicates whether table has language table.
        /// </summary>
        public bool HasLanguageTable { get; internal set; }
        /// <summary>
        /// Entity type info.
        /// </summary>
        public TypeInfo EntityTypeInfo { get; internal set; }
        #endregion

        #region Cache methods
        /// <summary>
        /// Caches primary key parameters for type in context.
        /// </summary>
        private void CachePrimaryKeyParameters()
        {
            PrimaryKeyParameters.AddRange(Parameters.Values.Where(x => x.IsPrimary && x.IsLanguageCode == false));
        }
        /// <summary>
        /// Caches all parameters for table entity.
        /// </summary>
        private void CacheParameters()
        {
            // Only plain fields can be parameters.
            foreach (var property in Properties.Values.Where(x => !x.IsForeignKey))
            {
                // Create parameter.
                Parameter parameter = new Parameter(
                    property.PropertyInfo,
                    property.SqlDbType,
                    SqlPathPrefix, 
                    SqlLanguagePathPrefix, 
                    property.IsLanguage, 
                    property.IsLanguageCode,
                    property.IsIdentity,
					property.IsTimestamp,
                    property.IsPrimaryKey);
                Parameters.Add(property.PropertyName, parameter);
            }
        }
        /// <summary>
        /// Caches language code parameter.
        /// </summary>
        private void CacheLanguageCodeParameter()
        {
            if (HasLanguageTable)
            {
                var languageCodes = Parameters.Where(x => x.Value.IsLanguageCode);
                if (languageCodes.Any())
                    LanguageCodeParameter = languageCodes.First().Value;
                else throw new Exception("Entity is missing language code field metadata.");
            }
        }
        /// <summary>
        /// Caches select, insert, update, delete string for TEntity entity.
        /// </summary>
        private void CacheCrudStrings()
        {
            // Cache select string.
            SelectString = Query<TEntity>.GenerateSelectQuery(this);
        
            // Cache insert string.
            InsertString = Query<TEntity>.GenerateInsertQuery(this);

            // Cache update string.
            UpdateString = Query<TEntity>.GenerateUpdateQuery(this);

            // Cache delete string.
            DeleteString = Query<TEntity>.GenerateDeleteQuery(this);
        }
        /// <summary>
        /// Caches all properties.
        /// </summary>
        protected void CacheProperties()
        {
            // Get reflection properties.
            BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic;
            PropertyInfo[] properties = EntityTypeInfo.GetProperties(bindingFlags);

            // Cache all properties and required properties.
            foreach (var propertyInfo in properties)
            {
                // Create property.
                var property = new Property<TEntity>(propertyInfo);

                // If property belongs to entity and is foreign key.
                if (property.IsEntityChild && property.IsForeignKey)
                {
                    // Cache relations.
                    var relationMetadata = EntityMeta<TEntity>.GetPropertyRelations(property);
                    property.CacheRelations(relationMetadata);
                }

                // If property belongs to entity and is it plain field.
                else if (property.IsEntityChild && !property.IsForeignKey)
                {
                    // Cache field properties.
                    ColumnMetadata columnMetada = EntityMeta<TEntity>.GetFieldAttributes(property);
                    property.AssignFieldProperty(columnMetada);
                }

                // Add to collection.
                Properties.Add(propertyInfo.Name, property);

                // To required collection.
                if ((property.IsRequired || property.IsPrimaryKey) && !property.IsIdentity && !property.IsLanguageCode)
                    RequiredProperties.Add(property);
            }         
        }
        /// <summary>
        /// Caches object database path.
        /// </summary>
        private void CacheObjectPath()
        {
            // Construct path.
            SqlPathPrefix = EntityMeta<TEntity>.TableSchema + "." + EntityMeta<TEntity>.TableName;

            // Construct language path.
            if (HasLanguageTable)
                SqlLanguagePathPrefix = EntityMeta<TEntity>.LanguageTableSchema + "." + EntityMeta<TEntity>.LanguageTableName;
        }
        /// <summary>
        /// Caches optimization flags.
        /// </summary>
        private void CacheFlags()
        {
            // Language table.
            HasLanguageTable = EntityMeta<TEntity>.HasLanguageTable;
        }
        #endregion

        #region Query strings
        /// <summary>
        /// Contains parametrized sql select string for
        /// this entity type ready to be passed to IDbCommand object. 
        /// </summary>
        public string SelectString
        {
            get;
            private set;
        }
        /// <summary>
        /// Contains parametrized sql insert string for
        /// this entity type ready to be passed to IDbCommand object.
        /// </summary>
        public string InsertString
        {
            get;
            private set;
        }
        /// <summary>
        /// Contains parametrized sql update string for
        /// this entity type ready to be passed to IDbCommand object. 
        /// </summary>
        public string UpdateString
        {
            get;
            private set;
        }
        /// <summary>
        /// Contains parametrized sql delete string for
        /// this entity type ready to be passed to IDbCommand object. 
        /// </summary>
        public string DeleteString
        {
            get;
            private set;
        }
        #endregion

        #region Public static methods
        /// <summary>
        /// Retrieves entity data context of calling static type.
        /// </summary>
        public static EntityContext<TEntity> GetEntityContext()
        {
            return EntityMechanic<TEntity>.EntityContext;
        }
        #endregion
    }
}
