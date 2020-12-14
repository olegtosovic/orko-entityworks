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
    /// SmjestajnaJedinica entity.
    /// </summary>
    public sealed partial class SmjestajnaJedinica : Entity
    {
		#region Members
		private KrevetnaDeklaracija m_KrevetnaDeklaracija;
        private PogledSmjestajneJedinice m_PogledSmjestajneJedinice;
        private SmjestajniObjekt m_SmjestajniObjekt;
        private TipSmjestajneJedinice m_TipSmjestajneJedinice;
        private VrstaSmjestajneJedinice m_VrstaSmjestajneJedinice;
        #endregion
        
		#region Constructors
        static SmjestajnaJedinica()
        {
            // Cache field metadata.
            EntityMeta<SmjestajnaJedinica>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SmjestajnaJedinicaSmjestajnaJedinica), @"SmjestajnaJedinicaSmjestajnaJedinica", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaSmjestajniObjekt), @"SmjestajnaJedinicaSmjestajniObjekt", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaVrstaSmjestajneJedinice), @"SmjestajnaJedinicaVrstaSmjestajneJedinice", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaVrstaSmjestajnogObjekta), @"SmjestajnaJedinicaVrstaSmjestajnogObjekta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaSkupinaSmjestajnogObjekta), @"SmjestajnaJedinicaSkupinaSmjestajnogObjekta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaTipSmjestajneJedinice), @"SmjestajnaJedinicaTipSmjestajneJedinice", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaNaziv), @"SmjestajnaJedinicaNaziv", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaSkraceniNaziv), @"SmjestajnaJedinicaSkraceniNaziv", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaBrojJedinice), @"SmjestajnaJedinicaBrojJedinice", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaKategorija), @"SmjestajnaJedinicaKategorija", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaModul), @"SmjestajnaJedinicaModul", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaKrevetnaDeklaracija), @"SmjestajnaJedinicaKrevetnaDeklaracija", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaPogledSmjestajneJedinice), @"SmjestajnaJedinicaPogledSmjestajneJedinice", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaKapacitet), @"SmjestajnaJedinicaKapacitet", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaUlica), @"SmjestajnaJedinicaUlica", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaKucniBroj), @"SmjestajnaJedinicaKucniBroj", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaTelefon1), @"SmjestajnaJedinicaTelefon1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaTelefon2), @"SmjestajnaJedinicaTelefon2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(SmjestajnaJedinicaAktivnost), @"SmjestajnaJedinicaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaUradio), @"SmjestajnaJedinicaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SmjestajnaJedinicaDatumIzmjene), @"SmjestajnaJedinicaDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SmjestajnaJedinica>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(KrevetnaDeklaracija), nameof(SmjestajnaJedinicaKrevetnaDeklaracija), nameof(Orko.Turist.KrevetnaDeklaracija.KrevetnaDeklaracijaKrevetnaDeklaracija)),
                new RelationMetadata(nameof(PogledSmjestajneJedinice), nameof(SmjestajnaJedinicaPogledSmjestajneJedinice), nameof(Orko.Turist.PogledSmjestajneJedinice.PogledSmjestajneJedinicePogledSmjestajneJedinice)),
                new RelationMetadata(nameof(SmjestajniObjekt), nameof(SmjestajnaJedinicaSmjestajniObjekt), nameof(Orko.Turist.SmjestajniObjekt.SmjestajniObjektSmjestajniObjekt)),
                new RelationMetadata(nameof(TipSmjestajneJedinice), nameof(SmjestajnaJedinicaTipSmjestajneJedinice), nameof(Orko.Turist.TipSmjestajneJedinice.TipSmjestajneJediniceTipSmjestajneJedinice)),
                new RelationMetadata(nameof(TipSmjestajneJedinice), nameof(SmjestajnaJedinicaSmjestajniObjekt), nameof(Orko.Turist.TipSmjestajneJedinice.TipSmjestajneJediniceSmjestajniObjekt)),
                new RelationMetadata(nameof(VrstaSmjestajneJedinice), nameof(SmjestajnaJedinicaVrstaSmjestajneJedinice), nameof(Orko.Turist.VrstaSmjestajneJedinice.VrstaSmjestajneJediniceVrstaSmjestajneJedinice)),
                new RelationMetadata(nameof(VrstaSmjestajneJedinice), nameof(SmjestajnaJedinicaVrstaSmjestajnogObjekta), nameof(Orko.Turist.VrstaSmjestajneJedinice.VrstaSmjestajneJediniceVrstaSmjestajnogObjekta)),
                new RelationMetadata(nameof(VrstaSmjestajneJedinice), nameof(SmjestajnaJedinicaSkupinaSmjestajnogObjekta), nameof(Orko.Turist.VrstaSmjestajneJedinice.VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta))
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
		public KrevetnaDeklaracija KrevetnaDeklaracija
        {
            get { return EntityContext<KrevetnaDeklaracija>.Get(ref m_KrevetnaDeklaracija, this, nameof(KrevetnaDeklaracija)); }
            set { EntityContext<KrevetnaDeklaracija>.Set(ref m_KrevetnaDeklaracija, this, value, nameof(KrevetnaDeklaracija)); }
        }
        public PogledSmjestajneJedinice PogledSmjestajneJedinice
        {
            get { return EntityContext<PogledSmjestajneJedinice>.Get(ref m_PogledSmjestajneJedinice, this, nameof(PogledSmjestajneJedinice)); }
            set { EntityContext<PogledSmjestajneJedinice>.Set(ref m_PogledSmjestajneJedinice, this, value, nameof(PogledSmjestajneJedinice)); }
        }
        public SmjestajniObjekt SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_SmjestajniObjekt, this, nameof(SmjestajniObjekt)); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_SmjestajniObjekt, this, value, nameof(SmjestajniObjekt)); }
        }
        public TipSmjestajneJedinice TipSmjestajneJedinice
        {
            get { return EntityContext<TipSmjestajneJedinice>.Get(ref m_TipSmjestajneJedinice, this, nameof(TipSmjestajneJedinice)); }
            set { EntityContext<TipSmjestajneJedinice>.Set(ref m_TipSmjestajneJedinice, this, value, nameof(TipSmjestajneJedinice)); }
        }
        public VrstaSmjestajneJedinice VrstaSmjestajneJedinice
        {
            get { return EntityContext<VrstaSmjestajneJedinice>.Get(ref m_VrstaSmjestajneJedinice, this, nameof(VrstaSmjestajneJedinice)); }
            set { EntityContext<VrstaSmjestajneJedinice>.Set(ref m_VrstaSmjestajneJedinice, this, value, nameof(VrstaSmjestajneJedinice)); }
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
    }
}