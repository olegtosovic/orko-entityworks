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
    /// CreditCard entity.
    /// </summary>
    public sealed partial class CreditCard : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static CreditCard()
        {
            // Cache field metadata.
            EntityMeta<CreditCard>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CreditCardID), @"CreditCardID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(CardType), @"CardType", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CardNumber), @"CardNumber", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ExpMonth), @"ExpMonth", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(ExpYear), @"ExpYear", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<CreditCard>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<CreditCard>.HasLanguageTable = false;
            EntityMeta<CreditCard>.TableSchema = @"Sales";
            EntityMeta<CreditCard>.TableName = @"CreditCard";
            EntityMeta<CreditCard>.LanguageTableSchema = null;
            EntityMeta<CreditCard>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CreditCardID { get; private set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public Byte? ExpMonth { get; set; }
        public short? ExpYear { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<CreditCard>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CreditCard>(queryConditions);
        }
        public static async Task<IEnumerable<CreditCard>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CreditCard>(columnName, queryOp, value);
        }
		public static async Task<CreditCard> GetByPrimaryKeyAsync(int CreditCardID)
        {
            return await GetByPrimaryKeyAsync<CreditCard>(CreditCardID);
        }
		public static async Task<CreditCard> TryGetByPrimaryKeyAsync(int CreditCardID)
        {
            return await TryGetByPrimaryKeyAsync<CreditCard>(CreditCardID);
        }
		#endregion
    }
}