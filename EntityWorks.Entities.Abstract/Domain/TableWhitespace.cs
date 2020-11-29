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
    /// TableWhitespace entity.
    /// </summary>
    public sealed partial class TableWhitespace : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TableWhitespace()
        {
            // Cache field metadata.
            EntityMeta<TableWhitespace>.LoadColumnMetadata
			(
				new ColumnMetadata("TableWhitespaceID", @"Table Whitespace ID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("TableWhitespaceNumber", @"Table Whitespace Number", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("TableWhitespaceString", @"Table Whitespace String", SqlDbType.NVarChar, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<TableWhitespace>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TableWhitespace>.HasLanguageTable = false;
            EntityMeta<TableWhitespace>.TableSchema = "Abstract";
            EntityMeta<TableWhitespace>.TableName = "TableWhitespace";
            EntityMeta<TableWhitespace>.LanguageTableSchema = null;
            EntityMeta<TableWhitespace>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? TableWhitespaceID { get; private set; }
        public int? TableWhitespaceNumber { get; set; }
        public string TableWhitespaceString { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TableWhitespace>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TableWhitespace>(queryConditions);
        }
        public static async Task<IEnumerable<TableWhitespace>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TableWhitespace>(columnName, queryOp, value);
        }
		public static async Task<TableWhitespace> GetByPrimaryKeyAsync(int TableWhitespaceID)
        {
            return await GetByPrimaryKeyAsync<TableWhitespace>(TableWhitespaceID);
        }
		public static async Task<TableWhitespace> TryGetByPrimaryKeyAsync(int TableWhitespaceID)
        {
            return await TryGetByPrimaryKeyAsync<TableWhitespace>(TableWhitespaceID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<TableWhitespace> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<TableWhitespace>(queryConditions);
        }
        public static IEnumerable<TableWhitespace> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<TableWhitespace>(columnName, queryOp, value);
        }
		public static TableWhitespace GetByPrimaryKey(int TableWhitespaceID)
        {
            return GetByPrimaryKey<TableWhitespace>(TableWhitespaceID);
        }
		public static TableWhitespace TryGetByPrimaryKey(int TableWhitespaceID)
        {
            return TryGetByPrimaryKey<TableWhitespace>(TableWhitespaceID);
        }
        #endregion
    }
}