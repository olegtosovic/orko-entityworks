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
    /// Destinacija entity.
    /// </summary>
    public sealed partial class Destinacija : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Destinacija()
        {
            // Cache field metadata.
            EntityMeta<Destinacija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(DestinacijaDestinacija), @"DestinacijaDestinacija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(DestinacijaSlug), @"DestinacijaSlug", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(DestinacijaPlaces), @"DestinacijaPlaces", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(DestinacijaHeaderImage), @"DestinacijaHeaderImage", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(DestinacijaThumbImage), @"DestinacijaThumbImage", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(DestinacijaContentImage), @"DestinacijaContentImage", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(DestinacijaMapImage), @"DestinacijaMapImage", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(DestinacijaIstaknuta), @"DestinacijaIstaknuta", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(DestinacijaAktivnost), @"DestinacijaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(DestinacijaLatitude), @"DestinacijaLatitude", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(DestinacijaLongitude), @"DestinacijaLongitude", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(DestinacijaZoomLevel), @"DestinacijaZoomLevel", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(DestinacijaJezik), @"DestinacijaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(DestinacijaNaziv), @"DestinacijaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(DestinacijaTekst), @"DestinacijaTekst", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(DestinacijaTitle), @"DestinacijaTitle", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(DestinacijaVisit), @"DestinacijaVisit", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(DestinacijaMetaTitle), @"DestinacijaMetaTitle", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(DestinacijaMetaDescription), @"DestinacijaMetaDescription", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Destinacija>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Destinacija>.HasLanguageTable = true;
            EntityMeta<Destinacija>.TableSchema = @"GuletCroatia";
            EntityMeta<Destinacija>.TableName = @"Destinacija";
            EntityMeta<Destinacija>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<Destinacija>.LanguageTableName = @"Destinacija_jezik";
        }
        #endregion

        #region Columns
        public string DestinacijaDestinacija { get; set; }
        public string DestinacijaSlug { get; set; }
        public string DestinacijaPlaces { get; set; }
        public string DestinacijaHeaderImage { get; set; }
        public string DestinacijaThumbImage { get; set; }
        public string DestinacijaContentImage { get; set; }
        public string DestinacijaMapImage { get; set; }
        public bool? DestinacijaIstaknuta { get; set; }
        public bool? DestinacijaAktivnost { get; set; }
        public decimal? DestinacijaLatitude { get; set; }
        public decimal? DestinacijaLongitude { get; set; }
        public int? DestinacijaZoomLevel { get; set; }
        public string DestinacijaJezik { get; private set; }
        public string DestinacijaNaziv { get; set; }
        public string DestinacijaTekst { get; set; }
        public string DestinacijaTitle { get; set; }
        public string DestinacijaVisit { get; set; }
        public string DestinacijaMetaTitle { get; set; }
        public string DestinacijaMetaDescription { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Destinacija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Destinacija>(queryConditions);
        }
        public static async Task<IEnumerable<Destinacija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Destinacija>(columnName, queryOp, value);
        }
		public static async Task<Destinacija> GetByPrimaryKeyAsync(string DestinacijaDestinacija)
        {
            return await GetByPrimaryKeyAsync<Destinacija>(DestinacijaDestinacija);
        }
		public static async Task<Destinacija> TryGetByPrimaryKeyAsync(string DestinacijaDestinacija)
        {
            return await TryGetByPrimaryKeyAsync<Destinacija>(DestinacijaDestinacija);
        }
		#endregion
    }
}