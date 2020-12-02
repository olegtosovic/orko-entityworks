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
    public partial class Novost
    {
		#region Methods
		public void Save()
        {
			Validate<Novost>();
            Save<Novost>();
        }
		public async Task SaveAsync()
        {
			Validate<Novost>();
            await SaveAsync<Novost>();
        }
        public void Delete()
        {
            Delete<Novost>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Novost>();
        }
		public void Validate()
		{
			Validate<Novost>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Novost).GetType().Name;
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