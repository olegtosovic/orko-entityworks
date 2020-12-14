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

namespace Orko.Turist
{
    /// <summary>
    /// SmjestajniObjekt entity.
    /// </summary>
    public sealed partial class SmjestajniObjekt : Entity
    {
		#region Members
		private Base.Drzava m_Drzava;
        private Obveznik m_Obveznik;
        private Base.Opcina m_Opcina;
        private SkupinaSmjestajnogObjekta m_SkupinaSmjestajnogObjekta;
        private VrstaCjenika m_VrstaCjenika;
        private VrstaSmjestajnogObjekta m_VrstaSmjestajnogObjekta;
        private Base.Zupanija m_Zupanija;
        #endregion
        
		#region Constructors
        static SmjestajniObjekt()
        {
            // Cache field metadata.
            EntityMeta<SmjestajniObjekt>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SmjestajniObjektSmjestajniObjekt), @"SmjestajniObjektSmjestajniObjekt", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektObveznik), @"SmjestajniObjektObveznik", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektSkupinaSmjestajnogObjekta), @"SmjestajniObjektSkupinaSmjestajnogObjekta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektVrstaSmjestajnogObjekta), @"SmjestajniObjektVrstaSmjestajnogObjekta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektNaziv), @"SmjestajniObjektNaziv", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektDrzava), @"SmjestajniObjektDrzava", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektOpcina), @"SmjestajniObjektOpcina", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektZupanija), @"SmjestajniObjektZupanija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektUlica), @"SmjestajniObjektUlica", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektKucniBroj), @"SmjestajniObjektKucniBroj", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektMjesto), @"SmjestajniObjektMjesto", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajniObjektAktivnost), @"SmjestajniObjektAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektTelefon1), @"SmjestajniObjektTelefon1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajniObjektTelefon2), @"SmjestajniObjektTelefon2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajniObjektMobitel1), @"SmjestajniObjektMobitel1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajniObjektMobitel2), @"SmjestajniObjektMobitel2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajniObjektEmail1), @"SmjestajniObjektEmail1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajniObjektEmail2), @"SmjestajniObjektEmail2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajniObjektUradio), @"SmjestajniObjektUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektDatumIzmjene), @"SmjestajniObjektDatumIzmjene", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektVrstaCjenika), @"SmjestajniObjektVrstaCjenika", DbType.String, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SmjestajniObjekt>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Drzava), nameof(SmjestajniObjektDrzava), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(Obveznik), nameof(SmjestajniObjektObveznik), nameof(Orko.Turist.Obveznik.ObveznikObveznik)),
                new RelationMetadata(nameof(Opcina), nameof(SmjestajniObjektOpcina), nameof(Orko.Base.Opcina.OpcinaOpcina)),
                new RelationMetadata(nameof(Opcina), nameof(SmjestajniObjektDrzava), nameof(Orko.Base.Opcina.OpcinaDrzava)),
                new RelationMetadata(nameof(SkupinaSmjestajnogObjekta), nameof(SmjestajniObjektSkupinaSmjestajnogObjekta), nameof(Orko.Turist.SkupinaSmjestajnogObjekta.SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta)),
                new RelationMetadata(nameof(VrstaCjenika), nameof(SmjestajniObjektVrstaCjenika), nameof(Orko.Turist.VrstaCjenika.VrstaCjenikaVrstaCjenika)),
                new RelationMetadata(nameof(VrstaSmjestajnogObjekta), nameof(SmjestajniObjektVrstaSmjestajnogObjekta), nameof(Orko.Turist.VrstaSmjestajnogObjekta.VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta)),
                new RelationMetadata(nameof(VrstaSmjestajnogObjekta), nameof(SmjestajniObjektSkupinaSmjestajnogObjekta), nameof(Orko.Turist.VrstaSmjestajnogObjekta.VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta)),
                new RelationMetadata(nameof(Zupanija), nameof(SmjestajniObjektZupanija), nameof(Orko.Base.Zupanija.ZupanijaZupanija)),
                new RelationMetadata(nameof(Zupanija), nameof(SmjestajniObjektDrzava), nameof(Orko.Base.Zupanija.ZupanijaDrzava))
			);

			// Cache table metadata.
			EntityMeta<SmjestajniObjekt>.HasLanguageTable = false;
            EntityMeta<SmjestajniObjekt>.TableSchema = @"Turist";
            EntityMeta<SmjestajniObjekt>.TableName = @"SmjestajniObjekt";
            EntityMeta<SmjestajniObjekt>.LanguageTableSchema = null;
            EntityMeta<SmjestajniObjekt>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SmjestajniObjektSmjestajniObjekt { get; private set; }
        public int? SmjestajniObjektObveznik { get; set; }
        public string SmjestajniObjektSkupinaSmjestajnogObjekta { get; set; }
        public string SmjestajniObjektVrstaSmjestajnogObjekta { get; set; }
        public string SmjestajniObjektNaziv { get; set; }
        public string SmjestajniObjektDrzava { get; set; }
        public string SmjestajniObjektOpcina { get; set; }
        public string SmjestajniObjektZupanija { get; set; }
        public string SmjestajniObjektUlica { get; set; }
        public string SmjestajniObjektKucniBroj { get; set; }
        public string SmjestajniObjektMjesto { get; set; }
        public bool? SmjestajniObjektAktivnost { get; set; }
        public string SmjestajniObjektTelefon1 { get; set; }
        public string SmjestajniObjektTelefon2 { get; set; }
        public string SmjestajniObjektMobitel1 { get; set; }
        public string SmjestajniObjektMobitel2 { get; set; }
        public string SmjestajniObjektEmail1 { get; set; }
        public string SmjestajniObjektEmail2 { get; set; }
        public string SmjestajniObjektUradio { get; set; }
        public DateTime? SmjestajniObjektDatumIzmjene { get; set; }
        public string SmjestajniObjektVrstaCjenika { get; set; }
        #endregion

        #region Entities
		public Base.Drzava Drzava
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_Drzava, this, nameof(Drzava)); }
            set { EntityContext<Base.Drzava>.Set(ref m_Drzava, this, value, nameof(Drzava)); }
        }
        public Obveznik Obveznik
        {
            get { return EntityContext<Obveznik>.Get(ref m_Obveznik, this, nameof(Obveznik)); }
            set { EntityContext<Obveznik>.Set(ref m_Obveznik, this, value, nameof(Obveznik)); }
        }
        public Base.Opcina Opcina
        {
            get { return EntityContext<Base.Opcina>.Get(ref m_Opcina, this, nameof(Opcina)); }
            set { EntityContext<Base.Opcina>.Set(ref m_Opcina, this, value, nameof(Opcina)); }
        }
        public SkupinaSmjestajnogObjekta SkupinaSmjestajnogObjekta
        {
            get { return EntityContext<SkupinaSmjestajnogObjekta>.Get(ref m_SkupinaSmjestajnogObjekta, this, nameof(SkupinaSmjestajnogObjekta)); }
            set { EntityContext<SkupinaSmjestajnogObjekta>.Set(ref m_SkupinaSmjestajnogObjekta, this, value, nameof(SkupinaSmjestajnogObjekta)); }
        }
        public VrstaCjenika VrstaCjenika
        {
            get { return EntityContext<VrstaCjenika>.Get(ref m_VrstaCjenika, this, nameof(VrstaCjenika)); }
            set { EntityContext<VrstaCjenika>.Set(ref m_VrstaCjenika, this, value, nameof(VrstaCjenika)); }
        }
        public VrstaSmjestajnogObjekta VrstaSmjestajnogObjekta
        {
            get { return EntityContext<VrstaSmjestajnogObjekta>.Get(ref m_VrstaSmjestajnogObjekta, this, nameof(VrstaSmjestajnogObjekta)); }
            set { EntityContext<VrstaSmjestajnogObjekta>.Set(ref m_VrstaSmjestajnogObjekta, this, value, nameof(VrstaSmjestajnogObjekta)); }
        }
        public Base.Zupanija Zupanija
        {
            get { return EntityContext<Base.Zupanija>.Get(ref m_Zupanija, this, nameof(Zupanija)); }
            set { EntityContext<Base.Zupanija>.Set(ref m_Zupanija, this, value, nameof(Zupanija)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SmjestajniObjekt>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SmjestajniObjekt>(queryConditions);
        }
        public static async Task<IEnumerable<SmjestajniObjekt>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SmjestajniObjekt>(columnName, queryOp, value);
        }
		public static async Task<SmjestajniObjekt> GetByPrimaryKeyAsync(int SmjestajniObjektSmjestajniObjekt)
        {
            return await GetByPrimaryKeyAsync<SmjestajniObjekt>(SmjestajniObjektSmjestajniObjekt);
        }
		public static async Task<SmjestajniObjekt> TryGetByPrimaryKeyAsync(int SmjestajniObjektSmjestajniObjekt)
        {
            return await TryGetByPrimaryKeyAsync<SmjestajniObjekt>(SmjestajniObjektSmjestajniObjekt);
        }
		#endregion
    }
}