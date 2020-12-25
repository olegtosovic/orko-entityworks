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
    /// BusinessEntity entity.
    /// </summary>
    public sealed partial class BusinessEntity : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static BusinessEntity()
        {
            // Cache field metadata.
            EntityMeta<BusinessEntity>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<BusinessEntity>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<BusinessEntity>.HasLanguageTable = false;
            EntityMeta<BusinessEntity>.TableSchema = @"Person";
            EntityMeta<BusinessEntity>.TableName = @"BusinessEntity";
            EntityMeta<BusinessEntity>.LanguageTableSchema = null;
            EntityMeta<BusinessEntity>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; private set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<BusinessEntity>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<BusinessEntity>(queryConditions);
        }
        public static async Task<IEnumerable<BusinessEntity>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<BusinessEntity>(columnName, queryOp, value);
        }
		public static async Task<BusinessEntity> GetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await GetByPrimaryKeyAsync<BusinessEntity>(BusinessEntityID);
        }
		public static async Task<BusinessEntity> TryGetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await TryGetByPrimaryKeyAsync<BusinessEntity>(BusinessEntityID);
        }
		#endregion
    }
}