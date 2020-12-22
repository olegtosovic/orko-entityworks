// Generated on 12/22/2020 12:53 PM using EntityWorks code generation tool.
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
    /// Territories entity.
    /// </summary>
    public sealed partial class Territories : Entity
    {
		#region Members
		private Region m_Region;
        #endregion
        
		#region Constructors
        static Territories()
        {
            // Cache field metadata.
            EntityMeta<Territories>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TerritoryID), @"TerritoryID", DbType.String, isPrimaryKey: true),
                new ColumnMetadata(nameof(TerritoryDescription), @"TerritoryDescription", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(RegionID), @"RegionID", DbType.Int32, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Territories>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Region), nameof(RegionID), nameof(Northwind.Dbo.Region.RegionID))
			);

			// Cache table metadata.
			EntityMeta<Territories>.HasLanguageTable = false;
            EntityMeta<Territories>.TableSchema = @"dbo";
            EntityMeta<Territories>.TableName = @"Territories";
            EntityMeta<Territories>.LanguageTableSchema = null;
            EntityMeta<Territories>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int? RegionID { get; set; }
        #endregion

        #region Entities
		public Region Region
        {
            get { return EntityContext<Region>.Get(ref m_Region, this, nameof(Region)); }
            set { EntityContext<Region>.Set(ref m_Region, this, value, nameof(Region)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Territories>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Territories>(queryConditions);
        }
        public static async Task<IEnumerable<Territories>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Territories>(columnName, queryOp, value);
        }
		public static async Task<Territories> GetByPrimaryKeyAsync(string TerritoryID)
        {
            return await GetByPrimaryKeyAsync<Territories>(TerritoryID);
        }
		public static async Task<Territories> TryGetByPrimaryKeyAsync(string TerritoryID)
        {
            return await TryGetByPrimaryKeyAsync<Territories>(TerritoryID);
        }
		#endregion
    }
}