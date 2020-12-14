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
    /// ProductCostHistory entity.
    /// </summary>
    public sealed partial class ProductCostHistory : Entity
    {
		#region Members
		private Product m_e_ProductID;
        #endregion
        
		#region Constructors
        static ProductCostHistory()
        {
            // Cache field metadata.
            EntityMeta<ProductCostHistory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(StartDate), @"StartDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(EndDate), @"EndDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(StandardCost), @"StandardCost", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductCostHistory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID))
			);

			// Cache table metadata.
			EntityMeta<ProductCostHistory>.HasLanguageTable = false;
            EntityMeta<ProductCostHistory>.TableSchema = @"Production";
            EntityMeta<ProductCostHistory>.TableName = @"ProductCostHistory";
            EntityMeta<ProductCostHistory>.LanguageTableSchema = null;
            EntityMeta<ProductCostHistory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? StandardCost { get; set; }
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
		public static async Task<IEnumerable<ProductCostHistory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductCostHistory>(queryConditions);
        }
        public static async Task<IEnumerable<ProductCostHistory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductCostHistory>(columnName, queryOp, value);
        }
		public static async Task<ProductCostHistory> GetByPrimaryKeyAsync(int ProductID, DateTime StartDate)
        {
            return await GetByPrimaryKeyAsync<ProductCostHistory>(ProductID, StartDate);
        }
		public static async Task<ProductCostHistory> TryGetByPrimaryKeyAsync(int ProductID, DateTime StartDate)
        {
            return await TryGetByPrimaryKeyAsync<ProductCostHistory>(ProductID, StartDate);
        }
		#endregion
    }
}