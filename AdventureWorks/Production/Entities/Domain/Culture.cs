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
    /// Culture entity.
    /// </summary>
    public sealed partial class Culture : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Culture()
        {
            // Cache field metadata.
            EntityMeta<Culture>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CultureID), @"CultureID", DbType.StringFixedLength, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Culture>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Culture>.HasLanguageTable = false;
            EntityMeta<Culture>.TableSchema = @"Production";
            EntityMeta<Culture>.TableName = @"Culture";
            EntityMeta<Culture>.LanguageTableSchema = null;
            EntityMeta<Culture>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string CultureID { get; set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Culture>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Culture>(queryConditions);
        }
        public static async Task<IEnumerable<Culture>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Culture>(columnName, queryOp, value);
        }
		public static async Task<Culture> GetByPrimaryKeyAsync(string CultureID)
        {
            return await GetByPrimaryKeyAsync<Culture>(CultureID);
        }
		public static async Task<Culture> TryGetByPrimaryKeyAsync(string CultureID)
        {
            return await TryGetByPrimaryKeyAsync<Culture>(CultureID);
        }
		#endregion
    }
}