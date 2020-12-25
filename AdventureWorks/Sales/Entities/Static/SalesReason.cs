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
    /// SalesReason entity.
    /// </summary>
    public partial class SalesReason
    {
		#region Self
		public static string _Self { get { return "Sales.SalesReason"; } }
		#endregion

        #region Columns
        public static string _SalesReasonID { get { return @"Sales.SalesReason.SalesReasonID"; } }
        public static string _Name { get { return @"Sales.SalesReason.Name"; } }
        public static string _ReasonType { get { return @"Sales.SalesReason.ReasonType"; } }
        public static string _ModifiedDate { get { return @"Sales.SalesReason.ModifiedDate"; } }
        #endregion
    }
}