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
    /// SalesTerritoryHistory entity.
    /// </summary>
    public sealed partial class SalesTerritoryHistory : Entity
    {
		#region Members
		private SalesPerson m_e_BusinessEntityID;
        private SalesTerritory m_e_TerritoryID;
        #endregion
        
		#region Constructors
        static SalesTerritoryHistory()
        {
            // Cache field metadata.
            EntityMeta<SalesTerritoryHistory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TerritoryID), @"TerritoryID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(StartDate), @"StartDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(EndDate), @"EndDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SalesTerritoryHistory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Sales.SalesPerson.BusinessEntityID)),
                new RelationMetadata(nameof(e_TerritoryID), nameof(TerritoryID), nameof(AdventureWorks.Sales.SalesTerritory.TerritoryID))
			);

			// Cache table metadata.
			EntityMeta<SalesTerritoryHistory>.HasLanguageTable = false;
            EntityMeta<SalesTerritoryHistory>.TableSchema = @"Sales";
            EntityMeta<SalesTerritoryHistory>.TableName = @"SalesTerritoryHistory";
            EntityMeta<SalesTerritoryHistory>.LanguageTableSchema = null;
            EntityMeta<SalesTerritoryHistory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public int? TerritoryID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public SalesPerson e_BusinessEntityID
        {
            get { return EntityContext<SalesPerson>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<SalesPerson>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        public SalesTerritory e_TerritoryID
        {
            get { return EntityContext<SalesTerritory>.Get(ref m_e_TerritoryID, this, nameof(e_TerritoryID)); }
            set { EntityContext<SalesTerritory>.Set(ref m_e_TerritoryID, this, value, nameof(e_TerritoryID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SalesTerritoryHistory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SalesTerritoryHistory>(queryConditions);
        }
        public static async Task<IEnumerable<SalesTerritoryHistory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SalesTerritoryHistory>(columnName, queryOp, value);
        }
		public static async Task<SalesTerritoryHistory> GetByPrimaryKeyAsync(int BusinessEntityID, int TerritoryID, DateTime StartDate)
        {
            return await GetByPrimaryKeyAsync<SalesTerritoryHistory>(BusinessEntityID, TerritoryID, StartDate);
        }
		public static async Task<SalesTerritoryHistory> TryGetByPrimaryKeyAsync(int BusinessEntityID, int TerritoryID, DateTime StartDate)
        {
            return await TryGetByPrimaryKeyAsync<SalesTerritoryHistory>(BusinessEntityID, TerritoryID, StartDate);
        }
		#endregion
    }
}