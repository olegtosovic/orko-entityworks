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
    /// WorkOrder entity.
    /// </summary>
    public sealed partial class WorkOrder : Entity
    {
		#region Members
		private Product m_e_ProductID;
        private ScrapReason m_e_ScrapReasonID;
        #endregion
        
		#region Constructors
        static WorkOrder()
        {
            // Cache field metadata.
            EntityMeta<WorkOrder>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(WorkOrderID), @"WorkOrderID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(OrderQty), @"OrderQty", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(StockedQty), @"StockedQty", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ScrappedQty), @"ScrappedQty", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(StartDate), @"StartDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(EndDate), @"EndDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(DueDate), @"DueDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(ScrapReasonID), @"ScrapReasonID", DbType.Int16, isRequired: false),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<WorkOrder>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID)),
                new RelationMetadata(nameof(e_ScrapReasonID), nameof(ScrapReasonID), nameof(AdventureWorks.Production.ScrapReason.ScrapReasonID))
			);

			// Cache table metadata.
			EntityMeta<WorkOrder>.HasLanguageTable = false;
            EntityMeta<WorkOrder>.TableSchema = @"Production";
            EntityMeta<WorkOrder>.TableName = @"WorkOrder";
            EntityMeta<WorkOrder>.LanguageTableSchema = null;
            EntityMeta<WorkOrder>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? WorkOrderID { get; private set; }
        public int? ProductID { get; set; }
        public int? OrderQty { get; set; }
        public int? StockedQty { get; set; }
        public short? ScrappedQty { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DueDate { get; set; }
        public short? ScrapReasonID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Product e_ProductID
        {
            get { return EntityContext<Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        public ScrapReason e_ScrapReasonID
        {
            get { return EntityContext<ScrapReason>.Get(ref m_e_ScrapReasonID, this, nameof(e_ScrapReasonID)); }
            set { EntityContext<ScrapReason>.Set(ref m_e_ScrapReasonID, this, value, nameof(e_ScrapReasonID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<WorkOrder>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<WorkOrder>(queryConditions);
        }
        public static async Task<IEnumerable<WorkOrder>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<WorkOrder>(columnName, queryOp, value);
        }
		public static async Task<WorkOrder> GetByPrimaryKeyAsync(int WorkOrderID)
        {
            return await GetByPrimaryKeyAsync<WorkOrder>(WorkOrderID);
        }
		public static async Task<WorkOrder> TryGetByPrimaryKeyAsync(int WorkOrderID)
        {
            return await TryGetByPrimaryKeyAsync<WorkOrder>(WorkOrderID);
        }
		#endregion
    }
}