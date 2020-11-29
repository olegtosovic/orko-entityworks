using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Indicates what mapping type is used between data reader data and object instance.
    /// </summary>
    public enum ObjectMappingType
    {
        /// <summary>
        /// Query select interface must be be exactly the same as the model property interface, number and names must match.
        /// Most restrictive, throws exception if interfaces are not identical.
        /// </summary>
        Exact = 1,

        /// <summary>
        /// Query select interface must be subset of model propery interface, names must match.
        /// Semi restrictive, throws exception if query interface is not subset.
        /// </summary>
        QueryFirst = 2,

        /// <summary>
        /// Model property interface must be subset of query select interface, names must match.
        /// Semi restrictive, throws exception if model interface is not subset.
        /// </summary>
        ModelFirst = 3,

        /// <summary>
        /// Maps to any interface name collision.
        /// Least restrictive, throws exception if there is not at least one column name match.
        /// </summary>
        Intersect = 4
    }
}
