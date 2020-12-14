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

namespace AdventureWorks.Purchasing
{
    /// <summary>
    /// ProductVendor entity.
    /// </summary>
    public sealed partial class ProductVendor : Entity
    {
		#region Members
		private Vendor m_e_BusinessEntityID;
        private Production.Product m_e_ProductID;
        private Production.UnitMeasure m_e_UnitMeasureCode;
        #endregion
        
		#region Constructors
        static ProductVendor()
        {
            // Cache field metadata.
            EntityMeta<ProductVendor>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(AverageLeadTime), @"AverageLeadTime", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(StandardPrice), @"StandardPrice", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(LastReceiptCost), @"LastReceiptCost", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(LastReceiptDate), @"LastReceiptDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(MinOrderQty), @"MinOrderQty", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(MaxOrderQty), @"MaxOrderQty", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(OnOrderQty), @"OnOrderQty", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(UnitMeasureCode), @"UnitMeasureCode", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductVendor>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Purchasing.Vendor.BusinessEntityID)),
                new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID)),
                new RelationMetadata(nameof(e_UnitMeasureCode), nameof(UnitMeasureCode), nameof(AdventureWorks.Production.UnitMeasure.UnitMeasureCode))
			);

			// Cache table metadata.
			EntityMeta<ProductVendor>.HasLanguageTable = false;
            EntityMeta<ProductVendor>.TableSchema = @"Purchasing";
            EntityMeta<ProductVendor>.TableName = @"ProductVendor";
            EntityMeta<ProductVendor>.LanguageTableSchema = null;
            EntityMeta<ProductVendor>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductID { get; set; }
        public int? BusinessEntityID { get; set; }
        public int? AverageLeadTime { get; set; }
        public decimal? StandardPrice { get; set; }
        public decimal? LastReceiptCost { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public int? MinOrderQty { get; set; }
        public int? MaxOrderQty { get; set; }
        public int? OnOrderQty { get; set; }
        public string UnitMeasureCode { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Vendor e_BusinessEntityID
        {
            get { return EntityContext<Vendor>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Vendor>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        public Production.Product e_ProductID
        {
            get { return EntityContext<Production.Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Production.Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        public Production.UnitMeasure e_UnitMeasureCode
        {
            get { return EntityContext<Production.UnitMeasure>.Get(ref m_e_UnitMeasureCode, this, nameof(e_UnitMeasureCode)); }
            set { EntityContext<Production.UnitMeasure>.Set(ref m_e_UnitMeasureCode, this, value, nameof(e_UnitMeasureCode)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ProductVendor>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductVendor>(queryConditions);
        }
        public static async Task<IEnumerable<ProductVendor>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductVendor>(columnName, queryOp, value);
        }
		public static async Task<ProductVendor> GetByPrimaryKeyAsync(int ProductID, int BusinessEntityID)
        {
            return await GetByPrimaryKeyAsync<ProductVendor>(ProductID, BusinessEntityID);
        }
		public static async Task<ProductVendor> TryGetByPrimaryKeyAsync(int ProductID, int BusinessEntityID)
        {
            return await TryGetByPrimaryKeyAsync<ProductVendor>(ProductID, BusinessEntityID);
        }
		#endregion
    }
}