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
    /// ProductDocument entity.
    /// </summary>
    public sealed partial class ProductDocument : Entity
    {
		#region Members
		private Document m_e_DocumentNode;
        private Product m_e_ProductID;
        #endregion
        
		#region Constructors
        static ProductDocument()
        {
            // Cache field metadata.
            EntityMeta<ProductDocument>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(DocumentNode), @"DocumentNode", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductDocument>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_DocumentNode), nameof(DocumentNode), nameof(AdventureWorks.Production.Document.DocumentNode)),
                new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID))
			);

			// Cache table metadata.
			EntityMeta<ProductDocument>.HasLanguageTable = false;
            EntityMeta<ProductDocument>.TableSchema = @"Production";
            EntityMeta<ProductDocument>.TableName = @"ProductDocument";
            EntityMeta<ProductDocument>.LanguageTableSchema = null;
            EntityMeta<ProductDocument>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductID { get; set; }
        public Object DocumentNode { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Document e_DocumentNode
        {
            get { return EntityContext<Document>.Get(ref m_e_DocumentNode, this, nameof(e_DocumentNode)); }
            set { EntityContext<Document>.Set(ref m_e_DocumentNode, this, value, nameof(e_DocumentNode)); }
        }
        public Product e_ProductID
        {
            get { return EntityContext<Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ProductDocument>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductDocument>(queryConditions);
        }
        public static async Task<IEnumerable<ProductDocument>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductDocument>(columnName, queryOp, value);
        }
		public static async Task<ProductDocument> GetByPrimaryKeyAsync(int ProductID, Object DocumentNode)
        {
            return await GetByPrimaryKeyAsync<ProductDocument>(ProductID, DocumentNode);
        }
		public static async Task<ProductDocument> TryGetByPrimaryKeyAsync(int ProductID, Object DocumentNode)
        {
            return await TryGetByPrimaryKeyAsync<ProductDocument>(ProductID, DocumentNode);
        }
		#endregion
    }
}