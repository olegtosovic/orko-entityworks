// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
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
				new ColumnMetadata("FakturaUputaID", @"FakturaUputaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("FakturaUputaObveznik", @"FakturaUputaObveznik", SqlDbType.Int, isRequired: true)
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

        #region Public methods
		public static IEnumerable<FakturaUputa> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<FakturaUputa>(queryConditions);
        }
        public static IEnumerable<FakturaUputa> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<FakturaUputa>(columnName, queryOp, value);
        }
		public static FakturaUputa GetByPrimaryKey(int FakturaUputaID)
        {
            return GetByPrimaryKey<FakturaUputa>(FakturaUputaID);
        }
		public static FakturaUputa TryGetByPrimaryKey(int FakturaUputaID)
        {
            return TryGetByPrimaryKey<FakturaUputa>(FakturaUputaID);
        }
        #endregion
    }
}