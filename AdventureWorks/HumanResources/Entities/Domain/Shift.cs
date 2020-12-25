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
    /// Shift entity.
    /// </summary>
    public sealed partial class Shift : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Shift()
        {
            // Cache field metadata.
            EntityMeta<Shift>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ShiftID), @"ShiftID", DbType.Byte, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(StartTime), @"StartTime", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(EndTime), @"EndTime", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Shift>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Shift>.HasLanguageTable = false;
            EntityMeta<Shift>.TableSchema = @"HumanResources";
            EntityMeta<Shift>.TableName = @"Shift";
            EntityMeta<Shift>.LanguageTableSchema = null;
            EntityMeta<Shift>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public Byte? ShiftID { get; private set; }
        public string Name { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Shift>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Shift>(queryConditions);
        }
        public static async Task<IEnumerable<Shift>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Shift>(columnName, queryOp, value);
        }
		public static async Task<Shift> GetByPrimaryKeyAsync(Byte ShiftID)
        {
            return await GetByPrimaryKeyAsync<Shift>(ShiftID);
        }
		public static async Task<Shift> TryGetByPrimaryKeyAsync(Byte ShiftID)
        {
            return await TryGetByPrimaryKeyAsync<Shift>(ShiftID);
        }
		#endregion
    }
}