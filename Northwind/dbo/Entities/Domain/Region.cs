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
    /// Region entity.
    /// </summary>
    public sealed partial class Region : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Region()
        {
            // Cache field metadata.
            EntityMeta<Region>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(RegionID), @"RegionID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RegionDescription), @"RegionDescription", DbType.StringFixedLength, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Region>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Region>.HasLanguageTable = false;
            EntityMeta<Region>.TableSchema = @"dbo";
            EntityMeta<Region>.TableName = @"Region";
            EntityMeta<Region>.LanguageTableSchema = null;
            EntityMeta<Region>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? RegionID { get; set; }
        public string RegionDescription { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Region>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Region>(queryConditions);
        }
        public static async Task<IEnumerable<Region>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Region>(columnName, queryOp, value);
        }
		public static async Task<Region> GetByPrimaryKeyAsync(int RegionID)
        {
            return await GetByPrimaryKeyAsync<Region>(RegionID);
        }
		public static async Task<Region> TryGetByPrimaryKeyAsync(int RegionID)
        {
            return await TryGetByPrimaryKeyAsync<Region>(RegionID);
        }
		#endregion
    }
}