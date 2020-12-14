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

namespace AdventureWorks.Sales
{
    /// <summary>
    /// SalesReason entity.
    /// </summary>
    public sealed partial class SalesReason : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static SalesReason()
        {
            // Cache field metadata.
            EntityMeta<SalesReason>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SalesReasonID), @"SalesReasonID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(ReasonType), @"ReasonType", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SalesReason>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<SalesReason>.HasLanguageTable = false;
            EntityMeta<SalesReason>.TableSchema = @"Sales";
            EntityMeta<SalesReason>.TableName = @"SalesReason";
            EntityMeta<SalesReason>.LanguageTableSchema = null;
            EntityMeta<SalesReason>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SalesReasonID { get; private set; }
        public string Name { get; set; }
        public string ReasonType { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SalesReason>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SalesReason>(queryConditions);
        }
        public static async Task<IEnumerable<SalesReason>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SalesReason>(columnName, queryOp, value);
        }
		public static async Task<SalesReason> GetByPrimaryKeyAsync(int SalesReasonID)
        {
            return await GetByPrimaryKeyAsync<SalesReason>(SalesReasonID);
        }
		public static async Task<SalesReason> TryGetByPrimaryKeyAsync(int SalesReasonID)
        {
            return await TryGetByPrimaryKeyAsync<SalesReason>(SalesReasonID);
        }
		#endregion
    }
}