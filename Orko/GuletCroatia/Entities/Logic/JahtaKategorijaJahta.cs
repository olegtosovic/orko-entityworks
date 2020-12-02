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
    public partial class JahtaKategorijaJahta
    {
		#region Methods
		public void Save()
        {
			Validate<JahtaKategorijaJahta>();
            Save<JahtaKategorijaJahta>();
        }
		public async Task SaveAsync()
        {
			Validate<JahtaKategorijaJahta>();
            await SaveAsync<JahtaKategorijaJahta>();
        }
        public void Delete()
        {
            Delete<JahtaKategorijaJahta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<JahtaKategorijaJahta>();
        }
		public void Validate()
		{
			Validate<JahtaKategorijaJahta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(JahtaKategorijaJahta).GetType().Name;
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