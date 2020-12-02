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
    public partial class Orijentacija
    {
		#region Methods
		public void Save()
        {
			Validate<Orijentacija>();
            Save<Orijentacija>();
        }
		public async Task SaveAsync()
        {
			Validate<Orijentacija>();
            await SaveAsync<Orijentacija>();
        }
        public void Delete()
        {
            Delete<Orijentacija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Orijentacija>();
        }
		public void Validate()
		{
			Validate<Orijentacija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Orijentacija).GetType().Name;
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