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
    /// Store entity.
    /// </summary>
    public partial class Store
    {
		#region Self
		public static string _Self { get { return "Sales.Store"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"Sales.Store.BusinessEntityID"; } }
        public static string _Name { get { return @"Sales.Store.Name"; } }
        public static string _SalesPersonID { get { return @"Sales.Store.SalesPersonID"; } }
        public static string _Demographics { get { return @"Sales.Store.Demographics"; } }
        public static string _rowguid { get { return @"Sales.Store.rowguid"; } }
        public static string _ModifiedDate { get { return @"Sales.Store.ModifiedDate"; } }
        #endregion
    }
}