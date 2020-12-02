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
    public partial class Artikal
    {
		#region Methods
		public void Save()
        {
			Validate<Artikal>();
            Save<Artikal>();
        }
		public async Task SaveAsync()
        {
			Validate<Artikal>();
            await SaveAsync<Artikal>();
        }
        public void Delete()
        {
            Delete<Artikal>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Artikal>();
        }
		public void Validate()
		{
			Validate<Artikal>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Artikal).GetType().Name;
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