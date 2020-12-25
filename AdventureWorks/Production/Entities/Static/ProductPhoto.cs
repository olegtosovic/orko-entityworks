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
    /// ProductPhoto entity.
    /// </summary>
    public partial class ProductPhoto
    {
		#region Self
		public static string _Self { get { return "Production.ProductPhoto"; } }
		#endregion

        #region Columns
        public static string _ProductPhotoID { get { return @"Production.ProductPhoto.ProductPhotoID"; } }
        public static string _ThumbNailPhoto { get { return @"Production.ProductPhoto.ThumbNailPhoto"; } }
        public static string _ThumbnailPhotoFileName { get { return @"Production.ProductPhoto.ThumbnailPhotoFileName"; } }
        public static string _LargePhoto { get { return @"Production.ProductPhoto.LargePhoto"; } }
        public static string _LargePhotoFileName { get { return @"Production.ProductPhoto.LargePhotoFileName"; } }
        public static string _ModifiedDate { get { return @"Production.ProductPhoto.ModifiedDate"; } }
        #endregion
    }
}