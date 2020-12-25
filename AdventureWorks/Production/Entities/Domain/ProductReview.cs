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
    /// ProductReview entity.
    /// </summary>
    public sealed partial class ProductReview : Entity
    {
		#region Members
		private Product m_e_ProductID;
        #endregion
        
		#region Constructors
        static ProductReview()
        {
            // Cache field metadata.
            EntityMeta<ProductReview>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductReviewID), @"ProductReviewID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ReviewerName), @"ReviewerName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ReviewDate), @"ReviewDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(EmailAddress), @"EmailAddress", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Rating), @"Rating", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(Comments), @"Comments", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductReview>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID))
			);

			// Cache table metadata.
			EntityMeta<ProductReview>.HasLanguageTable = false;
            EntityMeta<ProductReview>.TableSchema = @"Production";
            EntityMeta<ProductReview>.TableName = @"ProductReview";
            EntityMeta<ProductReview>.LanguageTableSchema = null;
            EntityMeta<ProductReview>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductReviewID { get; private set; }
        public int? ProductID { get; set; }
        public string ReviewerName { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string EmailAddress { get; set; }
        public int? Rating { get; set; }
        public string Comments { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Product e_ProductID
        {
            get { return EntityContext<Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<ProductReview>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductReview>(queryConditions);
        }
        public static async Task<IEnumerable<ProductReview>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductReview>(columnName, queryOp, value);
        }
		public static async Task<ProductReview> GetByPrimaryKeyAsync(int ProductReviewID)
        {
            return await GetByPrimaryKeyAsync<ProductReview>(ProductReviewID);
        }
		public static async Task<ProductReview> TryGetByPrimaryKeyAsync(int ProductReviewID)
        {
            return await TryGetByPrimaryKeyAsync<ProductReview>(ProductReviewID);
        }
		#endregion
    }
}