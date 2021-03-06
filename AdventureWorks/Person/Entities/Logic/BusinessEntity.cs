// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Person
{
    public partial class BusinessEntity
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<BusinessEntity>();
            await SaveAsync<BusinessEntity>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<BusinessEntity>();
        }
		public void Validate()
		{
			Validate<BusinessEntity>();
		}
        public BusinessEntity Clone()
		{
			return Clone<BusinessEntity>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(BusinessEntity).GetType().Name;
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