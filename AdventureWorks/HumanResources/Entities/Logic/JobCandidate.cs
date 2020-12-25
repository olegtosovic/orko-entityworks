// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.HumanResources
{
    public partial class JobCandidate
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<JobCandidate>();
            await SaveAsync<JobCandidate>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<JobCandidate>();
        }
		public void Validate()
		{
			Validate<JobCandidate>();
		}
        public JobCandidate Clone()
		{
			return Clone<JobCandidate>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(JobCandidate).GetType().Name;
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