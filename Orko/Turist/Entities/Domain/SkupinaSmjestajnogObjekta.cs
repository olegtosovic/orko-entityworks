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
    /// SkupinaSmjestajnogObjekta entity.
    /// </summary>
    public sealed partial class SkupinaSmjestajnogObjekta : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static SkupinaSmjestajnogObjekta()
        {
            // Cache field metadata.
            EntityMeta<SkupinaSmjestajnogObjekta>.LoadColumnMetadata
			(
				new ColumnMetadata("SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta", @"SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("SkupinaSmjestajnogObjektaAktivnost", @"SkupinaSmjestajnogObjektaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("SkupinaSmjestajnogObjektaJezik", @"SkupinaSmjestajnogObjektaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("SkupinaSmjestajnogObjektaNaziv", @"SkupinaSmjestajnogObjektaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("SkupinaSmjestajnogObjektaOpis", @"SkupinaSmjestajnogObjektaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<SkupinaSmjestajnogObjekta>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<SkupinaSmjestajnogObjekta>.HasLanguageTable = true;
            EntityMeta<SkupinaSmjestajnogObjekta>.TableSchema = @"Turist";
            EntityMeta<SkupinaSmjestajnogObjekta>.TableName = @"SkupinaSmjestajnogObjekta";
            EntityMeta<SkupinaSmjestajnogObjekta>.LanguageTableSchema = @"Turist";
            EntityMeta<SkupinaSmjestajnogObjekta>.LanguageTableName = @"SkupinaSmjestajnogObjekta_jezik";
        }
        #endregion

        #region Columns
        public string SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta { get; set; }
        public bool? SkupinaSmjestajnogObjektaAktivnost { get; set; }
        public string SkupinaSmjestajnogObjektaJezik { get; private set; }
        public string SkupinaSmjestajnogObjektaNaziv { get; set; }
        public string SkupinaSmjestajnogObjektaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SkupinaSmjestajnogObjekta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SkupinaSmjestajnogObjekta>(queryConditions);
        }
        public static async Task<IEnumerable<SkupinaSmjestajnogObjekta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SkupinaSmjestajnogObjekta>(columnName, queryOp, value);
        }
		public static async Task<SkupinaSmjestajnogObjekta> GetByPrimaryKeyAsync(string SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta)
        {
            return await GetByPrimaryKeyAsync<SkupinaSmjestajnogObjekta>(SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta);
        }
		public static async Task<SkupinaSmjestajnogObjekta> TryGetByPrimaryKeyAsync(string SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta)
        {
            return await TryGetByPrimaryKeyAsync<SkupinaSmjestajnogObjekta>(SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta);
        }
		#endregion

        #region Public methods
		public static IEnumerable<SkupinaSmjestajnogObjekta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<SkupinaSmjestajnogObjekta>(queryConditions);
        }
        public static IEnumerable<SkupinaSmjestajnogObjekta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<SkupinaSmjestajnogObjekta>(columnName, queryOp, value);
        }
		public static SkupinaSmjestajnogObjekta GetByPrimaryKey(string SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta)
        {
            return GetByPrimaryKey<SkupinaSmjestajnogObjekta>(SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta);
        }
		public static SkupinaSmjestajnogObjekta TryGetByPrimaryKey(string SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta)
        {
            return TryGetByPrimaryKey<SkupinaSmjestajnogObjekta>(SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta);
        }
        #endregion
    }
}