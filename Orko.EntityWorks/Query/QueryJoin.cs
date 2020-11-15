using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represents single query join segment.
    /// </summary>
    internal sealed class QueryJoin : QuerySegment
    {
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryJoinType">Query join type</param>
        /// <param name="tableName">Table name</param>
        /// <param name="alias">Alias</param>
        /// <param name="queryConditions">Query condition list</param>
        public QueryJoin(QueryJoinType queryJoinType, string tableName, string alias, IEnumerable<QueryCondition> queryConditions)
        {
            // Initializtaion.
            QueryJoinType = queryJoinType;
            QueryConditions = queryConditions;
            TableName = tableName;
            Alias = alias;
        }
        #endregion

        #region Properties
        private IEnumerable<QueryCondition> QueryConditions { get; set; }
        private QueryJoinType QueryJoinType { get; set; }
        private string TableName { get; set; }
        #endregion

        #region Build
        protected override void Build()
        {
            // Where string.
            StringBuilder join = new StringBuilder();

            // Append where statment.
            if (string.IsNullOrWhiteSpace(Alias) == false)
                join.Append(Query.ToSqlJoin(QueryJoinType) + TableName + " AS " + Alias + " ON ");
            else join.Append(Query.ToSqlJoin(QueryJoinType) + TableName + " ON ");

            // Query search condition.
            QuerySearchCondition querySearchCondition = new QuerySearchCondition(QueryConditions);

            // Append search condition.
            join.Append(querySearchCondition.ToString());

            // 5Return where string.
            string result = join.ToString();
            Text = result + Environment.NewLine;
        }
        #endregion
    }
}
