using System;
using System.Collections.Generic;
using System.Threading;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Cache storage for entity context.
	/// Reference only. It is not being used anywhere.
	/// </summary>
	class EntityCache<TEntity> where TEntity : Entity, new()
    {
        #region Constructors
        static EntityCache()
        {
            // Create instance for lazy object.
            m_Lazy = new Lazy<EntityCache<TEntity>>(
                () => new EntityCache<TEntity>(), 
                LazyThreadSafetyMode.ExecutionAndPublication
                );
        }
        private EntityCache()
        {
            // Create instances.
            EntityContextDictionary = new Dictionary<Type, EntityContext<TEntity>>();
        }
        #endregion

        #region Singleton
        private static readonly Lazy<EntityCache<TEntity>> m_Lazy;
        private static EntityCache<TEntity> Instance
        {
            get { return m_Lazy.Value; }
        }
        #endregion

        #region Properties
        private Dictionary<Type, EntityContext<TEntity>> EntityContextDictionary { get; set; }
        #endregion

        #region Cache methods
        /// <summary>
        /// Adds entity context object to dictionary.
        /// </summary>
        /// <param name="entityContextObjekt">Entity reflect object.</param>
        public static void Add(EntityContext<TEntity> entityContextObjekt)
        {
            // Get full entity type name
            Type entityObjektType = typeof(TEntity);
            string fullTypeName = entityObjektType.FullName;

            // For given entity type name add entity reflect object
            // to dictionary if not already added.
            if (!Instance.EntityContextDictionary.ContainsKey(entityObjektType))
            {
                Instance.EntityContextDictionary.Add(entityObjektType, entityContextObjekt);
            }
        }
        /// <summary>
        /// Gets entity context object from dictionary. If dictionary does not contain
        /// entity context object for given type then null is returned.
        /// </summary>
        /// <returns>Entity context objekt</returns>
        public static EntityContext<TEntity> Get()
        {
            // Get full entity type name
            Type entityObjektType = typeof(TEntity);
            String fullTypeName = entityObjektType.FullName;

            // For given entity type name get entity reflect object if exists.
            if (Instance.EntityContextDictionary.ContainsKey(entityObjektType))
            {
                return Instance.EntityContextDictionary[entityObjektType];
            }
            else return null;
        }
        #endregion
    }
}
