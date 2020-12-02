// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Sistem
{
    public partial class Iznimka
    {
		#region Methods
		public void Save()
        {
			Validate<Iznimka>();
            Save<Iznimka>();
        }
		public async Task SaveAsync()
        {
			Validate<Iznimka>();
            await SaveAsync<Iznimka>();
        }
        public void Delete()
        {
            Delete<Iznimka>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Iznimka>();
        }
		public void Validate()
		{
			Validate<Iznimka>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Iznimka).GetType().Name;
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