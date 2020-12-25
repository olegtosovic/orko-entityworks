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
    /// TransactionHistory entity.
    /// </summary>
    public partial class TransactionHistory
    {
		#region Self
		public static string _Self { get { return "Production.TransactionHistory"; } }
		#endregion

        #region Columns
        public static string _TransactionID { get { return @"Production.TransactionHistory.TransactionID"; } }
        public static string _ProductID { get { return @"Production.TransactionHistory.ProductID"; } }
        public static string _ReferenceOrderID { get { return @"Production.TransactionHistory.ReferenceOrderID"; } }
        public static string _ReferenceOrderLineID { get { return @"Production.TransactionHistory.ReferenceOrderLineID"; } }
        public static string _TransactionDate { get { return @"Production.TransactionHistory.TransactionDate"; } }
        public static string _TransactionType { get { return @"Production.TransactionHistory.TransactionType"; } }
        public static string _Quantity { get { return @"Production.TransactionHistory.Quantity"; } }
        public static string _ActualCost { get { return @"Production.TransactionHistory.ActualCost"; } }
        public static string _ModifiedDate { get { return @"Production.TransactionHistory.ModifiedDate"; } }
        #endregion
    }
}