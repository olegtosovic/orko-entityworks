// Generated on 12/21/2020 1:03 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Northwind.Dbo
{
    /// <summary>
    /// Customers entity.
    /// </summary>
    public partial class Customers
    {
		#region Self
		public static string _Self { get { return "dbo.Customers"; } }
		#endregion

        #region Columns
        public static string _CustomerID { get { return @"dbo.Customers.CustomerID"; } }
        public static string _CompanyName { get { return @"dbo.Customers.CompanyName"; } }
        public static string _ContactName { get { return @"dbo.Customers.ContactName"; } }
        public static string _ContactTitle { get { return @"dbo.Customers.ContactTitle"; } }
        public static string _Address { get { return @"dbo.Customers.Address"; } }
        public static string _City { get { return @"dbo.Customers.City"; } }
        public static string _Region { get { return @"dbo.Customers.Region"; } }
        public static string _PostalCode { get { return @"dbo.Customers.PostalCode"; } }
        public static string _Country { get { return @"dbo.Customers.Country"; } }
        public static string _Phone { get { return @"dbo.Customers.Phone"; } }
        public static string _Fax { get { return @"dbo.Customers.Fax"; } }
        #endregion
    }
}