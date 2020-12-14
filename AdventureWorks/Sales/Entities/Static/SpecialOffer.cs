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

namespace AdventureWorks.Sales
{
    /// <summary>
    /// SpecialOffer entity.
    /// </summary>
    public partial class SpecialOffer
    {
		#region Self
		public static string _Self { get { return "Sales.SpecialOffer"; } }
		#endregion

        #region Columns
        public static string _SpecialOfferID { get { return @"Sales.SpecialOffer.SpecialOfferID"; } }
        public static string _Description { get { return @"Sales.SpecialOffer.Description"; } }
        public static string _DiscountPct { get { return @"Sales.SpecialOffer.DiscountPct"; } }
        public static string _Type { get { return @"Sales.SpecialOffer.Type"; } }
        public static string _Category { get { return @"Sales.SpecialOffer.Category"; } }
        public static string _StartDate { get { return @"Sales.SpecialOffer.StartDate"; } }
        public static string _EndDate { get { return @"Sales.SpecialOffer.EndDate"; } }
        public static string _MinQty { get { return @"Sales.SpecialOffer.MinQty"; } }
        public static string _MaxQty { get { return @"Sales.SpecialOffer.MaxQty"; } }
        public static string _rowguid { get { return @"Sales.SpecialOffer.rowguid"; } }
        public static string _ModifiedDate { get { return @"Sales.SpecialOffer.ModifiedDate"; } }
        #endregion
    }
}