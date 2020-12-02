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
    /// CjenikStavka entity.
    /// </summary>
    public sealed partial class CjenikStavka : Entity
    {
		#region Members
		private Cjenik m_FK_CjenikStavka_Cjenik;
        private PogledSmjestajneJedinice m_FK_CjenikStavka_PogledSmjestajneJedinice;
        private SmjestajnaJedinica m_FK_CjenikStavka_SmjestajnaJedinica;
        private SmjestajniObjekt m_FK_CjenikStavka_SmjestajniObjekt;
        private TipSmjestajneJedinice m_FK_CjenikStavka_TipSmjestajneJedinice;
        private VrstaSmjestajneJedinice m_FK_CjenikStavka_VrstaSmjestajneJedinice;
        #endregion
        
		#region Constructors
        static CjenikStavka()
        {
            // Cache field metadata.
            EntityMeta<CjenikStavka>.LoadColumnMetadata
			(
				new ColumnMetadata("CjenikStavkaID", @"CjenikStavkaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("CjenikStavkaProtokolID", @"CjenikStavkaProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("CjenikStavkaSmjestajniObjekt", @"CjenikStavkaSmjestajniObjekt", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("CjenikStavkaSmjestajnaJedinica", @"CjenikStavkaSmjestajnaJedinica", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("CjenikStavkaTipSmjestajneJedinice", @"CjenikStavkaTipSmjestajneJedinice", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("CjenikStavkaPogledSmjestajneJedinice", @"CjenikStavkaPogledSmjestajneJedinice", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("CjenikStavkaVrstaSmjestajneJedinice", @"CjenikStavkaVrstaSmjestajneJedinice", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("CjenikStavkaVrstaSmjestajnogObjekta", @"CjenikStavkaVrstaSmjestajnogObjekta", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("CjenikStavkaSkupinaSmjestajnogObjekta", @"CjenikStavkaSkupinaSmjestajnogObjekta", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("CjenikStavkaBrojOsoba", @"CjenikStavkaBrojOsoba", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("CjenikStavkaPeriodOd", @"CjenikStavkaPeriodOd", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("CjenikStavkaPeriodDo", @"CjenikStavkaPeriodDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("CjenikStavkaIznos", @"CjenikStavkaIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikStavkaAlotmanskiIznos", @"CjenikStavkaAlotmanskiIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikStavkaDodatnaOsobaIznos", @"CjenikStavkaDodatnaOsobaIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikStavkaVrijediOd", @"CjenikStavkaVrijediOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("CjenikStavkaVrijediDo", @"CjenikStavkaVrijediDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("CjenikStavkaUradio", @"CjenikStavkaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("CjenikStavkaDatumIzmjene", @"CjenikStavkaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<CjenikStavka>.LoadRelationMetadata
			(
				new RelationMetadata("FK_CjenikStavka_Cjenik", "CjenikStavkaProtokolID", "CjenikProtokolID"),
                new RelationMetadata("FK_CjenikStavka_PogledSmjestajneJedinice", "CjenikStavkaPogledSmjestajneJedinice", "PogledSmjestajneJedinicePogledSmjestajneJedinice"),
                new RelationMetadata("FK_CjenikStavka_SmjestajnaJedinica", "CjenikStavkaSmjestajnaJedinica", "SmjestajnaJedinicaSmjestajnaJedinica"),
                new RelationMetadata("FK_CjenikStavka_SmjestajniObjekt", "CjenikStavkaSmjestajniObjekt", "SmjestajniObjektSmjestajniObjekt"),
                new RelationMetadata("FK_CjenikStavka_TipSmjestajneJedinice", "CjenikStavkaTipSmjestajneJedinice", "TipSmjestajneJediniceTipSmjestajneJedinice"),
                new RelationMetadata("FK_CjenikStavka_TipSmjestajneJedinice", "CjenikStavkaSmjestajniObjekt", "TipSmjestajneJediniceSmjestajniObjekt"),
                new RelationMetadata("FK_CjenikStavka_VrstaSmjestajneJedinice", "CjenikStavkaVrstaSmjestajneJedinice", "VrstaSmjestajneJediniceVrstaSmjestajneJedinice"),
                new RelationMetadata("FK_CjenikStavka_VrstaSmjestajneJedinice", "CjenikStavkaVrstaSmjestajnogObjekta", "VrstaSmjestajneJediniceVrstaSmjestajnogObjekta"),
                new RelationMetadata("FK_CjenikStavka_VrstaSmjestajneJedinice", "CjenikStavkaSkupinaSmjestajnogObjekta", "VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta")
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
		public Cjenik FK_CjenikStavka_Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_FK_CjenikStavka_Cjenik, this, "FK_CjenikStavka_Cjenik"); }
            set { EntityContext<Cjenik>.Set(ref m_FK_CjenikStavka_Cjenik, this, value, "FK_CjenikStavka_Cjenik"); }
        }
        public PogledSmjestajneJedinice FK_CjenikStavka_PogledSmjestajneJedinice
        {
            get { return EntityContext<PogledSmjestajneJedinice>.Get(ref m_FK_CjenikStavka_PogledSmjestajneJedinice, this, "FK_CjenikStavka_PogledSmjestajneJedinice"); }
            set { EntityContext<PogledSmjestajneJedinice>.Set(ref m_FK_CjenikStavka_PogledSmjestajneJedinice, this, value, "FK_CjenikStavka_PogledSmjestajneJedinice"); }
        }
        public SmjestajnaJedinica FK_CjenikStavka_SmjestajnaJedinica
        {
            get { return EntityContext<SmjestajnaJedinica>.Get(ref m_FK_CjenikStavka_SmjestajnaJedinica, this, "FK_CjenikStavka_SmjestajnaJedinica"); }
            set { EntityContext<SmjestajnaJedinica>.Set(ref m_FK_CjenikStavka_SmjestajnaJedinica, this, value, "FK_CjenikStavka_SmjestajnaJedinica"); }
        }
        public SmjestajniObjekt FK_CjenikStavka_SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_FK_CjenikStavka_SmjestajniObjekt, this, "FK_CjenikStavka_SmjestajniObjekt"); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_FK_CjenikStavka_SmjestajniObjekt, this, value, "FK_CjenikStavka_SmjestajniObjekt"); }
        }
        public TipSmjestajneJedinice FK_CjenikStavka_TipSmjestajneJedinice
        {
            get { return EntityContext<TipSmjestajneJedinice>.Get(ref m_FK_CjenikStavka_TipSmjestajneJedinice, this, "FK_CjenikStavka_TipSmjestajneJedinice"); }
            set { EntityContext<TipSmjestajneJedinice>.Set(ref m_FK_CjenikStavka_TipSmjestajneJedinice, this, value, "FK_CjenikStavka_TipSmjestajneJedinice"); }
        }
        public VrstaSmjestajneJedinice FK_CjenikStavka_VrstaSmjestajneJedinice
        {
            get { return EntityContext<VrstaSmjestajneJedinice>.Get(ref m_FK_CjenikStavka_VrstaSmjestajneJedinice, this, "FK_CjenikStavka_VrstaSmjestajneJedinice"); }
            set { EntityContext<VrstaSmjestajneJedinice>.Set(ref m_FK_CjenikStavka_VrstaSmjestajneJedinice, this, value, "FK_CjenikStavka_VrstaSmjestajneJedinice"); }
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

        #region Public methods
		public static IEnumerable<CjenikStavka> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<CjenikStavka>(queryConditions);
        }
        public static IEnumerable<CjenikStavka> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<CjenikStavka>(columnName, queryOp, value);
        }
		public static CjenikStavka GetByPrimaryKey(int CjenikStavkaID)
        {
            return GetByPrimaryKey<CjenikStavka>(CjenikStavkaID);
        }
		public static CjenikStavka TryGetByPrimaryKey(int CjenikStavkaID)
        {
            return TryGetByPrimaryKey<CjenikStavka>(CjenikStavkaID);
        }
        #endregion
    }
}