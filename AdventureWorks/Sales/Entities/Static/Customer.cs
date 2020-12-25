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
    /// Customer entity.
    /// </summary>
    public partial class Customer
    {
		#region Self
		public static string _Self { get { return "Sales.Customer"; } }
		#endregion

        #region Columns
        public static string _CustomerID { get { return @"Sales.Customer.CustomerID"; } }
        public static string _PersonID { get { return @"Sales.Customer.PersonID"; } }
        public static string _StoreID { get { return @"Sales.Customer.StoreID"; } }
        public static string _TerritoryID { get { return @"Sales.Customer.TerritoryID"; } }
        public static string _AccountNumber { get { return @"Sales.Customer.AccountNumber"; } }
        public static string _rowguid { get { return @"Sales.Customer.rowguid"; } }
        public static string _ModifiedDate { get { return @"Sales.Customer.ModifiedDate"; } }
        #endregion
    }
}