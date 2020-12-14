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

namespace AdventureWorks.Purchasing
{
    /// <summary>
    /// PurchaseOrderDetail entity.
    /// </summary>
    public partial class PurchaseOrderDetail
    {
		#region Self
		public static string _Self { get { return "Purchasing.PurchaseOrderDetail"; } }
		#endregion

        #region Columns
        public static string _PurchaseOrderID { get { return @"Purchasing.PurchaseOrderDetail.PurchaseOrderID"; } }
        public static string _PurchaseOrderDetailID { get { return @"Purchasing.PurchaseOrderDetail.PurchaseOrderDetailID"; } }
        public static string _DueDate { get { return @"Purchasing.PurchaseOrderDetail.DueDate"; } }
        public static string _OrderQty { get { return @"Purchasing.PurchaseOrderDetail.OrderQty"; } }
        public static string _ProductID { get { return @"Purchasing.PurchaseOrderDetail.ProductID"; } }
        public static string _UnitPrice { get { return @"Purchasing.PurchaseOrderDetail.UnitPrice"; } }
        public static string _LineTotal { get { return @"Purchasing.PurchaseOrderDetail.LineTotal"; } }
        public static string _ReceivedQty { get { return @"Purchasing.PurchaseOrderDetail.ReceivedQty"; } }
        public static string _RejectedQty { get { return @"Purchasing.PurchaseOrderDetail.RejectedQty"; } }
        public static string _StockedQty { get { return @"Purchasing.PurchaseOrderDetail.StockedQty"; } }
        public static string _ModifiedDate { get { return @"Purchasing.PurchaseOrderDetail.ModifiedDate"; } }
        #endregion
    }
}