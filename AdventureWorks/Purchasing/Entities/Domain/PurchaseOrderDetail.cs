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
    /// PurchaseOrderDetail entity.
    /// </summary>
    public sealed partial class PurchaseOrderDetail : Entity
    {
		#region Members
		private Production.Product m_e_ProductID;
        private PurchaseOrderHeader m_e_PurchaseOrderID;
        #endregion
        
		#region Constructors
        static PurchaseOrderDetail()
        {
            // Cache field metadata.
            EntityMeta<PurchaseOrderDetail>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(PurchaseOrderID), @"PurchaseOrderID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(PurchaseOrderDetailID), @"PurchaseOrderDetailID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(DueDate), @"DueDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(OrderQty), @"OrderQty", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(UnitPrice), @"UnitPrice", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(LineTotal), @"LineTotal", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ReceivedQty), @"ReceivedQty", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RejectedQty), @"RejectedQty", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(StockedQty), @"StockedQty", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<PurchaseOrderDetail>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID)),
                new RelationMetadata(nameof(e_PurchaseOrderID), nameof(PurchaseOrderID), nameof(AdventureWorks.Purchasing.PurchaseOrderHeader.PurchaseOrderID))
			);

			// Cache table metadata.
			EntityMeta<PurchaseOrderDetail>.HasLanguageTable = false;
            EntityMeta<PurchaseOrderDetail>.TableSchema = @"Purchasing";
            EntityMeta<PurchaseOrderDetail>.TableName = @"PurchaseOrderDetail";
            EntityMeta<PurchaseOrderDetail>.LanguageTableSchema = null;
            EntityMeta<PurchaseOrderDetail>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? PurchaseOrderID { get; set; }
        public int? PurchaseOrderDetailID { get; private set; }
        public DateTime? DueDate { get; set; }
        public short? OrderQty { get; set; }
        public int? ProductID { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? ReceivedQty { get; set; }
        public decimal? RejectedQty { get; set; }
        public decimal? StockedQty { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Production.Product e_ProductID
        {
            get { return EntityContext<Production.Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Production.Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        public PurchaseOrderHeader e_PurchaseOrderID
        {
            get { return EntityContext<PurchaseOrderHeader>.Get(ref m_e_PurchaseOrderID, this, nameof(e_PurchaseOrderID)); }
            set { EntityContext<PurchaseOrderHeader>.Set(ref m_e_PurchaseOrderID, this, value, nameof(e_PurchaseOrderID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<PurchaseOrderDetail>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PurchaseOrderDetail>(queryConditions);
        }
        public static async Task<IEnumerable<PurchaseOrderDetail>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PurchaseOrderDetail>(columnName, queryOp, value);
        }
		public static async Task<PurchaseOrderDetail> GetByPrimaryKeyAsync(int PurchaseOrderID, int PurchaseOrderDetailID)
        {
            return await GetByPrimaryKeyAsync<PurchaseOrderDetail>(PurchaseOrderID, PurchaseOrderDetailID);
        }
		public static async Task<PurchaseOrderDetail> TryGetByPrimaryKeyAsync(int PurchaseOrderID, int PurchaseOrderDetailID)
        {
            return await TryGetByPrimaryKeyAsync<PurchaseOrderDetail>(PurchaseOrderID, PurchaseOrderDetailID);
        }
		#endregion
    }
}