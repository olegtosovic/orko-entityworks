// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    /// <summary>
    /// ProductReview entity.
    /// </summary>
    public partial class ProductReview
    {
		#region Self
		public static string _Self { get { return "Production.ProductReview"; } }
		#endregion

        #region Columns
        public static string _ProductReviewID { get { return @"Production.ProductReview.ProductReviewID"; } }
        public static string _ProductID { get { return @"Production.ProductReview.ProductID"; } }
        public static string _ReviewerName { get { return @"Production.ProductReview.ReviewerName"; } }
        public static string _ReviewDate { get { return @"Production.ProductReview.ReviewDate"; } }
        public static string _EmailAddress { get { return @"Production.ProductReview.EmailAddress"; } }
        public static string _Rating { get { return @"Production.ProductReview.Rating"; } }
        public static string _Comments { get { return @"Production.ProductReview.Comments"; } }
        public static string _ModifiedDate { get { return @"Production.ProductReview.ModifiedDate"; } }
        #endregion
    }
}