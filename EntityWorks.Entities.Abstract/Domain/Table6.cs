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
    /// Table6 entity.
    /// </summary>
    public sealed partial class Table6 : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Table6()
        {
            // Cache field metadata.
            EntityMeta<Table6>.LoadColumnMetadata
			(
				new ColumnMetadata("Table6ID", @"Table6ID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("Table6Integer", @"Table6Integer", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("Table6String", @"Table6String", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("Table6Active", @"Table6Active", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("KenovaKakoSte", @"Kenova<> ''\KakoSte", SqlDbType.NChar, isRequired: false),
                new ColumnMetadata("Kenova2KakoSte", @"Kenova2<> ''\\/-,,KakoSte", SqlDbType.NChar, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Table6>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Table6>.HasLanguageTable = false;
            EntityMeta<Table6>.TableSchema = "Abstract";
            EntityMeta<Table6>.TableName = "Table6";
            EntityMeta<Table6>.LanguageTableSchema = null;
            EntityMeta<Table6>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? Table6ID { get; set; }
        public int? Table6Integer { get; set; }
        public string Table6String { get; set; }
        public bool? Table6Active { get; set; }
        public string KenovaKakoSte { get; set; }
        public string Kenova2KakoSte { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Table6>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Table6>(queryConditions);
        }
        public static async Task<IEnumerable<Table6>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Table6>(columnName, queryOp, value);
        }
		public static async Task<Table6> GetByPrimaryKeyAsync(int Table6ID)
        {
            return await GetByPrimaryKeyAsync<Table6>(Table6ID);
        }
		public static async Task<Table6> TryGetByPrimaryKeyAsync(int Table6ID)
        {
            return await TryGetByPrimaryKeyAsync<Table6>(Table6ID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Table6> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Table6>(queryConditions);
        }
        public static IEnumerable<Table6> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Table6>(columnName, queryOp, value);
        }
		public static Table6 GetByPrimaryKey(int Table6ID)
        {
            return GetByPrimaryKey<Table6>(Table6ID);
        }
		public static Table6 TryGetByPrimaryKey(int Table6ID)
        {
            return TryGetByPrimaryKey<Table6>(Table6ID);
        }
        #endregion
    }
}