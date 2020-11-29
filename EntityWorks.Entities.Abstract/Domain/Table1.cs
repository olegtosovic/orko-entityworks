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
    /// Table1 entity.
    /// </summary>
    public sealed partial class Table1 : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Table1()
        {
            // Cache field metadata.
            EntityMeta<Table1>.LoadColumnMetadata
			(
				new ColumnMetadata("Table1ID", @"Table1ID", SqlDbType.Int, isPrimaryKey: true)
			);

            // Cache entites metadata.
            EntityMeta<Table1>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Table1>.HasLanguageTable = false;
            EntityMeta<Table1>.TableSchema = "Abstract";
            EntityMeta<Table1>.TableName = "Table1";
            EntityMeta<Table1>.LanguageTableSchema = null;
            EntityMeta<Table1>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? Table1ID { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Table1>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Table1>(queryConditions);
        }
        public static async Task<IEnumerable<Table1>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Table1>(columnName, queryOp, value);
        }
		public static async Task<Table1> GetByPrimaryKeyAsync(int Table1ID)
        {
            return await GetByPrimaryKeyAsync<Table1>(Table1ID);
        }
		public static async Task<Table1> TryGetByPrimaryKeyAsync(int Table1ID)
        {
            return await TryGetByPrimaryKeyAsync<Table1>(Table1ID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Table1> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Table1>(queryConditions);
        }
        public static IEnumerable<Table1> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Table1>(columnName, queryOp, value);
        }
		public static Table1 GetByPrimaryKey(int Table1ID)
        {
            return GetByPrimaryKey<Table1>(Table1ID);
        }
		public static Table1 TryGetByPrimaryKey(int Table1ID)
        {
            return TryGetByPrimaryKey<Table1>(Table1ID);
        }
        #endregion
    }
}