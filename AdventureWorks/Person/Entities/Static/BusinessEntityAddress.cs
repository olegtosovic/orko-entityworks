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
    /// BusinessEntityAddress entity.
    /// </summary>
    public partial class BusinessEntityAddress
    {
		#region Self
		public static string _Self { get { return "Person.BusinessEntityAddress"; } }
		#endregion

        #region Columns
        public static string _BusinessEntityID { get { return @"Person.BusinessEntityAddress.BusinessEntityID"; } }
        public static string _AddressID { get { return @"Person.BusinessEntityAddress.AddressID"; } }
        public static string _AddressTypeID { get { return @"Person.BusinessEntityAddress.AddressTypeID"; } }
        public static string _rowguid { get { return @"Person.BusinessEntityAddress.rowguid"; } }
        public static string _ModifiedDate { get { return @"Person.BusinessEntityAddress.ModifiedDate"; } }
        #endregion
    }
}