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
    /// Employees entity.
    /// </summary>
    public sealed partial class Employees : Entity
    {
		#region Members
		private Employees m_e_Employees;
        #endregion
        
		#region Constructors
        static Employees()
        {
            // Cache field metadata.
            EntityMeta<Employees>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(EmployeeID), @"EmployeeID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(LastName), @"LastName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(FirstName), @"FirstName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Title), @"Title", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(TitleOfCourtesy), @"TitleOfCourtesy", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(BirthDate), @"BirthDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(HireDate), @"HireDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(Address), @"Address", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(City), @"City", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Region), @"Region", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(PostalCode), @"PostalCode", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Country), @"Country", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(HomePhone), @"HomePhone", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Extension), @"Extension", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Photo), @"Photo", DbType.Binary, isRequired: false),
                new ColumnMetadata(nameof(Notes), @"Notes", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ReportsTo), @"ReportsTo", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(PhotoPath), @"PhotoPath", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Employees>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_Employees), nameof(ReportsTo), nameof(Northwind.Dbo.Employees.EmployeeID))
			);

			// Cache table metadata.
			EntityMeta<Employees>.HasLanguageTable = false;
            EntityMeta<Employees>.TableSchema = @"dbo";
            EntityMeta<Employees>.TableName = @"Employees";
            EntityMeta<Employees>.LanguageTableSchema = null;
            EntityMeta<Employees>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? EmployeeID { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public Byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        #endregion

        #region Entities
		public Employees e_Employees
        {
            get { return EntityContext<Employees>.Get(ref m_e_Employees, this, nameof(e_Employees)); }
            set { EntityContext<Employees>.Set(ref m_e_Employees, this, value, nameof(e_Employees)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Employees>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Employees>(queryConditions);
        }
        public static async Task<IEnumerable<Employees>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Employees>(columnName, queryOp, value);
        }
		public static async Task<Employees> GetByPrimaryKeyAsync(int EmployeeID)
        {
            return await GetByPrimaryKeyAsync<Employees>(EmployeeID);
        }
		public static async Task<Employees> TryGetByPrimaryKeyAsync(int EmployeeID)
        {
            return await TryGetByPrimaryKeyAsync<Employees>(EmployeeID);
        }
		#endregion
    }
}