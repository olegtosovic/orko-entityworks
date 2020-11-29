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
    /// Table4 entity.
    /// </summary>
    public sealed partial class Table4 : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Table4()
        {
            // Cache field metadata.
            EntityMeta<Table4>.LoadColumnMetadata
			(
				new ColumnMetadata("Table4ID", @"Table4ID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("Table4Integer", @"Table4Integer", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("Table4String", @"Table4String", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("Table4Active", @"Table4Active", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Table4>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Table4>.HasLanguageTable = false;
            EntityMeta<Table4>.TableSchema = "Abstract";
            EntityMeta<Table4>.TableName = "Table4";
            EntityMeta<Table4>.LanguageTableSchema = null;
            EntityMeta<Table4>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? Table4ID { get; set; }
        public int? Table4Integer { get; set; }
        public string Table4String { get; set; }
        public bool? Table4Active { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Table4>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Table4>(queryConditions);
        }
        public static async Task<IEnumerable<Table4>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Table4>(columnName, queryOp, value);
        }
		public static async Task<Table4> GetByPrimaryKeyAsync(int Table4ID)
        {
            return await GetByPrimaryKeyAsync<Table4>(Table4ID);
        }
		public static async Task<Table4> TryGetByPrimaryKeyAsync(int Table4ID)
        {
            return await TryGetByPrimaryKeyAsync<Table4>(Table4ID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Table4> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Table4>(queryConditions);
        }
        public static IEnumerable<Table4> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Table4>(columnName, queryOp, value);
        }
		public static Table4 GetByPrimaryKey(int Table4ID)
        {
            return GetByPrimaryKey<Table4>(Table4ID);
        }
		public static Table4 TryGetByPrimaryKey(int Table4ID)
        {
            return TryGetByPrimaryKey<Table4>(Table4ID);
        }
        #endregion
    }
}