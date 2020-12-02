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
    public partial class Jahta
    {
		#region Methods
		public void Save()
        {
			Validate<Jahta>();
            Save<Jahta>();
        }
		public async Task SaveAsync()
        {
			Validate<Jahta>();
            await SaveAsync<Jahta>();
        }
        public void Delete()
        {
            Delete<Jahta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Jahta>();
        }
		public void Validate()
		{
			Validate<Jahta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Jahta).GetType().Name;
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