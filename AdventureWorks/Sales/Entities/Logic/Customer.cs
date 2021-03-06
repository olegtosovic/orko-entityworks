// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Sales
{
    public partial class Customer
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Customer>();
            await SaveAsync<Customer>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Customer>();
        }
		public void Validate()
		{
			Validate<Customer>();
		}
        public Customer Clone()
		{
			return Clone<Customer>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Customer).GetType().Name;
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