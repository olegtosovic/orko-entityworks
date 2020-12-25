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
    /// Location entity.
    /// </summary>
    public sealed partial class Location : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Location()
        {
            // Cache field metadata.
            EntityMeta<Location>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(LocationID), @"LocationID", DbType.Int16, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CostRate), @"CostRate", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(Availability), @"Availability", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Location>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Location>.HasLanguageTable = false;
            EntityMeta<Location>.TableSchema = @"Production";
            EntityMeta<Location>.TableName = @"Location";
            EntityMeta<Location>.LanguageTableSchema = null;
            EntityMeta<Location>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public short? LocationID { get; private set; }
        public string Name { get; set; }
        public decimal? CostRate { get; set; }
        public decimal? Availability { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Location>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Location>(queryConditions);
        }
        public static async Task<IEnumerable<Location>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Location>(columnName, queryOp, value);
        }
		public static async Task<Location> GetByPrimaryKeyAsync(short LocationID)
        {
            return await GetByPrimaryKeyAsync<Location>(LocationID);
        }
		public static async Task<Location> TryGetByPrimaryKeyAsync(short LocationID)
        {
            return await TryGetByPrimaryKeyAsync<Location>(LocationID);
        }
		#endregion
    }
}