// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    public partial class Document
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Document>();
            await SaveAsync<Document>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Document>();
        }
		public void Validate()
		{
			Validate<Document>();
		}
        public Document Clone()
		{
			return Clone<Document>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Document).GetType().Name;
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