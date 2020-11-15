using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Sql aggregate function list.
    /// </summary>
    public enum QueryAggregateFunction
    {
        #region Functions
        /// <summary>
        /// 
        /// </summary>
        Sum,

        /// <summary>
        /// 
        /// </summary>
        Count,

        /// <summary>
        /// 
        /// </summary>
        Count_big,

        /// <summary>
        /// AVG ([ALL|DISTINCT] expression) OVER ([partition_by_clause] order_by_clause)
        /// </summary>
        Avg,

        /// <summary>
        /// 
        /// </summary>
        Min,

        /// <summary>
        /// 
        /// </summary>
        Max,

        /// <summary>
        /// 
        /// </summary>
        Var,

        /// <summary>
        /// 
        /// </summary>
        Varp,

        /// <summary>
        /// 
        /// </summary>
        Stddev,

        /// <summary>
        /// 
        /// </summary>
        Stddevp,

        /// <summary>
        /// 
        /// </summary>
        Checksum_agg,

        /// <summary>
        /// 
        /// </summary>
        Grouping,

        /// <summary>
        /// 
        /// </summary>
        Grouping_id
        #endregion
    }

    /// <summary>
    /// Sql string function list.
    /// </summary>
    public enum QueryStringFunction
    {
        #region Functions
        AscII,
        Char,
        Charindex,
        Concat,
        Contact_ws,
        Difference,
        Format,
        Left,
        Len,
        Lower,
        Ltrim,
        Nchar,
        Patindex,
        Quotename,
        Replace,
        Replicate,
        Reverse,
        Right,
        Rtrim,
        Soundex,
        Space,
        Str,
        String_agg,
        String_escape,
        String_split,
        Stuff,
        Substring,
        Translate,
        Trim,
        Unicode,
        Upper
        #endregion
    }

    /// <summary>
    /// Sql date function list. 
    /// </summary>
    public enum QueryDateFunction
    {
        #region Functions
        Current_timestamp,
        DateAdd,
        DateDiff,
        DateDiff_big,
        DateFromParts,
        DateName,
        DatePart,
        DateTime2FromParts,
        DateTimeFromParts,
        DateTimeOffsetFromParts,
        Day,
        EoMonth,
        GetDate,
        GetUtDate,
        IsDate,
        Month,
        SmallDateTimeFromParts,
        SwitchOffset,
        SysDateTime,
        SysUtcDateTime,
        TimeFromParts,
        ToDateTimeOffset,
        Year
        #endregion
    }

    /// <summary>
    /// Sql mathematical function list.
    /// </summary>
    public enum QueryMathFunction
    {
        #region Functions
        Abs,
        Acos,
        Asin,
        Atan,
        Atn2,
        Ceiling,
        Cos,
        Cot,
        Degrees,
        Exp,
        Floor,
        Log,
        Log10,
        Pi,
        Power,
        Radians,
        Rand,
        Round,
        Sign,
        Sin,
        Sqrt,
        Square,
        Tan
        #endregion
    }

    /// <summary>
    /// Sql json function list.
    /// </summary>
    public enum QueryJsonFunction
    {
        #region Functions
        IsJson,
        Json_value,
        Json_query,
        Json_modify
        #endregion
    }

    /// <summary>
    /// Sql ranking function list.
    /// </summary>
    public enum QueryRankingFunction
    {
        #region Functions
        Rank,
        Dense_rank
        #endregion
    }

    /// <summary>
    /// Sql logical function list.
    /// </summary>
    public enum QueryLogicalFunction
    {
        #region Functions
        Choose,
        Iif
        #endregion
    }
}
