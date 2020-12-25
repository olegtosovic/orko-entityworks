// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    /// <summary>
    /// ProductPhoto entity.
    /// </summary>
    public sealed partial class ProductPhoto : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static ProductPhoto()
        {
            // Cache field metadata.
            EntityMeta<ProductPhoto>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductPhotoID), @"ProductPhotoID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(ThumbNailPhoto), @"ThumbNailPhoto", DbType.Binary, isRequired: false),
                new ColumnMetadata(nameof(ThumbnailPhotoFileName), @"ThumbnailPhotoFileName", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(LargePhoto), @"LargePhoto", DbType.Binary, isRequired: false),
                new ColumnMetadata(nameof(LargePhotoFileName), @"LargePhotoFileName", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductPhoto>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<ProductPhoto>.HasLanguageTable = false;
            EntityMeta<ProductPhoto>.TableSchema = @"Production";
            EntityMeta<ProductPhoto>.TableName = @"ProductPhoto";
            EntityMeta<ProductPhoto>.LanguageTableSchema = null;
            EntityMeta<ProductPhoto>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductPhotoID { get; private set; }
        public Byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public Byte[] LargePhoto { get; set; }
        public string LargePhotoFileName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<ProductPhoto>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductPhoto>(queryConditions);
        }
        public static async Task<IEnumerable<ProductPhoto>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductPhoto>(columnName, queryOp, value);
        }
		public static async Task<ProductPhoto> GetByPrimaryKeyAsync(int ProductPhotoID)
        {
            return await GetByPrimaryKeyAsync<ProductPhoto>(ProductPhotoID);
        }
		public static async Task<ProductPhoto> TryGetByPrimaryKeyAsync(int ProductPhotoID)
        {
            return await TryGetByPrimaryKeyAsync<ProductPhoto>(ProductPhotoID);
        }
		#endregion
    }
}