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
    /// WorkOrderRouting entity.
    /// </summary>
    public sealed partial class WorkOrderRouting : Entity
    {
		#region Members
		private Location m_e_LocationID;
        private WorkOrder m_e_WorkOrderID;
        #endregion
        
		#region Constructors
        static WorkOrderRouting()
        {
            // Cache field metadata.
            EntityMeta<WorkOrderRouting>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(WorkOrderID), @"WorkOrderID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(OperationSequence), @"OperationSequence", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(LocationID), @"LocationID", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(ScheduledStartDate), @"ScheduledStartDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(ScheduledEndDate), @"ScheduledEndDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(ActualStartDate), @"ActualStartDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(ActualEndDate), @"ActualEndDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(ActualResourceHrs), @"ActualResourceHrs", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(PlannedCost), @"PlannedCost", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ActualCost), @"ActualCost", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<WorkOrderRouting>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_LocationID), nameof(LocationID), nameof(AdventureWorks.Production.Location.LocationID)),
                new RelationMetadata(nameof(e_WorkOrderID), nameof(WorkOrderID), nameof(AdventureWorks.Production.WorkOrder.WorkOrderID))
			);

			// Cache table metadata.
			EntityMeta<WorkOrderRouting>.HasLanguageTable = false;
            EntityMeta<WorkOrderRouting>.TableSchema = @"Production";
            EntityMeta<WorkOrderRouting>.TableName = @"WorkOrderRouting";
            EntityMeta<WorkOrderRouting>.LanguageTableSchema = null;
            EntityMeta<WorkOrderRouting>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? WorkOrderID { get; set; }
        public int? ProductID { get; set; }
        public short? OperationSequence { get; set; }
        public short? LocationID { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public decimal? ActualResourceHrs { get; set; }
        public decimal? PlannedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Location e_LocationID
        {
            get { return EntityContext<Location>.Get(ref m_e_LocationID, this, nameof(e_LocationID)); }
            set { EntityContext<Location>.Set(ref m_e_LocationID, this, value, nameof(e_LocationID)); }
        }
        public WorkOrder e_WorkOrderID
        {
            get { return EntityContext<WorkOrder>.Get(ref m_e_WorkOrderID, this, nameof(e_WorkOrderID)); }
            set { EntityContext<WorkOrder>.Set(ref m_e_WorkOrderID, this, value, nameof(e_WorkOrderID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<WorkOrderRouting>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<WorkOrderRouting>(queryConditions);
        }
        public static async Task<IEnumerable<WorkOrderRouting>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<WorkOrderRouting>(columnName, queryOp, value);
        }
		public static async Task<WorkOrderRouting> GetByPrimaryKeyAsync(int WorkOrderID, int ProductID, short OperationSequence)
        {
            return await GetByPrimaryKeyAsync<WorkOrderRouting>(WorkOrderID, ProductID, OperationSequence);
        }
		public static async Task<WorkOrderRouting> TryGetByPrimaryKeyAsync(int WorkOrderID, int ProductID, short OperationSequence)
        {
            return await TryGetByPrimaryKeyAsync<WorkOrderRouting>(WorkOrderID, ProductID, OperationSequence);
        }
		#endregion
    }
}