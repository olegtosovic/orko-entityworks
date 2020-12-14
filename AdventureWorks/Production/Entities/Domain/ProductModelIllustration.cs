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
    /// ProductModelIllustration entity.
    /// </summary>
    public sealed partial class ProductModelIllustration : Entity
    {
		#region Members
		private Illustration m_e_IllustrationID;
        private ProductModel m_e_ProductModelID;
        #endregion
        
		#region Constructors
        static ProductModelIllustration()
        {
            // Cache field metadata.
            EntityMeta<ProductModelIllustration>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductModelID), @"ProductModelID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(IllustrationID), @"IllustrationID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductModelIllustration>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_IllustrationID), nameof(IllustrationID), nameof(AdventureWorks.Production.Illustration.IllustrationID)),
                new RelationMetadata(nameof(e_ProductModelID), nameof(ProductModelID), nameof(AdventureWorks.Production.ProductModel.ProductModelID))
			);

			// Cache table metadata.
			EntityMeta<ProductModelIllustration>.HasLanguageTable = false;
            EntityMeta<ProductModelIllustration>.TableSchema = @"Production";
            EntityMeta<ProductModelIllustration>.TableName = @"ProductModelIllustration";
            EntityMeta<ProductModelIllustration>.LanguageTableSchema = null;
            EntityMeta<ProductModelIllustration>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductModelID { get; set; }
        public int? IllustrationID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Illustration e_IllustrationID
        {
            get { return EntityContext<Illustration>.Get(ref m_e_IllustrationID, this, nameof(e_IllustrationID)); }
            set { EntityContext<Illustration>.Set(ref m_e_IllustrationID, this, value, nameof(e_IllustrationID)); }
        }
        public ProductModel e_ProductModelID
        {
            get { return EntityContext<ProductModel>.Get(ref m_e_ProductModelID, this, nameof(e_ProductModelID)); }
            set { EntityContext<ProductModel>.Set(ref m_e_ProductModelID, this, value, nameof(e_ProductModelID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ProductModelIllustration>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductModelIllustration>(queryConditions);
        }
        public static async Task<IEnumerable<ProductModelIllustration>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductModelIllustration>(columnName, queryOp, value);
        }
		public static async Task<ProductModelIllustration> GetByPrimaryKeyAsync(int ProductModelID, int IllustrationID)
        {
            return await GetByPrimaryKeyAsync<ProductModelIllustration>(ProductModelID, IllustrationID);
        }
		public static async Task<ProductModelIllustration> TryGetByPrimaryKeyAsync(int ProductModelID, int IllustrationID)
        {
            return await TryGetByPrimaryKeyAsync<ProductModelIllustration>(ProductModelID, IllustrationID);
        }
		#endregion
    }
}