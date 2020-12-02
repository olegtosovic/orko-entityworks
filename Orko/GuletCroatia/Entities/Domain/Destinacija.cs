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
				new ColumnMetadata("DestinacijaDestinacija", @"DestinacijaDestinacija", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("DestinacijaSlug", @"DestinacijaSlug", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("DestinacijaPlaces", @"DestinacijaPlaces", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("DestinacijaHeaderImage", @"DestinacijaHeaderImage", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("DestinacijaThumbImage", @"DestinacijaThumbImage", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("DestinacijaContentImage", @"DestinacijaContentImage", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("DestinacijaMapImage", @"DestinacijaMapImage", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("DestinacijaIstaknuta", @"DestinacijaIstaknuta", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("DestinacijaAktivnost", @"DestinacijaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("DestinacijaLatitude", @"DestinacijaLatitude", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("DestinacijaLongitude", @"DestinacijaLongitude", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("DestinacijaZoomLevel", @"DestinacijaZoomLevel", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("DestinacijaJezik", @"DestinacijaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("DestinacijaNaziv", @"DestinacijaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("DestinacijaTekst", @"DestinacijaTekst", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("DestinacijaTitle", @"DestinacijaTitle", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("DestinacijaVisit", @"DestinacijaVisit", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("DestinacijaMetaTitle", @"DestinacijaMetaTitle", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("DestinacijaMetaDescription", @"DestinacijaMetaDescription", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
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

        #region Public methods
		public static IEnumerable<Destinacija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Destinacija>(queryConditions);
        }
        public static IEnumerable<Destinacija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Destinacija>(columnName, queryOp, value);
        }
		public static Destinacija GetByPrimaryKey(string DestinacijaDestinacija)
        {
            return GetByPrimaryKey<Destinacija>(DestinacijaDestinacija);
        }
		public static Destinacija TryGetByPrimaryKey(string DestinacijaDestinacija)
        {
            return TryGetByPrimaryKey<Destinacija>(DestinacijaDestinacija);
        }
        public static Destinacija GetByUnique1(string DestinacijaSlug)
        {
            return GetByCallingParameters<Destinacija>(DestinacijaSlug);
        }
		public static Destinacija TryGetByUnique1(string DestinacijaSlug)
        {
            return TryGetByCallingParameters<Destinacija>(DestinacijaSlug);
        }
        #endregion
    }
}