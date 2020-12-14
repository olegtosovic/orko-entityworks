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
    /// CountryRegionCurrency entity.
    /// </summary>
    public sealed partial class CountryRegionCurrency : Entity
    {
		#region Members
		private Person.CountryRegion m_e_CountryRegionCode;
        private Currency m_e_CurrencyCode;
        #endregion
        
		#region Constructors
        static CountryRegionCurrency()
        {
            // Cache field metadata.
            EntityMeta<CountryRegionCurrency>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CountryRegionCode), @"CountryRegionCode", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CurrencyCode), @"CurrencyCode", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<CountryRegionCurrency>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_CountryRegionCode), nameof(CountryRegionCode), nameof(AdventureWorks.Person.CountryRegion.CountryRegionCode)),
                new RelationMetadata(nameof(e_CurrencyCode), nameof(CurrencyCode), nameof(AdventureWorks.Sales.Currency.CurrencyCode))
			);

			// Cache table metadata.
			EntityMeta<CountryRegionCurrency>.HasLanguageTable = false;
            EntityMeta<CountryRegionCurrency>.TableSchema = @"Sales";
            EntityMeta<CountryRegionCurrency>.TableName = @"CountryRegionCurrency";
            EntityMeta<CountryRegionCurrency>.LanguageTableSchema = null;
            EntityMeta<CountryRegionCurrency>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string CountryRegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person.CountryRegion e_CountryRegionCode
        {
            get { return EntityContext<Person.CountryRegion>.Get(ref m_e_CountryRegionCode, this, nameof(e_CountryRegionCode)); }
            set { EntityContext<Person.CountryRegion>.Set(ref m_e_CountryRegionCode, this, value, nameof(e_CountryRegionCode)); }
        }
        public Currency e_CurrencyCode
        {
            get { return EntityContext<Currency>.Get(ref m_e_CurrencyCode, this, nameof(e_CurrencyCode)); }
            set { EntityContext<Currency>.Set(ref m_e_CurrencyCode, this, value, nameof(e_CurrencyCode)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CountryRegionCurrency>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CountryRegionCurrency>(queryConditions);
        }
        public static async Task<IEnumerable<CountryRegionCurrency>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CountryRegionCurrency>(columnName, queryOp, value);
        }
		public static async Task<CountryRegionCurrency> GetByPrimaryKeyAsync(string CountryRegionCode, string CurrencyCode)
        {
            return await GetByPrimaryKeyAsync<CountryRegionCurrency>(CountryRegionCode, CurrencyCode);
        }
		public static async Task<CountryRegionCurrency> TryGetByPrimaryKeyAsync(string CountryRegionCode, string CurrencyCode)
        {
            return await TryGetByPrimaryKeyAsync<CountryRegionCurrency>(CountryRegionCode, CurrencyCode);
        }
		#endregion
    }
}