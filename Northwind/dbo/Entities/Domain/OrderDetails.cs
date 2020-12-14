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

namespace Northwind.Dbo
{
    /// <summary>
    /// OrderDetails entity.
    /// </summary>
    public sealed partial class OrderDetails : Entity
    {
		#region Members
		private Orders m_Orders;
        private Products m_Products;
        #endregion
        
		#region Constructors
        static OrderDetails()
        {
            // Cache field metadata.
            EntityMeta<OrderDetails>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(OrderID), @"OrderID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(UnitPrice), @"UnitPrice", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(Quantity), @"Quantity", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(Discount), @"Discount", DbType.Single, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<OrderDetails>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Orders), nameof(OrderID), nameof(Northwind.Dbo.Orders.OrderID)),
                new RelationMetadata(nameof(Products), nameof(ProductID), nameof(Northwind.Dbo.Products.ProductID))
			);

			// Cache table metadata.
			EntityMeta<OrderDetails>.HasLanguageTable = false;
            EntityMeta<OrderDetails>.TableSchema = @"dbo";
            EntityMeta<OrderDetails>.TableName = @"Order Details";
            EntityMeta<OrderDetails>.LanguageTableSchema = null;
            EntityMeta<OrderDetails>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? Quantity { get; set; }
        public Single? Discount { get; set; }
        #endregion

        #region Entities
		public Orders Orders
        {
            get { return EntityContext<Orders>.Get(ref m_Orders, this, nameof(Orders)); }
            set { EntityContext<Orders>.Set(ref m_Orders, this, value, nameof(Orders)); }
        }
        public Products Products
        {
            get { return EntityContext<Products>.Get(ref m_Products, this, nameof(Products)); }
            set { EntityContext<Products>.Set(ref m_Products, this, value, nameof(Products)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<OrderDetails>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<OrderDetails>(queryConditions);
        }
        public static async Task<IEnumerable<OrderDetails>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<OrderDetails>(columnName, queryOp, value);
        }
		public static async Task<OrderDetails> GetByPrimaryKeyAsync(int OrderID, int ProductID)
        {
            return await GetByPrimaryKeyAsync<OrderDetails>(OrderID, ProductID);
        }
		public static async Task<OrderDetails> TryGetByPrimaryKeyAsync(int OrderID, int ProductID)
        {
            return await TryGetByPrimaryKeyAsync<OrderDetails>(OrderID, ProductID);
        }
		#endregion
    }
}