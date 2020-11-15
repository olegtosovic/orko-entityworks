using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represents single query condition segment.
    /// </summary>
    public sealed class QueryCondition : QuerySegment
    {
        #region Constructors
        /// <summary>
        /// Creates query condition.
        /// </summary>
        /// <param name="leftExpression">Left expression</param>
        /// <param name="queryOperator">Query operator</param>
        /// <param name="rightExpression">Right expression</param>
        public QueryCondition(
			object leftExpression,
            QueryOp queryOperator,
            object rightExpression,
            bool enclosed = false,
            QueryOp lastOperator = QueryOp.And)
        {
            //  Initialization.
            LeftExpression = leftExpression;
            RightExpression = rightExpression;
            QueryOperator = queryOperator;
            QueryOperatorLast = lastOperator;
            Enclosed = enclosed;
        }

        /// <summary>
        /// Creates query condition.
        /// </summary>
        /// <param name="leftCondition">Left query condition</param>
        /// <param name="queryOperator">Query operator</param>
        /// <param name="rightCondition">Right query condition</param>
        public QueryCondition(
			QueryCondition leftCondition,
            QueryOp queryOperator, 
            QueryCondition rightCondition,
            bool enclosed = true,
            QueryOp lastOperator = QueryOp.And)
        {
            // Initialization.
            LeftExpression = leftCondition;
            RightExpression = rightCondition;
            QueryOperator = queryOperator;
            QueryOperatorLast = lastOperator;
            Enclosed = enclosed;
        }
        #endregion

        #region Segment
        private object LeftExpression { get; set; }
        private object RightExpression { get; set; }
        private QueryOp QueryOperator { get; set; }
        internal QueryOp QueryOperatorLast { get; set; }
        #endregion

        #region Properties
        public bool Enclosed { get; set; }
        #endregion

        #region Build
        protected override void Build()
        {
            // If for that is null.
            if (LeftExpression == null)
                LeftExpression = string.Empty;
            if (RightExpression == null)
                RightExpression = string.Empty;

			// Enclosing.
			if (LeftExpression != null && LeftExpression is Query)
				((QuerySegment)LeftExpression).Enclosed = true;
			if (RightExpression != null && RightExpression is Query)
				((QuerySegment)RightExpression).Enclosed = true;

            // If query condition constructor.
            if (LeftExpression is QueryCondition && RightExpression is QueryCondition)
            {
                // Query conditions.
                QueryCondition leftCondition = LeftExpression as QueryCondition;
                QueryCondition rightCondition = RightExpression as QueryCondition;

                // Build.
                if (Enclosed)
                    Text = "(" + leftCondition.ToString() + Query.ToSqlOperator(QueryOperator) + rightCondition.ToString() + ")";
                else Text = leftCondition.ToString() + Query.ToSqlOperator(QueryOperator) + rightCondition.ToString();
            }

			// Novo testirati.
			//else if (LeftExpression is Query && RightExpression is Query)
			//{

			//}
            else
            {
                // Build.
                if (Enclosed)
                    Text = "(" + LeftExpression.ToString() + Query.ToSqlOperator(QueryOperator) + RightExpression.ToString() + ")";
                else Text = LeftExpression.ToString() + Query.ToSqlOperator(QueryOperator) + RightExpression.ToString();
            }

            // Set builded true.
            Builded = true;
        }
        #endregion
    }
}
