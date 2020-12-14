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
    /// SalesPersonQuotaHistory entity.
    /// </summary>
    public partial class SalesPersonQuotaHistory
    {
		#region Self
		public static string _Self { get { return "Sales.SalesPersonQuotaHistory"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"Sales.SalesPersonQuotaHistory.BusinessEntityID"; } }
        public static string _QuotaDate { get { return @"Sales.SalesPersonQuotaHistory.QuotaDate"; } }
        public static string _SalesQuota { get { return @"Sales.SalesPersonQuotaHistory.SalesQuota"; } }
        public static string _rowguid { get { return @"Sales.SalesPersonQuotaHistory.rowguid"; } }
        public static string _ModifiedDate { get { return @"Sales.SalesPersonQuotaHistory.ModifiedDate"; } }
        #endregion
    }
}