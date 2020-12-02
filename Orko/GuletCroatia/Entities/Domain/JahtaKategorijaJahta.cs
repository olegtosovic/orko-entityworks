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

namespace Orko.GuletCroatia
{
    /// <summary>
    /// JahtaKategorijaJahta entity.
    /// </summary>
    public sealed partial class JahtaKategorijaJahta : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static JahtaKategorijaJahta()
        {
            // Cache field metadata.
            EntityMeta<JahtaKategorijaJahta>.LoadColumnMetadata
			(
				new ColumnMetadata("JahtaKategorijaJahtaKategorija", @"JahtaKategorijaJahtaKategorija", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaKategorijaJahtaJahta", @"JahtaKategorijaJahtaJahta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaKategorijaJahtaRedoslijed", @"JahtaKategorijaJahtaRedoslijed", SqlDbType.Int, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaKategorijaJahta>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<JahtaKategorijaJahta>.HasLanguageTable = false;
            EntityMeta<JahtaKategorijaJahta>.TableSchema = @"GuletCroatia";
            EntityMeta<JahtaKategorijaJahta>.TableName = @"JahtaKategorijaJahta";
            EntityMeta<JahtaKategorijaJahta>.LanguageTableSchema = null;
            EntityMeta<JahtaKategorijaJahta>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string JahtaKategorijaJahtaKategorija { get; set; }
        public string JahtaKategorijaJahtaJahta { get; set; }
        public int? JahtaKategorijaJahtaRedoslijed { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<JahtaKategorijaJahta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<JahtaKategorijaJahta>(queryConditions);
        }
        public static async Task<IEnumerable<JahtaKategorijaJahta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<JahtaKategorijaJahta>(columnName, queryOp, value);
        }
		public static async Task<JahtaKategorijaJahta> GetByPrimaryKeyAsync(string JahtaKategorijaJahtaKategorija, string JahtaKategorijaJahtaJahta)
        {
            return await GetByPrimaryKeyAsync<JahtaKategorijaJahta>(JahtaKategorijaJahtaKategorija, JahtaKategorijaJahtaJahta);
        }
		public static async Task<JahtaKategorijaJahta> TryGetByPrimaryKeyAsync(string JahtaKategorijaJahtaKategorija, string JahtaKategorijaJahtaJahta)
        {
            return await TryGetByPrimaryKeyAsync<JahtaKategorijaJahta>(JahtaKategorijaJahtaKategorija, JahtaKategorijaJahtaJahta);
        }
		#endregion

        #region Public methods
		public static IEnumerable<JahtaKategorijaJahta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<JahtaKategorijaJahta>(queryConditions);
        }
        public static IEnumerable<JahtaKategorijaJahta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<JahtaKategorijaJahta>(columnName, queryOp, value);
        }
		public static JahtaKategorijaJahta GetByPrimaryKey(string JahtaKategorijaJahtaKategorija, string JahtaKategorijaJahtaJahta)
        {
            return GetByPrimaryKey<JahtaKategorijaJahta>(JahtaKategorijaJahtaKategorija, JahtaKategorijaJahtaJahta);
        }
		public static JahtaKategorijaJahta TryGetByPrimaryKey(string JahtaKategorijaJahtaKategorija, string JahtaKategorijaJahtaJahta)
        {
            return TryGetByPrimaryKey<JahtaKategorijaJahta>(JahtaKategorijaJahtaKategorija, JahtaKategorijaJahtaJahta);
        }
        #endregion
    }
}