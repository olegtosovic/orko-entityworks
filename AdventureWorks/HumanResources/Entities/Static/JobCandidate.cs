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

namespace AdventureWorks.HumanResources
{
    /// <summary>
    /// JobCandidate entity.
    /// </summary>
    public partial class JobCandidate
    {
		#region Self
		public static string _Self { get { return "HumanResources.JobCandidate"; } }
		#endregion

        #region Columns
        public static string _JobCandidateID { get { return @"HumanResources.JobCandidate.JobCandidateID"; } }
        public static string _BusinessEntityID { get { return @"HumanResources.JobCandidate.BusinessEntityID"; } }
        public static string _Resume { get { return @"HumanResources.JobCandidate.Resume"; } }
        public static string _ModifiedDate { get { return @"HumanResources.JobCandidate.ModifiedDate"; } }
        #endregion
    }
}