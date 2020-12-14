// Generated on 12/14/2020 9:29 PM using EntityWorks code generation tool.
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
		public async Task SaveAsync()
        {
			Validate<Artikal>();
            await SaveAsync<Artikal>();
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