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

namespace AdventureWorks.Production
{
    /// <summary>
    /// ProductInventory entity.
    /// </summary>
    public partial class ProductInventory
    {
		#region Self
		public static string _Self { get { return "Production.ProductInventory"; } }
		#endregion

        #region Columns
        public static string _ProductID { get { return @"Production.ProductInventory.ProductID"; } }
        public static string _LocationID { get { return @"Production.ProductInventory.LocationID"; } }
        public static string _Shelf { get { return @"Production.ProductInventory.Shelf"; } }
        public static string _Bin { get { return @"Production.ProductInventory.Bin"; } }
        public static string _Quantity { get { return @"Production.ProductInventory.Quantity"; } }
        public static string _rowguid { get { return @"Production.ProductInventory.rowguid"; } }
        public static string _ModifiedDate { get { return @"Production.ProductInventory.ModifiedDate"; } }
        #endregion
    }
}