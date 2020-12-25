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
    public partial class Person
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Person>();
            await SaveAsync<Person>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Person>();
        }
		public void Validate()
		{
			Validate<Person>();
		}
        public Person Clone()
		{
			return Clone<Person>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Person).GetType().Name;
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