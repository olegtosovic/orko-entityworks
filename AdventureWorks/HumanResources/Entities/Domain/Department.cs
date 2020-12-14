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
    /// Department entity.
    /// </summary>
    public sealed partial class Department : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Department()
        {
            // Cache field metadata.
            EntityMeta<Department>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(DepartmentID), @"DepartmentID", DbType.Int16, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(GroupName), @"GroupName", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Department>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Department>.HasLanguageTable = false;
            EntityMeta<Department>.TableSchema = @"HumanResources";
            EntityMeta<Department>.TableName = @"Department";
            EntityMeta<Department>.LanguageTableSchema = null;
            EntityMeta<Department>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public short? DepartmentID { get; private set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Department>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Department>(queryConditions);
        }
        public static async Task<IEnumerable<Department>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Department>(columnName, queryOp, value);
        }
		public static async Task<Department> GetByPrimaryKeyAsync(short DepartmentID)
        {
            return await GetByPrimaryKeyAsync<Department>(DepartmentID);
        }
		public static async Task<Department> TryGetByPrimaryKeyAsync(short DepartmentID)
        {
            return await TryGetByPrimaryKeyAsync<Department>(DepartmentID);
        }
		#endregion
    }
}