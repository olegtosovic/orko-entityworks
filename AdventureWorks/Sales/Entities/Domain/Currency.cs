// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Sales
{
    /// <summary>
    /// Currency entity.
    /// </summary>
    public sealed partial class Currency : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Currency()
        {
            // Cache field metadata.
            EntityMeta<Currency>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CurrencyCode), @"CurrencyCode", DbType.StringFixedLength, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Currency>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Currency>.HasLanguageTable = false;
            EntityMeta<Currency>.TableSchema = @"Sales";
            EntityMeta<Currency>.TableName = @"Currency";
            EntityMeta<Currency>.LanguageTableSchema = null;
            EntityMeta<Currency>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Currency>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Currency>(queryConditions);
        }
        public static async Task<IEnumerable<Currency>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Currency>(columnName, queryOp, value);
        }
		public static async Task<Currency> GetByPrimaryKeyAsync(string CurrencyCode)
        {
            return await GetByPrimaryKeyAsync<Currency>(CurrencyCode);
        }
		public static async Task<Currency> TryGetByPrimaryKeyAsync(string CurrencyCode)
        {
            return await TryGetByPrimaryKeyAsync<Currency>(CurrencyCode);
        }
		#endregion
    }
}