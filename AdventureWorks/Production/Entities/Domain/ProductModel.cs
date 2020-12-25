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
    /// ProductModel entity.
    /// </summary>
    public sealed partial class ProductModel : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static ProductModel()
        {
            // Cache field metadata.
            EntityMeta<ProductModel>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductModelID), @"ProductModelID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CatalogDescription), @"CatalogDescription", DbType.Xml, isRequired: false),
                new ColumnMetadata(nameof(Instructions), @"Instructions", DbType.Xml, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductModel>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<ProductModel>.HasLanguageTable = false;
            EntityMeta<ProductModel>.TableSchema = @"Production";
            EntityMeta<ProductModel>.TableName = @"ProductModel";
            EntityMeta<ProductModel>.LanguageTableSchema = null;
            EntityMeta<ProductModel>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductModelID { get; private set; }
        public string Name { get; set; }
        public XElement CatalogDescription { get; set; }
        public XElement Instructions { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<ProductModel>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductModel>(queryConditions);
        }
        public static async Task<IEnumerable<ProductModel>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductModel>(columnName, queryOp, value);
        }
		public static async Task<ProductModel> GetByPrimaryKeyAsync(int ProductModelID)
        {
            return await GetByPrimaryKeyAsync<ProductModel>(ProductModelID);
        }
		public static async Task<ProductModel> TryGetByPrimaryKeyAsync(int ProductModelID)
        {
            return await TryGetByPrimaryKeyAsync<ProductModel>(ProductModelID);
        }
		#endregion
    }
}