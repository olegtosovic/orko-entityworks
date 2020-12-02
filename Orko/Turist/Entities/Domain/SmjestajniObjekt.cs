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

namespace Orko.Turist
{
    /// <summary>
    /// SmjestajniObjekt entity.
    /// </summary>
    public sealed partial class SmjestajniObjekt : Entity
    {
		#region Members
		private Base.Drzava m_FK_SmjestajniObjekt_Drzava;
        private Obveznik m_FK_SmjestajniObjekt_Obveznik;
        private Base.Opcina m_FK_SmjestajniObjekt_Opcina;
        private SkupinaSmjestajnogObjekta m_FK_SmjestajniObjekt_SkupinaSmjestajnogObjekta;
        private VrstaCjenika m_FK_SmjestajniObjekt_VrstaCjenika;
        private VrstaSmjestajnogObjekta m_FK_SmjestajniObjekt_VrstaSmjestajnogObjekta;
        private Base.Zupanija m_FK_SmjestajniObjekt_Zupanija;
        #endregion
        
		#region Constructors
        static SmjestajniObjekt()
        {
            // Cache field metadata.
            EntityMeta<SmjestajniObjekt>.LoadColumnMetadata
			(
				new ColumnMetadata("SmjestajniObjektSmjestajniObjekt", @"SmjestajniObjektSmjestajniObjekt", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("SmjestajniObjektObveznik", @"SmjestajniObjektObveznik", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("SmjestajniObjektSkupinaSmjestajnogObjekta", @"SmjestajniObjektSkupinaSmjestajnogObjekta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajniObjektVrstaSmjestajnogObjekta", @"SmjestajniObjektVrstaSmjestajnogObjekta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajniObjektNaziv", @"SmjestajniObjektNaziv", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajniObjektDrzava", @"SmjestajniObjektDrzava", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("SmjestajniObjektOpcina", @"SmjestajniObjektOpcina", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajniObjektZupanija", @"SmjestajniObjektZupanija", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajniObjektUlica", @"SmjestajniObjektUlica", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajniObjektKucniBroj", @"SmjestajniObjektKucniBroj", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajniObjektMjesto", @"SmjestajniObjektMjesto", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajniObjektAktivnost", @"SmjestajniObjektAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("SmjestajniObjektTelefon1", @"SmjestajniObjektTelefon1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajniObjektTelefon2", @"SmjestajniObjektTelefon2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajniObjektMobitel1", @"SmjestajniObjektMobitel1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajniObjektMobitel2", @"SmjestajniObjektMobitel2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajniObjektEmail1", @"SmjestajniObjektEmail1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajniObjektEmail2", @"SmjestajniObjektEmail2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajniObjektUradio", @"SmjestajniObjektUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajniObjektDatumIzmjene", @"SmjestajniObjektDatumIzmjene", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("SmjestajniObjektVrstaCjenika", @"SmjestajniObjektVrstaCjenika", SqlDbType.NVarChar, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SmjestajniObjekt>.LoadRelationMetadata
			(
				new RelationMetadata("FK_SmjestajniObjekt_Drzava", "SmjestajniObjektDrzava", "DrzavaDrzava"),
                new RelationMetadata("FK_SmjestajniObjekt_Obveznik", "SmjestajniObjektObveznik", "ObveznikObveznik"),
                new RelationMetadata("FK_SmjestajniObjekt_Opcina", "SmjestajniObjektOpcina", "OpcinaOpcina"),
                new RelationMetadata("FK_SmjestajniObjekt_Opcina", "SmjestajniObjektDrzava", "OpcinaDrzava"),
                new RelationMetadata("FK_SmjestajniObjekt_SkupinaSmjestajnogObjekta", "SmjestajniObjektSkupinaSmjestajnogObjekta", "SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta"),
                new RelationMetadata("FK_SmjestajniObjekt_VrstaCjenika", "SmjestajniObjektVrstaCjenika", "VrstaCjenikaVrstaCjenika"),
                new RelationMetadata("FK_SmjestajniObjekt_VrstaSmjestajnogObjekta", "SmjestajniObjektVrstaSmjestajnogObjekta", "VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta"),
                new RelationMetadata("FK_SmjestajniObjekt_VrstaSmjestajnogObjekta", "SmjestajniObjektSkupinaSmjestajnogObjekta", "VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta"),
                new RelationMetadata("FK_SmjestajniObjekt_Zupanija", "SmjestajniObjektZupanija", "ZupanijaZupanija"),
                new RelationMetadata("FK_SmjestajniObjekt_Zupanija", "SmjestajniObjektDrzava", "ZupanijaDrzava")
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
		public Base.Drzava FK_SmjestajniObjekt_Drzava
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_FK_SmjestajniObjekt_Drzava, this, "FK_SmjestajniObjekt_Drzava"); }
            set { EntityContext<Base.Drzava>.Set(ref m_FK_SmjestajniObjekt_Drzava, this, value, "FK_SmjestajniObjekt_Drzava"); }
        }
        public Obveznik FK_SmjestajniObjekt_Obveznik
        {
            get { return EntityContext<Obveznik>.Get(ref m_FK_SmjestajniObjekt_Obveznik, this, "FK_SmjestajniObjekt_Obveznik"); }
            set { EntityContext<Obveznik>.Set(ref m_FK_SmjestajniObjekt_Obveznik, this, value, "FK_SmjestajniObjekt_Obveznik"); }
        }
        public Base.Opcina FK_SmjestajniObjekt_Opcina
        {
            get { return EntityContext<Base.Opcina>.Get(ref m_FK_SmjestajniObjekt_Opcina, this, "FK_SmjestajniObjekt_Opcina"); }
            set { EntityContext<Base.Opcina>.Set(ref m_FK_SmjestajniObjekt_Opcina, this, value, "FK_SmjestajniObjekt_Opcina"); }
        }
        public SkupinaSmjestajnogObjekta FK_SmjestajniObjekt_SkupinaSmjestajnogObjekta
        {
            get { return EntityContext<SkupinaSmjestajnogObjekta>.Get(ref m_FK_SmjestajniObjekt_SkupinaSmjestajnogObjekta, this, "FK_SmjestajniObjekt_SkupinaSmjestajnogObjekta"); }
            set { EntityContext<SkupinaSmjestajnogObjekta>.Set(ref m_FK_SmjestajniObjekt_SkupinaSmjestajnogObjekta, this, value, "FK_SmjestajniObjekt_SkupinaSmjestajnogObjekta"); }
        }
        public VrstaCjenika FK_SmjestajniObjekt_VrstaCjenika
        {
            get { return EntityContext<VrstaCjenika>.Get(ref m_FK_SmjestajniObjekt_VrstaCjenika, this, "FK_SmjestajniObjekt_VrstaCjenika"); }
            set { EntityContext<VrstaCjenika>.Set(ref m_FK_SmjestajniObjekt_VrstaCjenika, this, value, "FK_SmjestajniObjekt_VrstaCjenika"); }
        }
        public VrstaSmjestajnogObjekta FK_SmjestajniObjekt_VrstaSmjestajnogObjekta
        {
            get { return EntityContext<VrstaSmjestajnogObjekta>.Get(ref m_FK_SmjestajniObjekt_VrstaSmjestajnogObjekta, this, "FK_SmjestajniObjekt_VrstaSmjestajnogObjekta"); }
            set { EntityContext<VrstaSmjestajnogObjekta>.Set(ref m_FK_SmjestajniObjekt_VrstaSmjestajnogObjekta, this, value, "FK_SmjestajniObjekt_VrstaSmjestajnogObjekta"); }
        }
        public Base.Zupanija FK_SmjestajniObjekt_Zupanija
        {
            get { return EntityContext<Base.Zupanija>.Get(ref m_FK_SmjestajniObjekt_Zupanija, this, "FK_SmjestajniObjekt_Zupanija"); }
            set { EntityContext<Base.Zupanija>.Set(ref m_FK_SmjestajniObjekt_Zupanija, this, value, "FK_SmjestajniObjekt_Zupanija"); }
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

        #region Public methods
		public static IEnumerable<SmjestajniObjekt> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<SmjestajniObjekt>(queryConditions);
        }
        public static IEnumerable<SmjestajniObjekt> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<SmjestajniObjekt>(columnName, queryOp, value);
        }
		public static SmjestajniObjekt GetByPrimaryKey(int SmjestajniObjektSmjestajniObjekt)
        {
            return GetByPrimaryKey<SmjestajniObjekt>(SmjestajniObjektSmjestajniObjekt);
        }
		public static SmjestajniObjekt TryGetByPrimaryKey(int SmjestajniObjektSmjestajniObjekt)
        {
            return TryGetByPrimaryKey<SmjestajniObjekt>(SmjestajniObjektSmjestajniObjekt);
        }
        #endregion
    }
}