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

namespace AdventureWorks.Sales
{
    /// <summary>
    /// CreditCard entity.
    /// </summary>
    public partial class CreditCard
    {
		#region Self
		public static string _Self { get { return "Sales.CreditCard"; } }
		#endregion

        #region Columns
        public static string _CreditCardID { get { return @"Sales.CreditCard.CreditCardID"; } }
        public static string _CardType { get { return @"Sales.CreditCard.CardType"; } }
        public static string _CardNumber { get { return @"Sales.CreditCard.CardNumber"; } }
        public static string _ExpMonth { get { return @"Sales.CreditCard.ExpMonth"; } }
        public static string _ExpYear { get { return @"Sales.CreditCard.ExpYear"; } }
        public static string _ModifiedDate { get { return @"Sales.CreditCard.ModifiedDate"; } }
        #endregion
    }
}