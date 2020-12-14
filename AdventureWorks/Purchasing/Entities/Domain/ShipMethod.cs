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

namespace AdventureWorks.Purchasing
{
    /// <summary>
    /// ShipMethod entity.
    /// </summary>
    public sealed partial class ShipMethod : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static ShipMethod()
        {
            // Cache field metadata.
            EntityMeta<ShipMethod>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ShipMethodID), @"ShipMethodID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(ShipBase), @"ShipBase", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ShipRate), @"ShipRate", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ShipMethod>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<ShipMethod>.HasLanguageTable = false;
            EntityMeta<ShipMethod>.TableSchema = @"Purchasing";
            EntityMeta<ShipMethod>.TableName = @"ShipMethod";
            EntityMeta<ShipMethod>.LanguageTableSchema = null;
            EntityMeta<ShipMethod>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ShipMethodID { get; private set; }
        public string Name { get; set; }
        public decimal? ShipBase { get; set; }
        public decimal? ShipRate { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ShipMethod>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ShipMethod>(queryConditions);
        }
        public static async Task<IEnumerable<ShipMethod>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ShipMethod>(columnName, queryOp, value);
        }
		public static async Task<ShipMethod> GetByPrimaryKeyAsync(int ShipMethodID)
        {
            return await GetByPrimaryKeyAsync<ShipMethod>(ShipMethodID);
        }
		public static async Task<ShipMethod> TryGetByPrimaryKeyAsync(int ShipMethodID)
        {
            return await TryGetByPrimaryKeyAsync<ShipMethod>(ShipMethodID);
        }
		#endregion
    }
}