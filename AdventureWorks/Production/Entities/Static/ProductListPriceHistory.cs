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
    /// ProductListPriceHistory entity.
    /// </summary>
    public partial class ProductListPriceHistory
    {
		#region Self
		public static string _Self { get { return "Production.ProductListPriceHistory"; } }
		#endregion

        #region Columns
        public static string _ProductID { get { return @"Production.ProductListPriceHistory.ProductID"; } }
        public static string _StartDate { get { return @"Production.ProductListPriceHistory.StartDate"; } }
        public static string _EndDate { get { return @"Production.ProductListPriceHistory.EndDate"; } }
        public static string _ListPrice { get { return @"Production.ProductListPriceHistory.ListPrice"; } }
        public static string _ModifiedDate { get { return @"Production.ProductListPriceHistory.ModifiedDate"; } }
        #endregion
    }
}