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
    public partial class Customers
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Customers>();
            await SaveAsync<Customers>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Customers>();
        }
		public void Validate()
		{
			Validate<Customers>();
		}
        public Customers Clone()
		{
			return Clone<Customers>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Customers).GetType().Name;
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