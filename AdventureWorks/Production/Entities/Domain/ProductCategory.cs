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
    /// ProductCategory entity.
    /// </summary>
    public sealed partial class ProductCategory : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static ProductCategory()
        {
            // Cache field metadata.
            EntityMeta<ProductCategory>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductCategoryID), @"ProductCategoryID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductCategory>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<ProductCategory>.HasLanguageTable = false;
            EntityMeta<ProductCategory>.TableSchema = @"Production";
            EntityMeta<ProductCategory>.TableName = @"ProductCategory";
            EntityMeta<ProductCategory>.LanguageTableSchema = null;
            EntityMeta<ProductCategory>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductCategoryID { get; private set; }
        public string Name { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<ProductCategory>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductCategory>(queryConditions);
        }
        public static async Task<IEnumerable<ProductCategory>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductCategory>(columnName, queryOp, value);
        }
		public static async Task<ProductCategory> GetByPrimaryKeyAsync(int ProductCategoryID)
        {
            return await GetByPrimaryKeyAsync<ProductCategory>(ProductCategoryID);
        }
		public static async Task<ProductCategory> TryGetByPrimaryKeyAsync(int ProductCategoryID)
        {
            return await TryGetByPrimaryKeyAsync<ProductCategory>(ProductCategoryID);
        }
		#endregion
    }
}