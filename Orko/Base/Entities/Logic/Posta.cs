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
    public partial class Posta
    {
		#region Methods
		public void Save()
        {
			Validate<Posta>();
            Save<Posta>();
        }
		public async Task SaveAsync()
        {
			Validate<Posta>();
            await SaveAsync<Posta>();
        }
        public void Delete()
        {
            Delete<Posta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Posta>();
        }
		public void Validate()
		{
			Validate<Posta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Posta).GetType().Name;
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