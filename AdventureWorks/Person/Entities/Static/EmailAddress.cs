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

namespace AdventureWorks.Person
{
    /// <summary>
    /// EmailAddress entity.
    /// </summary>
    public partial class EmailAddress
    {
		#region Self
		public static string _Self { get { return "Person.EmailAddress"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"Person.EmailAddress.BusinessEntityID"; } }
        public static string _EmailAddressID { get { return @"Person.EmailAddress.EmailAddressID"; } }
        public static string _c_EmailAddress { get { return @"Person.EmailAddress.EmailAddress"; } }
        public static string _rowguid { get { return @"Person.EmailAddress.rowguid"; } }
        public static string _ModifiedDate { get { return @"Person.EmailAddress.ModifiedDate"; } }
        #endregion
    }
}