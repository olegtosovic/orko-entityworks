using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Query calculation expression.
    /// </summary>
    public sealed class QueryCalculation : QuerySegment
    {
        #region Constructors
        /// <summary>
        /// Creates query calculation expression.
        /// Every even argument must be mathematical operator.
        /// Every nested query calculation will be surrounded by parentheses.
        /// </summary>
        /// <param name="expression">Calculation expression segment</param>
        public QueryCalculation(params object[] expressions)
        {
            // Initialization.
            CalculationExpressions = expressions.AsEnumerable();
        }
        #endregion

        #region Segment
        private IEnumerable<object> CalculationExpressions { get; set; }
        #endregion

        #region Properties
        #endregion

        #region Build
        protected override void Build()
        {
            // Build.
            this.Text = string.Join(" ", CalculationExpressions
                .Select(x => x.ToString()));

            //foreach (object expression in CalculationExpressions)
            //{
            //    string expressionText = expression.ToString();
            //    this.Text = string.Join(" ", this.Text + expression.ToString());
            //}
        }
        #endregion
    }
}
