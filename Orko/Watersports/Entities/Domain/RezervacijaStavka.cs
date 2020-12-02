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

namespace Orko.Watersports
{
    /// <summary>
    /// RezervacijaStavka entity.
    /// </summary>
    public sealed partial class RezervacijaStavka : Entity
    {
		#region Members
		private Brod m_FK_RezervacijaStavka_Brod;
        private Base.Evidencija m_FK_RezervacijaStavka_Evidencija;
        private Lokacija2 m_FK_RezervacijaStavka_Lokacija2;
        private PrometnaKartica m_FK_RezervacijaStavka_PrometnaKartica;
        private Rezervacija m_FK_RezervacijaStavka_Rezervacija;
        private Termin m_FK_RezervacijaStavka_Termin;
        private TipRezervacije m_FK_RezervacijaStavka_TipRezervacije;
        private VrstaIzleta m_FK_RezervacijaStavka_VrstaIzleta;
        private VrstaUsluge m_FK_RezervacijaStavka_VrstaUsluge;
        #endregion
        
		#region Constructors
        static RezervacijaStavka()
        {
            // Cache field metadata.
            EntityMeta<RezervacijaStavka>.LoadColumnMetadata
			(
				new ColumnMetadata("RezervacijaStavkaID", @"RezervacijaStavkaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("RezervacijaStavkaProtokolID", @"RezervacijaStavkaProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaPrometnaKarticaID", @"RezervacijaStavkaPrometnaKarticaID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaRedniBroj", @"RezervacijaStavkaRedniBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaBrod", @"RezervacijaStavkaBrod", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaVrstaUsluge", @"RezervacijaStavkaVrstaUsluge", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaVrstaIzleta", @"RezervacijaStavkaVrstaIzleta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaTipRezervacije", @"RezervacijaStavkaTipRezervacije", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaDatumUsluge", @"RezervacijaStavkaDatumUsluge", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaTerminID", @"RezervacijaStavkaTerminID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaDatumVrijemeOd", @"RezervacijaStavkaDatumVrijemeOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaDatumVrijemeDo", @"RezervacijaStavkaDatumVrijemeDo", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaVrijemeOd", @"RezervacijaStavkaVrijemeOd", SqlDbType.Time, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaVrijemeDo", @"RezervacijaStavkaVrijemeDo", SqlDbType.Time, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaTrajanje", @"RezervacijaStavkaTrajanje", SqlDbType.Time, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaBrojOdraslih", @"RezervacijaStavkaBrojOdraslih", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaBrojDjece", @"RezervacijaStavkaBrojDjece", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaBrojOsobaStvarno", @"RezervacijaStavkaBrojOsobaStvarno", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaBrojOsobaKalkulativno", @"RezervacijaStavkaBrojOsobaKalkulativno", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaSkiperUkljucen", @"RezervacijaStavkaSkiperUkljucen", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaGorivoUkljuceno", @"RezervacijaStavkaGorivoUkljuceno", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaPickupLokacija", @"RezervacijaStavkaPickupLokacija", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaCijenaUslugeCjenik", @"RezervacijaStavkaCijenaUslugeCjenik", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaCijenaUslugePopustPostotak", @"RezervacijaStavkaCijenaUslugePopustPostotak", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaCijenaUslugePopustIznos", @"RezervacijaStavkaCijenaUslugePopustIznos", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaCijenaUslugeKonacno", @"RezervacijaStavkaCijenaUslugeKonacno", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaCijenaUslugeNaplaceno", @"RezervacijaStavkaCijenaUslugeNaplaceno", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaNapomena", @"RezervacijaStavkaNapomena", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaEvidencijaID", @"RezervacijaStavkaEvidencijaID", SqlDbType.Int, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<RezervacijaStavka>.LoadRelationMetadata
			(
				new RelationMetadata("FK_RezervacijaStavka_Brod", "RezervacijaStavkaBrod", "BrodBrod"),
                new RelationMetadata("FK_RezervacijaStavka_Evidencija", "RezervacijaStavkaEvidencijaID", "EvidencijaID"),
                new RelationMetadata("FK_RezervacijaStavka_Lokacija2", "RezervacijaStavkaPickupLokacija", "LokacijaID"),
                new RelationMetadata("FK_RezervacijaStavka_PrometnaKartica", "RezervacijaStavkaPrometnaKarticaID", "PrometnaKarticaProtokolID"),
                new RelationMetadata("FK_RezervacijaStavka_Rezervacija", "RezervacijaStavkaProtokolID", "RezervacijaProtokolID"),
                new RelationMetadata("FK_RezervacijaStavka_Termin", "RezervacijaStavkaTerminID", "TerminID"),
                new RelationMetadata("FK_RezervacijaStavka_TipRezervacije", "RezervacijaStavkaTipRezervacije", "TipRezervacijeTipRezervacije"),
                new RelationMetadata("FK_RezervacijaStavka_VrstaIzleta", "RezervacijaStavkaVrstaIzleta", "VrstaIzletaVrstaIzleta"),
                new RelationMetadata("FK_RezervacijaStavka_VrstaUsluge", "RezervacijaStavkaVrstaUsluge", "VrstaUslugeVrstaUsluge")
			);

			// Cache table metadata.
			EntityMeta<RezervacijaStavka>.HasLanguageTable = false;
            EntityMeta<RezervacijaStavka>.TableSchema = @"Watersports";
            EntityMeta<RezervacijaStavka>.TableName = @"RezervacijaStavka";
            EntityMeta<RezervacijaStavka>.LanguageTableSchema = null;
            EntityMeta<RezervacijaStavka>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? RezervacijaStavkaID { get; private set; }
        public int? RezervacijaStavkaProtokolID { get; set; }
        public int? RezervacijaStavkaPrometnaKarticaID { get; set; }
        public int? RezervacijaStavkaRedniBroj { get; set; }
        public int? RezervacijaStavkaBrod { get; set; }
        public string RezervacijaStavkaVrstaUsluge { get; set; }
        public string RezervacijaStavkaVrstaIzleta { get; set; }
        public string RezervacijaStavkaTipRezervacije { get; set; }
        public DateTime? RezervacijaStavkaDatumUsluge { get; set; }
        public int? RezervacijaStavkaTerminID { get; set; }
        public DateTime? RezervacijaStavkaDatumVrijemeOd { get; set; }
        public DateTime? RezervacijaStavkaDatumVrijemeDo { get; set; }
        public TimeSpan? RezervacijaStavkaVrijemeOd { get; set; }
        public TimeSpan? RezervacijaStavkaVrijemeDo { get; set; }
        public TimeSpan? RezervacijaStavkaTrajanje { get; set; }
        public int? RezervacijaStavkaBrojOdraslih { get; set; }
        public int? RezervacijaStavkaBrojDjece { get; set; }
        public int? RezervacijaStavkaBrojOsobaStvarno { get; set; }
        public int? RezervacijaStavkaBrojOsobaKalkulativno { get; set; }
        public bool? RezervacijaStavkaSkiperUkljucen { get; set; }
        public bool? RezervacijaStavkaGorivoUkljuceno { get; set; }
        public int? RezervacijaStavkaPickupLokacija { get; set; }
        public decimal? RezervacijaStavkaCijenaUslugeCjenik { get; set; }
        public decimal? RezervacijaStavkaCijenaUslugePopustPostotak { get; set; }
        public decimal? RezervacijaStavkaCijenaUslugePopustIznos { get; set; }
        public decimal? RezervacijaStavkaCijenaUslugeKonacno { get; set; }
        public decimal? RezervacijaStavkaCijenaUslugeNaplaceno { get; set; }
        public string RezervacijaStavkaNapomena { get; set; }
        public int? RezervacijaStavkaEvidencijaID { get; set; }
        #endregion

        #region Entities
		public Brod FK_RezervacijaStavka_Brod
        {
            get { return EntityContext<Brod>.Get(ref m_FK_RezervacijaStavka_Brod, this, "FK_RezervacijaStavka_Brod"); }
            set { EntityContext<Brod>.Set(ref m_FK_RezervacijaStavka_Brod, this, value, "FK_RezervacijaStavka_Brod"); }
        }
        public Base.Evidencija FK_RezervacijaStavka_Evidencija
        {
            get { return EntityContext<Base.Evidencija>.Get(ref m_FK_RezervacijaStavka_Evidencija, this, "FK_RezervacijaStavka_Evidencija"); }
            set { EntityContext<Base.Evidencija>.Set(ref m_FK_RezervacijaStavka_Evidencija, this, value, "FK_RezervacijaStavka_Evidencija"); }
        }
        public Lokacija2 FK_RezervacijaStavka_Lokacija2
        {
            get { return EntityContext<Lokacija2>.Get(ref m_FK_RezervacijaStavka_Lokacija2, this, "FK_RezervacijaStavka_Lokacija2"); }
            set { EntityContext<Lokacija2>.Set(ref m_FK_RezervacijaStavka_Lokacija2, this, value, "FK_RezervacijaStavka_Lokacija2"); }
        }
        public PrometnaKartica FK_RezervacijaStavka_PrometnaKartica
        {
            get { return EntityContext<PrometnaKartica>.Get(ref m_FK_RezervacijaStavka_PrometnaKartica, this, "FK_RezervacijaStavka_PrometnaKartica"); }
            set { EntityContext<PrometnaKartica>.Set(ref m_FK_RezervacijaStavka_PrometnaKartica, this, value, "FK_RezervacijaStavka_PrometnaKartica"); }
        }
        public Rezervacija FK_RezervacijaStavka_Rezervacija
        {
            get { return EntityContext<Rezervacija>.Get(ref m_FK_RezervacijaStavka_Rezervacija, this, "FK_RezervacijaStavka_Rezervacija"); }
            set { EntityContext<Rezervacija>.Set(ref m_FK_RezervacijaStavka_Rezervacija, this, value, "FK_RezervacijaStavka_Rezervacija"); }
        }
        public Termin FK_RezervacijaStavka_Termin
        {
            get { return EntityContext<Termin>.Get(ref m_FK_RezervacijaStavka_Termin, this, "FK_RezervacijaStavka_Termin"); }
            set { EntityContext<Termin>.Set(ref m_FK_RezervacijaStavka_Termin, this, value, "FK_RezervacijaStavka_Termin"); }
        }
        public TipRezervacije FK_RezervacijaStavka_TipRezervacije
        {
            get { return EntityContext<TipRezervacije>.Get(ref m_FK_RezervacijaStavka_TipRezervacije, this, "FK_RezervacijaStavka_TipRezervacije"); }
            set { EntityContext<TipRezervacije>.Set(ref m_FK_RezervacijaStavka_TipRezervacije, this, value, "FK_RezervacijaStavka_TipRezervacije"); }
        }
        public VrstaIzleta FK_RezervacijaStavka_VrstaIzleta
        {
            get { return EntityContext<VrstaIzleta>.Get(ref m_FK_RezervacijaStavka_VrstaIzleta, this, "FK_RezervacijaStavka_VrstaIzleta"); }
            set { EntityContext<VrstaIzleta>.Set(ref m_FK_RezervacijaStavka_VrstaIzleta, this, value, "FK_RezervacijaStavka_VrstaIzleta"); }
        }
        public VrstaUsluge FK_RezervacijaStavka_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_RezervacijaStavka_VrstaUsluge, this, "FK_RezervacijaStavka_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_RezervacijaStavka_VrstaUsluge, this, value, "FK_RezervacijaStavka_VrstaUsluge"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<RezervacijaStavka>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<RezervacijaStavka>(queryConditions);
        }
        public static async Task<IEnumerable<RezervacijaStavka>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<RezervacijaStavka>(columnName, queryOp, value);
        }
		public static async Task<RezervacijaStavka> GetByPrimaryKeyAsync(int RezervacijaStavkaID)
        {
            return await GetByPrimaryKeyAsync<RezervacijaStavka>(RezervacijaStavkaID);
        }
		public static async Task<RezervacijaStavka> TryGetByPrimaryKeyAsync(int RezervacijaStavkaID)
        {
            return await TryGetByPrimaryKeyAsync<RezervacijaStavka>(RezervacijaStavkaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<RezervacijaStavka> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<RezervacijaStavka>(queryConditions);
        }
        public static IEnumerable<RezervacijaStavka> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<RezervacijaStavka>(columnName, queryOp, value);
        }
		public static RezervacijaStavka GetByPrimaryKey(int RezervacijaStavkaID)
        {
            return GetByPrimaryKey<RezervacijaStavka>(RezervacijaStavkaID);
        }
		public static RezervacijaStavka TryGetByPrimaryKey(int RezervacijaStavkaID)
        {
            return TryGetByPrimaryKey<RezervacijaStavka>(RezervacijaStavkaID);
        }
        public static RezervacijaStavka GetByUnique1(int RezervacijaStavkaProtokolID, string RezervacijaStavkaVrstaUsluge, string RezervacijaStavkaVrstaIzleta, DateTime RezervacijaStavkaDatumVrijemeOd, DateTime RezervacijaStavkaDatumVrijemeDo, int RezervacijaStavkaBrod)
        {
            return GetByCallingParameters<RezervacijaStavka>(RezervacijaStavkaProtokolID, RezervacijaStavkaVrstaUsluge, RezervacijaStavkaVrstaIzleta, RezervacijaStavkaDatumVrijemeOd, RezervacijaStavkaDatumVrijemeDo, RezervacijaStavkaBrod);
        }
		public static RezervacijaStavka TryGetByUnique1(int RezervacijaStavkaProtokolID, string RezervacijaStavkaVrstaUsluge, string RezervacijaStavkaVrstaIzleta, DateTime RezervacijaStavkaDatumVrijemeOd, DateTime RezervacijaStavkaDatumVrijemeDo, int RezervacijaStavkaBrod)
        {
            return TryGetByCallingParameters<RezervacijaStavka>(RezervacijaStavkaProtokolID, RezervacijaStavkaVrstaUsluge, RezervacijaStavkaVrstaIzleta, RezervacijaStavkaDatumVrijemeOd, RezervacijaStavkaDatumVrijemeDo, RezervacijaStavkaBrod);
        }
        #endregion
    }
}