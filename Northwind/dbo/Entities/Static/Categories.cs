// Generated on 12/21/2020 1:03 PM using EntityWorks code generation tool.
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
    /// Categories entity.
    /// </summary>
    public partial class Categories
    {
		#region Self
		public static string _Self { get { return "dbo.Categories"; } }
		#endregion

        #region Columns
        public static string _CategoryID { get { return @"dbo.Categories.CategoryID"; } }
        public static string _CategoryName { get { return @"dbo.Categories.CategoryName"; } }
        public static string _Description { get { return @"dbo.Categories.Description"; } }
        public static string _Picture { get { return @"dbo.Categories.Picture"; } }
        #endregion
    }
}