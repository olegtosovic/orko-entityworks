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
    /// PrometnaKartica entity.
    /// </summary>
    public sealed partial class PrometnaKartica : Entity
    {
		#region Members
		private Brod m_FK_PrometnaKartica_Brod;
        private Base.Protokol m_FK_PrometnaKartica_Protokol;
        private Termin m_FK_PrometnaKartica_Termin;
        private TipRezervacije m_FK_PrometnaKartica_TipRezervacije;
        private VrstaIzleta m_FK_PrometnaKartica_VrstaIzleta;
        private VrstaUsluge m_FK_PrometnaKartica_VrstaUsluge;
        #endregion
        
		#region Constructors
        static PrometnaKartica()
        {
            // Cache field metadata.
            EntityMeta<PrometnaKartica>.LoadColumnMetadata
			(
				new ColumnMetadata("PrometnaKarticaProtokolID", @"PrometnaKarticaProtokolID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("PrometnaKarticaBrod", @"PrometnaKarticaBrod", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("PrometnaKarticaVrstaUsluge", @"PrometnaKarticaVrstaUsluge", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("PrometnaKarticaVrstaIzleta", @"PrometnaKarticaVrstaIzleta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("PrometnaKarticaTipRezervacije", @"PrometnaKarticaTipRezervacije", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("PrometnaKarticaTerminID", @"PrometnaKarticaTerminID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("PrometnaKarticaDatumUsluge", @"PrometnaKarticaDatumUsluge", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("PrometnaKarticaDatumVrijemeOd", @"PrometnaKarticaDatumVrijemeOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("PrometnaKarticaDatumVrijemeDo", @"PrometnaKarticaDatumVrijemeDo", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("PrometnaKarticaVrijemeOd", @"PrometnaKarticaVrijemeOd", SqlDbType.Time, isRequired: true),
                new ColumnMetadata("PrometnaKarticaVrijemeDo", @"PrometnaKarticaVrijemeDo", SqlDbType.Time, isRequired: true),
                new ColumnMetadata("PrometnaKarticaTrajanjeIdealno", @"PrometnaKarticaTrajanjeIdealno", SqlDbType.Time, isRequired: false),
                new ColumnMetadata("PrometnaKarticaTrajanjeStvarno", @"PrometnaKarticaTrajanjeStvarno", SqlDbType.Time, isRequired: false),
                new ColumnMetadata("PrometnaKarticaPovratakProcjena", @"PrometnaKarticaPovratakProcjena", SqlDbType.Time, isRequired: false),
                new ColumnMetadata("PrometnaKarticaPovratakStvarno", @"PrometnaKarticaPovratakStvarno", SqlDbType.Time, isRequired: false),
                new ColumnMetadata("PrometnaKarticaBrojOsobaStvarno", @"PrometnaKarticaBrojOsobaStvarno", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("PrometnaKarticaBrojOsobaPreostaloStvarno", @"PrometnaKarticaBrojOsobaPreostaloStvarno", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("PrometnaKarticaBrojOsobaKalkulativno", @"PrometnaKarticaBrojOsobaKalkulativno", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("PrometnaKarticaBrojOsobaPreostaloKalkulativno", @"PrometnaKarticaBrojOsobaPreostaloKalkulativno", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("PrometnaKarticaBrojOdraslih", @"PrometnaKarticaBrojOdraslih", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("PrometnaKarticaBrojDjece", @"PrometnaKarticaBrojDjece", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("PrometnaKarticaSkiperUkljucen", @"PrometnaKarticaSkiperUkljucen", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("PrometnaKarticaCijenaUslugeCjenik", @"PrometnaKarticaCijenaUslugeCjenik", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("PrometnaKarticaCijenaUslugePopustPostotak", @"PrometnaKarticaCijenaUslugePopustPostotak", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("PrometnaKarticaCijenaUslugePopustIznos", @"PrometnaKarticaCijenaUslugePopustIznos", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("PrometnaKarticaCijenaUslugeKonacno", @"PrometnaKarticaCijenaUslugeKonacno", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("PrometnaKarticaCijenaUslugeNaplaceno", @"PrometnaKarticaCijenaUslugeNaplaceno", SqlDbType.Decimal, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<PrometnaKartica>.LoadRelationMetadata
			(
				new RelationMetadata("FK_PrometnaKartica_Brod", "PrometnaKarticaBrod", "BrodBrod"),
                new RelationMetadata("FK_PrometnaKartica_Protokol", "PrometnaKarticaProtokolID", "ProtokolID"),
                new RelationMetadata("FK_PrometnaKartica_Termin", "PrometnaKarticaTerminID", "TerminID"),
                new RelationMetadata("FK_PrometnaKartica_TipRezervacije", "PrometnaKarticaTipRezervacije", "TipRezervacijeTipRezervacije"),
                new RelationMetadata("FK_PrometnaKartica_VrstaIzleta", "PrometnaKarticaVrstaIzleta", "VrstaIzletaVrstaIzleta"),
                new RelationMetadata("FK_PrometnaKartica_VrstaUsluge", "PrometnaKarticaVrstaUsluge", "VrstaUslugeVrstaUsluge")
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
		public Brod FK_PrometnaKartica_Brod
        {
            get { return EntityContext<Brod>.Get(ref m_FK_PrometnaKartica_Brod, this, "FK_PrometnaKartica_Brod"); }
            set { EntityContext<Brod>.Set(ref m_FK_PrometnaKartica_Brod, this, value, "FK_PrometnaKartica_Brod"); }
        }
        public Base.Protokol FK_PrometnaKartica_Protokol
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_FK_PrometnaKartica_Protokol, this, "FK_PrometnaKartica_Protokol"); }
            set { EntityContext<Base.Protokol>.Set(ref m_FK_PrometnaKartica_Protokol, this, value, "FK_PrometnaKartica_Protokol"); }
        }
        public Termin FK_PrometnaKartica_Termin
        {
            get { return EntityContext<Termin>.Get(ref m_FK_PrometnaKartica_Termin, this, "FK_PrometnaKartica_Termin"); }
            set { EntityContext<Termin>.Set(ref m_FK_PrometnaKartica_Termin, this, value, "FK_PrometnaKartica_Termin"); }
        }
        public TipRezervacije FK_PrometnaKartica_TipRezervacije
        {
            get { return EntityContext<TipRezervacije>.Get(ref m_FK_PrometnaKartica_TipRezervacije, this, "FK_PrometnaKartica_TipRezervacije"); }
            set { EntityContext<TipRezervacije>.Set(ref m_FK_PrometnaKartica_TipRezervacije, this, value, "FK_PrometnaKartica_TipRezervacije"); }
        }
        public VrstaIzleta FK_PrometnaKartica_VrstaIzleta
        {
            get { return EntityContext<VrstaIzleta>.Get(ref m_FK_PrometnaKartica_VrstaIzleta, this, "FK_PrometnaKartica_VrstaIzleta"); }
            set { EntityContext<VrstaIzleta>.Set(ref m_FK_PrometnaKartica_VrstaIzleta, this, value, "FK_PrometnaKartica_VrstaIzleta"); }
        }
        public VrstaUsluge FK_PrometnaKartica_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_PrometnaKartica_VrstaUsluge, this, "FK_PrometnaKartica_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_PrometnaKartica_VrstaUsluge, this, value, "FK_PrometnaKartica_VrstaUsluge"); }
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

        #region Public methods
		public static IEnumerable<PrometnaKartica> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<PrometnaKartica>(queryConditions);
        }
        public static IEnumerable<PrometnaKartica> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<PrometnaKartica>(columnName, queryOp, value);
        }
		public static PrometnaKartica GetByPrimaryKey(int PrometnaKarticaProtokolID)
        {
            return GetByPrimaryKey<PrometnaKartica>(PrometnaKarticaProtokolID);
        }
		public static PrometnaKartica TryGetByPrimaryKey(int PrometnaKarticaProtokolID)
        {
            return TryGetByPrimaryKey<PrometnaKartica>(PrometnaKarticaProtokolID);
        }
        public static PrometnaKartica GetByUnique1(int PrometnaKarticaBrod, string PrometnaKarticaVrstaUsluge, string PrometnaKarticaVrstaIzleta, DateTime PrometnaKarticaDatumVrijemeOd, DateTime PrometnaKarticaDatumVrijemeDo)
        {
            return GetByCallingParameters<PrometnaKartica>(PrometnaKarticaBrod, PrometnaKarticaVrstaUsluge, PrometnaKarticaVrstaIzleta, PrometnaKarticaDatumVrijemeOd, PrometnaKarticaDatumVrijemeDo);
        }
		public static PrometnaKartica TryGetByUnique1(int PrometnaKarticaBrod, string PrometnaKarticaVrstaUsluge, string PrometnaKarticaVrstaIzleta, DateTime PrometnaKarticaDatumVrijemeOd, DateTime PrometnaKarticaDatumVrijemeDo)
        {
            return TryGetByCallingParameters<PrometnaKartica>(PrometnaKarticaBrod, PrometnaKarticaVrstaUsluge, PrometnaKarticaVrstaIzleta, PrometnaKarticaDatumVrijemeOd, PrometnaKarticaDatumVrijemeDo);
        }
        #endregion
    }
}