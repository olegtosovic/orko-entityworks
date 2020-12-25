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
    /// TransactionHistoryArchive entity.
    /// </summary>
    public sealed partial class TransactionHistoryArchive : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TransactionHistoryArchive()
        {
            // Cache field metadata.
            EntityMeta<TransactionHistoryArchive>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TransactionID), @"TransactionID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ReferenceOrderID), @"ReferenceOrderID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ReferenceOrderLineID), @"ReferenceOrderLineID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TransactionDate), @"TransactionDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(TransactionType), @"TransactionType", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(Quantity), @"Quantity", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ActualCost), @"ActualCost", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<TransactionHistoryArchive>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TransactionHistoryArchive>.HasLanguageTable = false;
            EntityMeta<TransactionHistoryArchive>.TableSchema = @"Production";
            EntityMeta<TransactionHistoryArchive>.TableName = @"TransactionHistoryArchive";
            EntityMeta<TransactionHistoryArchive>.LanguageTableSchema = null;
            EntityMeta<TransactionHistoryArchive>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? TransactionID { get; set; }
        public int? ProductID { get; set; }
        public int? ReferenceOrderID { get; set; }
        public int? ReferenceOrderLineID { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public int? Quantity { get; set; }
        public decimal? ActualCost { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<TransactionHistoryArchive>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TransactionHistoryArchive>(queryConditions);
        }
        public static async Task<IEnumerable<TransactionHistoryArchive>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TransactionHistoryArchive>(columnName, queryOp, value);
        }
		public static async Task<TransactionHistoryArchive> GetByPrimaryKeyAsync(int TransactionID)
        {
            return await GetByPrimaryKeyAsync<TransactionHistoryArchive>(TransactionID);
        }
		public static async Task<TransactionHistoryArchive> TryGetByPrimaryKeyAsync(int TransactionID)
        {
            return await TryGetByPrimaryKeyAsync<TransactionHistoryArchive>(TransactionID);
        }
		#endregion
    }
}