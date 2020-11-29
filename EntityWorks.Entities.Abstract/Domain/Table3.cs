// Generated on 11/25/2020 11:00 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace OrkoEntityWorks.Abstract
{
    /// <summary>
    /// Table3 entity.
    /// </summary>
    public sealed partial class Table3 : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Table3()
        {
            // Cache field metadata.
            EntityMeta<Table3>.LoadColumnMetadata
			(
				new ColumnMetadata("Table3ID", @"Table3ID", SqlDbType.Int, isPrimaryKey: true)
			);

            // Cache entites metadata.
            EntityMeta<Table3>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Table3>.HasLanguageTable = false;
            EntityMeta<Table3>.TableSchema = "Abstract";
            EntityMeta<Table3>.TableName = "Table3";
            EntityMeta<Table3>.LanguageTableSchema = null;
            EntityMeta<Table3>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? Table3ID { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Table3>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Table3>(queryConditions);
        }
        public static async Task<IEnumerable<Table3>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Table3>(columnName, queryOp, value);
        }
		public static async Task<Table3> GetByPrimaryKeyAsync(int Table3ID)
        {
            return await GetByPrimaryKeyAsync<Table3>(Table3ID);
        }
		public static async Task<Table3> TryGetByPrimaryKeyAsync(int Table3ID)
        {
            return await TryGetByPrimaryKeyAsync<Table3>(Table3ID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Table3> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Table3>(queryConditions);
        }
        public static IEnumerable<Table3> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Table3>(columnName, queryOp, value);
        }
		public static Table3 GetByPrimaryKey(int Table3ID)
        {
            return GetByPrimaryKey<Table3>(Table3ID);
        }
		public static Table3 TryGetByPrimaryKey(int Table3ID)
        {
            return TryGetByPrimaryKey<Table3>(Table3ID);
        }
        #endregion
    }
}