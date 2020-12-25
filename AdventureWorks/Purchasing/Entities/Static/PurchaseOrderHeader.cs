// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
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
    /// PurchaseOrderHeader entity.
    /// </summary>
    public partial class PurchaseOrderHeader
    {
		#region Self
		public static string _Self { get { return "Purchasing.PurchaseOrderHeader"; } }
		#endregion

        #region Columns
        public static string _PurchaseOrderID { get { return @"Purchasing.PurchaseOrderHeader.PurchaseOrderID"; } }
        public static string _RevisionNumber { get { return @"Purchasing.PurchaseOrderHeader.RevisionNumber"; } }
        public static string _Status { get { return @"Purchasing.PurchaseOrderHeader.Status"; } }
        public static string _EmployeeID { get { return @"Purchasing.PurchaseOrderHeader.EmployeeID"; } }
        public static string _VendorID { get { return @"Purchasing.PurchaseOrderHeader.VendorID"; } }
        public static string _ShipMethodID { get { return @"Purchasing.PurchaseOrderHeader.ShipMethodID"; } }
        public static string _OrderDate { get { return @"Purchasing.PurchaseOrderHeader.OrderDate"; } }
        public static string _ShipDate { get { return @"Purchasing.PurchaseOrderHeader.ShipDate"; } }
        public static string _SubTotal { get { return @"Purchasing.PurchaseOrderHeader.SubTotal"; } }
        public static string _TaxAmt { get { return @"Purchasing.PurchaseOrderHeader.TaxAmt"; } }
        public static string _Freight { get { return @"Purchasing.PurchaseOrderHeader.Freight"; } }
        public static string _TotalDue { get { return @"Purchasing.PurchaseOrderHeader.TotalDue"; } }
        public static string _ModifiedDate { get { return @"Purchasing.PurchaseOrderHeader.ModifiedDate"; } }
        #endregion
    }
}