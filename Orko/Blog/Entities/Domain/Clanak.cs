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

namespace Orko.Blog
{
    /// <summary>
    /// Clanak entity.
    /// </summary>
    public sealed partial class Clanak : Entity
    {
		#region Members
		private Kategorija m_FK_Clanak_Kategorija;
        private Sistem.Korisnik m_FK_Clanak_Korisnik;
        #endregion
        
		#region Constructors
        static Clanak()
        {
            // Cache field metadata.
            EntityMeta<Clanak>.LoadColumnMetadata
			(
				new ColumnMetadata("ClanakID", @"ClanakID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("ClanakKorisnikID", @"ClanakKorisnikID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("ClanakKategorijaID", @"ClanakKategorijaID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("ClanakDatumOd", @"ClanakDatumOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("ClanakDatumDo", @"ClanakDatumDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("ClanakIstaknut", @"ClanakIstaknut", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("ClanakAktivnost", @"ClanakAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("ClanakJezik", @"ClanakJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("ClanakSlug", @"ClanakSlug", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("ClanakNaslov", @"ClanakNaslov", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("ClanakPodnaslov", @"ClanakPodnaslov", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("ClanakSadrzaj", @"ClanakSadrzaj", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("ClanakMetaTitle", @"ClanakMetaTitle", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("ClanakMetaDescription", @"ClanakMetaDescription", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("ClanakMetaSingleAlt", @"ClanakMetaSingleAlt", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("ClanakMetaListAlt", @"ClanakMetaListAlt", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Clanak>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Clanak_Kategorija", "ClanakKategorijaID", "KategorijaID"),
                new RelationMetadata("FK_Clanak_Korisnik", "ClanakKorisnikID", "KorisnikID")
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
		public Kategorija FK_Clanak_Kategorija
        {
            get { return EntityContext<Kategorija>.Get(ref m_FK_Clanak_Kategorija, this, "FK_Clanak_Kategorija"); }
            set { EntityContext<Kategorija>.Set(ref m_FK_Clanak_Kategorija, this, value, "FK_Clanak_Kategorija"); }
        }
        public Sistem.Korisnik FK_Clanak_Korisnik
        {
            get { return EntityContext<Sistem.Korisnik>.Get(ref m_FK_Clanak_Korisnik, this, "FK_Clanak_Korisnik"); }
            set { EntityContext<Sistem.Korisnik>.Set(ref m_FK_Clanak_Korisnik, this, value, "FK_Clanak_Korisnik"); }
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

        #region Public methods
		public static IEnumerable<Clanak> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Clanak>(queryConditions);
        }
        public static IEnumerable<Clanak> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Clanak>(columnName, queryOp, value);
        }
		public static Clanak GetByPrimaryKey(int ClanakID)
        {
            return GetByPrimaryKey<Clanak>(ClanakID);
        }
		public static Clanak TryGetByPrimaryKey(int ClanakID)
        {
            return TryGetByPrimaryKey<Clanak>(ClanakID);
        }
        #endregion
    }
}