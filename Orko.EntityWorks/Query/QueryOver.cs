using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represents query over expression.
    /// </summary>
    public sealed class QueryOver : QuerySegment
    {
        #region Constructors
        public QueryOver(QueryPartition partition, QueryOrder orderBy, params string[] columns)
        {
            // Initialize.
            Partition = partition;
            OrderBy = orderBy;
            Columns = columns.AsEnumerable();
        }
        #endregion

        #region Segment
        private QueryPartition Partition { get; set; }
        private QueryOrder OrderBy { get; set; }
        private IEnumerable<string> Columns { get; set; }
        #endregion

        #region Build
        protected override void Build()
        {
            // Templates.
            string templateBasic = "({0} ORDER BY {1} {2}";
            string templatePartition = "(PARTITION BY {0} ORDER BY {2} {3})";
        }
        #endregion
    }
}
