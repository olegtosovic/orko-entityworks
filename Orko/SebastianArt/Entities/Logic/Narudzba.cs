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
    public partial class Narudzba
    {
		#region Methods
		public void Save()
        {
			Validate<Narudzba>();
            Save<Narudzba>();
        }
		public async Task SaveAsync()
        {
			Validate<Narudzba>();
            await SaveAsync<Narudzba>();
        }
        public void Delete()
        {
            Delete<Narudzba>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Narudzba>();
        }
		public void Validate()
		{
			Validate<Narudzba>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Narudzba).GetType().Name;
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