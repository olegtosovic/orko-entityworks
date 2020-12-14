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

namespace AdventureWorks.Purchasing
{
    /// <summary>
    /// Vendor entity.
    /// </summary>
    public partial class Vendor
    {
		#region Self
		public static string _Self { get { return "Purchasing.Vendor"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"Purchasing.Vendor.BusinessEntityID"; } }
        public static string _AccountNumber { get { return @"Purchasing.Vendor.AccountNumber"; } }
        public static string _Name { get { return @"Purchasing.Vendor.Name"; } }
        public static string _CreditRating { get { return @"Purchasing.Vendor.CreditRating"; } }
        public static string _PreferredVendorStatus { get { return @"Purchasing.Vendor.PreferredVendorStatus"; } }
        public static string _ActiveFlag { get { return @"Purchasing.Vendor.ActiveFlag"; } }
        public static string _PurchasingWebServiceURL { get { return @"Purchasing.Vendor.PurchasingWebServiceURL"; } }
        public static string _ModifiedDate { get { return @"Purchasing.Vendor.ModifiedDate"; } }
        #endregion
    }
}