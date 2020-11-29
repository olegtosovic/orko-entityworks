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
    /// Table2 entity.
    /// </summary>
    public sealed partial class Table2 : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Table2()
        {
            // Cache field metadata.
            EntityMeta<Table2>.LoadColumnMetadata
			(
				new ColumnMetadata("Table2ID", @"Table2ID", SqlDbType.Int, isPrimaryKey: true)
			);

            // Cache entites metadata.
            EntityMeta<Table2>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Table2>.HasLanguageTable = false;
            EntityMeta<Table2>.TableSchema = "Abstract";
            EntityMeta<Table2>.TableName = "Table2";
            EntityMeta<Table2>.LanguageTableSchema = null;
            EntityMeta<Table2>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? Table2ID { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Table2>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Table2>(queryConditions);
        }
        public static async Task<IEnumerable<Table2>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Table2>(columnName, queryOp, value);
        }
		public static async Task<Table2> GetByPrimaryKeyAsync(int Table2ID)
        {
            return await GetByPrimaryKeyAsync<Table2>(Table2ID);
        }
		public static async Task<Table2> TryGetByPrimaryKeyAsync(int Table2ID)
        {
            return await TryGetByPrimaryKeyAsync<Table2>(Table2ID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Table2> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Table2>(queryConditions);
        }
        public static IEnumerable<Table2> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Table2>(columnName, queryOp, value);
        }
		public static Table2 GetByPrimaryKey(int Table2ID)
        {
            return GetByPrimaryKey<Table2>(Table2ID);
        }
		public static Table2 TryGetByPrimaryKey(int Table2ID)
        {
            return TryGetByPrimaryKey<Table2>(Table2ID);
        }
        #endregion
    }
}