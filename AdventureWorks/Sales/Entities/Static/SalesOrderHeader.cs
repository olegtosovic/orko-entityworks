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
    /// SalesOrderHeader entity.
    /// </summary>
    public partial class SalesOrderHeader
    {
		#region Self
		public static string _Self { get { return "Sales.SalesOrderHeader"; } }
		#endregion

        #region Columns
        public static string _SalesOrderID { get { return @"Sales.SalesOrderHeader.SalesOrderID"; } }
        public static string _RevisionNumber { get { return @"Sales.SalesOrderHeader.RevisionNumber"; } }
        public static string _OrderDate { get { return @"Sales.SalesOrderHeader.OrderDate"; } }
        public static string _DueDate { get { return @"Sales.SalesOrderHeader.DueDate"; } }
        public static string _ShipDate { get { return @"Sales.SalesOrderHeader.ShipDate"; } }
        public static string _Status { get { return @"Sales.SalesOrderHeader.Status"; } }
        public static string _OnlineOrderFlag { get { return @"Sales.SalesOrderHeader.OnlineOrderFlag"; } }
        public static string _SalesOrderNumber { get { return @"Sales.SalesOrderHeader.SalesOrderNumber"; } }
        public static string _PurchaseOrderNumber { get { return @"Sales.SalesOrderHeader.PurchaseOrderNumber"; } }
        public static string _AccountNumber { get { return @"Sales.SalesOrderHeader.AccountNumber"; } }
        public static string _CustomerID { get { return @"Sales.SalesOrderHeader.CustomerID"; } }
        public static string _SalesPersonID { get { return @"Sales.SalesOrderHeader.SalesPersonID"; } }
        public static string _TerritoryID { get { return @"Sales.SalesOrderHeader.TerritoryID"; } }
        public static string _BillToAddressID { get { return @"Sales.SalesOrderHeader.BillToAddressID"; } }
        public static string _ShipToAddressID { get { return @"Sales.SalesOrderHeader.ShipToAddressID"; } }
        public static string _ShipMethodID { get { return @"Sales.SalesOrderHeader.ShipMethodID"; } }
        public static string _CreditCardID { get { return @"Sales.SalesOrderHeader.CreditCardID"; } }
        public static string _CreditCardApprovalCode { get { return @"Sales.SalesOrderHeader.CreditCardApprovalCode"; } }
        public static string _CurrencyRateID { get { return @"Sales.SalesOrderHeader.CurrencyRateID"; } }
        public static string _SubTotal { get { return @"Sales.SalesOrderHeader.SubTotal"; } }
        public static string _TaxAmt { get { return @"Sales.SalesOrderHeader.TaxAmt"; } }
        public static string _Freight { get { return @"Sales.SalesOrderHeader.Freight"; } }
        public static string _TotalDue { get { return @"Sales.SalesOrderHeader.TotalDue"; } }
        public static string _Comment { get { return @"Sales.SalesOrderHeader.Comment"; } }
        public static string _rowguid { get { return @"Sales.SalesOrderHeader.rowguid"; } }
        public static string _ModifiedDate { get { return @"Sales.SalesOrderHeader.ModifiedDate"; } }
        #endregion
    }
}