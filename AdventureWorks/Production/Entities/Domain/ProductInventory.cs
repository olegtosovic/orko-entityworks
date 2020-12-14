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
    /// ProductInventory entity.
    /// </summary>
    public sealed partial class ProductInventory : Entity
    {
		#region Members
		private Location m_e_LocationID;
        private Product m_e_ProductID;
        #endregion
        
		#region Constructors
        static ProductInventory()
        {
            // Cache field metadata.
            EntityMeta<ProductInventory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(LocationID), @"LocationID", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(Shelf), @"Shelf", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Bin), @"Bin", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(Quantity), @"Quantity", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductInventory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_LocationID), nameof(LocationID), nameof(AdventureWorks.Production.Location.LocationID)),
                new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID))
			);

			// Cache table metadata.
			EntityMeta<ProductInventory>.HasLanguageTable = false;
            EntityMeta<ProductInventory>.TableSchema = @"Production";
            EntityMeta<ProductInventory>.TableName = @"ProductInventory";
            EntityMeta<ProductInventory>.LanguageTableSchema = null;
            EntityMeta<ProductInventory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductID { get; set; }
        public short? LocationID { get; set; }
        public string Shelf { get; set; }
        public Byte? Bin { get; set; }
        public short? Quantity { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Location e_LocationID
        {
            get { return EntityContext<Location>.Get(ref m_e_LocationID, this, nameof(e_LocationID)); }
            set { EntityContext<Location>.Set(ref m_e_LocationID, this, value, nameof(e_LocationID)); }
        }
        public Product e_ProductID
        {
            get { return EntityContext<Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ProductInventory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductInventory>(queryConditions);
        }
        public static async Task<IEnumerable<ProductInventory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductInventory>(columnName, queryOp, value);
        }
		public static async Task<ProductInventory> GetByPrimaryKeyAsync(int ProductID, short LocationID)
        {
            return await GetByPrimaryKeyAsync<ProductInventory>(ProductID, LocationID);
        }
		public static async Task<ProductInventory> TryGetByPrimaryKeyAsync(int ProductID, short LocationID)
        {
            return await TryGetByPrimaryKeyAsync<ProductInventory>(ProductID, LocationID);
        }
		#endregion
    }
}