using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
    // Column equality comparer.
    internal class ColumnEqualityComparer : IEqualityComparer<Column>
    {
        bool IEqualityComparer<Column>.Equals(Column x, Column y)
        {
            return x.SqlName == y.SqlName;
        }

        int IEqualityComparer<Column>.GetHashCode(Column obj)
        {
            return obj.SqlName.GetHashCode();
        }
    }
}
