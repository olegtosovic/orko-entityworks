using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Base class for all entity types.
	/// </summary>
	public abstract class Entity
    {
        #region Constructors
        public Entity()
        {
            // Initialization.
            IsNew = true;
        }
        #endregion

        #region Entity operations
        /// <summary>
        /// Returns single entity object from database given primary key value.
        /// Throws RecordNotFoundException if record not found.
        /// </summary>
        protected static TEntity GetByPrimaryKey<TEntity>(params object[] parameters) where TEntity : Entity, new()
        {
            TEntity entity = TryGetByPrimaryKey<TEntity>(parameters);
            if (entity == null)
                throw new RecordNotFoundException("Record does not exists in table: " + typeof(TEntity).Name, null);
            return entity;
        }
        /// <summary>
        /// Returns single entity object (or null) from database given primary key value.
        /// </summary>
        protected static TEntity TryGetByPrimaryKey<TEntity>(params object[] parameters) where TEntity : Entity, new()
        {
            return EntityMechanic<TEntity>.GetByPrimaryKey(parameters);
        }
        /// <summary>
        /// Returns single entity object from database given unique key value.
        /// Throws RecordNotFoundException if record not found.
        /// </summary>
        protected static TEntity GetByCallingParameters<TEntity>(params object[] parameters) where TEntity : Entity, new()
        {
            TEntity entity = TryGetByCallingParameters<TEntity>(parameters);
            if (entity == null)
                throw new RecordNotFoundException("Record does not exists in table: " + typeof(TEntity).Name, null);
            return entity;
        }
        /// <summary>
        /// Returns single entity object (or null) from database given unique key value.
        /// </summary>
        protected static TEntity TryGetByCallingParameters<TEntity>(params object[] parameters) where TEntity : Entity, new()
        {
            return EntityMechanic<TEntity>.GetByUniqueKey(parameters);
        }
        /// <summary>
        /// Returns collection of entites given query conditions.
        /// </summary>
        protected static IEnumerable<TEntity> GetByAny<TEntity>(params QueryCondition[] queryConditions) where TEntity : Entity, new()
        {
            return EntityMechanic<TEntity>.GetByAny(queryConditions);
        }
        /// <summary>
        /// Returns collection of entites given query condition.
        /// </summary>
        protected static IEnumerable<TEntity> GetByAny<TEntity>(string columnName, QueryOp queryOp, object value) where TEntity : Entity, new()
        {
            return EntityMechanic<TEntity>.GetByAny(columnName, queryOp, value);
        }
		#endregion

		#region Entity operations async
		/// <summary>
		/// Returns single entity object from database given primary key value.
		/// Throws RecordNotFoundException if record not found.
		/// </summary>
		protected static async Task<TEntity> GetByPrimaryKeyAsync<TEntity>(params object[] parameters) where TEntity : Entity, new()
		{
			TEntity entity = await TryGetByPrimaryKeyAsync<TEntity>(parameters);
			if (entity == null)
				throw new RecordNotFoundException("Record does not exists in table: " + typeof(TEntity).Name, null);
			return entity;
		}
		/// <summary>
		/// Returns single entity object (or null) from database given primary key value.
		/// </summary>
		protected static async Task<TEntity> TryGetByPrimaryKeyAsync<TEntity>(params object[] parameters) where TEntity : Entity, new()
		{
			return await EntityMechanic<TEntity>.GetByPrimaryKeyAsync(parameters);
		}
		/// <summary>
		/// Returns single entity object from database given unique key value.
		/// Throws RecordNotFoundException if record not found.
		/// </summary>
		protected static async Task<TEntity> GetByCallingParametersAsync<TEntity>(params object[] parameters) where TEntity : Entity, new()
		{
			TEntity entity = await TryGetByCallingParametersAsync<TEntity>(parameters);
			if (entity == null)
				throw new RecordNotFoundException("Record does not exists in table: " + typeof(TEntity).Name, null);
			return entity;
		}
		/// <summary>
		/// Returns single entity object (or null) from database given unique key value.
		/// </summary>
		protected static async Task<TEntity> TryGetByCallingParametersAsync<TEntity>(params object[] parameters) where TEntity : Entity, new()
		{
			return await EntityMechanic<TEntity>.GetByUniqueKeyAsync(parameters);
		}
		/// <summary>
		/// Returns collection of entites given query conditions.
		/// </summary>
		protected static async Task<IEnumerable<TEntity>> GetByAnyAsync<TEntity>(params QueryCondition[] queryConditions) where TEntity : Entity, new()
		{
			return await EntityMechanic<TEntity>.GetByAnyAsync(queryConditions);
		}
		/// <summary>
		/// Returns collection of entites given query condition.
		/// </summary>
		protected static async Task<IEnumerable<TEntity>> GetByAnyAsync<TEntity>(string columnName, QueryOp queryOp, object value) where TEntity : Entity, new()
		{
			return await EntityMechanic<TEntity>.GetByAnyAsync(columnName, queryOp, value);
		}
		#endregion

		#region CRUD
		/// <summary>
		/// Saves entity object to database.
		/// </summary>
		/// <typeparam name="TEntity">Type of entity. Eg. Person, Customer ...</typeparam>
		protected void Save<TEntity>() where TEntity : Entity, new()
        {
            EntityMechanic<TEntity>.SaveEntity(this);
        }
        /// <summary>
        /// Deletes entity object from database.
        /// </summary>
        /// <typeparam name="TEntity">Type of entity. Eg. Person, Customer ...</typeparam>
        protected void Delete<TEntity>() where TEntity : Entity, new()
        {
            EntityMechanic<TEntity>.DeleteEntity(this);
        }        
		#endregion

		#region CRUD async
		/// <summary>
		/// Saves entity object to database.
		/// </summary>
		/// <typeparam name="TEntity">Type of entity. Eg. Person, Customer ...</typeparam>
		protected async Task SaveAsync<TEntity>() where TEntity : Entity, new()
		{
			await EntityMechanic<TEntity>.SaveEntityAsync(this);
		}
		/// <summary>
		/// Deletes entity object from database.
		/// </summary>
		/// <typeparam name="TEntity">Type of entity. Eg. Person, Customer ...</typeparam>
		protected async Task DeleteAsync<TEntity>() where TEntity : Entity, new()
		{
			await EntityMechanic<TEntity>.DeleteEntityAsync(this);
		}
		#endregion

		#region Entity state
		/// <summary>
		/// Indicates whether object is created.
		/// </summary>
		public bool IsNew { get; set; }
		#endregion

		#region Required validation
		/// <summary>
		/// Validates entity object against in memory copy of database constraints.
		/// </summary>
		/// <typeparam name="TEntity">Type of entity. Eg. Person, Customer ...</typeparam>
		protected void Validate<TEntity>() where TEntity : Entity, new()
		{
			EntityMechanic<TEntity>.ValidateEntity(this);
		}
		#endregion

		#region Value methods
		/// <summary>
		/// Gets entity object display value. etc. firstname + lastname.
		/// </summary>
		public virtual string GetDisplayValue()
        {
            return GetType().Name;
        }
        /// <summary>
        /// Gets entity type caption value, etc. for column name in grid.
        /// </summary>
        public static string GetCaptionValue()
        {
            return typeof(Entity).GetType().Name;
        }
        /// <summary>
        /// ToString override.
        /// </summary>
        public override string ToString()
        {
            return GetDisplayValue();
        }
        #endregion
    }
}
