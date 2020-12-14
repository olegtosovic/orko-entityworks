// Generated on 12/14/2020 9:21 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    /// <summary>
    /// WorkOrderRouting entity.
    /// </summary>
    public partial class WorkOrderRouting
    {
		#region Self
		public static string _Self { get { return "Production.WorkOrderRouting"; } }
		#endregion

        #region Columns
        public static string _WorkOrderID { get { return @"Production.WorkOrderRouting.WorkOrderID"; } }
        public static string _ProductID { get { return @"Production.WorkOrderRouting.ProductID"; } }
        public static string _OperationSequence { get { return @"Production.WorkOrderRouting.OperationSequence"; } }
        public static string _LocationID { get { return @"Production.WorkOrderRouting.LocationID"; } }
        public static string _ScheduledStartDate { get { return @"Production.WorkOrderRouting.ScheduledStartDate"; } }
        public static string _ScheduledEndDate { get { return @"Production.WorkOrderRouting.ScheduledEndDate"; } }
        public static string _ActualStartDate { get { return @"Production.WorkOrderRouting.ActualStartDate"; } }
        public static string _ActualEndDate { get { return @"Production.WorkOrderRouting.ActualEndDate"; } }
        public static string _ActualResourceHrs { get { return @"Production.WorkOrderRouting.ActualResourceHrs"; } }
        public static string _PlannedCost { get { return @"Production.WorkOrderRouting.PlannedCost"; } }
        public static string _ActualCost { get { return @"Production.WorkOrderRouting.ActualCost"; } }
        public static string _ModifiedDate { get { return @"Production.WorkOrderRouting.ModifiedDate"; } }
        #endregion
    }
}