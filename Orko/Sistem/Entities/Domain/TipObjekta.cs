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

namespace Orko.Sistem
{
    /// <summary>
    /// TipObjekta entity.
    /// </summary>
    public sealed partial class TipObjekta : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TipObjekta()
        {
            // Cache field metadata.
            EntityMeta<TipObjekta>.LoadColumnMetadata
			(
				new ColumnMetadata("TipObjektaTipObjekta", @"TipObjektaTipObjekta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("TipObjektaAktivnost", @"TipObjektaAktivnost", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<TipObjekta>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TipObjekta>.HasLanguageTable = false;
            EntityMeta<TipObjekta>.TableSchema = @"Sistem";
            EntityMeta<TipObjekta>.TableName = @"TipObjekta";
            EntityMeta<TipObjekta>.LanguageTableSchema = null;
            EntityMeta<TipObjekta>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string TipObjektaTipObjekta { get; set; }
        public bool? TipObjektaAktivnost { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TipObjekta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TipObjekta>(queryConditions);
        }
        public static async Task<IEnumerable<TipObjekta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TipObjekta>(columnName, queryOp, value);
        }
		public static async Task<TipObjekta> GetByPrimaryKeyAsync(string TipObjektaTipObjekta)
        {
            return await GetByPrimaryKeyAsync<TipObjekta>(TipObjektaTipObjekta);
        }
		public static async Task<TipObjekta> TryGetByPrimaryKeyAsync(string TipObjektaTipObjekta)
        {
            return await TryGetByPrimaryKeyAsync<TipObjekta>(TipObjektaTipObjekta);
        }
		#endregion

        #region Public methods
		public static IEnumerable<TipObjekta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<TipObjekta>(queryConditions);
        }
        public static IEnumerable<TipObjekta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<TipObjekta>(columnName, queryOp, value);
        }
		public static TipObjekta GetByPrimaryKey(string TipObjektaTipObjekta)
        {
            return GetByPrimaryKey<TipObjekta>(TipObjektaTipObjekta);
        }
		public static TipObjekta TryGetByPrimaryKey(string TipObjektaTipObjekta)
        {
            return TryGetByPrimaryKey<TipObjekta>(TipObjektaTipObjekta);
        }
        #endregion
    }
}