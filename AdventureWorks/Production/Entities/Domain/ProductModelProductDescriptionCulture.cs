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
    /// ProductModelProductDescriptionCulture entity.
    /// </summary>
    public sealed partial class ProductModelProductDescriptionCulture : Entity
    {
		#region Members
		private Culture m_e_CultureID;
        private ProductDescription m_e_ProductDescriptionID;
        private ProductModel m_e_ProductModelID;
        #endregion
        
		#region Constructors
        static ProductModelProductDescriptionCulture()
        {
            // Cache field metadata.
            EntityMeta<ProductModelProductDescriptionCulture>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductModelID), @"ProductModelID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(ProductDescriptionID), @"ProductDescriptionID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(CultureID), @"CultureID", DbType.StringFixedLength, isPrimaryKey: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductModelProductDescriptionCulture>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_CultureID), nameof(CultureID), nameof(AdventureWorks.Production.Culture.CultureID)),
                new RelationMetadata(nameof(e_ProductDescriptionID), nameof(ProductDescriptionID), nameof(AdventureWorks.Production.ProductDescription.ProductDescriptionID)),
                new RelationMetadata(nameof(e_ProductModelID), nameof(ProductModelID), nameof(AdventureWorks.Production.ProductModel.ProductModelID))
			);

			// Cache table metadata.
			EntityMeta<ProductModelProductDescriptionCulture>.HasLanguageTable = false;
            EntityMeta<ProductModelProductDescriptionCulture>.TableSchema = @"Production";
            EntityMeta<ProductModelProductDescriptionCulture>.TableName = @"ProductModelProductDescriptionCulture";
            EntityMeta<ProductModelProductDescriptionCulture>.LanguageTableSchema = null;
            EntityMeta<ProductModelProductDescriptionCulture>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductModelID { get; set; }
        public int? ProductDescriptionID { get; set; }
        public string CultureID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Culture e_CultureID
        {
            get { return EntityContext<Culture>.Get(ref m_e_CultureID, this, nameof(e_CultureID)); }
            set { EntityContext<Culture>.Set(ref m_e_CultureID, this, value, nameof(e_CultureID)); }
        }
        public ProductDescription e_ProductDescriptionID
        {
            get { return EntityContext<ProductDescription>.Get(ref m_e_ProductDescriptionID, this, nameof(e_ProductDescriptionID)); }
            set { EntityContext<ProductDescription>.Set(ref m_e_ProductDescriptionID, this, value, nameof(e_ProductDescriptionID)); }
        }
        public ProductModel e_ProductModelID
        {
            get { return EntityContext<ProductModel>.Get(ref m_e_ProductModelID, this, nameof(e_ProductModelID)); }
            set { EntityContext<ProductModel>.Set(ref m_e_ProductModelID, this, value, nameof(e_ProductModelID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<ProductModelProductDescriptionCulture>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductModelProductDescriptionCulture>(queryConditions);
        }
        public static async Task<IEnumerable<ProductModelProductDescriptionCulture>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductModelProductDescriptionCulture>(columnName, queryOp, value);
        }
		public static async Task<ProductModelProductDescriptionCulture> GetByPrimaryKeyAsync(int ProductModelID, int ProductDescriptionID, string CultureID)
        {
            return await GetByPrimaryKeyAsync<ProductModelProductDescriptionCulture>(ProductModelID, ProductDescriptionID, CultureID);
        }
		public static async Task<ProductModelProductDescriptionCulture> TryGetByPrimaryKeyAsync(int ProductModelID, int ProductDescriptionID, string CultureID)
        {
            return await TryGetByPrimaryKeyAsync<ProductModelProductDescriptionCulture>(ProductModelID, ProductDescriptionID, CultureID);
        }
		#endregion
    }
}