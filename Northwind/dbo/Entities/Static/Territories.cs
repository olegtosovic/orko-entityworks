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
    /// Territories entity.
    /// </summary>
    public partial class Territories
    {
		#region Self
		public static string _Self { get { return "dbo.Territories"; } }
		#endregion

        #region Columns
        public static string _TerritoryID { get { return @"dbo.Territories.TerritoryID"; } }
        public static string _TerritoryDescription { get { return @"dbo.Territories.TerritoryDescription"; } }
        public static string _RegionID { get { return @"dbo.Territories.RegionID"; } }
        #endregion
    }
}