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
    /// PrometnaKartica entity.
    /// </summary>
    public sealed partial class PrometnaKartica : Entity
    {
		#region Members
		private Brod m_Brod;
        private Base.Protokol m_Protokol;
        private Termin m_Termin;
        private TipRezervacije m_TipRezervacije;
        private VrstaIzleta m_VrstaIzleta;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static PrometnaKartica()
        {
            // Cache field metadata.
            EntityMeta<PrometnaKartica>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(PrometnaKarticaProtokolID), @"PrometnaKarticaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaBrod), @"PrometnaKarticaBrod", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaVrstaUsluge), @"PrometnaKarticaVrstaUsluge", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaVrstaIzleta), @"PrometnaKarticaVrstaIzleta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaTipRezervacije), @"PrometnaKarticaTipRezervacije", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaTerminID), @"PrometnaKarticaTerminID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(PrometnaKarticaDatumUsluge), @"PrometnaKarticaDatumUsluge", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaDatumVrijemeOd), @"PrometnaKarticaDatumVrijemeOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaDatumVrijemeDo), @"PrometnaKarticaDatumVrijemeDo", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaVrijemeOd), @"PrometnaKarticaVrijemeOd", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaVrijemeDo), @"PrometnaKarticaVrijemeDo", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaTrajanjeIdealno), @"PrometnaKarticaTrajanjeIdealno", DbType.Time, isRequired: false),
                new ColumnMetadata(nameof(PrometnaKarticaTrajanjeStvarno), @"PrometnaKarticaTrajanjeStvarno", DbType.Time, isRequired: false),
                new ColumnMetadata(nameof(PrometnaKarticaPovratakProcjena), @"PrometnaKarticaPovratakProcjena", DbType.Time, isRequired: false),
                new ColumnMetadata(nameof(PrometnaKarticaPovratakStvarno), @"PrometnaKarticaPovratakStvarno", DbType.Time, isRequired: false),
                new ColumnMetadata(nameof(PrometnaKarticaBrojOsobaStvarno), @"PrometnaKarticaBrojOsobaStvarno", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaBrojOsobaPreostaloStvarno), @"PrometnaKarticaBrojOsobaPreostaloStvarno", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaBrojOsobaKalkulativno), @"PrometnaKarticaBrojOsobaKalkulativno", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaBrojOsobaPreostaloKalkulativno), @"PrometnaKarticaBrojOsobaPreostaloKalkulativno", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaBrojOdraslih), @"PrometnaKarticaBrojOdraslih", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaBrojDjece), @"PrometnaKarticaBrojDjece", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaSkiperUkljucen), @"PrometnaKarticaSkiperUkljucen", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(PrometnaKarticaCijenaUslugeCjenik), @"PrometnaKarticaCijenaUslugeCjenik", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaCijenaUslugePopustPostotak), @"PrometnaKarticaCijenaUslugePopustPostotak", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaCijenaUslugePopustIznos), @"PrometnaKarticaCijenaUslugePopustIznos", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaCijenaUslugeKonacno), @"PrometnaKarticaCijenaUslugeKonacno", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(PrometnaKarticaCijenaUslugeNaplaceno), @"PrometnaKarticaCijenaUslugeNaplaceno", DbType.Decimal, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<PrometnaKartica>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Brod), nameof(PrometnaKarticaBrod), nameof(Orko.Watersports.Brod.BrodBrod)),
                new RelationMetadata(nameof(Protokol), nameof(PrometnaKarticaProtokolID), nameof(Orko.Base.Protokol.ProtokolID)),
                new RelationMetadata(nameof(Termin), nameof(PrometnaKarticaTerminID), nameof(Orko.Watersports.Termin.TerminID)),
                new RelationMetadata(nameof(TipRezervacije), nameof(PrometnaKarticaTipRezervacije), nameof(Orko.Watersports.TipRezervacije.TipRezervacijeTipRezervacije)),
                new RelationMetadata(nameof(VrstaIzleta), nameof(PrometnaKarticaVrstaIzleta), nameof(Orko.Watersports.VrstaIzleta.VrstaIzletaVrstaIzleta)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(PrometnaKarticaVrstaUsluge), nameof(Orko.Watersports.VrstaUsluge.VrstaUslugeVrstaUsluge))
			);

			// Cache table metadata.
			EntityMeta<PrometnaKartica>.HasLanguageTable = false;
            EntityMeta<PrometnaKartica>.TableSchema = @"Watersports";
            EntityMeta<PrometnaKartica>.TableName = @"PrometnaKartica";
            EntityMeta<PrometnaKartica>.LanguageTableSchema = null;
            EntityMeta<PrometnaKartica>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? PrometnaKarticaProtokolID { get; set; }
        public int? PrometnaKarticaBrod { get; set; }
        public string PrometnaKarticaVrstaUsluge { get; set; }
        public string PrometnaKarticaVrstaIzleta { get; set; }
        public string PrometnaKarticaTipRezervacije { get; set; }
        public int? PrometnaKarticaTerminID { get; set; }
        public DateTime? PrometnaKarticaDatumUsluge { get; set; }
        public DateTime? PrometnaKarticaDatumVrijemeOd { get; set; }
        public DateTime? PrometnaKarticaDatumVrijemeDo { get; set; }
        public TimeSpan? PrometnaKarticaVrijemeOd { get; set; }
        public TimeSpan? PrometnaKarticaVrijemeDo { get; set; }
        public TimeSpan? PrometnaKarticaTrajanjeIdealno { get; set; }
        public TimeSpan? PrometnaKarticaTrajanjeStvarno { get; set; }
        public TimeSpan? PrometnaKarticaPovratakProcjena { get; set; }
        public TimeSpan? PrometnaKarticaPovratakStvarno { get; set; }
        public int? PrometnaKarticaBrojOsobaStvarno { get; set; }
        public int? PrometnaKarticaBrojOsobaPreostaloStvarno { get; set; }
        public int? PrometnaKarticaBrojOsobaKalkulativno { get; set; }
        public int? PrometnaKarticaBrojOsobaPreostaloKalkulativno { get; set; }
        public int? PrometnaKarticaBrojOdraslih { get; set; }
        public int? PrometnaKarticaBrojDjece { get; set; }
        public bool? PrometnaKarticaSkiperUkljucen { get; set; }
        public decimal? PrometnaKarticaCijenaUslugeCjenik { get; set; }
        public decimal? PrometnaKarticaCijenaUslugePopustPostotak { get; set; }
        public decimal? PrometnaKarticaCijenaUslugePopustIznos { get; set; }
        public decimal? PrometnaKarticaCijenaUslugeKonacno { get; set; }
        public decimal? PrometnaKarticaCijenaUslugeNaplaceno { get; set; }
        #endregion

        #region Entities
		public Brod Brod
        {
            get { return EntityContext<Brod>.Get(ref m_Brod, this, nameof(Brod)); }
            set { EntityContext<Brod>.Set(ref m_Brod, this, value, nameof(Brod)); }
        }
        public Base.Protokol Protokol
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_Protokol, this, nameof(Protokol)); }
            set { EntityContext<Base.Protokol>.Set(ref m_Protokol, this, value, nameof(Protokol)); }
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
		public static async Task<IEnumerable<PrometnaKartica>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PrometnaKartica>(queryConditions);
        }
        public static async Task<IEnumerable<PrometnaKartica>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PrometnaKartica>(columnName, queryOp, value);
        }
		public static async Task<PrometnaKartica> GetByPrimaryKeyAsync(int PrometnaKarticaProtokolID)
        {
            return await GetByPrimaryKeyAsync<PrometnaKartica>(PrometnaKarticaProtokolID);
        }
		public static async Task<PrometnaKartica> TryGetByPrimaryKeyAsync(int PrometnaKarticaProtokolID)
        {
            return await TryGetByPrimaryKeyAsync<PrometnaKartica>(PrometnaKarticaProtokolID);
        }
		#endregion
    }
}