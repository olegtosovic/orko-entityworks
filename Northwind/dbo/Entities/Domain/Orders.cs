// Generated on 12/21/2020 1:03 PM using EntityWorks code generation tool.
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
    /// Orders entity.
    /// </summary>
    public sealed partial class Orders : Entity
    {
		#region Members
		private Customers m_Customers;
        private Employees m_Employees;
        private Shippers m_Shippers;
        #endregion
        
		#region Constructors
        static Orders()
        {
            // Cache field metadata.
            EntityMeta<Orders>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(OrderID), @"OrderID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(CustomerID), @"CustomerID", DbType.StringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(EmployeeID), @"EmployeeID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(OrderDate), @"OrderDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(RequiredDate), @"RequiredDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(ShippedDate), @"ShippedDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(ShipVia), @"ShipVia", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(Freight), @"Freight", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(ShipName), @"ShipName", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ShipAddress), @"ShipAddress", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ShipCity), @"ShipCity", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ShipRegion), @"ShipRegion", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ShipPostalCode), @"ShipPostalCode", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ShipCountry), @"ShipCountry", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Orders>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Customers), nameof(CustomerID), nameof(Northwind.Dbo.Customers.CustomerID)),
                new RelationMetadata(nameof(Employees), nameof(EmployeeID), nameof(Northwind.Dbo.Employees.EmployeeID)),
                new RelationMetadata(nameof(Shippers), nameof(ShipVia), nameof(Northwind.Dbo.Shippers.ShipperID))
			);

			// Cache table metadata.
			EntityMeta<Orders>.HasLanguageTable = false;
            EntityMeta<Orders>.TableSchema = @"dbo";
            EntityMeta<Orders>.TableName = @"Orders";
            EntityMeta<Orders>.LanguageTableSchema = null;
            EntityMeta<Orders>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? OrderID { get; private set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        #endregion

        #region Entities
		public Customers Customers
        {
            get { return EntityContext<Customers>.Get(ref m_Customers, this, nameof(Customers)); }
            set { EntityContext<Customers>.Set(ref m_Customers, this, value, nameof(Customers)); }
        }
        public Employees Employees
        {
            get { return EntityContext<Employees>.Get(ref m_Employees, this, nameof(Employees)); }
            set { EntityContext<Employees>.Set(ref m_Employees, this, value, nameof(Employees)); }
        }
        public Shippers Shippers
        {
            get { return EntityContext<Shippers>.Get(ref m_Shippers, this, nameof(Shippers)); }
            set { EntityContext<Shippers>.Set(ref m_Shippers, this, value, nameof(Shippers)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Orders>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Orders>(queryConditions);
        }
        public static async Task<IEnumerable<Orders>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Orders>(columnName, queryOp, value);
        }
		public static async Task<Orders> GetByPrimaryKeyAsync(int OrderID)
        {
            return await GetByPrimaryKeyAsync<Orders>(OrderID);
        }
		public static async Task<Orders> TryGetByPrimaryKeyAsync(int OrderID)
        {
            return await TryGetByPrimaryKeyAsync<Orders>(OrderID);
        }
		#endregion
    }
}