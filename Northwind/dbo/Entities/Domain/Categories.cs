// Generated on 12/14/2020 9:21 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Northwind.Dbo
{
    /// <summary>
    /// Categories entity.
    /// </summary>
    public sealed partial class Categories : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Categories()
        {
            // Cache field metadata.
            EntityMeta<Categories>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CategoryID), @"CategoryID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CategoryName), @"CategoryName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Description), @"Description", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Picture), @"Picture", DbType.Binary, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Categories>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Categories>.HasLanguageTable = false;
            EntityMeta<Categories>.TableSchema = @"dbo";
            EntityMeta<Categories>.TableName = @"Categories";
            EntityMeta<Categories>.LanguageTableSchema = null;
            EntityMeta<Categories>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CategoryID { get; private set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Byte[] Picture { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Categories>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Categories>(queryConditions);
        }
        public static async Task<IEnumerable<Categories>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Categories>(columnName, queryOp, value);
        }
		public static async Task<Categories> GetByPrimaryKeyAsync(int CategoryID)
        {
            return await GetByPrimaryKeyAsync<Categories>(CategoryID);
        }
		public static async Task<Categories> TryGetByPrimaryKeyAsync(int CategoryID)
        {
            return await TryGetByPrimaryKeyAsync<Categories>(CategoryID);
        }
		#endregion
    }
}