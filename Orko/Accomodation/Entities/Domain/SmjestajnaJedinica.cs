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
				new ColumnMetadata(nameof(SmjestajnaJedinicaID), @"SmjestajnaJedinicaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaSifra), @"SmjestajnaJedinicaSifra", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaBrojOsoba), @"SmjestajnaJedinicaBrojOsoba", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaKategorija), @"SmjestajnaJedinicaKategorija", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaModul), @"SmjestajnaJedinicaModul", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaDrzava), @"SmjestajnaJedinicaDrzava", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaOpcina), @"SmjestajnaJedinicaOpcina", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaUlica), @"SmjestajnaJedinicaUlica", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaKucniBroj), @"SmjestajnaJedinicaKucniBroj", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaGoogleMapsLink), @"SmjestajnaJedinicaGoogleMapsLink", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaKrevetnaDeklaracija), @"SmjestajnaJedinicaKrevetnaDeklaracija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaBrojDoubleBed), @"SmjestajnaJedinicaBrojDoubleBed", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaBrojSingleBed), @"SmjestajnaJedinicaBrojSingleBed", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaBrojSofaBed), @"SmjestajnaJedinicaBrojSofaBed", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaBrojExtraBed), @"SmjestajnaJedinicaBrojExtraBed", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaAktivnost), @"SmjestajnaJedinicaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaJezik), @"SmjestajnaJedinicaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaSlug), @"SmjestajnaJedinicaSlug", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaNaziv), @"SmjestajnaJedinicaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaPodnaziv), @"SmjestajnaJedinicaPodnaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaOpis), @"SmjestajnaJedinicaOpis", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaAdresa), @"SmjestajnaJedinicaAdresa", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaMetaTitle), @"SmjestajnaJedinicaMetaTitle", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaMetaDescription), @"SmjestajnaJedinicaMetaDescription", DbType.String, isRequired: true, isLanguage: true)
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
    }
}