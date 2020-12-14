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

namespace AdventureWorks.HumanResources
{
    /// <summary>
    /// EmployeeDepartmentHistory entity.
    /// </summary>
    public sealed partial class EmployeeDepartmentHistory : Entity
    {
		#region Members
		private Employee m_e_BusinessEntityID;
        private Department m_e_DepartmentID;
        private Shift m_e_ShiftID;
        #endregion
        
		#region Constructors
        static EmployeeDepartmentHistory()
        {
            // Cache field metadata.
            EntityMeta<EmployeeDepartmentHistory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(DepartmentID), @"DepartmentID", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(ShiftID), @"ShiftID", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(StartDate), @"StartDate", DbType.Date, isRequired: true),
                new ColumnMetadata(nameof(EndDate), @"EndDate", DbType.Date, isRequired: false),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<EmployeeDepartmentHistory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.HumanResources.Employee.BusinessEntityID)),
                new RelationMetadata(nameof(e_DepartmentID), nameof(DepartmentID), nameof(AdventureWorks.HumanResources.Department.DepartmentID)),
                new RelationMetadata(nameof(e_ShiftID), nameof(ShiftID), nameof(AdventureWorks.HumanResources.Shift.ShiftID))
			);

			// Cache table metadata.
			EntityMeta<EmployeeDepartmentHistory>.HasLanguageTable = false;
            EntityMeta<EmployeeDepartmentHistory>.TableSchema = @"HumanResources";
            EntityMeta<EmployeeDepartmentHistory>.TableName = @"EmployeeDepartmentHistory";
            EntityMeta<EmployeeDepartmentHistory>.LanguageTableSchema = null;
            EntityMeta<EmployeeDepartmentHistory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public short? DepartmentID { get; set; }
        public Byte? ShiftID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Employee e_BusinessEntityID
        {
            get { return EntityContext<Employee>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Employee>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        public Department e_DepartmentID
        {
            get { return EntityContext<Department>.Get(ref m_e_DepartmentID, this, nameof(e_DepartmentID)); }
            set { EntityContext<Department>.Set(ref m_e_DepartmentID, this, value, nameof(e_DepartmentID)); }
        }
        public Shift e_ShiftID
        {
            get { return EntityContext<Shift>.Get(ref m_e_ShiftID, this, nameof(e_ShiftID)); }
            set { EntityContext<Shift>.Set(ref m_e_ShiftID, this, value, nameof(e_ShiftID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<EmployeeDepartmentHistory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<EmployeeDepartmentHistory>(queryConditions);
        }
        public static async Task<IEnumerable<EmployeeDepartmentHistory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<EmployeeDepartmentHistory>(columnName, queryOp, value);
        }
		public static async Task<EmployeeDepartmentHistory> GetByPrimaryKeyAsync(int BusinessEntityID, short DepartmentID, Byte ShiftID, DateTime StartDate)
        {
            return await GetByPrimaryKeyAsync<EmployeeDepartmentHistory>(BusinessEntityID, DepartmentID, ShiftID, StartDate);
        }
		public static async Task<EmployeeDepartmentHistory> TryGetByPrimaryKeyAsync(int BusinessEntityID, short DepartmentID, Byte ShiftID, DateTime StartDate)
        {
            return await TryGetByPrimaryKeyAsync<EmployeeDepartmentHistory>(BusinessEntityID, DepartmentID, ShiftID, StartDate);
        }
		#endregion
    }
}