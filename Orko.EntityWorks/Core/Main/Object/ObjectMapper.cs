using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Provides mapping functionality in regards with set theory.
	/// </summary>
	internal class ObjectMapper<TObject> where TObject : class, new()
    {
        #region Members
        protected ObjectMappingType m_ObjectMappingType;
        protected IEnumerable<Property<TObject>> m_Properties;
        #endregion

        #region Mapping set
        protected IEnumerable<Property<TObject>> m_mappingSet;
        #endregion

        #region Constructors
        /// <summary>
        /// Used to disengage concrete object mapper constructor.
        /// </summary>
        protected ObjectMapper()
        {

        }
        /// <summary>
        /// Creates new object context mapper.
        /// </summary>
        public ObjectMapper(ObjectMappingType objectMappingType, IDataReader dataReader)
        {
            // Set members.
            m_ObjectMappingType = objectMappingType;

            // Get object context.
            var objectContext = ObjectContext<TObject>.GetObjectContext();

            // Get properties.
            m_Properties = objectContext.Properties.Values;

            // Determine mapping sets.
            DetermineInterfaceSets(dataReader);
        }
        #endregion

        #region Protected methods
        /// <summary>
        /// Resolves mapping set.
        /// </summary>
        /// <param name="dataReader">Data reader</param>
        protected void DetermineInterfaceSets(IDataReader dataReader)
        {
            // Get property sets.
            var queryProperties = dataReader.GetColumnNames();
            var modelProperties = m_Properties.Where(x => !x.IsForeignKey);
            var matchingProperties = modelProperties.Where(x => queryProperties.Contains(x.PropertyName));

            // Get set counts.
            var queryCount = queryProperties.Count();
            var modelCount = modelProperties.Count();
            var matchingCount = matchingProperties.Count();

            // Validate interface sets.
            ValidateInterfaceSets(queryCount, modelCount, matchingCount);

            // Set mapping set.
            m_mappingSet = matchingProperties;                             
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Validates mapping sets.
        /// </summary>
        /// <param name="queryCount">Data reader columns count</param>
        /// <param name="modelCount">Object property count</param>
        /// <param name="matchingCount">Intersected properties count</param>
        private void ValidateInterfaceSets(int queryCount, int modelCount, int matchingCount)
        {
            // If query first mapping.
            if (m_ObjectMappingType == ObjectMappingType.QueryFirst)
            {
                // If it is not same number throw exception.
                if (matchingCount < queryCount)
                    throw new Exception("QueryFirst mapping type violation.");
            }

            // If model first mapping.
            else if (m_ObjectMappingType == ObjectMappingType.ModelFirst)
            {
                // If it is not same number throw exception.
                if (matchingCount < modelCount)
                    throw new Exception("ModelFirst mapping type violation.");
            }

            // If exact mapping.
            else if (m_ObjectMappingType == ObjectMappingType.Exact)
            {
                // If there is not exact matching properties as query and model properties.
                if (matchingCount != modelCount ||
                    matchingCount != queryCount)
                    throw new Exception("Exact mapping type violation.");
            }

            // If intersect mapping.
            else if (m_ObjectMappingType == ObjectMappingType.Intersect)
            {
                if (matchingCount == 0)
                    throw new Exception("Intersect mapping type violation.");
            }
        }
        #endregion

        #region Mapping
        /// <summary>
        /// Maps data reader data to object instance.
        /// </summary>
        /// <param name="instance">Object instance to map to</param>
        /// <param name="dataReader">Active data reader</param>
        public void MapToObject(TObject instance, IDataReader dataReader)
        {
            // For every determined property map to object.
            foreach (var property in m_mappingSet)
            {
                object value = dataReader[property.PropertyName];
                property.SetValueFast(value, instance);
            }
        }
        /// <summary>
        /// Maps source object to instance object.
        /// </summary>
        /// <param name="instance">Object instance to map to</param>
        /// <param name="source">Source object instance</param>
        public void MapToObject(TObject instance, TObject source)
        {
            // For every determined property map to object.
            foreach (var property in m_mappingSet)
            {
                // Get source property value.
                object value = property.GetValueFast(source);

                // Set source property value.
                property.SetValueFast(value, instance);
            }
        }
        #endregion
    }
}
