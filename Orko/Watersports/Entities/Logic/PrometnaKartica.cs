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
    public partial class PrometnaKartica
    {
		#region Methods
		public void Save()
        {
			Validate<PrometnaKartica>();
            Save<PrometnaKartica>();
        }
		public async Task SaveAsync()
        {
			Validate<PrometnaKartica>();
            await SaveAsync<PrometnaKartica>();
        }
        public void Delete()
        {
            Delete<PrometnaKartica>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<PrometnaKartica>();
        }
		public void Validate()
		{
			Validate<PrometnaKartica>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(PrometnaKartica).GetType().Name;
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