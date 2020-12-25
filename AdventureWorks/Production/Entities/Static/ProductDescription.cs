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

namespace AdventureWorks.Production
{
    /// <summary>
    /// ProductDescription entity.
    /// </summary>
    public partial class ProductDescription
    {
		#region Self
		public static string _Self { get { return "Production.ProductDescription"; } }
		#endregion

        #region Columns
        public static string _ProductDescriptionID { get { return @"Production.ProductDescription.ProductDescriptionID"; } }
        public static string _Description { get { return @"Production.ProductDescription.Description"; } }
        public static string _rowguid { get { return @"Production.ProductDescription.rowguid"; } }
        public static string _ModifiedDate { get { return @"Production.ProductDescription.ModifiedDate"; } }
        #endregion
    }
}