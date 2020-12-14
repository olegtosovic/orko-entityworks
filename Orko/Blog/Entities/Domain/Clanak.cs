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

namespace Orko.Blog
{
    /// <summary>
    /// Clanak entity.
    /// </summary>
    public sealed partial class Clanak : Entity
    {
		#region Members
		private Kategorija m_Kategorija;
        private Sistem.Korisnik m_Korisnik;
        #endregion
        
		#region Constructors
        static Clanak()
        {
            // Cache field metadata.
            EntityMeta<Clanak>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ClanakID), @"ClanakID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(ClanakKorisnikID), @"ClanakKorisnikID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(ClanakKategorijaID), @"ClanakKategorijaID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(ClanakDatumOd), @"ClanakDatumOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(ClanakDatumDo), @"ClanakDatumDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(ClanakIstaknut), @"ClanakIstaknut", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(ClanakAktivnost), @"ClanakAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(ClanakJezik), @"ClanakJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(ClanakSlug), @"ClanakSlug", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(ClanakNaslov), @"ClanakNaslov", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(ClanakPodnaslov), @"ClanakPodnaslov", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(ClanakSadrzaj), @"ClanakSadrzaj", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(ClanakMetaTitle), @"ClanakMetaTitle", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(ClanakMetaDescription), @"ClanakMetaDescription", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(ClanakMetaSingleAlt), @"ClanakMetaSingleAlt", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(ClanakMetaListAlt), @"ClanakMetaListAlt", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Clanak>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Kategorija), nameof(ClanakKategorijaID), nameof(Orko.Blog.Kategorija.KategorijaID)),
                new RelationMetadata(nameof(Korisnik), nameof(ClanakKorisnikID), nameof(Orko.Sistem.Korisnik.KorisnikID))
			);

			// Cache table metadata.
			EntityMeta<Clanak>.HasLanguageTable = true;
            EntityMeta<Clanak>.TableSchema = @"Blog";
            EntityMeta<Clanak>.TableName = @"Clanak";
            EntityMeta<Clanak>.LanguageTableSchema = @"Blog";
            EntityMeta<Clanak>.LanguageTableName = @"Clanak_jezik";
        }
        #endregion

        #region Columns
        public int? ClanakID { get; private set; }
        public int? ClanakKorisnikID { get; set; }
        public int? ClanakKategorijaID { get; set; }
        public DateTime? ClanakDatumOd { get; set; }
        public DateTime? ClanakDatumDo { get; set; }
        public bool? ClanakIstaknut { get; set; }
        public bool? ClanakAktivnost { get; set; }
        public string ClanakJezik { get; private set; }
        public string ClanakSlug { get; set; }
        public string ClanakNaslov { get; set; }
        public string ClanakPodnaslov { get; set; }
        public string ClanakSadrzaj { get; set; }
        public string ClanakMetaTitle { get; set; }
        public string ClanakMetaDescription { get; set; }
        public string ClanakMetaSingleAlt { get; set; }
        public string ClanakMetaListAlt { get; set; }
        #endregion

        #region Entities
		public Kategorija Kategorija
        {
            get { return EntityContext<Kategorija>.Get(ref m_Kategorija, this, nameof(Kategorija)); }
            set { EntityContext<Kategorija>.Set(ref m_Kategorija, this, value, nameof(Kategorija)); }
        }
        public Sistem.Korisnik Korisnik
        {
            get { return EntityContext<Sistem.Korisnik>.Get(ref m_Korisnik, this, nameof(Korisnik)); }
            set { EntityContext<Sistem.Korisnik>.Set(ref m_Korisnik, this, value, nameof(Korisnik)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Clanak>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Clanak>(queryConditions);
        }
        public static async Task<IEnumerable<Clanak>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Clanak>(columnName, queryOp, value);
        }
		public static async Task<Clanak> GetByPrimaryKeyAsync(int ClanakID)
        {
            return await GetByPrimaryKeyAsync<Clanak>(ClanakID);
        }
		public static async Task<Clanak> TryGetByPrimaryKeyAsync(int ClanakID)
        {
            return await TryGetByPrimaryKeyAsync<Clanak>(ClanakID);
        }
		#endregion
    }
}