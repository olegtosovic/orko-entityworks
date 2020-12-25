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

namespace AdventureWorks.Production
{
    /// <summary>
    /// UnitMeasure entity.
    /// </summary>
    public sealed partial class UnitMeasure : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static UnitMeasure()
        {
            // Cache field metadata.
            EntityMeta<UnitMeasure>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(UnitMeasureCode), @"UnitMeasureCode", DbType.StringFixedLength, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<UnitMeasure>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<UnitMeasure>.HasLanguageTable = false;
            EntityMeta<UnitMeasure>.TableSchema = @"Production";
            EntityMeta<UnitMeasure>.TableName = @"UnitMeasure";
            EntityMeta<UnitMeasure>.LanguageTableSchema = null;
            EntityMeta<UnitMeasure>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string UnitMeasureCode { get; set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<UnitMeasure>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<UnitMeasure>(queryConditions);
        }
        public static async Task<IEnumerable<UnitMeasure>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<UnitMeasure>(columnName, queryOp, value);
        }
		public static async Task<UnitMeasure> GetByPrimaryKeyAsync(string UnitMeasureCode)
        {
            return await GetByPrimaryKeyAsync<UnitMeasure>(UnitMeasureCode);
        }
		public static async Task<UnitMeasure> TryGetByPrimaryKeyAsync(string UnitMeasureCode)
        {
            return await TryGetByPrimaryKeyAsync<UnitMeasure>(UnitMeasureCode);
        }
		#endregion
    }
}