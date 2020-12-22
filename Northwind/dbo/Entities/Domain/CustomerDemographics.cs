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
    /// CustomerDemographics entity.
    /// </summary>
    public sealed partial class CustomerDemographics : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static CustomerDemographics()
        {
            // Cache field metadata.
            EntityMeta<CustomerDemographics>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CustomerTypeID), @"CustomerTypeID", DbType.StringFixedLength, isPrimaryKey: true),
                new ColumnMetadata(nameof(CustomerDesc), @"CustomerDesc", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<CustomerDemographics>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<CustomerDemographics>.HasLanguageTable = false;
            EntityMeta<CustomerDemographics>.TableSchema = @"dbo";
            EntityMeta<CustomerDemographics>.TableName = @"CustomerDemographics";
            EntityMeta<CustomerDemographics>.LanguageTableSchema = null;
            EntityMeta<CustomerDemographics>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<CustomerDemographics>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CustomerDemographics>(queryConditions);
        }
        public static async Task<IEnumerable<CustomerDemographics>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CustomerDemographics>(columnName, queryOp, value);
        }
		public static async Task<CustomerDemographics> GetByPrimaryKeyAsync(string CustomerTypeID)
        {
            return await GetByPrimaryKeyAsync<CustomerDemographics>(CustomerTypeID);
        }
		public static async Task<CustomerDemographics> TryGetByPrimaryKeyAsync(string CustomerTypeID)
        {
            return await TryGetByPrimaryKeyAsync<CustomerDemographics>(CustomerTypeID);
        }
		#endregion
    }
}