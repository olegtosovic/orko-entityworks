// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
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
    public partial class Autor
    {
		#region Methods
		public void Save()
        {
			Validate<Autor>();
            Save<Autor>();
        }
		public async Task SaveAsync()
        {
			Validate<Autor>();
            await SaveAsync<Autor>();
        }
        public void Delete()
        {
            Delete<Autor>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Autor>();
        }
		public void Validate()
		{
			Validate<Autor>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Autor).GetType().Name;
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