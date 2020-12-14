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

namespace AdventureWorks.Dbo
{
    /// <summary>
    /// DatabaseLog entity.
    /// </summary>
    public partial class DatabaseLog
    {
		#region Self
		public static string _Self { get { return "dbo.DatabaseLog"; } }
		#endregion

        #region Columns
        public static string _DatabaseLogID { get { return @"dbo.DatabaseLog.DatabaseLogID"; } }
        public static string _PostTime { get { return @"dbo.DatabaseLog.PostTime"; } }
        public static string _DatabaseUser { get { return @"dbo.DatabaseLog.DatabaseUser"; } }
        public static string _Event { get { return @"dbo.DatabaseLog.Event"; } }
        public static string _Schema { get { return @"dbo.DatabaseLog.Schema"; } }
        public static string _Object { get { return @"dbo.DatabaseLog.Object"; } }
        public static string _TSQL { get { return @"dbo.DatabaseLog.TSQL"; } }
        public static string _XmlEvent { get { return @"dbo.DatabaseLog.XmlEvent"; } }
        #endregion
    }
}