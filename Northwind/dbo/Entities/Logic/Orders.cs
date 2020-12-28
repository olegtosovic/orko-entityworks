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
    public partial class Orders
    {
        #region Methods
        /// <summary>
        /// Saves Orders entity to database.
        /// </summary>
        public async Task SaveAsync()
        {
			Validate<Orders>();
            await SaveAsync<Orders>();
        }
        /// <summary>
        /// Deletes Orders entity from database.
        /// </summary>
        public async Task DeleteAsync()
        {
            await DeleteAsync<Orders>();
        }
        /// <summary>
        /// Validates Orders entity object.
        /// </summary>
		public void Validate()
		{
			Validate<Orders>();
		}
        /// <summary>
        /// Return field by field copy of Orders entity.
        /// </summary>
        public Orders Clone()
		{
			return Clone<Orders>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Orders).GetType().Name;
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