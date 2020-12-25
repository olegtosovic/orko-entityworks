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
    /// Customer entity.
    /// </summary>
    public sealed partial class Customer : Entity
    {
		#region Members
		private Person.Person m_e_PersonID;
        private Store m_e_StoreID;
        private SalesTerritory m_e_TerritoryID;
        #endregion
        
		#region Constructors
        static Customer()
        {
            // Cache field metadata.
            EntityMeta<Customer>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CustomerID), @"CustomerID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(PersonID), @"PersonID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(StoreID), @"StoreID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(TerritoryID), @"TerritoryID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(AccountNumber), @"AccountNumber", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Customer>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_PersonID), nameof(PersonID), nameof(AdventureWorks.Person.Person.BusinessEntityID)),
                new RelationMetadata(nameof(e_StoreID), nameof(StoreID), nameof(AdventureWorks.Sales.Store.BusinessEntityID)),
                new RelationMetadata(nameof(e_TerritoryID), nameof(TerritoryID), nameof(AdventureWorks.Sales.SalesTerritory.TerritoryID))
			);

			// Cache table metadata.
			EntityMeta<Customer>.HasLanguageTable = false;
            EntityMeta<Customer>.TableSchema = @"Sales";
            EntityMeta<Customer>.TableName = @"Customer";
            EntityMeta<Customer>.LanguageTableSchema = null;
            EntityMeta<Customer>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CustomerID { get; private set; }
        public int? PersonID { get; set; }
        public int? StoreID { get; set; }
        public int? TerritoryID { get; set; }
        public string AccountNumber { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person.Person e_PersonID
        {
            get { return EntityContext<Person.Person>.Get(ref m_e_PersonID, this, nameof(e_PersonID)); }
            set { EntityContext<Person.Person>.Set(ref m_e_PersonID, this, value, nameof(e_PersonID)); }
        }
        public Store e_StoreID
        {
            get { return EntityContext<Store>.Get(ref m_e_StoreID, this, nameof(e_StoreID)); }
            set { EntityContext<Store>.Set(ref m_e_StoreID, this, value, nameof(e_StoreID)); }
        }
        public SalesTerritory e_TerritoryID
        {
            get { return EntityContext<SalesTerritory>.Get(ref m_e_TerritoryID, this, nameof(e_TerritoryID)); }
            set { EntityContext<SalesTerritory>.Set(ref m_e_TerritoryID, this, value, nameof(e_TerritoryID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Customer>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Customer>(queryConditions);
        }
        public static async Task<IEnumerable<Customer>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Customer>(columnName, queryOp, value);
        }
		public static async Task<Customer> GetByPrimaryKeyAsync(int CustomerID)
        {
            return await GetByPrimaryKeyAsync<Customer>(CustomerID);
        }
		public static async Task<Customer> TryGetByPrimaryKeyAsync(int CustomerID)
        {
            return await TryGetByPrimaryKeyAsync<Customer>(CustomerID);
        }
		#endregion
    }
}