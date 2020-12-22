using System.Data;
using System.Linq;

namespace Orko.EntityWorks
{
	internal class EntityMapper<TEntity> : ObjectMapper<TEntity> where TEntity : Entity, new()
    {
        #region Constructors
        /// <summary>
        /// Creates new entity context mapper object.
        /// </summary>
        public EntityMapper()
        {
            // Get entity context.
            var entityContext = EntityContext<TEntity>.GetEntityContext();

            // Get properties.
            m_Properties = entityContext.Properties.Values.Where(x => !x.IsForeignKey);

            // Set mapping set same as entity properties.
            m_mappingSet = m_Properties;
        }
        /// <summary>
        /// Creates new entity context mapper object.
        /// </summary>
        public EntityMapper(ObjectMappingType objectMappingType, IDataReader dataReader)
        {
            // Get entity context.
            var entityContext = EntityContext<TEntity>.GetEntityContext();

            // Get properties.
            m_Properties = entityContext.Properties.Values.Where(x => !x.IsForeignKey);

            // Set members.
            m_ObjectMappingType = objectMappingType;

            // Determine mapping sets.
            DetermineInterfaceSets(dataReader);
        }

        #endregion
    }
}
