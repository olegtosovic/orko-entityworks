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
    /// SalesTerritory entity.
    /// </summary>
    public sealed partial class SalesTerritory : Entity
    {
		#region Members
		private Person.CountryRegion m_e_CountryRegionCode;
        #endregion
        
		#region Constructors
        static SalesTerritory()
        {
            // Cache field metadata.
            EntityMeta<SalesTerritory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TerritoryID), @"TerritoryID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CountryRegionCode), @"CountryRegionCode", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Group), @"Group", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SalesYTD), @"SalesYTD", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(SalesLastYear), @"SalesLastYear", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(CostYTD), @"CostYTD", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(CostLastYear), @"CostLastYear", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SalesTerritory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_CountryRegionCode), nameof(CountryRegionCode), nameof(AdventureWorks.Person.CountryRegion.CountryRegionCode))
			);

			// Cache table metadata.
			EntityMeta<SalesTerritory>.HasLanguageTable = false;
            EntityMeta<SalesTerritory>.TableSchema = @"Sales";
            EntityMeta<SalesTerritory>.TableName = @"SalesTerritory";
            EntityMeta<SalesTerritory>.LanguageTableSchema = null;
            EntityMeta<SalesTerritory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? TerritoryID { get; private set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public decimal? SalesYTD { get; set; }
        public decimal? SalesLastYear { get; set; }
        public decimal? CostYTD { get; set; }
        public decimal? CostLastYear { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person.CountryRegion e_CountryRegionCode
        {
            get { return EntityContext<Person.CountryRegion>.Get(ref m_e_CountryRegionCode, this, nameof(e_CountryRegionCode)); }
            set { EntityContext<Person.CountryRegion>.Set(ref m_e_CountryRegionCode, this, value, nameof(e_CountryRegionCode)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<SalesTerritory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SalesTerritory>(queryConditions);
        }
        public static async Task<IEnumerable<SalesTerritory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SalesTerritory>(columnName, queryOp, value);
        }
		public static async Task<SalesTerritory> GetByPrimaryKeyAsync(int TerritoryID)
        {
            return await GetByPrimaryKeyAsync<SalesTerritory>(TerritoryID);
        }
		public static async Task<SalesTerritory> TryGetByPrimaryKeyAsync(int TerritoryID)
        {
            return await TryGetByPrimaryKeyAsync<SalesTerritory>(TerritoryID);
        }
		#endregion
    }
}