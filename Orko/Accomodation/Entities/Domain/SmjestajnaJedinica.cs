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

namespace Orko.Accomodation
{
    /// <summary>
    /// SmjestajnaJedinica entity.
    /// </summary>
    public sealed partial class SmjestajnaJedinica : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static SmjestajnaJedinica()
        {
            // Cache field metadata.
            EntityMeta<SmjestajnaJedinica>.LoadColumnMetadata
			(
				new ColumnMetadata("SmjestajnaJedinicaID", @"SmjestajnaJedinicaID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("SmjestajnaJedinicaSifra", @"SmjestajnaJedinicaSifra", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaBrojOsoba", @"SmjestajnaJedinicaBrojOsoba", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaKategorija", @"SmjestajnaJedinicaKategorija", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaModul", @"SmjestajnaJedinicaModul", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaDrzava", @"SmjestajnaJedinicaDrzava", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaOpcina", @"SmjestajnaJedinicaOpcina", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaUlica", @"SmjestajnaJedinicaUlica", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaKucniBroj", @"SmjestajnaJedinicaKucniBroj", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaGoogleMapsLink", @"SmjestajnaJedinicaGoogleMapsLink", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaKrevetnaDeklaracija", @"SmjestajnaJedinicaKrevetnaDeklaracija", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaBrojDoubleBed", @"SmjestajnaJedinicaBrojDoubleBed", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaBrojSingleBed", @"SmjestajnaJedinicaBrojSingleBed", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaBrojSofaBed", @"SmjestajnaJedinicaBrojSofaBed", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaBrojExtraBed", @"SmjestajnaJedinicaBrojExtraBed", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaAktivnost", @"SmjestajnaJedinicaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaJezik", @"SmjestajnaJedinicaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("SmjestajnaJedinicaSlug", @"SmjestajnaJedinicaSlug", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("SmjestajnaJedinicaNaziv", @"SmjestajnaJedinicaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("SmjestajnaJedinicaPodnaziv", @"SmjestajnaJedinicaPodnaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("SmjestajnaJedinicaOpis", @"SmjestajnaJedinicaOpis", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("SmjestajnaJedinicaAdresa", @"SmjestajnaJedinicaAdresa", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("SmjestajnaJedinicaMetaTitle", @"SmjestajnaJedinicaMetaTitle", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("SmjestajnaJedinicaMetaDescription", @"SmjestajnaJedinicaMetaDescription", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<SmjestajnaJedinica>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<SmjestajnaJedinica>.HasLanguageTable = true;
            EntityMeta<SmjestajnaJedinica>.TableSchema = @"Accomodation";
            EntityMeta<SmjestajnaJedinica>.TableName = @"SmjestajnaJedinica";
            EntityMeta<SmjestajnaJedinica>.LanguageTableSchema = @"Accomodation";
            EntityMeta<SmjestajnaJedinica>.LanguageTableName = @"SmjestajnaJedinica_jezik";
        }
        #endregion

        #region Columns
        public int? SmjestajnaJedinicaID { get; set; }
        public string SmjestajnaJedinicaSifra { get; set; }
        public int? SmjestajnaJedinicaBrojOsoba { get; set; }
        public int? SmjestajnaJedinicaKategorija { get; set; }
        public int? SmjestajnaJedinicaModul { get; set; }
        public string SmjestajnaJedinicaDrzava { get; set; }
        public string SmjestajnaJedinicaOpcina { get; set; }
        public string SmjestajnaJedinicaUlica { get; set; }
        public string SmjestajnaJedinicaKucniBroj { get; set; }
        public string SmjestajnaJedinicaGoogleMapsLink { get; set; }
        public string SmjestajnaJedinicaKrevetnaDeklaracija { get; set; }
        public int? SmjestajnaJedinicaBrojDoubleBed { get; set; }
        public int? SmjestajnaJedinicaBrojSingleBed { get; set; }
        public int? SmjestajnaJedinicaBrojSofaBed { get; set; }
        public int? SmjestajnaJedinicaBrojExtraBed { get; set; }
        public bool? SmjestajnaJedinicaAktivnost { get; set; }
        public string SmjestajnaJedinicaJezik { get; private set; }
        public string SmjestajnaJedinicaSlug { get; set; }
        public string SmjestajnaJedinicaNaziv { get; set; }
        public string SmjestajnaJedinicaPodnaziv { get; set; }
        public string SmjestajnaJedinicaOpis { get; set; }
        public string SmjestajnaJedinicaAdresa { get; set; }
        public string SmjestajnaJedinicaMetaTitle { get; set; }
        public string SmjestajnaJedinicaMetaDescription { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SmjestajnaJedinica>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SmjestajnaJedinica>(queryConditions);
        }
        public static async Task<IEnumerable<SmjestajnaJedinica>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SmjestajnaJedinica>(columnName, queryOp, value);
        }
		public static async Task<SmjestajnaJedinica> GetByPrimaryKeyAsync(int SmjestajnaJedinicaID)
        {
            return await GetByPrimaryKeyAsync<SmjestajnaJedinica>(SmjestajnaJedinicaID);
        }
		public static async Task<SmjestajnaJedinica> TryGetByPrimaryKeyAsync(int SmjestajnaJedinicaID)
        {
            return await TryGetByPrimaryKeyAsync<SmjestajnaJedinica>(SmjestajnaJedinicaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<SmjestajnaJedinica> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<SmjestajnaJedinica>(queryConditions);
        }
        public static IEnumerable<SmjestajnaJedinica> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<SmjestajnaJedinica>(columnName, queryOp, value);
        }
		public static SmjestajnaJedinica GetByPrimaryKey(int SmjestajnaJedinicaID)
        {
            return GetByPrimaryKey<SmjestajnaJedinica>(SmjestajnaJedinicaID);
        }
		public static SmjestajnaJedinica TryGetByPrimaryKey(int SmjestajnaJedinicaID)
        {
            return TryGetByPrimaryKey<SmjestajnaJedinica>(SmjestajnaJedinicaID);
        }
        public static SmjestajnaJedinica GetByUnique1(string SmjestajnaJedinicaSifra)
        {
            return GetByCallingParameters<SmjestajnaJedinica>(SmjestajnaJedinicaSifra);
        }
		public static SmjestajnaJedinica TryGetByUnique1(string SmjestajnaJedinicaSifra)
        {
            return TryGetByCallingParameters<SmjestajnaJedinica>(SmjestajnaJedinicaSifra);
        }
        #endregion
    }
}