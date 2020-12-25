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
    /// BusinessEntityContact entity.
    /// </summary>
    public partial class BusinessEntityContact
    {
		#region Self
		public static string _Self { get { return "Person.BusinessEntityContact"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"Person.BusinessEntityContact.BusinessEntityID"; } }
        public static string _PersonID { get { return @"Person.BusinessEntityContact.PersonID"; } }
        public static string _ContactTypeID { get { return @"Person.BusinessEntityContact.ContactTypeID"; } }
        public static string _rowguid { get { return @"Person.BusinessEntityContact.rowguid"; } }
        public static string _ModifiedDate { get { return @"Person.BusinessEntityContact.ModifiedDate"; } }
        #endregion
    }
}