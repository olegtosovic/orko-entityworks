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
    /// ProductListPriceHistory entity.
    /// </summary>
    public sealed partial class ProductListPriceHistory : Entity
    {
		#region Members
		private Product m_e_ProductID;
        #endregion
        
		#region Constructors
        static ProductListPriceHistory()
        {
            // Cache field metadata.
            EntityMeta<ProductListPriceHistory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(StartDate), @"StartDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(EndDate), @"EndDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(ListPrice), @"ListPrice", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductListPriceHistory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID))
			);

			// Cache table metadata.
			EntityMeta<ProductListPriceHistory>.HasLanguageTable = false;
            EntityMeta<ProductListPriceHistory>.TableSchema = @"Production";
            EntityMeta<ProductListPriceHistory>.TableName = @"ProductListPriceHistory";
            EntityMeta<ProductListPriceHistory>.LanguageTableSchema = null;
            EntityMeta<ProductListPriceHistory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? ListPrice { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Product e_ProductID
        {
            get { return EntityContext<Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ProductListPriceHistory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductListPriceHistory>(queryConditions);
        }
        public static async Task<IEnumerable<ProductListPriceHistory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductListPriceHistory>(columnName, queryOp, value);
        }
		public static async Task<ProductListPriceHistory> GetByPrimaryKeyAsync(int ProductID, DateTime StartDate)
        {
            return await GetByPrimaryKeyAsync<ProductListPriceHistory>(ProductID, StartDate);
        }
		public static async Task<ProductListPriceHistory> TryGetByPrimaryKeyAsync(int ProductID, DateTime StartDate)
        {
            return await TryGetByPrimaryKeyAsync<ProductListPriceHistory>(ProductID, StartDate);
        }
		#endregion
    }
}