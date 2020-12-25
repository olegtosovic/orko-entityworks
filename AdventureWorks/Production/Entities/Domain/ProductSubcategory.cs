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
    /// ProductSubcategory entity.
    /// </summary>
    public sealed partial class ProductSubcategory : Entity
    {
		#region Members
		private ProductCategory m_e_ProductCategoryID;
        #endregion
        
		#region Constructors
        static ProductSubcategory()
        {
            // Cache field metadata.
            EntityMeta<ProductSubcategory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductSubcategoryID), @"ProductSubcategoryID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(ProductCategoryID), @"ProductCategoryID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductSubcategory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductCategoryID), nameof(ProductCategoryID), nameof(AdventureWorks.Production.ProductCategory.ProductCategoryID))
			);

			// Cache table metadata.
			EntityMeta<ProductSubcategory>.HasLanguageTable = false;
            EntityMeta<ProductSubcategory>.TableSchema = @"Production";
            EntityMeta<ProductSubcategory>.TableName = @"ProductSubcategory";
            EntityMeta<ProductSubcategory>.LanguageTableSchema = null;
            EntityMeta<ProductSubcategory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductSubcategoryID { get; private set; }
        public int? ProductCategoryID { get; set; }
        public string Name { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public ProductCategory e_ProductCategoryID
        {
            get { return EntityContext<ProductCategory>.Get(ref m_e_ProductCategoryID, this, nameof(e_ProductCategoryID)); }
            set { EntityContext<ProductCategory>.Set(ref m_e_ProductCategoryID, this, value, nameof(e_ProductCategoryID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<ProductSubcategory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductSubcategory>(queryConditions);
        }
        public static async Task<IEnumerable<ProductSubcategory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductSubcategory>(columnName, queryOp, value);
        }
		public static async Task<ProductSubcategory> GetByPrimaryKeyAsync(int ProductSubcategoryID)
        {
            return await GetByPrimaryKeyAsync<ProductSubcategory>(ProductSubcategoryID);
        }
		public static async Task<ProductSubcategory> TryGetByPrimaryKeyAsync(int ProductSubcategoryID)
        {
            return await TryGetByPrimaryKeyAsync<ProductSubcategory>(ProductSubcategoryID);
        }
		#endregion
    }
}