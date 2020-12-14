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
    /// SalesOrderHeader entity.
    /// </summary>
    public sealed partial class SalesOrderHeader : Entity
    {
		#region Members
		private Person.Address m_e_BillToAddressID;
        private CreditCard m_e_CreditCardID;
        private CurrencyRate m_e_CurrencyRateID;
        private Customer m_e_CustomerID;
        private SalesPerson m_e_SalesPersonID;
        private Purchasing.ShipMethod m_e_ShipMethodID;
        private Person.Address m_e_ShipToAddressID;
        private SalesTerritory m_e_TerritoryID;
        #endregion
        
		#region Constructors
        static SalesOrderHeader()
        {
            // Cache field metadata.
            EntityMeta<SalesOrderHeader>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SalesOrderID), @"SalesOrderID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(RevisionNumber), @"RevisionNumber", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(OrderDate), @"OrderDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(DueDate), @"DueDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(ShipDate), @"ShipDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(Status), @"Status", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(OnlineOrderFlag), @"OnlineOrderFlag", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(SalesOrderNumber), @"SalesOrderNumber", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(PurchaseOrderNumber), @"PurchaseOrderNumber", DbType.Object, isRequired: false),
                new ColumnMetadata(nameof(AccountNumber), @"AccountNumber", DbType.Object, isRequired: false),
                new ColumnMetadata(nameof(CustomerID), @"CustomerID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SalesPersonID), @"SalesPersonID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(TerritoryID), @"TerritoryID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(BillToAddressID), @"BillToAddressID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ShipToAddressID), @"ShipToAddressID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ShipMethodID), @"ShipMethodID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(CreditCardID), @"CreditCardID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(CreditCardApprovalCode), @"CreditCardApprovalCode", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(CurrencyRateID), @"CurrencyRateID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SubTotal), @"SubTotal", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(TaxAmt), @"TaxAmt", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(Freight), @"Freight", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(TotalDue), @"TotalDue", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(Comment), @"Comment", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SalesOrderHeader>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BillToAddressID), nameof(BillToAddressID), nameof(AdventureWorks.Person.Address.AddressID)),
                new RelationMetadata(nameof(e_CreditCardID), nameof(CreditCardID), nameof(AdventureWorks.Sales.CreditCard.CreditCardID)),
                new RelationMetadata(nameof(e_CurrencyRateID), nameof(CurrencyRateID), nameof(AdventureWorks.Sales.CurrencyRate.CurrencyRateID)),
                new RelationMetadata(nameof(e_CustomerID), nameof(CustomerID), nameof(AdventureWorks.Sales.Customer.CustomerID)),
                new RelationMetadata(nameof(e_SalesPersonID), nameof(SalesPersonID), nameof(AdventureWorks.Sales.SalesPerson.BusinessEntityID)),
                new RelationMetadata(nameof(e_ShipMethodID), nameof(ShipMethodID), nameof(AdventureWorks.Purchasing.ShipMethod.ShipMethodID)),
                new RelationMetadata(nameof(e_ShipToAddressID), nameof(ShipToAddressID), nameof(AdventureWorks.Person.Address.AddressID)),
                new RelationMetadata(nameof(e_TerritoryID), nameof(TerritoryID), nameof(AdventureWorks.Sales.SalesTerritory.TerritoryID))
			);

			// Cache table metadata.
			EntityMeta<SalesOrderHeader>.HasLanguageTable = false;
            EntityMeta<SalesOrderHeader>.TableSchema = @"Sales";
            EntityMeta<SalesOrderHeader>.TableName = @"SalesOrderHeader";
            EntityMeta<SalesOrderHeader>.LanguageTableSchema = null;
            EntityMeta<SalesOrderHeader>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SalesOrderID { get; private set; }
        public Byte? RevisionNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public Byte? Status { get; set; }
        public string OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        public int? CustomerID { get; set; }
        public int? SalesPersonID { get; set; }
        public int? TerritoryID { get; set; }
        public int? BillToAddressID { get; set; }
        public int? ShipToAddressID { get; set; }
        public int? ShipMethodID { get; set; }
        public int? CreditCardID { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public int? CurrencyRateID { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TaxAmt { get; set; }
        public decimal? Freight { get; set; }
        public decimal? TotalDue { get; set; }
        public string Comment { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person.Address e_BillToAddressID
        {
            get { return EntityContext<Person.Address>.Get(ref m_e_BillToAddressID, this, nameof(e_BillToAddressID)); }
            set { EntityContext<Person.Address>.Set(ref m_e_BillToAddressID, this, value, nameof(e_BillToAddressID)); }
        }
        public CreditCard e_CreditCardID
        {
            get { return EntityContext<CreditCard>.Get(ref m_e_CreditCardID, this, nameof(e_CreditCardID)); }
            set { EntityContext<CreditCard>.Set(ref m_e_CreditCardID, this, value, nameof(e_CreditCardID)); }
        }
        public CurrencyRate e_CurrencyRateID
        {
            get { return EntityContext<CurrencyRate>.Get(ref m_e_CurrencyRateID, this, nameof(e_CurrencyRateID)); }
            set { EntityContext<CurrencyRate>.Set(ref m_e_CurrencyRateID, this, value, nameof(e_CurrencyRateID)); }
        }
        public Customer e_CustomerID
        {
            get { return EntityContext<Customer>.Get(ref m_e_CustomerID, this, nameof(e_CustomerID)); }
            set { EntityContext<Customer>.Set(ref m_e_CustomerID, this, value, nameof(e_CustomerID)); }
        }
        public SalesPerson e_SalesPersonID
        {
            get { return EntityContext<SalesPerson>.Get(ref m_e_SalesPersonID, this, nameof(e_SalesPersonID)); }
            set { EntityContext<SalesPerson>.Set(ref m_e_SalesPersonID, this, value, nameof(e_SalesPersonID)); }
        }
        public Purchasing.ShipMethod e_ShipMethodID
        {
            get { return EntityContext<Purchasing.ShipMethod>.Get(ref m_e_ShipMethodID, this, nameof(e_ShipMethodID)); }
            set { EntityContext<Purchasing.ShipMethod>.Set(ref m_e_ShipMethodID, this, value, nameof(e_ShipMethodID)); }
        }
        public Person.Address e_ShipToAddressID
        {
            get { return EntityContext<Person.Address>.Get(ref m_e_ShipToAddressID, this, nameof(e_ShipToAddressID)); }
            set { EntityContext<Person.Address>.Set(ref m_e_ShipToAddressID, this, value, nameof(e_ShipToAddressID)); }
        }
        public SalesTerritory e_TerritoryID
        {
            get { return EntityContext<SalesTerritory>.Get(ref m_e_TerritoryID, this, nameof(e_TerritoryID)); }
            set { EntityContext<SalesTerritory>.Set(ref m_e_TerritoryID, this, value, nameof(e_TerritoryID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SalesOrderHeader>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SalesOrderHeader>(queryConditions);
        }
        public static async Task<IEnumerable<SalesOrderHeader>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SalesOrderHeader>(columnName, queryOp, value);
        }
		public static async Task<SalesOrderHeader> GetByPrimaryKeyAsync(int SalesOrderID)
        {
            return await GetByPrimaryKeyAsync<SalesOrderHeader>(SalesOrderID);
        }
		public static async Task<SalesOrderHeader> TryGetByPrimaryKeyAsync(int SalesOrderID)
        {
            return await TryGetByPrimaryKeyAsync<SalesOrderHeader>(SalesOrderID);
        }
		#endregion
    }
}