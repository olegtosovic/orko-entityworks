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
    /// Jahta entity.
    /// </summary>
    public sealed partial class Jahta : Entity
    {
		#region Members
		private Agencija m_FK_Jahta_Agencija;
        private VrstaJahte m_FK_Jahta_VrstaJahte;
        #endregion
        
		#region Constructors
        static Jahta()
        {
            // Cache field metadata.
            EntityMeta<Jahta>.LoadColumnMetadata
			(
				new ColumnMetadata("JahtaJahta", @"JahtaJahta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaSlug", @"JahtaSlug", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("JahtaAgencija", @"JahtaAgencija", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("JahtaLokacija", @"JahtaLokacija", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("JahtaVrstaJahte", @"JahtaVrstaJahte", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("JahtaBrojGostiju", @"JahtaBrojGostiju", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("JahtaDuljina", @"JahtaDuljina", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("JahtaSirina", @"JahtaSirina", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("JahtaBrzina", @"JahtaBrzina", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("JahtaBrojKabina", @"JahtaBrojKabina", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("JahtaMaksBrzina", @"JahtaMaksBrzina", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("JahtaGodinaGradnjeRefita", @"JahtaGodinaGradnjeRefita", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("JahtaThumbSlika", @"JahtaThumbSlika", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("JahtaAktivnost", @"JahtaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("JahtaKategorija", @"JahtaKategorija", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("JahtaVideoLink", @"JahtaVideoLink", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("JahtaJezik", @"JahtaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("JahtaNaziv", @"JahtaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("JahtaOpis", @"JahtaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("JahtaKabinaOpis", @"JahtaKabinaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("JahtaHranaOpis", @"JahtaHranaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("JahtaOpremaOpis", @"JahtaOpremaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("JahtaMetaTitle", @"JahtaMetaTitle", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("JahtaMetaDescription", @"JahtaMetaDescription", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("JahtaCijenaOpis", @"JahtaCijenaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("JahtaApaOpis", @"JahtaApaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Jahta>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Jahta_Agencija", "JahtaAgencija", "AgencijaAgencija"),
                new RelationMetadata("FK_Jahta_VrstaJahte", "JahtaVrstaJahte", "VrstaJahteVrstaJahte")
			);

			// Cache table metadata.
			EntityMeta<Jahta>.HasLanguageTable = true;
            EntityMeta<Jahta>.TableSchema = @"GuletCroatia";
            EntityMeta<Jahta>.TableName = @"Jahta";
            EntityMeta<Jahta>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<Jahta>.LanguageTableName = @"Jahta_jezik";
        }
        #endregion

        #region Columns
        public string JahtaJahta { get; set; }
        public string JahtaSlug { get; set; }
        public string JahtaAgencija { get; set; }
        public string JahtaLokacija { get; set; }
        public string JahtaVrstaJahte { get; set; }
        public int? JahtaBrojGostiju { get; set; }
        public decimal? JahtaDuljina { get; set; }
        public decimal? JahtaSirina { get; set; }
        public decimal? JahtaBrzina { get; set; }
        public int? JahtaBrojKabina { get; set; }
        public decimal? JahtaMaksBrzina { get; set; }
        public int? JahtaGodinaGradnjeRefita { get; set; }
        public string JahtaThumbSlika { get; set; }
        public bool? JahtaAktivnost { get; set; }
        public int? JahtaKategorija { get; set; }
        public string JahtaVideoLink { get; set; }
        public string JahtaJezik { get; private set; }
        public string JahtaNaziv { get; set; }
        public string JahtaOpis { get; set; }
        public string JahtaKabinaOpis { get; set; }
        public string JahtaHranaOpis { get; set; }
        public string JahtaOpremaOpis { get; set; }
        public string JahtaMetaTitle { get; set; }
        public string JahtaMetaDescription { get; set; }
        public string JahtaCijenaOpis { get; set; }
        public string JahtaApaOpis { get; set; }
        #endregion

        #region Entities
		public Agencija FK_Jahta_Agencija
        {
            get { return EntityContext<Agencija>.Get(ref m_FK_Jahta_Agencija, this, "FK_Jahta_Agencija"); }
            set { EntityContext<Agencija>.Set(ref m_FK_Jahta_Agencija, this, value, "FK_Jahta_Agencija"); }
        }
        public VrstaJahte FK_Jahta_VrstaJahte
        {
            get { return EntityContext<VrstaJahte>.Get(ref m_FK_Jahta_VrstaJahte, this, "FK_Jahta_VrstaJahte"); }
            set { EntityContext<VrstaJahte>.Set(ref m_FK_Jahta_VrstaJahte, this, value, "FK_Jahta_VrstaJahte"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Jahta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Jahta>(queryConditions);
        }
        public static async Task<IEnumerable<Jahta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Jahta>(columnName, queryOp, value);
        }
		public static async Task<Jahta> GetByPrimaryKeyAsync(string JahtaJahta)
        {
            return await GetByPrimaryKeyAsync<Jahta>(JahtaJahta);
        }
		public static async Task<Jahta> TryGetByPrimaryKeyAsync(string JahtaJahta)
        {
            return await TryGetByPrimaryKeyAsync<Jahta>(JahtaJahta);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Jahta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Jahta>(queryConditions);
        }
        public static IEnumerable<Jahta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Jahta>(columnName, queryOp, value);
        }
		public static Jahta GetByPrimaryKey(string JahtaJahta)
        {
            return GetByPrimaryKey<Jahta>(JahtaJahta);
        }
		public static Jahta TryGetByPrimaryKey(string JahtaJahta)
        {
            return TryGetByPrimaryKey<Jahta>(JahtaJahta);
        }
        public static Jahta GetByUnique1(string JahtaSlug)
        {
            return GetByCallingParameters<Jahta>(JahtaSlug);
        }
		public static Jahta TryGetByUnique1(string JahtaSlug)
        {
            return TryGetByCallingParameters<Jahta>(JahtaSlug);
        }
        #endregion
    }
}