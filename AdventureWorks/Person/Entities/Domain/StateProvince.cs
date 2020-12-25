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

namespace AdventureWorks.Person
{
    /// <summary>
    /// StateProvince entity.
    /// </summary>
    public sealed partial class StateProvince : Entity
    {
		#region Members
		private CountryRegion m_e_CountryRegionCode;
        private Sales.SalesTerritory m_e_TerritoryID;
        #endregion
        
		#region Constructors
        static StateProvince()
        {
            // Cache field metadata.
            EntityMeta<StateProvince>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(StateProvinceID), @"StateProvinceID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(StateProvinceCode), @"StateProvinceCode", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(CountryRegionCode), @"CountryRegionCode", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(IsOnlyStateProvinceFlag), @"IsOnlyStateProvinceFlag", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(TerritoryID), @"TerritoryID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<StateProvince>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_CountryRegionCode), nameof(CountryRegionCode), nameof(AdventureWorks.Person.CountryRegion.CountryRegionCode)),
                new RelationMetadata(nameof(e_TerritoryID), nameof(TerritoryID), nameof(AdventureWorks.Sales.SalesTerritory.TerritoryID))
			);

			// Cache table metadata.
			EntityMeta<StateProvince>.HasLanguageTable = false;
            EntityMeta<StateProvince>.TableSchema = @"Person";
            EntityMeta<StateProvince>.TableName = @"StateProvince";
            EntityMeta<StateProvince>.LanguageTableSchema = null;
            EntityMeta<StateProvince>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? StateProvinceID { get; private set; }
        public string StateProvinceCode { get; set; }
        public string CountryRegionCode { get; set; }
        public bool? IsOnlyStateProvinceFlag { get; set; }
        public string Name { get; set; }
        public int? TerritoryID { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public CountryRegion e_CountryRegionCode
        {
            get { return EntityContext<CountryRegion>.Get(ref m_e_CountryRegionCode, this, nameof(e_CountryRegionCode)); }
            set { EntityContext<CountryRegion>.Set(ref m_e_CountryRegionCode, this, value, nameof(e_CountryRegionCode)); }
        }
        public Sales.SalesTerritory e_TerritoryID
        {
            get { return EntityContext<Sales.SalesTerritory>.Get(ref m_e_TerritoryID, this, nameof(e_TerritoryID)); }
            set { EntityContext<Sales.SalesTerritory>.Set(ref m_e_TerritoryID, this, value, nameof(e_TerritoryID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<StateProvince>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<StateProvince>(queryConditions);
        }
        public static async Task<IEnumerable<StateProvince>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<StateProvince>(columnName, queryOp, value);
        }
		public static async Task<StateProvince> GetByPrimaryKeyAsync(int StateProvinceID)
        {
            return await GetByPrimaryKeyAsync<StateProvince>(StateProvinceID);
        }
		public static async Task<StateProvince> TryGetByPrimaryKeyAsync(int StateProvinceID)
        {
            return await TryGetByPrimaryKeyAsync<StateProvince>(StateProvinceID);
        }
		#endregion
    }
}