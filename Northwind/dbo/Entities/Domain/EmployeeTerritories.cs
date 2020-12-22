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
    /// EmployeeTerritories entity.
    /// </summary>
    public sealed partial class EmployeeTerritories : Entity
    {
		#region Members
		private Employees m_Employees;
        private Territories m_Territories;
        #endregion
        
		#region Constructors
        static EmployeeTerritories()
        {
            // Cache field metadata.
            EntityMeta<EmployeeTerritories>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(EmployeeID), @"EmployeeID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(TerritoryID), @"TerritoryID", DbType.String, isPrimaryKey: true)
			);

            // Cache entites metadata.
            EntityMeta<EmployeeTerritories>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Employees), nameof(EmployeeID), nameof(Northwind.Dbo.Employees.EmployeeID)),
                new RelationMetadata(nameof(Territories), nameof(TerritoryID), nameof(Northwind.Dbo.Territories.TerritoryID))
			);

			// Cache table metadata.
			EntityMeta<EmployeeTerritories>.HasLanguageTable = false;
            EntityMeta<EmployeeTerritories>.TableSchema = @"dbo";
            EntityMeta<EmployeeTerritories>.TableName = @"EmployeeTerritories";
            EntityMeta<EmployeeTerritories>.LanguageTableSchema = null;
            EntityMeta<EmployeeTerritories>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? EmployeeID { get; set; }
        public string TerritoryID { get; set; }
        #endregion

        #region Entities
		public Employees Employees
        {
            get { return EntityContext<Employees>.Get(ref m_Employees, this, nameof(Employees)); }
            set { EntityContext<Employees>.Set(ref m_Employees, this, value, nameof(Employees)); }
        }
        public Territories Territories
        {
            get { return EntityContext<Territories>.Get(ref m_Territories, this, nameof(Territories)); }
            set { EntityContext<Territories>.Set(ref m_Territories, this, value, nameof(Territories)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<EmployeeTerritories>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<EmployeeTerritories>(queryConditions);
        }
        public static async Task<IEnumerable<EmployeeTerritories>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<EmployeeTerritories>(columnName, queryOp, value);
        }
		public static async Task<EmployeeTerritories> GetByPrimaryKeyAsync(int EmployeeID, string TerritoryID)
        {
            return await GetByPrimaryKeyAsync<EmployeeTerritories>(EmployeeID, TerritoryID);
        }
		public static async Task<EmployeeTerritories> TryGetByPrimaryKeyAsync(int EmployeeID, string TerritoryID)
        {
            return await TryGetByPrimaryKeyAsync<EmployeeTerritories>(EmployeeID, TerritoryID);
        }
		#endregion
    }
}