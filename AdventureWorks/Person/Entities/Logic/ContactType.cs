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
    public partial class ContactType
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<ContactType>();
            await SaveAsync<ContactType>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<ContactType>();
        }
		public void Validate()
		{
			Validate<ContactType>();
		}
        public ContactType Clone()
		{
			return Clone<ContactType>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(ContactType).GetType().Name;
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