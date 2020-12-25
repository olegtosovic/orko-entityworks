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

namespace AdventureWorks.Person
{
    /// <summary>
    /// CountryRegion entity.
    /// </summary>
    public sealed partial class CountryRegion : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static CountryRegion()
        {
            // Cache field metadata.
            EntityMeta<CountryRegion>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CountryRegionCode), @"CountryRegionCode", DbType.String, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<CountryRegion>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<CountryRegion>.HasLanguageTable = false;
            EntityMeta<CountryRegion>.TableSchema = @"Person";
            EntityMeta<CountryRegion>.TableName = @"CountryRegion";
            EntityMeta<CountryRegion>.LanguageTableSchema = null;
            EntityMeta<CountryRegion>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string CountryRegionCode { get; set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<CountryRegion>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CountryRegion>(queryConditions);
        }
        public static async Task<IEnumerable<CountryRegion>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CountryRegion>(columnName, queryOp, value);
        }
		public static async Task<CountryRegion> GetByPrimaryKeyAsync(string CountryRegionCode)
        {
            return await GetByPrimaryKeyAsync<CountryRegion>(CountryRegionCode);
        }
		public static async Task<CountryRegion> TryGetByPrimaryKeyAsync(string CountryRegionCode)
        {
            return await TryGetByPrimaryKeyAsync<CountryRegion>(CountryRegionCode);
        }
		#endregion
    }
}