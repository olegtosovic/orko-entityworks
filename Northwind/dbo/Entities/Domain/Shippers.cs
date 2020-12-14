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
    /// Shippers entity.
    /// </summary>
    public sealed partial class Shippers : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Shippers()
        {
            // Cache field metadata.
            EntityMeta<Shippers>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ShipperID), @"ShipperID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CompanyName), @"CompanyName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Phone), @"Phone", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Shippers>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Shippers>.HasLanguageTable = false;
            EntityMeta<Shippers>.TableSchema = @"dbo";
            EntityMeta<Shippers>.TableName = @"Shippers";
            EntityMeta<Shippers>.LanguageTableSchema = null;
            EntityMeta<Shippers>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ShipperID { get; private set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Shippers>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Shippers>(queryConditions);
        }
        public static async Task<IEnumerable<Shippers>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Shippers>(columnName, queryOp, value);
        }
		public static async Task<Shippers> GetByPrimaryKeyAsync(int ShipperID)
        {
            return await GetByPrimaryKeyAsync<Shippers>(ShipperID);
        }
		public static async Task<Shippers> TryGetByPrimaryKeyAsync(int ShipperID)
        {
            return await TryGetByPrimaryKeyAsync<Shippers>(ShipperID);
        }
		#endregion
    }
}