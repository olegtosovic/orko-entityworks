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

namespace AdventureWorks.Production
{
    /// <summary>
    /// Product entity.
    /// </summary>
    public sealed partial class Product : Entity
    {
		#region Members
		private ProductModel m_e_ProductModelID;
        private ProductSubcategory m_e_ProductSubcategoryID;
        private UnitMeasure m_e_SizeUnitMeasureCode;
        private UnitMeasure m_e_WeightUnitMeasureCode;
        #endregion
        
		#region Constructors
        static Product()
        {
            // Cache field metadata.
            EntityMeta<Product>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ProductNumber), @"ProductNumber", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(MakeFlag), @"MakeFlag", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(FinishedGoodsFlag), @"FinishedGoodsFlag", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(Color), @"Color", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SafetyStockLevel), @"SafetyStockLevel", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(ReorderPoint), @"ReorderPoint", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(StandardCost), @"StandardCost", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ListPrice), @"ListPrice", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(Size), @"Size", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SizeUnitMeasureCode), @"SizeUnitMeasureCode", DbType.StringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(WeightUnitMeasureCode), @"WeightUnitMeasureCode", DbType.StringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(Weight), @"Weight", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(DaysToManufacture), @"DaysToManufacture", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProductLine), @"ProductLine", DbType.StringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(Class), @"Class", DbType.StringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(Style), @"Style", DbType.StringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(ProductSubcategoryID), @"ProductSubcategoryID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(ProductModelID), @"ProductModelID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SellStartDate), @"SellStartDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(SellEndDate), @"SellEndDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(DiscontinuedDate), @"DiscontinuedDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Product>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductModelID), nameof(ProductModelID), nameof(AdventureWorks.Production.ProductModel.ProductModelID)),
                new RelationMetadata(nameof(e_ProductSubcategoryID), nameof(ProductSubcategoryID), nameof(AdventureWorks.Production.ProductSubcategory.ProductSubcategoryID)),
                new RelationMetadata(nameof(e_SizeUnitMeasureCode), nameof(SizeUnitMeasureCode), nameof(AdventureWorks.Production.UnitMeasure.UnitMeasureCode)),
                new RelationMetadata(nameof(e_WeightUnitMeasureCode), nameof(WeightUnitMeasureCode), nameof(AdventureWorks.Production.UnitMeasure.UnitMeasureCode))
			);

			// Cache table metadata.
			EntityMeta<Product>.HasLanguageTable = false;
            EntityMeta<Product>.TableSchema = @"Production";
            EntityMeta<Product>.TableName = @"Product";
            EntityMeta<Product>.LanguageTableSchema = null;
            EntityMeta<Product>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductID { get; private set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public bool? MakeFlag { get; set; }
        public bool? FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public short? SafetyStockLevel { get; set; }
        public short? ReorderPoint { get; set; }
        public decimal? StandardCost { get; set; }
        public decimal? ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public decimal? Weight { get; set; }
        public int? DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int? ProductSubcategoryID { get; set; }
        public int? ProductModelID { get; set; }
        public DateTime? SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public ProductModel e_ProductModelID
        {
            get { return EntityContext<ProductModel>.Get(ref m_e_ProductModelID, this, nameof(e_ProductModelID)); }
            set { EntityContext<ProductModel>.Set(ref m_e_ProductModelID, this, value, nameof(e_ProductModelID)); }
        }
        public ProductSubcategory e_ProductSubcategoryID
        {
            get { return EntityContext<ProductSubcategory>.Get(ref m_e_ProductSubcategoryID, this, nameof(e_ProductSubcategoryID)); }
            set { EntityContext<ProductSubcategory>.Set(ref m_e_ProductSubcategoryID, this, value, nameof(e_ProductSubcategoryID)); }
        }
        public UnitMeasure e_SizeUnitMeasureCode
        {
            get { return EntityContext<UnitMeasure>.Get(ref m_e_SizeUnitMeasureCode, this, nameof(e_SizeUnitMeasureCode)); }
            set { EntityContext<UnitMeasure>.Set(ref m_e_SizeUnitMeasureCode, this, value, nameof(e_SizeUnitMeasureCode)); }
        }
        public UnitMeasure e_WeightUnitMeasureCode
        {
            get { return EntityContext<UnitMeasure>.Get(ref m_e_WeightUnitMeasureCode, this, nameof(e_WeightUnitMeasureCode)); }
            set { EntityContext<UnitMeasure>.Set(ref m_e_WeightUnitMeasureCode, this, value, nameof(e_WeightUnitMeasureCode)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Product>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Product>(queryConditions);
        }
        public static async Task<IEnumerable<Product>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Product>(columnName, queryOp, value);
        }
		public static async Task<Product> GetByPrimaryKeyAsync(int ProductID)
        {
            return await GetByPrimaryKeyAsync<Product>(ProductID);
        }
		public static async Task<Product> TryGetByPrimaryKeyAsync(int ProductID)
        {
            return await TryGetByPrimaryKeyAsync<Product>(ProductID);
        }
		#endregion
    }
}