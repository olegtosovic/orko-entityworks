// Generated on 12/14/2020 9:21 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    public partial class TransactionHistoryArchive
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<TransactionHistoryArchive>();
            await SaveAsync<TransactionHistoryArchive>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<TransactionHistoryArchive>();
        }
		public void Validate()
		{
			Validate<TransactionHistoryArchive>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(TransactionHistoryArchive).GetType().Name;
        }
        public override string GetDisplayValue()
        {
            return base.GetDisplayValue();
        }
		public static string GetTooltipValue()
		{
            return string.Empty;
		}
        #endregion
    }
}