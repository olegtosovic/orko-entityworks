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
    public partial class Address
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Address>();
            await SaveAsync<Address>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Address>();
        }
		public void Validate()
		{
			Validate<Address>();
		}
        public Address Clone()
		{
			return Clone<Address>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Address).GetType().Name;
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