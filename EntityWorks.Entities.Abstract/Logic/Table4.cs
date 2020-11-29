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
    public partial class Table4
    {
		#region Methods
		public void Save()
        {
			Validate<Table4>();
            Save<Table4>();
        }
		public async Task SaveAsync()
        {
			Validate<Table4>();
            await SaveAsync<Table4>();
        }
        public void Delete()
        {
            Delete<Table4>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Table4>();
        }
		public void Validate()
		{
			Validate<Table4>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Table4).GetType().Name;
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