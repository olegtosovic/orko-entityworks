// Generated on 12/21/2020 1:03 PM using EntityWorks code generation tool.
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
    /// OrderDetails entity.
    /// </summary>
    public partial class OrderDetails
    {
		#region Self
		public static string _Self { get { return "dbo.OrderDetails"; } }
		#endregion

        #region Columns
        public static string _OrderID { get { return @"dbo.Order Details.OrderID"; } }
        public static string _ProductID { get { return @"dbo.Order Details.ProductID"; } }
        public static string _UnitPrice { get { return @"dbo.Order Details.UnitPrice"; } }
        public static string _Quantity { get { return @"dbo.Order Details.Quantity"; } }
        public static string _Discount { get { return @"dbo.Order Details.Discount"; } }
        #endregion
    }
}