using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
    // Column equality comparer.
    internal class TableEqualityComparer : IEqualityComparer<Table>
    {
        bool IEqualityComparer<Table>.Equals(Table x, Table y)
        {
            return x.SqlName == y.SqlName;
        }

        int IEqualityComparer<Table>.GetHashCode(Table obj)
        {
            return obj.SqlName.GetHashCode();
        }
    }
}