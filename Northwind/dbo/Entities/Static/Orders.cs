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

namespace Northwind.Dbo
{
    /// <summary>
    /// Orders entity.
    /// </summary>
    public partial class Orders
    {
		#region Self
		public static string _Self { get { return "dbo.Orders"; } }
		#endregion

        #region Columns
        public static string _OrderID { get { return @"dbo.Orders.OrderID"; } }
        public static string _CustomerID { get { return @"dbo.Orders.CustomerID"; } }
        public static string _EmployeeID { get { return @"dbo.Orders.EmployeeID"; } }
        public static string _OrderDate { get { return @"dbo.Orders.OrderDate"; } }
        public static string _RequiredDate { get { return @"dbo.Orders.RequiredDate"; } }
        public static string _ShippedDate { get { return @"dbo.Orders.ShippedDate"; } }
        public static string _ShipVia { get { return @"dbo.Orders.ShipVia"; } }
        public static string _Freight { get { return @"dbo.Orders.Freight"; } }
        public static string _ShipName { get { return @"dbo.Orders.ShipName"; } }
        public static string _ShipAddress { get { return @"dbo.Orders.ShipAddress"; } }
        public static string _ShipCity { get { return @"dbo.Orders.ShipCity"; } }
        public static string _ShipRegion { get { return @"dbo.Orders.ShipRegion"; } }
        public static string _ShipPostalCode { get { return @"dbo.Orders.ShipPostalCode"; } }
        public static string _ShipCountry { get { return @"dbo.Orders.ShipCountry"; } }
        #endregion
    }
}