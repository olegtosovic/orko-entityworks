using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Query join type list.
    /// </summary>
    internal enum QueryJoinType
    {
        Inner = 1,
        Left = 2,
        Right = 3,
        Full = 4,
        Cross = 5
    }
}
