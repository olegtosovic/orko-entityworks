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
    /// Address entity.
    /// </summary>
    public partial class Address
    {
		#region Self
		public static string _Self { get { return "Person.Address"; } }
		#endregion

        #region Columns
        public static string _AddressID { get { return @"Person.Address.AddressID"; } }
        public static string _AddressLine1 { get { return @"Person.Address.AddressLine1"; } }
        public static string _AddressLine2 { get { return @"Person.Address.AddressLine2"; } }
        public static string _City { get { return @"Person.Address.City"; } }
        public static string _StateProvinceID { get { return @"Person.Address.StateProvinceID"; } }
        public static string _PostalCode { get { return @"Person.Address.PostalCode"; } }
        public static string _SpatialLocation { get { return @"Person.Address.SpatialLocation"; } }
        public static string _rowguid { get { return @"Person.Address.rowguid"; } }
        public static string _ModifiedDate { get { return @"Person.Address.ModifiedDate"; } }
        #endregion
    }
}