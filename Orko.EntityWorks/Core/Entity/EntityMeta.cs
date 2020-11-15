using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Entity database mapping information.
    /// </summary>
    public static class EntityMeta<TEntity> where TEntity : Entity, new()
    {
        #region Constructors
        static EntityMeta()
        {
            // Initialization.
            EntityRelations = new List<RelationMetadata>();
            EntityFields = new List<ColumnMetadata>();
            HasLanguageTable = false;
        }
        #endregion

        #region Metadata properties
        public static List<RelationMetadata> EntityRelations { get; set; }
        public static List<ColumnMetadata> EntityFields { get; set; }
        public static string TableSchema { get; set; }
        public static string TableName { get; set; }
        public static string LanguageTableSchema { get; set; }
        public static string LanguageTableName { get; set; }
        public static bool HasLanguageTable { get; set; }
        public static bool ComplexEntity { get; set; }
        #endregion

        #region Metadata methods
        public static void LoadRelationMetadata(params RelationMetadata[] relationMetadata)
        {
            // Load metadata list.
            if (relationMetadata != null)
                foreach (var relationMeta in relationMetadata)
                    EntityRelations.Add(relationMeta);
        }
        public static void LoadColumnMetadata(params ColumnMetadata[] fieldMetadata)
        {
            // Load metadata list.
            if (fieldMetadata != null)
                foreach (var fieldMeta in fieldMetadata)
                    EntityFields.Add(fieldMeta);
        }
        internal static ColumnMetadata GetFieldAttributes(Property<TEntity> property)
        {
            // Get fields xml for entity type.
            IEnumerable<ColumnMetadata> fieldMetadataCollection = EntityFields;
            if (fieldMetadataCollection.Any() == false)
                RuntimeHelpers.RunClassConstructor(property.DeclaringType.TypeHandle);

            // Get field attributes.
            return fieldMetadataCollection.Where(x => x.ColumnName == property.PropertyName).First();
        }
        internal static IEnumerable<RelationMetadata> GetPropertyRelations(Property<TEntity> property)
        {
            // Get all relations for entity type.
            IEnumerable<RelationMetadata> relationsMetadata = EntityRelations;
            if (relationsMetadata.Any() == false)
                RuntimeHelpers.RunClassConstructor(property.DeclaringType.TypeHandle);

            // Get all relations for property type.
            return relationsMetadata.Where(x => x.EntityColumnName == property.PropertyName);
        }
        #endregion
    }
}
