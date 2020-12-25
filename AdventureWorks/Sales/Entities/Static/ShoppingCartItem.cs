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
    /// ShoppingCartItem entity.
    /// </summary>
    public partial class ShoppingCartItem
    {
		#region Self
		public static string _Self { get { return "Sales.ShoppingCartItem"; } }
		#endregion

        #region Columns
        public static string _ShoppingCartItemID { get { return @"Sales.ShoppingCartItem.ShoppingCartItemID"; } }
        public static string _ShoppingCartID { get { return @"Sales.ShoppingCartItem.ShoppingCartID"; } }
        public static string _Quantity { get { return @"Sales.ShoppingCartItem.Quantity"; } }
        public static string _ProductID { get { return @"Sales.ShoppingCartItem.ProductID"; } }
        public static string _DateCreated { get { return @"Sales.ShoppingCartItem.DateCreated"; } }
        public static string _ModifiedDate { get { return @"Sales.ShoppingCartItem.ModifiedDate"; } }
        #endregion
    }
}