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

namespace AdventureWorks.Person
{
    /// <summary>
    /// Password entity.
    /// </summary>
    public partial class Password
    {
		#region Self
		public static string _Self { get { return "Person.Password"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"Person.Password.BusinessEntityID"; } }
        public static string _PasswordHash { get { return @"Person.Password.PasswordHash"; } }
        public static string _PasswordSalt { get { return @"Person.Password.PasswordSalt"; } }
        public static string _rowguid { get { return @"Person.Password.rowguid"; } }
        public static string _ModifiedDate { get { return @"Person.Password.ModifiedDate"; } }
        #endregion
    }
}