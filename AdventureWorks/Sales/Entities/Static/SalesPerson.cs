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
    /// SalesPerson entity.
    /// </summary>
    public partial class SalesPerson
    {
		#region Self
		public static string _Self { get { return "Sales.SalesPerson"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"Sales.SalesPerson.BusinessEntityID"; } }
        public static string _TerritoryID { get { return @"Sales.SalesPerson.TerritoryID"; } }
        public static string _SalesQuota { get { return @"Sales.SalesPerson.SalesQuota"; } }
        public static string _Bonus { get { return @"Sales.SalesPerson.Bonus"; } }
        public static string _CommissionPct { get { return @"Sales.SalesPerson.CommissionPct"; } }
        public static string _SalesYTD { get { return @"Sales.SalesPerson.SalesYTD"; } }
        public static string _SalesLastYear { get { return @"Sales.SalesPerson.SalesLastYear"; } }
        public static string _rowguid { get { return @"Sales.SalesPerson.rowguid"; } }
        public static string _ModifiedDate { get { return @"Sales.SalesPerson.ModifiedDate"; } }
        #endregion
    }
}