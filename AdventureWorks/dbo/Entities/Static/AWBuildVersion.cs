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

namespace AdventureWorks.Dbo
{
    /// <summary>
    /// AWBuildVersion entity.
    /// </summary>
    public partial class AWBuildVersion
    {
		#region Self
		public static string _Self { get { return "dbo.AWBuildVersion"; } }
		#endregion

        #region Columns
        public static string _SystemInformationID { get { return @"dbo.AWBuildVersion.SystemInformationID"; } }
        public static string _DatabaseVersion { get { return @"dbo.AWBuildVersion.Database Version"; } }
        public static string _VersionDate { get { return @"dbo.AWBuildVersion.VersionDate"; } }
        public static string _ModifiedDate { get { return @"dbo.AWBuildVersion.ModifiedDate"; } }
        #endregion
    }
}