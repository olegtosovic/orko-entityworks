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

namespace AdventureWorks.Purchasing
{
    /// <summary>
    /// PurchaseOrderHeader entity.
    /// </summary>
    public sealed partial class PurchaseOrderHeader : Entity
    {
		#region Members
		private HumanResources.Employee m_e_EmployeeID;
        private ShipMethod m_e_ShipMethodID;
        private Vendor m_e_VendorID;
        #endregion
        
		#region Constructors
        static PurchaseOrderHeader()
        {
            // Cache field metadata.
            EntityMeta<PurchaseOrderHeader>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(PurchaseOrderID), @"PurchaseOrderID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(RevisionNumber), @"RevisionNumber", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(Status), @"Status", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(EmployeeID), @"EmployeeID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(VendorID), @"VendorID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ShipMethodID), @"ShipMethodID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(OrderDate), @"OrderDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(ShipDate), @"ShipDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(SubTotal), @"SubTotal", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(TaxAmt), @"TaxAmt", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(Freight), @"Freight", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(TotalDue), @"TotalDue", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<PurchaseOrderHeader>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_EmployeeID), nameof(EmployeeID), nameof(AdventureWorks.HumanResources.Employee.BusinessEntityID)),
                new RelationMetadata(nameof(e_ShipMethodID), nameof(ShipMethodID), nameof(AdventureWorks.Purchasing.ShipMethod.ShipMethodID)),
                new RelationMetadata(nameof(e_VendorID), nameof(VendorID), nameof(AdventureWorks.Purchasing.Vendor.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<PurchaseOrderHeader>.HasLanguageTable = false;
            EntityMeta<PurchaseOrderHeader>.TableSchema = @"Purchasing";
            EntityMeta<PurchaseOrderHeader>.TableName = @"PurchaseOrderHeader";
            EntityMeta<PurchaseOrderHeader>.LanguageTableSchema = null;
            EntityMeta<PurchaseOrderHeader>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? PurchaseOrderID { get; private set; }
        public Byte? RevisionNumber { get; set; }
        public Byte? Status { get; set; }
        public int? EmployeeID { get; set; }
        public int? VendorID { get; set; }
        public int? ShipMethodID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TaxAmt { get; set; }
        public decimal? Freight { get; set; }
        public decimal? TotalDue { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public HumanResources.Employee e_EmployeeID
        {
            get { return EntityContext<HumanResources.Employee>.Get(ref m_e_EmployeeID, this, nameof(e_EmployeeID)); }
            set { EntityContext<HumanResources.Employee>.Set(ref m_e_EmployeeID, this, value, nameof(e_EmployeeID)); }
        }
        public ShipMethod e_ShipMethodID
        {
            get { return EntityContext<ShipMethod>.Get(ref m_e_ShipMethodID, this, nameof(e_ShipMethodID)); }
            set { EntityContext<ShipMethod>.Set(ref m_e_ShipMethodID, this, value, nameof(e_ShipMethodID)); }
        }
        public Vendor e_VendorID
        {
            get { return EntityContext<Vendor>.Get(ref m_e_VendorID, this, nameof(e_VendorID)); }
            set { EntityContext<Vendor>.Set(ref m_e_VendorID, this, value, nameof(e_VendorID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<PurchaseOrderHeader>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PurchaseOrderHeader>(queryConditions);
        }
        public static async Task<IEnumerable<PurchaseOrderHeader>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PurchaseOrderHeader>(columnName, queryOp, value);
        }
		public static async Task<PurchaseOrderHeader> GetByPrimaryKeyAsync(int PurchaseOrderID)
        {
            return await GetByPrimaryKeyAsync<PurchaseOrderHeader>(PurchaseOrderID);
        }
		public static async Task<PurchaseOrderHeader> TryGetByPrimaryKeyAsync(int PurchaseOrderID)
        {
            return await TryGetByPrimaryKeyAsync<PurchaseOrderHeader>(PurchaseOrderID);
        }
		#endregion
    }
}