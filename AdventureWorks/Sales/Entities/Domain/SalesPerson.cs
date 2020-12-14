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
    /// SalesPerson entity.
    /// </summary>
    public sealed partial class SalesPerson : Entity
    {
		#region Members
		private HumanResources.Employee m_e_BusinessEntityID;
        private SalesTerritory m_e_TerritoryID;
        #endregion
        
		#region Constructors
        static SalesPerson()
        {
            // Cache field metadata.
            EntityMeta<SalesPerson>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TerritoryID), @"TerritoryID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SalesQuota), @"SalesQuota", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(Bonus), @"Bonus", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(CommissionPct), @"CommissionPct", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(SalesYTD), @"SalesYTD", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(SalesLastYear), @"SalesLastYear", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SalesPerson>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.HumanResources.Employee.BusinessEntityID)),
                new RelationMetadata(nameof(e_TerritoryID), nameof(TerritoryID), nameof(AdventureWorks.Sales.SalesTerritory.TerritoryID))
			);

			// Cache table metadata.
			EntityMeta<SalesPerson>.HasLanguageTable = false;
            EntityMeta<SalesPerson>.TableSchema = @"Sales";
            EntityMeta<SalesPerson>.TableName = @"SalesPerson";
            EntityMeta<SalesPerson>.LanguageTableSchema = null;
            EntityMeta<SalesPerson>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public int? TerritoryID { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? CommissionPct { get; set; }
        public decimal? SalesYTD { get; set; }
        public decimal? SalesLastYear { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public HumanResources.Employee e_BusinessEntityID
        {
            get { return EntityContext<HumanResources.Employee>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<HumanResources.Employee>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        public SalesTerritory e_TerritoryID
        {
            get { return EntityContext<SalesTerritory>.Get(ref m_e_TerritoryID, this, nameof(e_TerritoryID)); }
            set { EntityContext<SalesTerritory>.Set(ref m_e_TerritoryID, this, value, nameof(e_TerritoryID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SalesPerson>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SalesPerson>(queryConditions);
        }
        public static async Task<IEnumerable<SalesPerson>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SalesPerson>(columnName, queryOp, value);
        }
		public static async Task<SalesPerson> GetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await GetByPrimaryKeyAsync<SalesPerson>(BusinessEntityID);
        }
		public static async Task<SalesPerson> TryGetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await TryGetByPrimaryKeyAsync<SalesPerson>(BusinessEntityID);
        }
		#endregion
    }
}