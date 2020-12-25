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

namespace AdventureWorks.Sales
{
    /// <summary>
    /// ShoppingCartItem entity.
    /// </summary>
    public sealed partial class ShoppingCartItem : Entity
    {
		#region Members
		private Production.Product m_e_ProductID;
        #endregion
        
		#region Constructors
        static ShoppingCartItem()
        {
            // Cache field metadata.
            EntityMeta<ShoppingCartItem>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ShoppingCartItemID), @"ShoppingCartItemID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(ShoppingCartID), @"ShoppingCartID", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Quantity), @"Quantity", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(DateCreated), @"DateCreated", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ShoppingCartItem>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID))
			);

			// Cache table metadata.
			EntityMeta<ShoppingCartItem>.HasLanguageTable = false;
            EntityMeta<ShoppingCartItem>.TableSchema = @"Sales";
            EntityMeta<ShoppingCartItem>.TableName = @"ShoppingCartItem";
            EntityMeta<ShoppingCartItem>.LanguageTableSchema = null;
            EntityMeta<ShoppingCartItem>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ShoppingCartItemID { get; private set; }
        public string ShoppingCartID { get; set; }
        public int? Quantity { get; set; }
        public int? ProductID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Production.Product e_ProductID
        {
            get { return EntityContext<Production.Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Production.Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<ShoppingCartItem>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ShoppingCartItem>(queryConditions);
        }
        public static async Task<IEnumerable<ShoppingCartItem>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ShoppingCartItem>(columnName, queryOp, value);
        }
		public static async Task<ShoppingCartItem> GetByPrimaryKeyAsync(int ShoppingCartItemID)
        {
            return await GetByPrimaryKeyAsync<ShoppingCartItem>(ShoppingCartItemID);
        }
		public static async Task<ShoppingCartItem> TryGetByPrimaryKeyAsync(int ShoppingCartItemID)
        {
            return await TryGetByPrimaryKeyAsync<ShoppingCartItem>(ShoppingCartItemID);
        }
		#endregion
    }
}