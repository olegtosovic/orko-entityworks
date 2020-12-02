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
    /// SmjestajnaJedinica entity.
    /// </summary>
    public sealed partial class SmjestajnaJedinica : Entity
    {
		#region Members
		private KrevetnaDeklaracija m_FK_SmjestajnaJedinica_KrevetnaDeklaracija;
        private PogledSmjestajneJedinice m_FK_SmjestajnaJedinica_PogledSmjestajneJedinice;
        private SmjestajniObjekt m_FK_SmjestajnaJedinica_SmjestajniObjekt;
        private TipSmjestajneJedinice m_FK_SmjestajnaJedinica_TipSmjestajneJedinice;
        private VrstaSmjestajneJedinice m_FK_SmjestajnaJedinica_VrstaSmjestajneJedinice;
        #endregion
        
		#region Constructors
        static SmjestajnaJedinica()
        {
            // Cache field metadata.
            EntityMeta<SmjestajnaJedinica>.LoadColumnMetadata
			(
				new ColumnMetadata("SmjestajnaJedinicaSmjestajnaJedinica", @"SmjestajnaJedinicaSmjestajnaJedinica", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("SmjestajnaJedinicaSmjestajniObjekt", @"SmjestajnaJedinicaSmjestajniObjekt", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaVrstaSmjestajneJedinice", @"SmjestajnaJedinicaVrstaSmjestajneJedinice", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaVrstaSmjestajnogObjekta", @"SmjestajnaJedinicaVrstaSmjestajnogObjekta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaSkupinaSmjestajnogObjekta", @"SmjestajnaJedinicaSkupinaSmjestajnogObjekta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaTipSmjestajneJedinice", @"SmjestajnaJedinicaTipSmjestajneJedinice", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaNaziv", @"SmjestajnaJedinicaNaziv", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaSkraceniNaziv", @"SmjestajnaJedinicaSkraceniNaziv", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaBrojJedinice", @"SmjestajnaJedinicaBrojJedinice", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaKategorija", @"SmjestajnaJedinicaKategorija", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaModul", @"SmjestajnaJedinicaModul", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaKrevetnaDeklaracija", @"SmjestajnaJedinicaKrevetnaDeklaracija", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaPogledSmjestajneJedinice", @"SmjestajnaJedinicaPogledSmjestajneJedinice", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaKapacitet", @"SmjestajnaJedinicaKapacitet", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaUlica", @"SmjestajnaJedinicaUlica", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaKucniBroj", @"SmjestajnaJedinicaKucniBroj", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaTelefon1", @"SmjestajnaJedinicaTelefon1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaTelefon2", @"SmjestajnaJedinicaTelefon2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("SmjestajnaJedinicaAktivnost", @"SmjestajnaJedinicaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaUradio", @"SmjestajnaJedinicaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("SmjestajnaJedinicaDatumIzmjene", @"SmjestajnaJedinicaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SmjestajnaJedinica>.LoadRelationMetadata
			(
				new RelationMetadata("FK_SmjestajnaJedinica_KrevetnaDeklaracija", "SmjestajnaJedinicaKrevetnaDeklaracija", "KrevetnaDeklaracijaKrevetnaDeklaracija"),
                new RelationMetadata("FK_SmjestajnaJedinica_PogledSmjestajneJedinice", "SmjestajnaJedinicaPogledSmjestajneJedinice", "PogledSmjestajneJedinicePogledSmjestajneJedinice"),
                new RelationMetadata("FK_SmjestajnaJedinica_SmjestajniObjekt", "SmjestajnaJedinicaSmjestajniObjekt", "SmjestajniObjektSmjestajniObjekt"),
                new RelationMetadata("FK_SmjestajnaJedinica_TipSmjestajneJedinice", "SmjestajnaJedinicaTipSmjestajneJedinice", "TipSmjestajneJediniceTipSmjestajneJedinice"),
                new RelationMetadata("FK_SmjestajnaJedinica_TipSmjestajneJedinice", "SmjestajnaJedinicaSmjestajniObjekt", "TipSmjestajneJediniceSmjestajniObjekt"),
                new RelationMetadata("FK_SmjestajnaJedinica_VrstaSmjestajneJedinice", "SmjestajnaJedinicaVrstaSmjestajneJedinice", "VrstaSmjestajneJediniceVrstaSmjestajneJedinice"),
                new RelationMetadata("FK_SmjestajnaJedinica_VrstaSmjestajneJedinice", "SmjestajnaJedinicaVrstaSmjestajnogObjekta", "VrstaSmjestajneJediniceVrstaSmjestajnogObjekta"),
                new RelationMetadata("FK_SmjestajnaJedinica_VrstaSmjestajneJedinice", "SmjestajnaJedinicaSkupinaSmjestajnogObjekta", "VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta")
			);

			// Cache table metadata.
			EntityMeta<SmjestajnaJedinica>.HasLanguageTable = false;
            EntityMeta<SmjestajnaJedinica>.TableSchema = @"Turist";
            EntityMeta<SmjestajnaJedinica>.TableName = @"SmjestajnaJedinica";
            EntityMeta<SmjestajnaJedinica>.LanguageTableSchema = null;
            EntityMeta<SmjestajnaJedinica>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SmjestajnaJedinicaSmjestajnaJedinica { get; private set; }
        public int? SmjestajnaJedinicaSmjestajniObjekt { get; set; }
        public string SmjestajnaJedinicaVrstaSmjestajneJedinice { get; set; }
        public string SmjestajnaJedinicaVrstaSmjestajnogObjekta { get; set; }
        public string SmjestajnaJedinicaSkupinaSmjestajnogObjekta { get; set; }
        public int? SmjestajnaJedinicaTipSmjestajneJedinice { get; set; }
        public string SmjestajnaJedinicaNaziv { get; set; }
        public string SmjestajnaJedinicaSkraceniNaziv { get; set; }
        public string SmjestajnaJedinicaBrojJedinice { get; set; }
        public int? SmjestajnaJedinicaKategorija { get; set; }
        public int? SmjestajnaJedinicaModul { get; set; }
        public string SmjestajnaJedinicaKrevetnaDeklaracija { get; set; }
        public string SmjestajnaJedinicaPogledSmjestajneJedinice { get; set; }
        public int? SmjestajnaJedinicaKapacitet { get; set; }
        public string SmjestajnaJedinicaUlica { get; set; }
        public string SmjestajnaJedinicaKucniBroj { get; set; }
        public string SmjestajnaJedinicaTelefon1 { get; set; }
        public string SmjestajnaJedinicaTelefon2 { get; set; }
        public bool? SmjestajnaJedinicaAktivnost { get; set; }
        public string SmjestajnaJedinicaUradio { get; set; }
        public DateTime? SmjestajnaJedinicaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public KrevetnaDeklaracija FK_SmjestajnaJedinica_KrevetnaDeklaracija
        {
            get { return EntityContext<KrevetnaDeklaracija>.Get(ref m_FK_SmjestajnaJedinica_KrevetnaDeklaracija, this, "FK_SmjestajnaJedinica_KrevetnaDeklaracija"); }
            set { EntityContext<KrevetnaDeklaracija>.Set(ref m_FK_SmjestajnaJedinica_KrevetnaDeklaracija, this, value, "FK_SmjestajnaJedinica_KrevetnaDeklaracija"); }
        }
        public PogledSmjestajneJedinice FK_SmjestajnaJedinica_PogledSmjestajneJedinice
        {
            get { return EntityContext<PogledSmjestajneJedinice>.Get(ref m_FK_SmjestajnaJedinica_PogledSmjestajneJedinice, this, "FK_SmjestajnaJedinica_PogledSmjestajneJedinice"); }
            set { EntityContext<PogledSmjestajneJedinice>.Set(ref m_FK_SmjestajnaJedinica_PogledSmjestajneJedinice, this, value, "FK_SmjestajnaJedinica_PogledSmjestajneJedinice"); }
        }
        public SmjestajniObjekt FK_SmjestajnaJedinica_SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_FK_SmjestajnaJedinica_SmjestajniObjekt, this, "FK_SmjestajnaJedinica_SmjestajniObjekt"); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_FK_SmjestajnaJedinica_SmjestajniObjekt, this, value, "FK_SmjestajnaJedinica_SmjestajniObjekt"); }
        }
        public TipSmjestajneJedinice FK_SmjestajnaJedinica_TipSmjestajneJedinice
        {
            get { return EntityContext<TipSmjestajneJedinice>.Get(ref m_FK_SmjestajnaJedinica_TipSmjestajneJedinice, this, "FK_SmjestajnaJedinica_TipSmjestajneJedinice"); }
            set { EntityContext<TipSmjestajneJedinice>.Set(ref m_FK_SmjestajnaJedinica_TipSmjestajneJedinice, this, value, "FK_SmjestajnaJedinica_TipSmjestajneJedinice"); }
        }
        public VrstaSmjestajneJedinice FK_SmjestajnaJedinica_VrstaSmjestajneJedinice
        {
            get { return EntityContext<VrstaSmjestajneJedinice>.Get(ref m_FK_SmjestajnaJedinica_VrstaSmjestajneJedinice, this, "FK_SmjestajnaJedinica_VrstaSmjestajneJedinice"); }
            set { EntityContext<VrstaSmjestajneJedinice>.Set(ref m_FK_SmjestajnaJedinica_VrstaSmjestajneJedinice, this, value, "FK_SmjestajnaJedinica_VrstaSmjestajneJedinice"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SmjestajnaJedinica>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SmjestajnaJedinica>(queryConditions);
        }
        public static async Task<IEnumerable<SmjestajnaJedinica>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SmjestajnaJedinica>(columnName, queryOp, value);
        }
		public static async Task<SmjestajnaJedinica> GetByPrimaryKeyAsync(int SmjestajnaJedinicaSmjestajnaJedinica)
        {
            return await GetByPrimaryKeyAsync<SmjestajnaJedinica>(SmjestajnaJedinicaSmjestajnaJedinica);
        }
		public static async Task<SmjestajnaJedinica> TryGetByPrimaryKeyAsync(int SmjestajnaJedinicaSmjestajnaJedinica)
        {
            return await TryGetByPrimaryKeyAsync<SmjestajnaJedinica>(SmjestajnaJedinicaSmjestajnaJedinica);
        }
		#endregion

        #region Public methods
		public static IEnumerable<SmjestajnaJedinica> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<SmjestajnaJedinica>(queryConditions);
        }
        public static IEnumerable<SmjestajnaJedinica> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<SmjestajnaJedinica>(columnName, queryOp, value);
        }
		public static SmjestajnaJedinica GetByPrimaryKey(int SmjestajnaJedinicaSmjestajnaJedinica)
        {
            return GetByPrimaryKey<SmjestajnaJedinica>(SmjestajnaJedinicaSmjestajnaJedinica);
        }
		public static SmjestajnaJedinica TryGetByPrimaryKey(int SmjestajnaJedinicaSmjestajnaJedinica)
        {
            return TryGetByPrimaryKey<SmjestajnaJedinica>(SmjestajnaJedinicaSmjestajnaJedinica);
        }
        #endregion
    }
}