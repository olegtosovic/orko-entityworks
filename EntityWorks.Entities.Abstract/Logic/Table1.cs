// Generated on 11/25/2020 11:00 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace OrkoEntityWorks.Abstract
{
    public partial class Table1
    {
		#region Methods
		public void Save()
        {
			Validate<Table1>();
            Save<Table1>();
        }
		public async Task SaveAsync()
        {
			Validate<Table1>();
            await SaveAsync<Table1>();
        }
        public void Delete()
        {
            Delete<Table1>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Table1>();
        }
		public void Validate()
		{
			Validate<Table1>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Table1).GetType().Name;
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