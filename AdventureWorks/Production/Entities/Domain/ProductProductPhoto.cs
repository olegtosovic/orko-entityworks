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

namespace AdventureWorks.Production
{
    /// <summary>
    /// ProductProductPhoto entity.
    /// </summary>
    public sealed partial class ProductProductPhoto : Entity
    {
		#region Members
		private Product m_e_ProductID;
        private ProductPhoto m_e_ProductPhotoID;
        #endregion
        
		#region Constructors
        static ProductProductPhoto()
        {
            // Cache field metadata.
            EntityMeta<ProductProductPhoto>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProductPhotoID), @"ProductPhotoID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(Primary), @"Primary", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductProductPhoto>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID)),
                new RelationMetadata(nameof(e_ProductPhotoID), nameof(ProductPhotoID), nameof(AdventureWorks.Production.ProductPhoto.ProductPhotoID))
			);

			// Cache table metadata.
			EntityMeta<ProductProductPhoto>.HasLanguageTable = false;
            EntityMeta<ProductProductPhoto>.TableSchema = @"Production";
            EntityMeta<ProductProductPhoto>.TableName = @"ProductProductPhoto";
            EntityMeta<ProductProductPhoto>.LanguageTableSchema = null;
            EntityMeta<ProductProductPhoto>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductID { get; set; }
        public int? ProductPhotoID { get; set; }
        public string Primary { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Product e_ProductID
        {
            get { return EntityContext<Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        public ProductPhoto e_ProductPhotoID
        {
            get { return EntityContext<ProductPhoto>.Get(ref m_e_ProductPhotoID, this, nameof(e_ProductPhotoID)); }
            set { EntityContext<ProductPhoto>.Set(ref m_e_ProductPhotoID, this, value, nameof(e_ProductPhotoID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ProductProductPhoto>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductProductPhoto>(queryConditions);
        }
        public static async Task<IEnumerable<ProductProductPhoto>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductProductPhoto>(columnName, queryOp, value);
        }
		public static async Task<ProductProductPhoto> GetByPrimaryKeyAsync(int ProductID, int ProductPhotoID)
        {
            return await GetByPrimaryKeyAsync<ProductProductPhoto>(ProductID, ProductPhotoID);
        }
		public static async Task<ProductProductPhoto> TryGetByPrimaryKeyAsync(int ProductID, int ProductPhotoID)
        {
            return await TryGetByPrimaryKeyAsync<ProductProductPhoto>(ProductID, ProductPhotoID);
        }
		#endregion
    }
}