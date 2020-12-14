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

namespace Orko.Watersports
{
    /// <summary>
    /// RezervacijaStavka entity.
    /// </summary>
    public sealed partial class RezervacijaStavka : Entity
    {
		#region Members
		private Brod m_Brod;
        private Base.Evidencija m_Evidencija;
        private Lokacija2 m_Lokacija2;
        private PrometnaKartica m_PrometnaKartica;
        private Rezervacija m_Rezervacija;
        private Termin m_Termin;
        private TipRezervacije m_TipRezervacije;
        private VrstaIzleta m_VrstaIzleta;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static RezervacijaStavka()
        {
            // Cache field metadata.
            EntityMeta<RezervacijaStavka>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(RezervacijaStavkaID), @"RezervacijaStavkaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaProtokolID), @"RezervacijaStavkaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaPrometnaKarticaID), @"RezervacijaStavkaPrometnaKarticaID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaRedniBroj), @"RezervacijaStavkaRedniBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaBrod), @"RezervacijaStavkaBrod", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaVrstaUsluge), @"RezervacijaStavkaVrstaUsluge", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaVrstaIzleta), @"RezervacijaStavkaVrstaIzleta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaTipRezervacije), @"RezervacijaStavkaTipRezervacije", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaDatumUsluge), @"RezervacijaStavkaDatumUsluge", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaTerminID), @"RezervacijaStavkaTerminID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaDatumVrijemeOd), @"RezervacijaStavkaDatumVrijemeOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaDatumVrijemeDo), @"RezervacijaStavkaDatumVrijemeDo", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaVrijemeOd), @"RezervacijaStavkaVrijemeOd", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaVrijemeDo), @"RezervacijaStavkaVrijemeDo", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaTrajanje), @"RezervacijaStavkaTrajanje", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaBrojOdraslih), @"RezervacijaStavkaBrojOdraslih", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaBrojDjece), @"RezervacijaStavkaBrojDjece", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaBrojOsobaStvarno), @"RezervacijaStavkaBrojOsobaStvarno", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaBrojOsobaKalkulativno), @"RezervacijaStavkaBrojOsobaKalkulativno", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaSkiperUkljucen), @"RezervacijaStavkaSkiperUkljucen", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaGorivoUkljuceno), @"RezervacijaStavkaGorivoUkljuceno", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaPickupLokacija), @"RezervacijaStavkaPickupLokacija", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaCijenaUslugeCjenik), @"RezervacijaStavkaCijenaUslugeCjenik", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaCijenaUslugePopustPostotak), @"RezervacijaStavkaCijenaUslugePopustPostotak", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaCijenaUslugePopustIznos), @"RezervacijaStavkaCijenaUslugePopustIznos", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaCijenaUslugeKonacno), @"RezervacijaStavkaCijenaUslugeKonacno", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaCijenaUslugeNaplaceno), @"RezervacijaStavkaCijenaUslugeNaplaceno", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaNapomena), @"RezervacijaStavkaNapomena", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaEvidencijaID), @"RezervacijaStavkaEvidencijaID", DbType.Int32, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<RezervacijaStavka>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Brod), nameof(RezervacijaStavkaBrod), nameof(Orko.Watersports.Brod.BrodBrod)),
                new RelationMetadata(nameof(Evidencija), nameof(RezervacijaStavkaEvidencijaID), nameof(Orko.Base.Evidencija.EvidencijaID)),
                new RelationMetadata(nameof(Lokacija2), nameof(RezervacijaStavkaPickupLokacija), nameof(Orko.Watersports.Lokacija2.LokacijaID)),
                new RelationMetadata(nameof(PrometnaKartica), nameof(RezervacijaStavkaPrometnaKarticaID), nameof(Orko.Watersports.PrometnaKartica.PrometnaKarticaProtokolID)),
                new RelationMetadata(nameof(Rezervacija), nameof(RezervacijaStavkaProtokolID), nameof(Orko.Watersports.Rezervacija.RezervacijaProtokolID)),
                new RelationMetadata(nameof(Termin), nameof(RezervacijaStavkaTerminID), nameof(Orko.Watersports.Termin.TerminID)),
                new RelationMetadata(nameof(TipRezervacije), nameof(RezervacijaStavkaTipRezervacije), nameof(Orko.Watersports.TipRezervacije.TipRezervacijeTipRezervacije)),
                new RelationMetadata(nameof(VrstaIzleta), nameof(RezervacijaStavkaVrstaIzleta), nameof(Orko.Watersports.VrstaIzleta.VrstaIzletaVrstaIzleta)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(RezervacijaStavkaVrstaUsluge), nameof(Orko.Watersports.VrstaUsluge.VrstaUslugeVrstaUsluge))
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
		public Brod Brod
        {
            get { return EntityContext<Brod>.Get(ref m_Brod, this, nameof(Brod)); }
            set { EntityContext<Brod>.Set(ref m_Brod, this, value, nameof(Brod)); }
        }
        public Base.Evidencija Evidencija
        {
            get { return EntityContext<Base.Evidencija>.Get(ref m_Evidencija, this, nameof(Evidencija)); }
            set { EntityContext<Base.Evidencija>.Set(ref m_Evidencija, this, value, nameof(Evidencija)); }
        }
        public Lokacija2 Lokacija2
        {
            get { return EntityContext<Lokacija2>.Get(ref m_Lokacija2, this, nameof(Lokacija2)); }
            set { EntityContext<Lokacija2>.Set(ref m_Lokacija2, this, value, nameof(Lokacija2)); }
        }
        public PrometnaKartica PrometnaKartica
        {
            get { return EntityContext<PrometnaKartica>.Get(ref m_PrometnaKartica, this, nameof(PrometnaKartica)); }
            set { EntityContext<PrometnaKartica>.Set(ref m_PrometnaKartica, this, value, nameof(PrometnaKartica)); }
        }
        public Rezervacija Rezervacija
        {
            get { return EntityContext<Rezervacija>.Get(ref m_Rezervacija, this, nameof(Rezervacija)); }
            set { EntityContext<Rezervacija>.Set(ref m_Rezervacija, this, value, nameof(Rezervacija)); }
        }
        public Termin Termin
        {
            get { return EntityContext<Termin>.Get(ref m_Termin, this, nameof(Termin)); }
            set { EntityContext<Termin>.Set(ref m_Termin, this, value, nameof(Termin)); }
        }
        public TipRezervacije TipRezervacije
        {
            get { return EntityContext<TipRezervacije>.Get(ref m_TipRezervacije, this, nameof(TipRezervacije)); }
            set { EntityContext<TipRezervacije>.Set(ref m_TipRezervacije, this, value, nameof(TipRezervacije)); }
        }
        public VrstaIzleta VrstaIzleta
        {
            get { return EntityContext<VrstaIzleta>.Get(ref m_VrstaIzleta, this, nameof(VrstaIzleta)); }
            set { EntityContext<VrstaIzleta>.Set(ref m_VrstaIzleta, this, value, nameof(VrstaIzleta)); }
        }
        public VrstaUsluge VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_VrstaUsluge, this, nameof(VrstaUsluge)); }
            set { EntityContext<VrstaUsluge>.Set(ref m_VrstaUsluge, this, value, nameof(VrstaUsluge)); }
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
    }
}