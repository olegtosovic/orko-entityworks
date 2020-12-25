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
    /// SalesPersonQuotaHistory entity.
    /// </summary>
    public sealed partial class SalesPersonQuotaHistory : Entity
    {
		#region Members
		private SalesPerson m_e_BusinessEntityID;
        #endregion
        
		#region Constructors
        static SalesPersonQuotaHistory()
        {
            // Cache field metadata.
            EntityMeta<SalesPersonQuotaHistory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(QuotaDate), @"QuotaDate", DbType.DateTime, isPrimaryKey: true),
                new ColumnMetadata(nameof(SalesQuota), @"SalesQuota", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SalesPersonQuotaHistory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Sales.SalesPerson.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<SalesPersonQuotaHistory>.HasLanguageTable = false;
            EntityMeta<SalesPersonQuotaHistory>.TableSchema = @"Sales";
            EntityMeta<SalesPersonQuotaHistory>.TableName = @"SalesPersonQuotaHistory";
            EntityMeta<SalesPersonQuotaHistory>.LanguageTableSchema = null;
            EntityMeta<SalesPersonQuotaHistory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public DateTime? QuotaDate { get; set; }
        public decimal? SalesQuota { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public SalesPerson e_BusinessEntityID
        {
            get { return EntityContext<SalesPerson>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<SalesPerson>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<SalesPersonQuotaHistory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SalesPersonQuotaHistory>(queryConditions);
        }
        public static async Task<IEnumerable<SalesPersonQuotaHistory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SalesPersonQuotaHistory>(columnName, queryOp, value);
        }
		public static async Task<SalesPersonQuotaHistory> GetByPrimaryKeyAsync(int BusinessEntityID, DateTime QuotaDate)
        {
            return await GetByPrimaryKeyAsync<SalesPersonQuotaHistory>(BusinessEntityID, QuotaDate);
        }
		public static async Task<SalesPersonQuotaHistory> TryGetByPrimaryKeyAsync(int BusinessEntityID, DateTime QuotaDate)
        {
            return await TryGetByPrimaryKeyAsync<SalesPersonQuotaHistory>(BusinessEntityID, QuotaDate);
        }
		#endregion
    }
}