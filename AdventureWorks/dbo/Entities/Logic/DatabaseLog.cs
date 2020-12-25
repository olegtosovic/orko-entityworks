// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Dbo
{
    public partial class DatabaseLog
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<DatabaseLog>();
            await SaveAsync<DatabaseLog>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<DatabaseLog>();
        }
		public void Validate()
		{
			Validate<DatabaseLog>();
		}
        public DatabaseLog Clone()
		{
			return Clone<DatabaseLog>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(DatabaseLog).GetType().Name;
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