// Generated on 12/22/2020 12:53 PM using EntityWorks code generation tool.
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
    /// Products entity.
    /// </summary>
    public sealed partial class Products : Entity
    {
		#region Members
		private Categories m_Categories;
        private Suppliers m_Suppliers;
        #endregion
        
		#region Constructors
        static Products()
        {
            // Cache field metadata.
            EntityMeta<Products>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(ProductName), @"ProductName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SupplierID), @"SupplierID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(CategoryID), @"CategoryID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(QuantityPerUnit), @"QuantityPerUnit", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(UnitPrice), @"UnitPrice", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(UnitsInStock), @"UnitsInStock", DbType.Int16, isRequired: false),
                new ColumnMetadata(nameof(UnitsOnOrder), @"UnitsOnOrder", DbType.Int16, isRequired: false),
                new ColumnMetadata(nameof(ReorderLevel), @"ReorderLevel", DbType.Int16, isRequired: false),
                new ColumnMetadata(nameof(Discontinued), @"Discontinued", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Products>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Categories), nameof(CategoryID), nameof(Northwind.Dbo.Categories.CategoryID)),
                new RelationMetadata(nameof(Suppliers), nameof(SupplierID), nameof(Northwind.Dbo.Suppliers.SupplierID))
			);

			// Cache table metadata.
			EntityMeta<Products>.HasLanguageTable = false;
            EntityMeta<Products>.TableSchema = @"dbo";
            EntityMeta<Products>.TableName = @"Products";
            EntityMeta<Products>.LanguageTableSchema = null;
            EntityMeta<Products>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductID { get; private set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool? Discontinued { get; set; }
        #endregion

        #region Entities
		public Categories Categories
        {
            get { return EntityContext<Categories>.Get(ref m_Categories, this, nameof(Categories)); }
            set { EntityContext<Categories>.Set(ref m_Categories, this, value, nameof(Categories)); }
        }
        public Suppliers Suppliers
        {
            get { return EntityContext<Suppliers>.Get(ref m_Suppliers, this, nameof(Suppliers)); }
            set { EntityContext<Suppliers>.Set(ref m_Suppliers, this, value, nameof(Suppliers)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Products>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Products>(queryConditions);
        }
        public static async Task<IEnumerable<Products>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Products>(columnName, queryOp, value);
        }
		public static async Task<Products> GetByPrimaryKeyAsync(int ProductID)
        {
            return await GetByPrimaryKeyAsync<Products>(ProductID);
        }
		public static async Task<Products> TryGetByPrimaryKeyAsync(int ProductID)
        {
            return await TryGetByPrimaryKeyAsync<Products>(ProductID);
        }
		#endregion
    }
}