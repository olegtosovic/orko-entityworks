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
    /// SalesOrderDetail entity.
    /// </summary>
    public sealed partial class SalesOrderDetail : Entity
    {
		#region Members
		private SalesOrderHeader m_e_SalesOrderID;
        private SpecialOfferProduct m_SpecialOfferIDProductID;
        #endregion
        
		#region Constructors
        static SalesOrderDetail()
        {
            // Cache field metadata.
            EntityMeta<SalesOrderDetail>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SalesOrderID), @"SalesOrderID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SalesOrderDetailID), @"SalesOrderDetailID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CarrierTrackingNumber), @"CarrierTrackingNumber", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OrderQty), @"OrderQty", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SpecialOfferID), @"SpecialOfferID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(UnitPrice), @"UnitPrice", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(UnitPriceDiscount), @"UnitPriceDiscount", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(LineTotal), @"LineTotal", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SalesOrderDetail>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_SalesOrderID), nameof(SalesOrderID), nameof(AdventureWorks.Sales.SalesOrderHeader.SalesOrderID)),
                new RelationMetadata(nameof(SpecialOfferIDProductID), nameof(SpecialOfferID), nameof(AdventureWorks.Sales.SpecialOfferProduct.SpecialOfferID)),
                new RelationMetadata(nameof(SpecialOfferIDProductID), nameof(ProductID), nameof(AdventureWorks.Sales.SpecialOfferProduct.ProductID))
			);

			// Cache table metadata.
			EntityMeta<SalesOrderDetail>.HasLanguageTable = false;
            EntityMeta<SalesOrderDetail>.TableSchema = @"Sales";
            EntityMeta<SalesOrderDetail>.TableName = @"SalesOrderDetail";
            EntityMeta<SalesOrderDetail>.LanguageTableSchema = null;
            EntityMeta<SalesOrderDetail>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SalesOrderID { get; set; }
        public int? SalesOrderDetailID { get; private set; }
        public string CarrierTrackingNumber { get; set; }
        public short? OrderQty { get; set; }
        public int? ProductID { get; set; }
        public int? SpecialOfferID { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitPriceDiscount { get; set; }
        public decimal? LineTotal { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public SalesOrderHeader e_SalesOrderID
        {
            get { return EntityContext<SalesOrderHeader>.Get(ref m_e_SalesOrderID, this, nameof(e_SalesOrderID)); }
            set { EntityContext<SalesOrderHeader>.Set(ref m_e_SalesOrderID, this, value, nameof(e_SalesOrderID)); }
        }
        public SpecialOfferProduct SpecialOfferIDProductID
        {
            get { return EntityContext<SpecialOfferProduct>.Get(ref m_SpecialOfferIDProductID, this, nameof(SpecialOfferIDProductID)); }
            set { EntityContext<SpecialOfferProduct>.Set(ref m_SpecialOfferIDProductID, this, value, nameof(SpecialOfferIDProductID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SalesOrderDetail>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SalesOrderDetail>(queryConditions);
        }
        public static async Task<IEnumerable<SalesOrderDetail>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SalesOrderDetail>(columnName, queryOp, value);
        }
		public static async Task<SalesOrderDetail> GetByPrimaryKeyAsync(int SalesOrderID, int SalesOrderDetailID)
        {
            return await GetByPrimaryKeyAsync<SalesOrderDetail>(SalesOrderID, SalesOrderDetailID);
        }
		public static async Task<SalesOrderDetail> TryGetByPrimaryKeyAsync(int SalesOrderID, int SalesOrderDetailID)
        {
            return await TryGetByPrimaryKeyAsync<SalesOrderDetail>(SalesOrderID, SalesOrderDetailID);
        }
		#endregion
    }
}