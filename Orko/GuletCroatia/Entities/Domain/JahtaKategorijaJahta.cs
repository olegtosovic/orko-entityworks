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
				new ColumnMetadata(nameof(JahtaKategorijaJahtaKategorija), @"JahtaKategorijaJahtaKategorija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaKategorijaJahtaJahta), @"JahtaKategorijaJahtaJahta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaKategorijaJahtaRedoslijed), @"JahtaKategorijaJahtaRedoslijed", DbType.Int32, isRequired: true)
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
    }
}