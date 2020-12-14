// Generated on 12/14/2020 9:29 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Turist
{
    /// <summary>
    /// FakturaUputa entity.
    /// </summary>
    public sealed partial class FakturaUputa : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static FakturaUputa()
        {
            // Cache field metadata.
            EntityMeta<FakturaUputa>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(FakturaUputaID), @"FakturaUputaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(FakturaUputaObveznik), @"FakturaUputaObveznik", DbType.Int32, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<FakturaUputa>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<FakturaUputa>.HasLanguageTable = false;
            EntityMeta<FakturaUputa>.TableSchema = @"Turist";
            EntityMeta<FakturaUputa>.TableName = @"FakturaUputa";
            EntityMeta<FakturaUputa>.LanguageTableSchema = null;
            EntityMeta<FakturaUputa>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? FakturaUputaID { get; private set; }
        public int? FakturaUputaObveznik { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<FakturaUputa>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<FakturaUputa>(queryConditions);
        }
        public static async Task<IEnumerable<FakturaUputa>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<FakturaUputa>(columnName, queryOp, value);
        }
		public static async Task<FakturaUputa> GetByPrimaryKeyAsync(int FakturaUputaID)
        {
            return await GetByPrimaryKeyAsync<FakturaUputa>(FakturaUputaID);
        }
		public static async Task<FakturaUputa> TryGetByPrimaryKeyAsync(int FakturaUputaID)
        {
            return await TryGetByPrimaryKeyAsync<FakturaUputa>(FakturaUputaID);
        }
		#endregion
    }
}