// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Watersports
{
    public partial class VrstaUslugeStavke
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaUslugeStavke>();
            Save<VrstaUslugeStavke>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaUslugeStavke>();
            await SaveAsync<VrstaUslugeStavke>();
        }
        public void Delete()
        {
            Delete<VrstaUslugeStavke>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaUslugeStavke>();
        }
		public void Validate()
		{
			Validate<VrstaUslugeStavke>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaUslugeStavke).GetType().Name;
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