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

namespace AdventureWorks.Production
{
    /// <summary>
    /// TransactionHistoryArchive entity.
    /// </summary>
    public partial class TransactionHistoryArchive
    {
		#region Self
		public static string _Self { get { return "Production.TransactionHistoryArchive"; } }
		#endregion

        #region Columns
        public static string _TransactionID { get { return @"Production.TransactionHistoryArchive.TransactionID"; } }
        public static string _ProductID { get { return @"Production.TransactionHistoryArchive.ProductID"; } }
        public static string _ReferenceOrderID { get { return @"Production.TransactionHistoryArchive.ReferenceOrderID"; } }
        public static string _ReferenceOrderLineID { get { return @"Production.TransactionHistoryArchive.ReferenceOrderLineID"; } }
        public static string _TransactionDate { get { return @"Production.TransactionHistoryArchive.TransactionDate"; } }
        public static string _TransactionType { get { return @"Production.TransactionHistoryArchive.TransactionType"; } }
        public static string _Quantity { get { return @"Production.TransactionHistoryArchive.Quantity"; } }
        public static string _ActualCost { get { return @"Production.TransactionHistoryArchive.ActualCost"; } }
        public static string _ModifiedDate { get { return @"Production.TransactionHistoryArchive.ModifiedDate"; } }
        #endregion
    }
}