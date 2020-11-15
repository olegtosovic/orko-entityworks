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
            return x.Name == y.Name;
        }

        int IEqualityComparer<Column>.GetHashCode(Column obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
