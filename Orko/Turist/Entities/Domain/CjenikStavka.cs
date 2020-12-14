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
    /// CjenikStavka entity.
    /// </summary>
    public sealed partial class CjenikStavka : Entity
    {
		#region Members
		private Cjenik m_Cjenik;
        private PogledSmjestajneJedinice m_PogledSmjestajneJedinice;
        private SmjestajnaJedinica m_SmjestajnaJedinica;
        private SmjestajniObjekt m_SmjestajniObjekt;
        private TipSmjestajneJedinice m_TipSmjestajneJedinice;
        private VrstaSmjestajneJedinice m_VrstaSmjestajneJedinice;
        #endregion
        
		#region Constructors
        static CjenikStavka()
        {
            // Cache field metadata.
            EntityMeta<CjenikStavka>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CjenikStavkaID), @"CjenikStavkaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaProtokolID), @"CjenikStavkaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaSmjestajniObjekt), @"CjenikStavkaSmjestajniObjekt", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaSmjestajnaJedinica), @"CjenikStavkaSmjestajnaJedinica", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaTipSmjestajneJedinice), @"CjenikStavkaTipSmjestajneJedinice", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaPogledSmjestajneJedinice), @"CjenikStavkaPogledSmjestajneJedinice", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaVrstaSmjestajneJedinice), @"CjenikStavkaVrstaSmjestajneJedinice", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaVrstaSmjestajnogObjekta), @"CjenikStavkaVrstaSmjestajnogObjekta", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaSkupinaSmjestajnogObjekta), @"CjenikStavkaSkupinaSmjestajnogObjekta", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaBrojOsoba), @"CjenikStavkaBrojOsoba", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaPeriodOd), @"CjenikStavkaPeriodOd", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaPeriodDo), @"CjenikStavkaPeriodDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaIznos), @"CjenikStavkaIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaAlotmanskiIznos), @"CjenikStavkaAlotmanskiIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaDodatnaOsobaIznos), @"CjenikStavkaDodatnaOsobaIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaVrijediOd), @"CjenikStavkaVrijediOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaVrijediDo), @"CjenikStavkaVrijediDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaUradio), @"CjenikStavkaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaDatumIzmjene), @"CjenikStavkaDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<CjenikStavka>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Cjenik), nameof(CjenikStavkaProtokolID), nameof(Orko.Turist.Cjenik.CjenikProtokolID)),
                new RelationMetadata(nameof(PogledSmjestajneJedinice), nameof(CjenikStavkaPogledSmjestajneJedinice), nameof(Orko.Turist.PogledSmjestajneJedinice.PogledSmjestajneJedinicePogledSmjestajneJedinice)),
                new RelationMetadata(nameof(SmjestajnaJedinica), nameof(CjenikStavkaSmjestajnaJedinica), nameof(Orko.Turist.SmjestajnaJedinica.SmjestajnaJedinicaSmjestajnaJedinica)),
                new RelationMetadata(nameof(SmjestajniObjekt), nameof(CjenikStavkaSmjestajniObjekt), nameof(Orko.Turist.SmjestajniObjekt.SmjestajniObjektSmjestajniObjekt)),
                new RelationMetadata(nameof(TipSmjestajneJedinice), nameof(CjenikStavkaTipSmjestajneJedinice), nameof(Orko.Turist.TipSmjestajneJedinice.TipSmjestajneJediniceTipSmjestajneJedinice)),
                new RelationMetadata(nameof(TipSmjestajneJedinice), nameof(CjenikStavkaSmjestajniObjekt), nameof(Orko.Turist.TipSmjestajneJedinice.TipSmjestajneJediniceSmjestajniObjekt)),
                new RelationMetadata(nameof(VrstaSmjestajneJedinice), nameof(CjenikStavkaVrstaSmjestajneJedinice), nameof(Orko.Turist.VrstaSmjestajneJedinice.VrstaSmjestajneJediniceVrstaSmjestajneJedinice)),
                new RelationMetadata(nameof(VrstaSmjestajneJedinice), nameof(CjenikStavkaVrstaSmjestajnogObjekta), nameof(Orko.Turist.VrstaSmjestajneJedinice.VrstaSmjestajneJediniceVrstaSmjestajnogObjekta)),
                new RelationMetadata(nameof(VrstaSmjestajneJedinice), nameof(CjenikStavkaSkupinaSmjestajnogObjekta), nameof(Orko.Turist.VrstaSmjestajneJedinice.VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta))
			);

			// Cache table metadata.
			EntityMeta<CjenikStavka>.HasLanguageTable = false;
            EntityMeta<CjenikStavka>.TableSchema = @"Turist";
            EntityMeta<CjenikStavka>.TableName = @"CjenikStavka";
            EntityMeta<CjenikStavka>.LanguageTableSchema = null;
            EntityMeta<CjenikStavka>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CjenikStavkaID { get; private set; }
        public int? CjenikStavkaProtokolID { get; set; }
        public int? CjenikStavkaSmjestajniObjekt { get; set; }
        public int? CjenikStavkaSmjestajnaJedinica { get; set; }
        public int? CjenikStavkaTipSmjestajneJedinice { get; set; }
        public string CjenikStavkaPogledSmjestajneJedinice { get; set; }
        public string CjenikStavkaVrstaSmjestajneJedinice { get; set; }
        public string CjenikStavkaVrstaSmjestajnogObjekta { get; set; }
        public string CjenikStavkaSkupinaSmjestajnogObjekta { get; set; }
        public int? CjenikStavkaBrojOsoba { get; set; }
        public DateTime? CjenikStavkaPeriodOd { get; set; }
        public DateTime? CjenikStavkaPeriodDo { get; set; }
        public decimal? CjenikStavkaIznos { get; set; }
        public decimal? CjenikStavkaAlotmanskiIznos { get; set; }
        public decimal? CjenikStavkaDodatnaOsobaIznos { get; set; }
        public DateTime? CjenikStavkaVrijediOd { get; set; }
        public DateTime? CjenikStavkaVrijediDo { get; set; }
        public string CjenikStavkaUradio { get; set; }
        public DateTime? CjenikStavkaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public Cjenik Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_Cjenik, this, nameof(Cjenik)); }
            set { EntityContext<Cjenik>.Set(ref m_Cjenik, this, value, nameof(Cjenik)); }
        }
        public PogledSmjestajneJedinice PogledSmjestajneJedinice
        {
            get { return EntityContext<PogledSmjestajneJedinice>.Get(ref m_PogledSmjestajneJedinice, this, nameof(PogledSmjestajneJedinice)); }
            set { EntityContext<PogledSmjestajneJedinice>.Set(ref m_PogledSmjestajneJedinice, this, value, nameof(PogledSmjestajneJedinice)); }
        }
        public SmjestajnaJedinica SmjestajnaJedinica
        {
            get { return EntityContext<SmjestajnaJedinica>.Get(ref m_SmjestajnaJedinica, this, nameof(SmjestajnaJedinica)); }
            set { EntityContext<SmjestajnaJedinica>.Set(ref m_SmjestajnaJedinica, this, value, nameof(SmjestajnaJedinica)); }
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
		public static async Task<IEnumerable<CjenikStavka>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CjenikStavka>(queryConditions);
        }
        public static async Task<IEnumerable<CjenikStavka>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CjenikStavka>(columnName, queryOp, value);
        }
		public static async Task<CjenikStavka> GetByPrimaryKeyAsync(int CjenikStavkaID)
        {
            return await GetByPrimaryKeyAsync<CjenikStavka>(CjenikStavkaID);
        }
		public static async Task<CjenikStavka> TryGetByPrimaryKeyAsync(int CjenikStavkaID)
        {
            return await TryGetByPrimaryKeyAsync<CjenikStavka>(CjenikStavkaID);
        }
		#endregion
    }
}