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
    /// WorkOrder entity.
    /// </summary>
    public partial class WorkOrder
    {
		#region Self
		public static string _Self { get { return "Production.WorkOrder"; } }
		#endregion

        #region Columns
        public static string _WorkOrderID { get { return @"Production.WorkOrder.WorkOrderID"; } }
        public static string _ProductID { get { return @"Production.WorkOrder.ProductID"; } }
        public static string _OrderQty { get { return @"Production.WorkOrder.OrderQty"; } }
        public static string _StockedQty { get { return @"Production.WorkOrder.StockedQty"; } }
        public static string _ScrappedQty { get { return @"Production.WorkOrder.ScrappedQty"; } }
        public static string _StartDate { get { return @"Production.WorkOrder.StartDate"; } }
        public static string _EndDate { get { return @"Production.WorkOrder.EndDate"; } }
        public static string _DueDate { get { return @"Production.WorkOrder.DueDate"; } }
        public static string _ScrapReasonID { get { return @"Production.WorkOrder.ScrapReasonID"; } }
        public static string _ModifiedDate { get { return @"Production.WorkOrder.ModifiedDate"; } }
        #endregion
    }
}