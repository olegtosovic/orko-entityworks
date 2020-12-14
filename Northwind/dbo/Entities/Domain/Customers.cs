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
    /// Customers entity.
    /// </summary>
    public sealed partial class Customers : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Customers()
        {
            // Cache field metadata.
            EntityMeta<Customers>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CustomerID), @"CustomerID", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(CompanyName), @"CompanyName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ContactName), @"ContactName", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ContactTitle), @"ContactTitle", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Address), @"Address", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(City), @"City", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Region), @"Region", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(PostalCode), @"PostalCode", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Country), @"Country", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Phone), @"Phone", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Fax), @"Fax", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Customers>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Customers>.HasLanguageTable = false;
            EntityMeta<Customers>.TableSchema = @"dbo";
            EntityMeta<Customers>.TableName = @"Customers";
            EntityMeta<Customers>.LanguageTableSchema = null;
            EntityMeta<Customers>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Customers>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Customers>(queryConditions);
        }
        public static async Task<IEnumerable<Customers>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Customers>(columnName, queryOp, value);
        }
		public static async Task<Customers> GetByPrimaryKeyAsync(string CustomerID)
        {
            return await GetByPrimaryKeyAsync<Customers>(CustomerID);
        }
		public static async Task<Customers> TryGetByPrimaryKeyAsync(string CustomerID)
        {
            return await TryGetByPrimaryKeyAsync<Customers>(CustomerID);
        }
		#endregion
    }
}