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
    public partial class ArtikalEx
    {
		#region Methods
		public void Save()
        {
			Validate<ArtikalEx>();
            Save<ArtikalEx>();
        }
		public async Task SaveAsync()
        {
			Validate<ArtikalEx>();
            await SaveAsync<ArtikalEx>();
        }
        public void Delete()
        {
            Delete<ArtikalEx>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<ArtikalEx>();
        }
		public void Validate()
		{
			Validate<ArtikalEx>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(ArtikalEx).GetType().Name;
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