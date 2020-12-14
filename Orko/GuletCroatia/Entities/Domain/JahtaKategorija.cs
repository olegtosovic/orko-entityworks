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
    /// JahtaKategorija entity.
    /// </summary>
    public sealed partial class JahtaKategorija : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static JahtaKategorija()
        {
            // Cache field metadata.
            EntityMeta<JahtaKategorija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(JahtaKategorijaJahtaKategorija), @"JahtaKategorijaJahtaKategorija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaKategorijaAktivnost), @"JahtaKategorijaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(JahtaKategorijaJezik), @"JahtaKategorijaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(JahtaKategorijaNaziv), @"JahtaKategorijaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(JahtaKategorijaOpis), @"JahtaKategorijaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaKategorija>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<JahtaKategorija>.HasLanguageTable = true;
            EntityMeta<JahtaKategorija>.TableSchema = @"GuletCroatia";
            EntityMeta<JahtaKategorija>.TableName = @"JahtaKategorija";
            EntityMeta<JahtaKategorija>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<JahtaKategorija>.LanguageTableName = @"JahtaKategorija_jezik";
        }
        #endregion

        #region Columns
        public string JahtaKategorijaJahtaKategorija { get; set; }
        public bool? JahtaKategorijaAktivnost { get; set; }
        public string JahtaKategorijaJezik { get; private set; }
        public string JahtaKategorijaNaziv { get; set; }
        public string JahtaKategorijaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<JahtaKategorija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<JahtaKategorija>(queryConditions);
        }
        public static async Task<IEnumerable<JahtaKategorija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<JahtaKategorija>(columnName, queryOp, value);
        }
		public static async Task<JahtaKategorija> GetByPrimaryKeyAsync(string JahtaKategorijaJahtaKategorija)
        {
            return await GetByPrimaryKeyAsync<JahtaKategorija>(JahtaKategorijaJahtaKategorija);
        }
		public static async Task<JahtaKategorija> TryGetByPrimaryKeyAsync(string JahtaKategorijaJahtaKategorija)
        {
            return await TryGetByPrimaryKeyAsync<JahtaKategorija>(JahtaKategorijaJahtaKategorija);
        }
		#endregion
    }
}