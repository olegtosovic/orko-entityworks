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
    public partial class Gost
    {
		#region Methods
		public void Save()
        {
			Validate<Gost>();
            Save<Gost>();
        }
		public async Task SaveAsync()
        {
			Validate<Gost>();
            await SaveAsync<Gost>();
        }
        public void Delete()
        {
            Delete<Gost>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Gost>();
        }
		public void Validate()
		{
			Validate<Gost>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Gost).GetType().Name;
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