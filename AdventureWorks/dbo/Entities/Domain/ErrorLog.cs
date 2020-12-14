// Generated on 12/14/2020 9:21 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Dbo
{
    /// <summary>
    /// ErrorLog entity.
    /// </summary>
    public sealed partial class ErrorLog : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static ErrorLog()
        {
            // Cache field metadata.
            EntityMeta<ErrorLog>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ErrorLogID), @"ErrorLogID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(ErrorTime), @"ErrorTime", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(UserName), @"UserName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ErrorNumber), @"ErrorNumber", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ErrorSeverity), @"ErrorSeverity", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(ErrorState), @"ErrorState", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(ErrorProcedure), @"ErrorProcedure", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ErrorLine), @"ErrorLine", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(ErrorMessage), @"ErrorMessage", DbType.String, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ErrorLog>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<ErrorLog>.HasLanguageTable = false;
            EntityMeta<ErrorLog>.TableSchema = @"dbo";
            EntityMeta<ErrorLog>.TableName = @"ErrorLog";
            EntityMeta<ErrorLog>.LanguageTableSchema = null;
            EntityMeta<ErrorLog>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ErrorLogID { get; private set; }
        public DateTime? ErrorTime { get; set; }
        public string UserName { get; set; }
        public int? ErrorNumber { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public int? ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ErrorLog>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ErrorLog>(queryConditions);
        }
        public static async Task<IEnumerable<ErrorLog>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ErrorLog>(columnName, queryOp, value);
        }
		public static async Task<ErrorLog> GetByPrimaryKeyAsync(int ErrorLogID)
        {
            return await GetByPrimaryKeyAsync<ErrorLog>(ErrorLogID);
        }
		public static async Task<ErrorLog> TryGetByPrimaryKeyAsync(int ErrorLogID)
        {
            return await TryGetByPrimaryKeyAsync<ErrorLog>(ErrorLogID);
        }
		#endregion
    }
}