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

namespace Northwind.Dbo
{
    /// <summary>
    /// Employees entity.
    /// </summary>
    public partial class Employees
    {
		#region Self
		public static string _Self { get { return "dbo.Employees"; } }
		#endregion

        #region Columns
        public static string _EmployeeID { get { return @"dbo.Employees.EmployeeID"; } }
        public static string _LastName { get { return @"dbo.Employees.LastName"; } }
        public static string _FirstName { get { return @"dbo.Employees.FirstName"; } }
        public static string _Title { get { return @"dbo.Employees.Title"; } }
        public static string _TitleOfCourtesy { get { return @"dbo.Employees.TitleOfCourtesy"; } }
        public static string _BirthDate { get { return @"dbo.Employees.BirthDate"; } }
        public static string _HireDate { get { return @"dbo.Employees.HireDate"; } }
        public static string _Address { get { return @"dbo.Employees.Address"; } }
        public static string _City { get { return @"dbo.Employees.City"; } }
        public static string _Region { get { return @"dbo.Employees.Region"; } }
        public static string _PostalCode { get { return @"dbo.Employees.PostalCode"; } }
        public static string _Country { get { return @"dbo.Employees.Country"; } }
        public static string _HomePhone { get { return @"dbo.Employees.HomePhone"; } }
        public static string _Extension { get { return @"dbo.Employees.Extension"; } }
        public static string _Photo { get { return @"dbo.Employees.Photo"; } }
        public static string _Notes { get { return @"dbo.Employees.Notes"; } }
        public static string _ReportsTo { get { return @"dbo.Employees.ReportsTo"; } }
        public static string _PhotoPath { get { return @"dbo.Employees.PhotoPath"; } }
        #endregion
    }
}