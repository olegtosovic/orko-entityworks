using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Provides common segment structure.
    /// </summary>
    public class QuerySegment : IQuerySegment
    {
        #region Members
        private QuerySegment m_parent;
        #endregion

        #region Constructors
        public QuerySegment()
        {
            // Init members.
            m_parent = null;

            // Init properties.
            Builded = false;
            Alias = null;
            PartOfGroupBy = true;
            Text = string.Empty;
			Enclosed = false;
			EnclosingDone = false;
		}
        #endregion

        #region Properties
        protected bool Builded { get; set; }
        internal bool PartOfGroupBy { get; set; }
        internal string Alias { get; set; }
        protected string Text { get; set; }
		internal bool Enclosed { get; set; }
		internal bool EnclosingDone { get; set; }
        #endregion

        #region Build
        /// <summary>
        /// Builds segment to string.
        /// </summary>
        protected virtual void Build()
        {

        }

        /// <summary>
        /// Main build entry point.
        /// </summary>
        private void BuildBase()
        {
            // If not builded.
            if (Builded == false)
            {
                // Build.
                Build();

				// If enclosed.
				if (Enclosed)
					Enclose();

                // Mark as builded.
                Builded = true;
            }
			else
			{
				if (Enclosed && !EnclosingDone)
					Enclose();
			}
        }

        /// <summary>
        /// Surrounds segment by parentheses if criteria match.
        /// </summary>
        private void Enclose()
        {
			// Enclose.
            this.Text = "(" + this.Text + ")";

			// Set enclosing done flag.
			this.EnclosingDone = true;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Builds segment to string.
        /// </summary>
        /// <returns>Segment string</returns>
        public override string ToString()
        {
            // Build.
            BuildBase();

            // Return string.
            return Text;
        }

        /// <summary>
        /// Build segment to string.
        /// </summary>
        /// <param name="parent">Parent query segment</param>
        public string ToString(QuerySegment parent)
        {
            // Set parent.
            m_parent = parent;

            // Call real ToString.
            return ToString();
        }
        #endregion
    }
}
