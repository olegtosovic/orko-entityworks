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

namespace AdventureWorks.Production
{
    /// <summary>
    /// TransactionHistory entity.
    /// </summary>
    public sealed partial class TransactionHistory : Entity
    {
		#region Members
		private Product m_e_ProductID;
        #endregion
        
		#region Constructors
        static TransactionHistory()
        {
            // Cache field metadata.
            EntityMeta<TransactionHistory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TransactionID), @"TransactionID", DbType.Int32, isIdentity: true, isRequired: true),
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
            EntityMeta<TransactionHistory>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID))
			);

			// Cache table metadata.
			EntityMeta<TransactionHistory>.HasLanguageTable = false;
            EntityMeta<TransactionHistory>.TableSchema = @"Production";
            EntityMeta<TransactionHistory>.TableName = @"TransactionHistory";
            EntityMeta<TransactionHistory>.LanguageTableSchema = null;
            EntityMeta<TransactionHistory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? TransactionID { get; private set; }
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
		public Product e_ProductID
        {
            get { return EntityContext<Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TransactionHistory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TransactionHistory>(queryConditions);
        }
        public static async Task<IEnumerable<TransactionHistory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TransactionHistory>(columnName, queryOp, value);
        }
		public static async Task<TransactionHistory> GetByPrimaryKeyAsync(int TransactionID)
        {
            return await GetByPrimaryKeyAsync<TransactionHistory>(TransactionID);
        }
		public static async Task<TransactionHistory> TryGetByPrimaryKeyAsync(int TransactionID)
        {
            return await TryGetByPrimaryKeyAsync<TransactionHistory>(TransactionID);
        }
		#endregion
    }
}