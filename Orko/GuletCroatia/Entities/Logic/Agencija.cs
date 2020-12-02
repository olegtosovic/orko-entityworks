// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.GuletCroatia
{
    public partial class Agencija
    {
		#region Methods
		public void Save()
        {
			Validate<Agencija>();
            Save<Agencija>();
        }
		public async Task SaveAsync()
        {
			Validate<Agencija>();
            await SaveAsync<Agencija>();
        }
        public void Delete()
        {
            Delete<Agencija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Agencija>();
        }
		public void Validate()
		{
			Validate<Agencija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Agencija).GetType().Name;
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