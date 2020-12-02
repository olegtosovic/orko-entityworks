// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Turist
{
    public partial class IzvorRezervacije
    {
		#region Methods
		public void Save()
        {
			Validate<IzvorRezervacije>();
            Save<IzvorRezervacije>();
        }
		public async Task SaveAsync()
        {
			Validate<IzvorRezervacije>();
            await SaveAsync<IzvorRezervacije>();
        }
        public void Delete()
        {
            Delete<IzvorRezervacije>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<IzvorRezervacije>();
        }
		public void Validate()
		{
			Validate<IzvorRezervacije>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(IzvorRezervacije).GetType().Name;
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