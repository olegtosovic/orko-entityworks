// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.HumanResources
{
    public partial class Shift
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Shift>();
            await SaveAsync<Shift>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Shift>();
        }
		public void Validate()
		{
			Validate<Shift>();
		}
        public Shift Clone()
		{
			return Clone<Shift>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Shift).GetType().Name;
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