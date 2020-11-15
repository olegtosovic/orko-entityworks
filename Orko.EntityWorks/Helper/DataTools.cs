using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Data conversions, connections strings, general settings, etc ...
    /// </summary>
    public static class DataTools
    {
        #region Constructors
        static DataTools()
        {

        }
        #endregion

        #region Public Static Metode
        internal static object SqlToNetConvert(object value)
        {
            if (value is DBNull) return null;
            return value;
        }
        /// <summary>
        /// Creates ambient transaction with default isolation level read committed.
        /// </summary>
        /// <returns>Transcation scope instance</returns>
        //public static TransactionScope CreateTransaction()
        //{
        //    TransactionScopeOption transactionScopeOption = TransactionScopeOption.Required;
        //    TransactionOptions transactionOtions = new TransactionOptions();
        //    transactionOtions.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
        //    TransactionScope transactionScope = new TransactionScope(transactionScopeOption, transactionOtions);
        //    return transactionScope;
        //}
        #endregion
    }
}
