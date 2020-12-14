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
    /// ErrorLog entity.
    /// </summary>
    public partial class ErrorLog
    {
		#region Self
		public static string _Self { get { return "dbo.ErrorLog"; } }
		#endregion

        #region Columns
        public static string _ErrorLogID { get { return @"dbo.ErrorLog.ErrorLogID"; } }
        public static string _ErrorTime { get { return @"dbo.ErrorLog.ErrorTime"; } }
        public static string _UserName { get { return @"dbo.ErrorLog.UserName"; } }
        public static string _ErrorNumber { get { return @"dbo.ErrorLog.ErrorNumber"; } }
        public static string _ErrorSeverity { get { return @"dbo.ErrorLog.ErrorSeverity"; } }
        public static string _ErrorState { get { return @"dbo.ErrorLog.ErrorState"; } }
        public static string _ErrorProcedure { get { return @"dbo.ErrorLog.ErrorProcedure"; } }
        public static string _ErrorLine { get { return @"dbo.ErrorLog.ErrorLine"; } }
        public static string _ErrorMessage { get { return @"dbo.ErrorLog.ErrorMessage"; } }
        #endregion
    }
}