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
    /// ProductCostHistory entity.
    /// </summary>
    public partial class ProductCostHistory
    {
		#region Self
		public static string _Self { get { return "Production.ProductCostHistory"; } }
		#endregion

        #region Columns
        public static string _ProductID { get { return @"Production.ProductCostHistory.ProductID"; } }
        public static string _StartDate { get { return @"Production.ProductCostHistory.StartDate"; } }
        public static string _EndDate { get { return @"Production.ProductCostHistory.EndDate"; } }
        public static string _StandardCost { get { return @"Production.ProductCostHistory.StandardCost"; } }
        public static string _ModifiedDate { get { return @"Production.ProductCostHistory.ModifiedDate"; } }
        #endregion
    }
}