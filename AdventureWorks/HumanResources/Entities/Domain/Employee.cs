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

namespace AdventureWorks.HumanResources
{
    /// <summary>
    /// Employee entity.
    /// </summary>
    public sealed partial class Employee : Entity
    {
		#region Members
		private Person.Person m_e_BusinessEntityID;
        #endregion
        
		#region Constructors
        static Employee()
        {
            // Cache field metadata.
            EntityMeta<Employee>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(NationalIDNumber), @"NationalIDNumber", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(LoginID), @"LoginID", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(OrganizationNode), @"OrganizationNode", DbType.Binary, isRequired: false),
                new ColumnMetadata(nameof(OrganizationLevel), @"OrganizationLevel", DbType.Int16, isRequired: false),
                new ColumnMetadata(nameof(JobTitle), @"JobTitle", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(BirthDate), @"BirthDate", DbType.Date, isRequired: true),
                new ColumnMetadata(nameof(MaritalStatus), @"MaritalStatus", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(Gender), @"Gender", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(HireDate), @"HireDate", DbType.Date, isRequired: true),
                new ColumnMetadata(nameof(SalariedFlag), @"SalariedFlag", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VacationHours), @"VacationHours", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(SickLeaveHours), @"SickLeaveHours", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(CurrentFlag), @"CurrentFlag", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Employee>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.Person.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<Employee>.HasLanguageTable = false;
            EntityMeta<Employee>.TableSchema = @"HumanResources";
            EntityMeta<Employee>.TableName = @"Employee";
            EntityMeta<Employee>.LanguageTableSchema = null;
            EntityMeta<Employee>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public string NationalIDNumber { get; set; }
        public string LoginID { get; set; }
        public Byte[] OrganizationNode { get; set; }
        public short? OrganizationLevel { get; set; }
        public string JobTitle { get; set; }
        public DateTime? BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime? HireDate { get; set; }
        public bool? SalariedFlag { get; set; }
        public short? VacationHours { get; set; }
        public short? SickLeaveHours { get; set; }
        public bool? CurrentFlag { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person.Person e_BusinessEntityID
        {
            get { return EntityContext<Person.Person>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Person.Person>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Employee>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Employee>(queryConditions);
        }
        public static async Task<IEnumerable<Employee>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Employee>(columnName, queryOp, value);
        }
		public static async Task<Employee> GetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await GetByPrimaryKeyAsync<Employee>(BusinessEntityID);
        }
		public static async Task<Employee> TryGetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await TryGetByPrimaryKeyAsync<Employee>(BusinessEntityID);
        }
		#endregion
    }
}