using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    public class QuotedValue : QuerySegment
    {
        #region Constructors
        internal QuotedValue()
        {

        }
        #endregion

        #region Value
        public string Value { get; set; }
        #endregion

        #region Build
        protected override void Build()
        {

        }
        #endregion
    }
}
