// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Blog
{
    public partial class Kategorija
    {
		#region Methods
		public void Save()
        {
			Validate<Kategorija>();
            Save<Kategorija>();
        }
		public async Task SaveAsync()
        {
			Validate<Kategorija>();
            await SaveAsync<Kategorija>();
        }
        public void Delete()
        {
            Delete<Kategorija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Kategorija>();
        }
		public void Validate()
		{
			Validate<Kategorija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Kategorija).GetType().Name;
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