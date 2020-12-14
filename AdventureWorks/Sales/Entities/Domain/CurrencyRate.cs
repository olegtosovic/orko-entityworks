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

namespace AdventureWorks.Sales
{
    /// <summary>
    /// CurrencyRate entity.
    /// </summary>
    public sealed partial class CurrencyRate : Entity
    {
		#region Members
		private Currency m_e_FromCurrencyCode;
        private Currency m_e_ToCurrencyCode;
        #endregion
        
		#region Constructors
        static CurrencyRate()
        {
            // Cache field metadata.
            EntityMeta<CurrencyRate>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CurrencyRateID), @"CurrencyRateID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CurrencyRateDate), @"CurrencyRateDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(FromCurrencyCode), @"FromCurrencyCode", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(ToCurrencyCode), @"ToCurrencyCode", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(AverageRate), @"AverageRate", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(EndOfDayRate), @"EndOfDayRate", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<CurrencyRate>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_FromCurrencyCode), nameof(FromCurrencyCode), nameof(AdventureWorks.Sales.Currency.CurrencyCode)),
                new RelationMetadata(nameof(e_ToCurrencyCode), nameof(ToCurrencyCode), nameof(AdventureWorks.Sales.Currency.CurrencyCode))
			);

			// Cache table metadata.
			EntityMeta<CurrencyRate>.HasLanguageTable = false;
            EntityMeta<CurrencyRate>.TableSchema = @"Sales";
            EntityMeta<CurrencyRate>.TableName = @"CurrencyRate";
            EntityMeta<CurrencyRate>.LanguageTableSchema = null;
            EntityMeta<CurrencyRate>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CurrencyRateID { get; private set; }
        public DateTime? CurrencyRateDate { get; set; }
        public string FromCurrencyCode { get; set; }
        public string ToCurrencyCode { get; set; }
        public decimal? AverageRate { get; set; }
        public decimal? EndOfDayRate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Currency e_FromCurrencyCode
        {
            get { return EntityContext<Currency>.Get(ref m_e_FromCurrencyCode, this, nameof(e_FromCurrencyCode)); }
            set { EntityContext<Currency>.Set(ref m_e_FromCurrencyCode, this, value, nameof(e_FromCurrencyCode)); }
        }
        public Currency e_ToCurrencyCode
        {
            get { return EntityContext<Currency>.Get(ref m_e_ToCurrencyCode, this, nameof(e_ToCurrencyCode)); }
            set { EntityContext<Currency>.Set(ref m_e_ToCurrencyCode, this, value, nameof(e_ToCurrencyCode)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CurrencyRate>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CurrencyRate>(queryConditions);
        }
        public static async Task<IEnumerable<CurrencyRate>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CurrencyRate>(columnName, queryOp, value);
        }
		public static async Task<CurrencyRate> GetByPrimaryKeyAsync(int CurrencyRateID)
        {
            return await GetByPrimaryKeyAsync<CurrencyRate>(CurrencyRateID);
        }
		public static async Task<CurrencyRate> TryGetByPrimaryKeyAsync(int CurrencyRateID)
        {
            return await TryGetByPrimaryKeyAsync<CurrencyRate>(CurrencyRateID);
        }
		#endregion
    }
}