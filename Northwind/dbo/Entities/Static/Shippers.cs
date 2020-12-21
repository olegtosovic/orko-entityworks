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
    /// Shippers entity.
    /// </summary>
    public partial class Shippers
    {
		#region Self
		public static string _Self { get { return "dbo.Shippers"; } }
		#endregion

        #region Columns
        public static string _ShipperID { get { return @"dbo.Shippers.ShipperID"; } }
        public static string _CompanyName { get { return @"dbo.Shippers.CompanyName"; } }
        public static string _Phone { get { return @"dbo.Shippers.Phone"; } }
        #endregion
    }
}