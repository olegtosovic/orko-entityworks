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

namespace AdventureWorks.Sales
{
    /// <summary>
    /// SalesOrderDetail entity.
    /// </summary>
    public partial class SalesOrderDetail
    {
		#region Self
		public static string _Self { get { return "Sales.SalesOrderDetail"; } }
		#endregion

        #region Columns
        public static string _SalesOrderID { get { return @"Sales.SalesOrderDetail.SalesOrderID"; } }
        public static string _SalesOrderDetailID { get { return @"Sales.SalesOrderDetail.SalesOrderDetailID"; } }
        public static string _CarrierTrackingNumber { get { return @"Sales.SalesOrderDetail.CarrierTrackingNumber"; } }
        public static string _OrderQty { get { return @"Sales.SalesOrderDetail.OrderQty"; } }
        public static string _ProductID { get { return @"Sales.SalesOrderDetail.ProductID"; } }
        public static string _SpecialOfferID { get { return @"Sales.SalesOrderDetail.SpecialOfferID"; } }
        public static string _UnitPrice { get { return @"Sales.SalesOrderDetail.UnitPrice"; } }
        public static string _UnitPriceDiscount { get { return @"Sales.SalesOrderDetail.UnitPriceDiscount"; } }
        public static string _LineTotal { get { return @"Sales.SalesOrderDetail.LineTotal"; } }
        public static string _rowguid { get { return @"Sales.SalesOrderDetail.rowguid"; } }
        public static string _ModifiedDate { get { return @"Sales.SalesOrderDetail.ModifiedDate"; } }
        #endregion
    }
}