using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represents sql built in function.
    /// </summary>
    public sealed class QueryFunction : QuerySegment
    {
        #region Constructors
        /// <summary>
        /// Creates instance of query aggregate function.
        /// </summary>
        /// <param name="function">Sql function</param>
        /// <param name="parameters">Function parameters and expressions</param>
        public QueryFunction(QueryAggregateFunction function, params object[] parameters)
        {
            // Initialize.
            PartOfGroupBy = false;
            FunctionName = function.ToString().ToUpper();
            SeperateParameters(parameters);
        }

        /// <summary>
        /// Creates instance of query string function.
        /// </summary>
        /// <param name="function">Sql function</param>
        /// <param name="parameters">Function parameters and expressions</param>
        public QueryFunction(QueryStringFunction function, params object[] parameters)
        {
            // Initialize.
            PartOfGroupBy = true;
            FunctionName = function.ToString().ToUpper();
            SeperateParameters(parameters);
        }

        /// <summary>
        /// Creates instance of query math function.
        /// </summary>
        /// <param name="function">Sql function</param>
        /// <param name="parameters">Function parameters and expressions</param>
        public QueryFunction(QueryMathFunction function, params object[] parameters)
        {
            // Initialize.
            PartOfGroupBy = true;
            FunctionName = function.ToString().ToUpper();
            SeperateParameters(parameters);
        }

        /// <summary>
        /// Creates instance of query date function.
        /// </summary>
        /// <param name="function">Sql function</param>
        /// <param name="parameters">Function parameters and expressions</param>
        public QueryFunction(QueryDateFunction function, params object[] parameters)
        {
            // Initialize.
            PartOfGroupBy = true;
            FunctionName = function.ToString().ToUpper();
            SeperateParameters(parameters);
        }

        /// <summary>
        /// Creates instance of query json function.
        /// </summary>
        /// <param name="function">Sql function</param>
        /// <param name="parameters">Function parameters and expressions</param>
        public QueryFunction(QueryJsonFunction function, params object[] parameters)
        {
            // Initialize.
            PartOfGroupBy = true;
            FunctionName = function.ToString().ToUpper();
            SeperateParameters(parameters);
        }

        /// <summary>
        /// Creates instance of query ranking function.
        /// </summary>
        /// <param name="function">Sql function</param>
        /// <param name="parameters"></param>
        public QueryFunction(QueryRankingFunction function, params object[] parameters)
        {
            // Initialize.
            PartOfGroupBy = true;
            FunctionName = function.ToString().ToUpper();
            SeperateParameters(parameters);
        }

        /// <summary>
        /// Creates instance of query logical function.
        /// </summary>
        /// <param name="function">Sql function</param>
        /// <param name="parameters">Function parameters and expressions</param>
        public QueryFunction(QueryLogicalFunction function, params object[] parameters)
        {
            // Initialize.
            PartOfGroupBy = true;
            FunctionName = function.ToString().ToUpper();
            SeperateParameters(parameters);
        }
        #endregion

        #region Segment
        private IEnumerable<object> Parameters { get; set; }
        private QueryKey? QueryKey { get; set; }
        private QueryOver QueryOver { get; set; }
        private string FunctionName { get; set; }
        #endregion

        #region Helper
        /// <summary>
        /// Seperates function segments into containers.
        /// </summary>
        /// <param name="parameters">All function segment types</param>
        private void SeperateParameters(IEnumerable<object> parameters)
        {
            // Remove non segment segments.
            parameters = Query.GetQuerySegmentsParameters(parameters);

            // Get all function parameters.
            Parameters = parameters.Where(
                x => x is QueryKey == false &&
                x is QueryOver == false &&
                x is QueryPartition == false);

            // Get query key.
            var _queryKey = parameters.Where(x => x is QueryKey).FirstOrDefault();
            this.QueryKey = (QueryKey?)_queryKey;

            // Get query over.
            var _queryOver = parameters.Where(x => x is QueryOver).FirstOrDefault();
            this.QueryOver = (QueryOver)_queryOver;
        }
        #endregion

        #region Function build
        private void BuildFunctionBody()
        {
            // Build function body.
            switch (FunctionName)
            {
                case "DatePart2FromParts":
                    {
                        BuildDatePart();
                        break;
                    }
                default:
                    {
                        BuildGenericFunction();
                        break;
                    }
            }
        }
        private void BuildOverBody()
        {

        }
        private void BuildGenericFunction()
        {
            // Build function body with parameters.
            Text = FunctionName + "({0}{1})";
            List<string> paramValues = new List<string>();
            foreach (var parameter in Parameters)
            {
                if (parameter is string)
                    paramValues.Add(parameter as string);
                else paramValues.Add(parameter.ToString());
            }
            Text = string.Format(Text, QueryKey, string.Join(",", paramValues));
        }
        #endregion

        #region Specific function build
        private void BuildDatePart()
        {
        }
        #endregion

        #region Build
        protected override void Build()
        {
            // Build main function body.
            BuildFunctionBody();

            // Build over body.
            BuildOverBody();
        }
        #endregion
    }
}
