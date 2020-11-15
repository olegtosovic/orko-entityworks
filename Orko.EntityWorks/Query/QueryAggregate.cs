using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Query aggregate function
    /// </summary>
    public sealed class QueryAggregate : QuerySegment
    {
        #region Static constructor and templates
        /// <summary>
        /// Templates for aggregate functions.
        /// </summary>
        private static string m_normalTemplate;
        private static string m_normalTemplateKey;
        private static string m_overTemplate;
        private static string m_partitionTemplate;

        /// <summary>
        /// Template initialization constructor.
        /// </summary>
        static QueryAggregate()
        {
            m_normalTemplate = "{0}({1})";
            m_normalTemplateKey = "{0}({1} {2})";
            m_overTemplate = "{0}({1} {2}) OVER (ORDER BY {3})";
            m_partitionTemplate = "{0}({1}{2}) OVER (PARTITION BY {3} ORDER BY {4})";
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates instance of query aggregate function.
        /// </summary>
        /// <param name="queryFunction"></param>
        /// <param name="columnName"></param>
        public QueryAggregate(QueryAggregateFunction function, object expression)
        {
            // Initialization.
            QueryFunction = function;
            Expression = expression;
            QueryKey = QueryKey.All;
        }

        /// <summary>
        /// Creates instance of query aggregate function.
        /// </summary>
        /// <param name="function">Sql function name</param>
        /// <param name="key">Sql function keyword (ALL, DISTINCT)</param>
        /// <param name="expression"></param>
        public QueryAggregate(QueryAggregateFunction function, QueryKey key, object expression)
        {
            // Initialization.
            QueryFunction = function;
            Expression = expression;
            QueryKey = key;
        }

        /// <summary>
        /// Creates instance of query aggregate function.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="key"></param>
        /// <param name="expression"></param>
        public QueryAggregate(QueryAggregateFunction function, string expression, string overExpression)
        {

        }

        /// <summary>
        /// Creates instance of query aggregate function.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="key"></param>
        /// <param name="expression"></param>
        public QueryAggregate(QueryAggregateFunction function, string[] expression, string[] overExpression)
        {

        }

        /// <summary>
        /// Creates instance of query aggregate function.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="key"></param>
        /// <param name="expression"></param>
        /// <param name="partitionExpression"></param>
        /// <param name="overExpression"></param>
        public QueryAggregate(QueryAggregateFunction function, string expression, string partitionExpression, string overExpression)
        {

        }
        #endregion

        #region Segment
        private object Expression { get; set; }
        private string[] OverColumns { get; set; }
        private string[] PartitionColumns { get; set; } 
        private QueryKey QueryKey { get; set; }
        private QueryAggregateFunction QueryFunction { get; set; }
        #endregion

        #region Validation
        #endregion

        #region Helper
        private void BuildExpression(object expression, string key, string function)
        {
            if (expression is string)
                Text = string.Format(m_normalTemplate, function, key, expression as string);
        }
        #endregion

        #region Build
        /// <summary>
        /// Builds query agrregate function.
        /// </summary>
        protected override void Build()
        {
            // Build expression.
            string function = QueryFunction.ToString().ToUpper();
            string expression = Expression.ToString();
            string key = string.Empty;
            if (QueryKey != QueryKey.All)
                key = QueryKey.ToString().ToUpper();

            // If normal template.
            if (Expression != null && OverColumns == null)
            {
                if (QueryKey == QueryKey.All)
                    Text = string.Format(m_normalTemplate, function, expression);
                else if (QueryKey != QueryKey.All)
                    Text = string.Format(m_normalTemplateKey, function, key, expression);
            }

            // If over template.
            else if (OverColumns != null && PartitionColumns == null)
            {

            }

            // If partition template.
            else if (PartitionColumns != null)
            {

            }

            // Column name.
            //string columnName = ColumnName.TrimComma();

            // Generate aggregate string.
            //Text = string.Format(m_normalTemplate, queryFunction, queryKey, columnName);
        }
        #endregion
    }
}
