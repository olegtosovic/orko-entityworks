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
    public partial class SmjestajniObjektVrstaUsluge
    {
		#region Methods
		public void Save()
        {
			Validate<SmjestajniObjektVrstaUsluge>();
            Save<SmjestajniObjektVrstaUsluge>();
        }
		public async Task SaveAsync()
        {
			Validate<SmjestajniObjektVrstaUsluge>();
            await SaveAsync<SmjestajniObjektVrstaUsluge>();
        }
        public void Delete()
        {
            Delete<SmjestajniObjektVrstaUsluge>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<SmjestajniObjektVrstaUsluge>();
        }
		public void Validate()
		{
			Validate<SmjestajniObjektVrstaUsluge>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(SmjestajniObjektVrstaUsluge).GetType().Name;
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