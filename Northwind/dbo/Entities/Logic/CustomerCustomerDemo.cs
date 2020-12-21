// Generated on 12/21/2020 1:03 PM using EntityWorks code generation tool.
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
    public partial class CustomerCustomerDemo
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<CustomerCustomerDemo>();
            await SaveAsync<CustomerCustomerDemo>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<CustomerCustomerDemo>();
        }
		public void Validate()
		{
			Validate<CustomerCustomerDemo>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(CustomerCustomerDemo).GetType().Name;
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