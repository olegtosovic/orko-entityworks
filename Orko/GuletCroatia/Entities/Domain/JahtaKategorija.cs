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
				new ColumnMetadata("JahtaKategorijaJahtaKategorija", @"JahtaKategorijaJahtaKategorija", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaKategorijaAktivnost", @"JahtaKategorijaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("JahtaKategorijaJezik", @"JahtaKategorijaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("JahtaKategorijaNaziv", @"JahtaKategorijaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("JahtaKategorijaOpis", @"JahtaKategorijaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
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

        #region Public methods
		public static IEnumerable<JahtaKategorija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<JahtaKategorija>(queryConditions);
        }
        public static IEnumerable<JahtaKategorija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<JahtaKategorija>(columnName, queryOp, value);
        }
		public static JahtaKategorija GetByPrimaryKey(string JahtaKategorijaJahtaKategorija)
        {
            return GetByPrimaryKey<JahtaKategorija>(JahtaKategorijaJahtaKategorija);
        }
		public static JahtaKategorija TryGetByPrimaryKey(string JahtaKategorijaJahtaKategorija)
        {
            return TryGetByPrimaryKey<JahtaKategorija>(JahtaKategorijaJahtaKategorija);
        }
        #endregion
    }
}