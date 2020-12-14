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
        #region Type methods
        /// <summary>
        /// Runs entity static constructor.
        /// </summary>
        private void RunStaticConstrucor()
        {
            // Get type info.
            TypeInfo entityTypeInfo = typeof(TEntity).GetTypeInfo();

            // Run static constructor.
            RuntimeHelpers.RunClassConstructor(entityTypeInfo.UnderlyingSystemType.TypeHandle);

            // Cache type info.
            TypeInfo = entityTypeInfo;
        }
        #endregion

        #region Cache methods
        /// <summary>
        /// Caches optimization flags.
        /// </summary>
        private void CacheFlags()
        {
            // Language table.
            HasLanguageTable = EntityMeta<TEntity>.HasLanguageTable;
        }
        /// <summary>
        /// Caches object database path.
        /// </summary>
        private void CacheObjectPath()
        {
            // Construct path.
            SqlTablePathWithSchema = "[" + EntityMeta<TEntity>.TableSchema + "]" + "." + "[" + EntityMeta<TEntity>.TableName + "]";

            // Construct language path.
            if (HasLanguageTable)
                SqlLanguageTablePathWithSchema = "[" + EntityMeta<TEntity>.LanguageTableSchema + "]" + "." + "[" + EntityMeta<TEntity>.LanguageTableName + "]";
        }
        /// <summary>
        /// Caches all properties.
        /// </summary>
        protected void CacheProperties()
        {
            // Get binding flags for properties.
            var bindingFlags = BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic;

            // Get properties with binding flags.
            var properties = TypeInfo.GetProperties(bindingFlags);

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
        /// Caches all parameters for table entity.
        /// </summary>
        private void CacheParameters()
        {
            // Only plain fields can be parameters.
            foreach (var property in Properties.Values.Where(x => !x.IsForeignKey))
            {
                // Create parameter.
                Parameter parameter = new Parameter(
                    property.PropertySqlName,
                    property.PropertyInfo,
                    property.SqlDbType,
                    SqlTablePathWithSchema,
                    SqlLanguageTablePathWithSchema,
                    property.IsLanguage,
                    property.IsLanguageCode,
                    property.IsIdentity,
                    property.IsTimestamp,
                    property.IsPrimaryKey);

                // Cache parameter.
                Parameters.Add(property.PropertyName, parameter);
            }
        }
        /// <summary>
        /// Caches primary key parameters for type in context.
        /// </summary>
        private void CachePrimaryKeyParameters()
        {
            PrimaryKeyParameters.AddRange(Parameters.Values.Where(x => x.IsPrimary && x.IsLanguageCode == false));
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
		#endregion

		#region Constructors
		/// <summary>
		/// Creates instance of entity works context object.
		/// Only for internal usage.
		/// </summary>
		internal EntityContext()
        {
            // Create instances.
            PrimaryKeyParameters = new List<Parameter>();
            Parameters = new Dictionary<string, Parameter>();
            Properties = new Dictionary<string, Property<TEntity>>();
            RequiredProperties = new List<Property<TEntity>>();

            // Entity static constructor ***MUST*** run or be runned at this point.
            // Entity static constructor load entity metadata via EntityMeta<TEntity>.
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
        /// Table full database path.
        /// </summary>
        public string SqlTablePathWithSchema { get; private set; }
        /// <summary>
        /// Object language full database path prefix.
        /// </summary>
        public string SqlLanguageTablePathWithSchema { get; private set; }
        /// <summary>
        /// Indicates whether table has language table.
        /// </summary>
        public bool HasLanguageTable { get; internal set; }
        /// <summary>
        /// Entity type info.
        /// </summary>
        public TypeInfo TypeInfo { get; internal set; }
        #endregion        

        #region CRUD strings
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

        #region Static methods
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
