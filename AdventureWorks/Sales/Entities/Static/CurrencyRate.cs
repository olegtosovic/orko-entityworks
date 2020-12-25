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
    /// CurrencyRate entity.
    /// </summary>
    public partial class CurrencyRate
    {
		#region Self
		public static string _Self { get { return "Sales.CurrencyRate"; } }
		#endregion

        #region Columns
        public static string _CurrencyRateID { get { return @"Sales.CurrencyRate.CurrencyRateID"; } }
        public static string _CurrencyRateDate { get { return @"Sales.CurrencyRate.CurrencyRateDate"; } }
        public static string _FromCurrencyCode { get { return @"Sales.CurrencyRate.FromCurrencyCode"; } }
        public static string _ToCurrencyCode { get { return @"Sales.CurrencyRate.ToCurrencyCode"; } }
        public static string _AverageRate { get { return @"Sales.CurrencyRate.AverageRate"; } }
        public static string _EndOfDayRate { get { return @"Sales.CurrencyRate.EndOfDayRate"; } }
        public static string _ModifiedDate { get { return @"Sales.CurrencyRate.ModifiedDate"; } }
        #endregion
    }
}