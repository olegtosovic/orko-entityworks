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
    /// Jahta entity.
    /// </summary>
    public sealed partial class Jahta : Entity
    {
		#region Members
		private Agencija m_Agencija;
        private VrstaJahte m_VrstaJahte;
        #endregion
        
		#region Constructors
        static Jahta()
        {
            // Cache field metadata.
            EntityMeta<Jahta>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(JahtaJahta), @"JahtaJahta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaSlug), @"JahtaSlug", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaAgencija), @"JahtaAgencija", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(JahtaLokacija), @"JahtaLokacija", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(JahtaVrstaJahte), @"JahtaVrstaJahte", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(JahtaBrojGostiju), @"JahtaBrojGostiju", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(JahtaDuljina), @"JahtaDuljina", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(JahtaSirina), @"JahtaSirina", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(JahtaBrzina), @"JahtaBrzina", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(JahtaBrojKabina), @"JahtaBrojKabina", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(JahtaMaksBrzina), @"JahtaMaksBrzina", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(JahtaGodinaGradnjeRefita), @"JahtaGodinaGradnjeRefita", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(JahtaThumbSlika), @"JahtaThumbSlika", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(JahtaAktivnost), @"JahtaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(JahtaKategorija), @"JahtaKategorija", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(JahtaVideoLink), @"JahtaVideoLink", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(JahtaJezik), @"JahtaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(JahtaNaziv), @"JahtaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(JahtaOpis), @"JahtaOpis", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(JahtaKabinaOpis), @"JahtaKabinaOpis", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(JahtaHranaOpis), @"JahtaHranaOpis", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(JahtaOpremaOpis), @"JahtaOpremaOpis", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(JahtaMetaTitle), @"JahtaMetaTitle", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(JahtaMetaDescription), @"JahtaMetaDescription", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(JahtaCijenaOpis), @"JahtaCijenaOpis", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(JahtaApaOpis), @"JahtaApaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Jahta>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Agencija), nameof(JahtaAgencija), nameof(Orko.GuletCroatia.Agencija.AgencijaAgencija)),
                new RelationMetadata(nameof(VrstaJahte), nameof(JahtaVrstaJahte), nameof(Orko.GuletCroatia.VrstaJahte.VrstaJahteVrstaJahte))
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
		public Agencija Agencija
        {
            get { return EntityContext<Agencija>.Get(ref m_Agencija, this, nameof(Agencija)); }
            set { EntityContext<Agencija>.Set(ref m_Agencija, this, value, nameof(Agencija)); }
        }
        public VrstaJahte VrstaJahte
        {
            get { return EntityContext<VrstaJahte>.Get(ref m_VrstaJahte, this, nameof(VrstaJahte)); }
            set { EntityContext<VrstaJahte>.Set(ref m_VrstaJahte, this, value, nameof(VrstaJahte)); }
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
    }
}