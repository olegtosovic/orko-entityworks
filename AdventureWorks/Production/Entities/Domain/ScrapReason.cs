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
    /// ScrapReason entity.
    /// </summary>
    public sealed partial class ScrapReason : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static ScrapReason()
        {
            // Cache field metadata.
            EntityMeta<ScrapReason>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ScrapReasonID), @"ScrapReasonID", DbType.Int16, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ScrapReason>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<ScrapReason>.HasLanguageTable = false;
            EntityMeta<ScrapReason>.TableSchema = @"Production";
            EntityMeta<ScrapReason>.TableName = @"ScrapReason";
            EntityMeta<ScrapReason>.LanguageTableSchema = null;
            EntityMeta<ScrapReason>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public short? ScrapReasonID { get; private set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<ScrapReason>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ScrapReason>(queryConditions);
        }
        public static async Task<IEnumerable<ScrapReason>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ScrapReason>(columnName, queryOp, value);
        }
		public static async Task<ScrapReason> GetByPrimaryKeyAsync(short ScrapReasonID)
        {
            return await GetByPrimaryKeyAsync<ScrapReason>(ScrapReasonID);
        }
		public static async Task<ScrapReason> TryGetByPrimaryKeyAsync(short ScrapReasonID)
        {
            return await TryGetByPrimaryKeyAsync<ScrapReason>(ScrapReasonID);
        }
		#endregion
    }
}