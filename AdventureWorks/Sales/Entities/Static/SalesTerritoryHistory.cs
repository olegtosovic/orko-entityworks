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

namespace AdventureWorks.Sales
{
    /// <summary>
    /// SalesTerritoryHistory entity.
    /// </summary>
    public partial class SalesTerritoryHistory
    {
		#region Self
		public static string _Self { get { return "Sales.SalesTerritoryHistory"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"Sales.SalesTerritoryHistory.BusinessEntityID"; } }
        public static string _TerritoryID { get { return @"Sales.SalesTerritoryHistory.TerritoryID"; } }
        public static string _StartDate { get { return @"Sales.SalesTerritoryHistory.StartDate"; } }
        public static string _EndDate { get { return @"Sales.SalesTerritoryHistory.EndDate"; } }
        public static string _rowguid { get { return @"Sales.SalesTerritoryHistory.rowguid"; } }
        public static string _ModifiedDate { get { return @"Sales.SalesTerritoryHistory.ModifiedDate"; } }
        #endregion
    }
}