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
    /// Suppliers entity.
    /// </summary>
    public sealed partial class Suppliers : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Suppliers()
        {
            // Cache field metadata.
            EntityMeta<Suppliers>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SupplierID), @"SupplierID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CompanyName), @"CompanyName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ContactName), @"ContactName", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ContactTitle), @"ContactTitle", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Address), @"Address", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(City), @"City", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Region), @"Region", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(PostalCode), @"PostalCode", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Country), @"Country", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Phone), @"Phone", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Fax), @"Fax", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(HomePage), @"HomePage", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Suppliers>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Suppliers>.HasLanguageTable = false;
            EntityMeta<Suppliers>.TableSchema = @"dbo";
            EntityMeta<Suppliers>.TableName = @"Suppliers";
            EntityMeta<Suppliers>.LanguageTableSchema = null;
            EntityMeta<Suppliers>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SupplierID { get; private set; }
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
        public string HomePage { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Suppliers>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Suppliers>(queryConditions);
        }
        public static async Task<IEnumerable<Suppliers>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Suppliers>(columnName, queryOp, value);
        }
		public static async Task<Suppliers> GetByPrimaryKeyAsync(int SupplierID)
        {
            return await GetByPrimaryKeyAsync<Suppliers>(SupplierID);
        }
		public static async Task<Suppliers> TryGetByPrimaryKeyAsync(int SupplierID)
        {
            return await TryGetByPrimaryKeyAsync<Suppliers>(SupplierID);
        }
		#endregion
    }
}