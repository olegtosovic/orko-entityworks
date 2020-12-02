// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Base
{
    public partial class Opcina
    {
		#region Methods
		public void Save()
        {
			Validate<Opcina>();
            Save<Opcina>();
        }
		public async Task SaveAsync()
        {
			Validate<Opcina>();
            await SaveAsync<Opcina>();
        }
        public void Delete()
        {
            Delete<Opcina>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Opcina>();
        }
		public void Validate()
		{
			Validate<Opcina>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Opcina).GetType().Name;
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