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
    /// CustomerCustomerDemo entity.
    /// </summary>
    public sealed partial class CustomerCustomerDemo : Entity
    {
		#region Members
		private Customers m_Customers;
        private CustomerDemographics m_e_CustomerCustomerDemo;
        #endregion
        
		#region Constructors
        static CustomerCustomerDemo()
        {
            // Cache field metadata.
            EntityMeta<CustomerCustomerDemo>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CustomerID), @"CustomerID", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(CustomerTypeID), @"CustomerTypeID", DbType.StringFixedLength, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<CustomerCustomerDemo>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Customers), nameof(CustomerID), nameof(Northwind.Dbo.Customers.CustomerID)),
                new RelationMetadata(nameof(e_CustomerCustomerDemo), nameof(CustomerTypeID), nameof(Northwind.Dbo.CustomerDemographics.CustomerTypeID))
			);

			// Cache table metadata.
			EntityMeta<CustomerCustomerDemo>.HasLanguageTable = false;
            EntityMeta<CustomerCustomerDemo>.TableSchema = @"dbo";
            EntityMeta<CustomerCustomerDemo>.TableName = @"CustomerCustomerDemo";
            EntityMeta<CustomerCustomerDemo>.LanguageTableSchema = null;
            EntityMeta<CustomerCustomerDemo>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string CustomerID { get; set; }
        public string CustomerTypeID { get; set; }
        #endregion

        #region Entities
		public Customers Customers
        {
            get { return EntityContext<Customers>.Get(ref m_Customers, this, nameof(Customers)); }
            set { EntityContext<Customers>.Set(ref m_Customers, this, value, nameof(Customers)); }
        }
        public CustomerDemographics e_CustomerCustomerDemo
        {
            get { return EntityContext<CustomerDemographics>.Get(ref m_e_CustomerCustomerDemo, this, nameof(e_CustomerCustomerDemo)); }
            set { EntityContext<CustomerDemographics>.Set(ref m_e_CustomerCustomerDemo, this, value, nameof(e_CustomerCustomerDemo)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CustomerCustomerDemo>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CustomerCustomerDemo>(queryConditions);
        }
        public static async Task<IEnumerable<CustomerCustomerDemo>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CustomerCustomerDemo>(columnName, queryOp, value);
        }
		public static async Task<CustomerCustomerDemo> GetByPrimaryKeyAsync(string CustomerID, string CustomerTypeID)
        {
            return await GetByPrimaryKeyAsync<CustomerCustomerDemo>(CustomerID, CustomerTypeID);
        }
		public static async Task<CustomerCustomerDemo> TryGetByPrimaryKeyAsync(string CustomerID, string CustomerTypeID)
        {
            return await TryGetByPrimaryKeyAsync<CustomerCustomerDemo>(CustomerID, CustomerTypeID);
        }
		#endregion
    }
}