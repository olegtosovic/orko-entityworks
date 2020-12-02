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
    public partial class Korisnik
    {
		#region Methods
		public void Save()
        {
			Validate<Korisnik>();
            Save<Korisnik>();
        }
		public async Task SaveAsync()
        {
			Validate<Korisnik>();
            await SaveAsync<Korisnik>();
        }
        public void Delete()
        {
            Delete<Korisnik>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Korisnik>();
        }
		public void Validate()
		{
			Validate<Korisnik>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Korisnik).GetType().Name;
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