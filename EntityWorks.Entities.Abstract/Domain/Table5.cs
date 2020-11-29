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
    /// Table5 entity.
    /// </summary>
    public sealed partial class Table5 : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Table5()
        {
            // Cache field metadata.
            EntityMeta<Table5>.LoadColumnMetadata
			(
				new ColumnMetadata("Table5ID", @"Table5ID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("Table5Integer", @"Table5Integer", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("Table5String", @"Table5String", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("Table5Active", @"Table5Active", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Table5>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Table5>.HasLanguageTable = false;
            EntityMeta<Table5>.TableSchema = "Abstract";
            EntityMeta<Table5>.TableName = "Table5";
            EntityMeta<Table5>.LanguageTableSchema = null;
            EntityMeta<Table5>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? Table5ID { get; set; }
        public int? Table5Integer { get; set; }
        public string Table5String { get; set; }
        public bool? Table5Active { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Table5>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Table5>(queryConditions);
        }
        public static async Task<IEnumerable<Table5>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Table5>(columnName, queryOp, value);
        }
		public static async Task<Table5> GetByPrimaryKeyAsync(int Table5ID)
        {
            return await GetByPrimaryKeyAsync<Table5>(Table5ID);
        }
		public static async Task<Table5> TryGetByPrimaryKeyAsync(int Table5ID)
        {
            return await TryGetByPrimaryKeyAsync<Table5>(Table5ID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Table5> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Table5>(queryConditions);
        }
        public static IEnumerable<Table5> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Table5>(columnName, queryOp, value);
        }
		public static Table5 GetByPrimaryKey(int Table5ID)
        {
            return GetByPrimaryKey<Table5>(Table5ID);
        }
		public static Table5 TryGetByPrimaryKey(int Table5ID)
        {
            return TryGetByPrimaryKey<Table5>(Table5ID);
        }
        #endregion
    }
}