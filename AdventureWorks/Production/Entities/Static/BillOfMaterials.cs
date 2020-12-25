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
    /// BillOfMaterials entity.
    /// </summary>
    public partial class BillOfMaterials
    {
		#region Self
		public static string _Self { get { return "Production.BillOfMaterials"; } }
		#endregion

        #region Columns
        public static string _BillOfMaterialsID { get { return @"Production.BillOfMaterials.BillOfMaterialsID"; } }
        public static string _ProductAssemblyID { get { return @"Production.BillOfMaterials.ProductAssemblyID"; } }
        public static string _ComponentID { get { return @"Production.BillOfMaterials.ComponentID"; } }
        public static string _StartDate { get { return @"Production.BillOfMaterials.StartDate"; } }
        public static string _EndDate { get { return @"Production.BillOfMaterials.EndDate"; } }
        public static string _UnitMeasureCode { get { return @"Production.BillOfMaterials.UnitMeasureCode"; } }
        public static string _BOMLevel { get { return @"Production.BillOfMaterials.BOMLevel"; } }
        public static string _PerAssemblyQty { get { return @"Production.BillOfMaterials.PerAssemblyQty"; } }
        public static string _ModifiedDate { get { return @"Production.BillOfMaterials.ModifiedDate"; } }
        #endregion
    }
}