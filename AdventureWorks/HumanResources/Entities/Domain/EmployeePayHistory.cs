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
    /// EmployeePayHistory entity.
    /// </summary>
    public sealed partial class EmployeePayHistory : Entity
    {
		#region Members
		private Employee m_e_BusinessEntityID;
        #endregion
        
		#region Constructors
        static EmployeePayHistory()
        {
            // Cache field metadata.
            EntityMeta<EmployeePayHistory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RateChangeDate), @"RateChangeDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(Rate), @"Rate", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(PayFrequency), @"PayFrequency", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<EmployeePayHistory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.HumanResources.Employee.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<EmployeePayHistory>.HasLanguageTable = false;
            EntityMeta<EmployeePayHistory>.TableSchema = @"HumanResources";
            EntityMeta<EmployeePayHistory>.TableName = @"EmployeePayHistory";
            EntityMeta<EmployeePayHistory>.LanguageTableSchema = null;
            EntityMeta<EmployeePayHistory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public DateTime? RateChangeDate { get; set; }
        public decimal? Rate { get; set; }
        public Byte? PayFrequency { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Employee e_BusinessEntityID
        {
            get { return EntityContext<Employee>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Employee>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<EmployeePayHistory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<EmployeePayHistory>(queryConditions);
        }
        public static async Task<IEnumerable<EmployeePayHistory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<EmployeePayHistory>(columnName, queryOp, value);
        }
		public static async Task<EmployeePayHistory> GetByPrimaryKeyAsync(int BusinessEntityID, DateTime RateChangeDate)
        {
            return await GetByPrimaryKeyAsync<EmployeePayHistory>(BusinessEntityID, RateChangeDate);
        }
		public static async Task<EmployeePayHistory> TryGetByPrimaryKeyAsync(int BusinessEntityID, DateTime RateChangeDate)
        {
            return await TryGetByPrimaryKeyAsync<EmployeePayHistory>(BusinessEntityID, RateChangeDate);
        }
		#endregion
    }
}