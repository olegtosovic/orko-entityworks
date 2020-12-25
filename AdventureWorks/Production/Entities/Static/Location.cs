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

namespace AdventureWorks.Production
{
    /// <summary>
    /// Location entity.
    /// </summary>
    public partial class Location
    {
		#region Self
		public static string _Self { get { return "Production.Location"; } }
		#endregion

        #region Columns
        public static string _LocationID { get { return @"Production.Location.LocationID"; } }
        public static string _Name { get { return @"Production.Location.Name"; } }
        public static string _CostRate { get { return @"Production.Location.CostRate"; } }
        public static string _Availability { get { return @"Production.Location.Availability"; } }
        public static string _ModifiedDate { get { return @"Production.Location.ModifiedDate"; } }
        #endregion
    }
}