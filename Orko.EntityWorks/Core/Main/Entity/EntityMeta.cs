using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Entity database metadata information.
    /// </summary>
    public static class EntityMeta<TEntity> where TEntity : Entity, new()
    {
        #region Methods
        /// <summary>
        /// Gets field attributes.
        /// </summary>
        internal static ColumnMetadata GetFieldAttributes(Property<TEntity> property)
        {
            // Get fields xml for entity type.
            IEnumerable<ColumnMetadata> fieldMetadataCollection = Fields;
            if (fieldMetadataCollection.Any() == false)
                RuntimeHelpers.RunClassConstructor(property.DeclaringType.TypeHandle);

            // Get field attributes.
            return fieldMetadataCollection.Where(x => x.ColumnNetName == property.PropertyName).First();
        }
        /// <summary>
        /// Gets relations.
        /// </summary>
        internal static IEnumerable<RelationMetadata> GetPropertyRelations(Property<TEntity> property)
        {
            // Get all relations for entity type.
            IEnumerable<RelationMetadata> relationsMetadata = Relations;
            if (relationsMetadata.Any() == false)
                RuntimeHelpers.RunClassConstructor(property.DeclaringType.TypeHandle);

            // Get all relations for property type.
            return relationsMetadata.Where(x => x.PropertyName == property.PropertyName);
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates static instance of EntityMeta object.
        /// </summary>
        static EntityMeta()
        {
            // Create instances.
            Relations = new List<RelationMetadata>();
            Fields = new List<ColumnMetadata>();

            // No language table by default.
            HasLanguageTable = false;
        }
        #endregion

        #region Metadata containers
        /// <summary>
        /// Represents and contains all primary key metadata.
        /// </summary>
        public static List<ColumnMetadata> PrimaryKey { get; private set; }
        /// <summary>
        /// Represents and contains all primary key metadata.
        /// </summary>
        public static List<ColumnMetadata> UniqueKeys { get; private set; }
        /// <summary>
        /// Contains all entity foreign key relation metada.
        /// </summary>
        public static List<RelationMetadata> Relations { get; private set; }
        /// <summary>
        /// Contains all entity columns metadata.
        /// </summary>
        public static List<ColumnMetadata> Fields { get; private set; }

        #endregion

        #region Metadata properties
        /// <summary>
        /// Entity database schema / net namespace.
        /// </summary>
        public static string TableSchema { get; set; }
        /// <summary>
        /// Entity database table sql name.
        /// </summary>
        public static string TableName { get; set; }
        /// <summary>
        /// Entity database language schema / net namespace.
        /// </summary>
        public static string LanguageTableSchema { get; set; }
        /// <summary>
        /// Entity database language table sql name.
        /// </summary>
        public static string LanguageTableName { get; set; }
        /// <summary>
        /// Indicates if main table has language table. For details please refer to documentation.
        /// </summary>
        public static bool HasLanguageTable { get; set; }
        /// <summary>
        /// Indicates if table is complex table. For details please refer to documentation.
        /// </summary>
        public static bool ComplexEntity { get; set; }
        #endregion

        #region Metadata methods
        /// <summary>
        /// Loads and caches foreign key relation metadata.
        /// </summary>
        public static void LoadRelationMetadata(params RelationMetadata[] relationMetadata)
        {
            // Load relation metadata list.
            if (relationMetadata != null)
                foreach (var relationMeta in relationMetadata)
                    Relations.Add(relationMeta);
        }
        /// <summary>
        /// Loads and caches column metadata.
        /// </summary>
        public static void LoadColumnMetadata(params ColumnMetadata[] fieldMetadata)
        {
            // Load column metadata list.
            if (fieldMetadata != null)
                foreach (var fieldMeta in fieldMetadata)
                    Fields.Add(fieldMeta);
        }
        #endregion
    }
}
