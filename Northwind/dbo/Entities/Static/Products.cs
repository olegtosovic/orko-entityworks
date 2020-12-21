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
    /// Products entity.
    /// </summary>
    public partial class Products
    {
		#region Self
		public static string _Self { get { return "dbo.Products"; } }
		#endregion

        #region Columns
        public static string _ProductID { get { return @"dbo.Products.ProductID"; } }
        public static string _ProductName { get { return @"dbo.Products.ProductName"; } }
        public static string _SupplierID { get { return @"dbo.Products.SupplierID"; } }
        public static string _CategoryID { get { return @"dbo.Products.CategoryID"; } }
        public static string _QuantityPerUnit { get { return @"dbo.Products.QuantityPerUnit"; } }
        public static string _UnitPrice { get { return @"dbo.Products.UnitPrice"; } }
        public static string _UnitsInStock { get { return @"dbo.Products.UnitsInStock"; } }
        public static string _UnitsOnOrder { get { return @"dbo.Products.UnitsOnOrder"; } }
        public static string _ReorderLevel { get { return @"dbo.Products.ReorderLevel"; } }
        public static string _Discontinued { get { return @"dbo.Products.Discontinued"; } }
        #endregion
    }
}