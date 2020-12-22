// Generated on 12/22/2020 12:53 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Northwind.Dbo
{
    public partial class CustomerDemographics
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<CustomerDemographics>();
            await SaveAsync<CustomerDemographics>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<CustomerDemographics>();
        }
		public void Validate()
		{
			Validate<CustomerDemographics>();
		}
        public CustomerDemographics Clone()
		{
			return Clone<CustomerDemographics>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(CustomerDemographics).GetType().Name;
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