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
    /// EmployeePayHistory entity.
    /// </summary>
    public partial class EmployeePayHistory
    {
		#region Self
		public static string _Self { get { return "HumanResources.EmployeePayHistory"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"HumanResources.EmployeePayHistory.BusinessEntityID"; } }
        public static string _RateChangeDate { get { return @"HumanResources.EmployeePayHistory.RateChangeDate"; } }
        public static string _Rate { get { return @"HumanResources.EmployeePayHistory.Rate"; } }
        public static string _PayFrequency { get { return @"HumanResources.EmployeePayHistory.PayFrequency"; } }
        public static string _ModifiedDate { get { return @"HumanResources.EmployeePayHistory.ModifiedDate"; } }
        #endregion
    }
}