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
    /// SalesOrderHeaderSalesReason entity.
    /// </summary>
    public sealed partial class SalesOrderHeaderSalesReason : Entity
    {
		#region Members
		private SalesOrderHeader m_e_SalesOrderID;
        private SalesReason m_e_SalesReasonID;
        #endregion
        
		#region Constructors
        static SalesOrderHeaderSalesReason()
        {
            // Cache field metadata.
            EntityMeta<SalesOrderHeaderSalesReason>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SalesOrderID), @"SalesOrderID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SalesReasonID), @"SalesReasonID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SalesOrderHeaderSalesReason>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_SalesOrderID), nameof(SalesOrderID), nameof(AdventureWorks.Sales.SalesOrderHeader.SalesOrderID)),
                new RelationMetadata(nameof(e_SalesReasonID), nameof(SalesReasonID), nameof(AdventureWorks.Sales.SalesReason.SalesReasonID))
			);

			// Cache table metadata.
			EntityMeta<SalesOrderHeaderSalesReason>.HasLanguageTable = false;
            EntityMeta<SalesOrderHeaderSalesReason>.TableSchema = @"Sales";
            EntityMeta<SalesOrderHeaderSalesReason>.TableName = @"SalesOrderHeaderSalesReason";
            EntityMeta<SalesOrderHeaderSalesReason>.LanguageTableSchema = null;
            EntityMeta<SalesOrderHeaderSalesReason>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SalesOrderID { get; set; }
        public int? SalesReasonID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public SalesOrderHeader e_SalesOrderID
        {
            get { return EntityContext<SalesOrderHeader>.Get(ref m_e_SalesOrderID, this, nameof(e_SalesOrderID)); }
            set { EntityContext<SalesOrderHeader>.Set(ref m_e_SalesOrderID, this, value, nameof(e_SalesOrderID)); }
        }
        public SalesReason e_SalesReasonID
        {
            get { return EntityContext<SalesReason>.Get(ref m_e_SalesReasonID, this, nameof(e_SalesReasonID)); }
            set { EntityContext<SalesReason>.Set(ref m_e_SalesReasonID, this, value, nameof(e_SalesReasonID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SalesOrderHeaderSalesReason>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SalesOrderHeaderSalesReason>(queryConditions);
        }
        public static async Task<IEnumerable<SalesOrderHeaderSalesReason>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SalesOrderHeaderSalesReason>(columnName, queryOp, value);
        }
		public static async Task<SalesOrderHeaderSalesReason> GetByPrimaryKeyAsync(int SalesOrderID, int SalesReasonID)
        {
            return await GetByPrimaryKeyAsync<SalesOrderHeaderSalesReason>(SalesOrderID, SalesReasonID);
        }
		public static async Task<SalesOrderHeaderSalesReason> TryGetByPrimaryKeyAsync(int SalesOrderID, int SalesReasonID)
        {
            return await TryGetByPrimaryKeyAsync<SalesOrderHeaderSalesReason>(SalesOrderID, SalesReasonID);
        }
		#endregion
    }
}