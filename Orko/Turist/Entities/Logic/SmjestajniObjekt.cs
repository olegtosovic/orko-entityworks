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
    public partial class SmjestajniObjekt
    {
		#region Methods
		public void Save()
        {
			Validate<SmjestajniObjekt>();
            Save<SmjestajniObjekt>();
        }
		public async Task SaveAsync()
        {
			Validate<SmjestajniObjekt>();
            await SaveAsync<SmjestajniObjekt>();
        }
        public void Delete()
        {
            Delete<SmjestajniObjekt>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<SmjestajniObjekt>();
        }
		public void Validate()
		{
			Validate<SmjestajniObjekt>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(SmjestajniObjekt).GetType().Name;
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