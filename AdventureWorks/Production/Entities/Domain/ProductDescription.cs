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
    /// ProductDescription entity.
    /// </summary>
    public sealed partial class ProductDescription : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static ProductDescription()
        {
            // Cache field metadata.
            EntityMeta<ProductDescription>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProductDescriptionID), @"ProductDescriptionID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(Description), @"Description", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ProductDescription>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<ProductDescription>.HasLanguageTable = false;
            EntityMeta<ProductDescription>.TableSchema = @"Production";
            EntityMeta<ProductDescription>.TableName = @"ProductDescription";
            EntityMeta<ProductDescription>.LanguageTableSchema = null;
            EntityMeta<ProductDescription>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProductDescriptionID { get; private set; }
        public string Description { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<ProductDescription>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ProductDescription>(queryConditions);
        }
        public static async Task<IEnumerable<ProductDescription>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ProductDescription>(columnName, queryOp, value);
        }
		public static async Task<ProductDescription> GetByPrimaryKeyAsync(int ProductDescriptionID)
        {
            return await GetByPrimaryKeyAsync<ProductDescription>(ProductDescriptionID);
        }
		public static async Task<ProductDescription> TryGetByPrimaryKeyAsync(int ProductDescriptionID)
        {
            return await TryGetByPrimaryKeyAsync<ProductDescription>(ProductDescriptionID);
        }
		#endregion
    }
}