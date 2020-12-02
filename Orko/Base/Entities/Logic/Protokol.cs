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
    public partial class Protokol
    {
		#region Methods
		public void Save()
        {
			Validate<Protokol>();
            Save<Protokol>();
        }
		public async Task SaveAsync()
        {
			Validate<Protokol>();
            await SaveAsync<Protokol>();
        }
        public void Delete()
        {
            Delete<Protokol>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Protokol>();
        }
		public void Validate()
		{
			Validate<Protokol>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Protokol).GetType().Name;
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