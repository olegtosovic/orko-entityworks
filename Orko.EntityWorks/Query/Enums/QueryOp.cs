using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Query operator list.
    /// </summary>
    public enum QueryOp
    {
        Equal,
        NotEqual,
        Greater ,
        GreaterOrEqual,
        Less,
        LessOrEqual,
        Is,
        IsNot,
        In,
        NotIn,
        Like,
        And,
        Or,
        Exists,
        NotExists
    }
}
