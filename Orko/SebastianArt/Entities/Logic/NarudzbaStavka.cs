// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.SebastianArt
{
    public partial class NarudzbaStavka
    {
		#region Methods
		public void Save()
        {
			Validate<NarudzbaStavka>();
            Save<NarudzbaStavka>();
        }
		public async Task SaveAsync()
        {
			Validate<NarudzbaStavka>();
            await SaveAsync<NarudzbaStavka>();
        }
        public void Delete()
        {
            Delete<NarudzbaStavka>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<NarudzbaStavka>();
        }
		public void Validate()
		{
			Validate<NarudzbaStavka>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(NarudzbaStavka).GetType().Name;
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