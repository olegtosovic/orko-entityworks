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
    public partial class Table3
    {
		#region Methods
		public void Save()
        {
			Validate<Table3>();
            Save<Table3>();
        }
		public async Task SaveAsync()
        {
			Validate<Table3>();
            await SaveAsync<Table3>();
        }
        public void Delete()
        {
            Delete<Table3>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Table3>();
        }
		public void Validate()
		{
			Validate<Table3>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Table3).GetType().Name;
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