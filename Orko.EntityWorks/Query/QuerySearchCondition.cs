using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represents query search condition segment with multiple query conditions.
    /// </summary>
    internal sealed class QuerySearchCondition : QuerySegment
    {
        #region Constructors
        public QuerySearchCondition(IEnumerable<QueryCondition> queryConditions)
        {
            // Initialization.
            QueryConditions = queryConditions;
        }
        #endregion

        #region Properties
        private IEnumerable<QueryCondition> QueryConditions { get; set; }
        #endregion

        #region Build
        /// <summary>
        /// Builds query search condition string.
        /// </summary>
        protected override void Build()
        {
            // Build.
            foreach (QueryCondition queryCondition in QueryConditions)
            {
                // Build string.
                if (queryCondition == QueryConditions.Last())
                    Text += queryCondition.ToString();
                else Text += queryCondition.ToString() + " " + Query.ToSqlOperator(queryCondition.QueryOperatorLast);
            }
        }
        #endregion
    }
}
