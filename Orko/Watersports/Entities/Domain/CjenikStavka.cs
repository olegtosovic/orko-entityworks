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
    /// CjenikStavka entity.
    /// </summary>
    public sealed partial class CjenikStavka : Entity
    {
		#region Members
		private Cjenik m_FK_CjenikStavka_Cjenik;
        private Base.Evidencija m_FK_CjenikStavka_Evidencija;
        private TipBroda m_FK_CjenikStavka_TipBroda;
        private VrstaBroda m_FK_CjenikStavka_VrstaBroda;
        private VrstaIzleta m_FK_CjenikStavka_VrstaIzleta;
        private VrstaUsluge m_FK_CjenikStavka_VrstaUsluge;
        #endregion
        
		#region Constructors
        static CjenikStavka()
        {
            // Cache field metadata.
            EntityMeta<CjenikStavka>.LoadColumnMetadata
			(
				new ColumnMetadata("CjenikStavkaID", @"CjenikStavkaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("CjenikStavkaProtokolID", @"CjenikStavkaProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("CjenikStavkaVrstaUsluge", @"CjenikStavkaVrstaUsluge", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("CjenikStavkaVrstaIzleta", @"CjenikStavkaVrstaIzleta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("CjenikStavkaVrstaBroda", @"CjenikStavkaVrstaBroda", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("CjenikStavkaTipBroda", @"CjenikStavkaTipBroda", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("CjenikStavkaTrajanje", @"CjenikStavkaTrajanje", SqlDbType.Time, isRequired: false),
                new ColumnMetadata("CjenikStavkaSkiperUkljucen", @"CjenikStavkaSkiperUkljucen", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("CjenikStavkaGorivoUkljuceno", @"CjenikStavkaGorivoUkljuceno", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("CjenikStavkaCijena", @"CjenikStavkaCijena", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("CjenikStavkaEvidencijaID", @"CjenikStavkaEvidencijaID", SqlDbType.Int, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<CjenikStavka>.LoadRelationMetadata
			(
				new RelationMetadata("FK_CjenikStavka_Cjenik", "CjenikStavkaProtokolID", "CjenikProtokolID"),
                new RelationMetadata("FK_CjenikStavka_Evidencija", "CjenikStavkaEvidencijaID", "EvidencijaID"),
                new RelationMetadata("FK_CjenikStavka_TipBroda", "CjenikStavkaTipBroda", "TipBrodaTipBroda"),
                new RelationMetadata("FK_CjenikStavka_VrstaBroda", "CjenikStavkaVrstaBroda", "VrstaBrodaVrstaBroda"),
                new RelationMetadata("FK_CjenikStavka_VrstaIzleta", "CjenikStavkaVrstaIzleta", "VrstaIzletaVrstaIzleta"),
                new RelationMetadata("FK_CjenikStavka_VrstaUsluge", "CjenikStavkaVrstaUsluge", "VrstaUslugeVrstaUsluge")
			);

			// Cache table metadata.
			EntityMeta<CjenikStavka>.HasLanguageTable = false;
            EntityMeta<CjenikStavka>.TableSchema = @"Watersports";
            EntityMeta<CjenikStavka>.TableName = @"CjenikStavka";
            EntityMeta<CjenikStavka>.LanguageTableSchema = null;
            EntityMeta<CjenikStavka>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CjenikStavkaID { get; private set; }
        public int? CjenikStavkaProtokolID { get; set; }
        public string CjenikStavkaVrstaUsluge { get; set; }
        public string CjenikStavkaVrstaIzleta { get; set; }
        public string CjenikStavkaVrstaBroda { get; set; }
        public string CjenikStavkaTipBroda { get; set; }
        public TimeSpan? CjenikStavkaTrajanje { get; set; }
        public bool? CjenikStavkaSkiperUkljucen { get; set; }
        public bool? CjenikStavkaGorivoUkljuceno { get; set; }
        public decimal? CjenikStavkaCijena { get; set; }
        public int? CjenikStavkaEvidencijaID { get; set; }
        #endregion

        #region Entities
		public Cjenik FK_CjenikStavka_Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_FK_CjenikStavka_Cjenik, this, "FK_CjenikStavka_Cjenik"); }
            set { EntityContext<Cjenik>.Set(ref m_FK_CjenikStavka_Cjenik, this, value, "FK_CjenikStavka_Cjenik"); }
        }
        public Base.Evidencija FK_CjenikStavka_Evidencija
        {
            get { return EntityContext<Base.Evidencija>.Get(ref m_FK_CjenikStavka_Evidencija, this, "FK_CjenikStavka_Evidencija"); }
            set { EntityContext<Base.Evidencija>.Set(ref m_FK_CjenikStavka_Evidencija, this, value, "FK_CjenikStavka_Evidencija"); }
        }
        public TipBroda FK_CjenikStavka_TipBroda
        {
            get { return EntityContext<TipBroda>.Get(ref m_FK_CjenikStavka_TipBroda, this, "FK_CjenikStavka_TipBroda"); }
            set { EntityContext<TipBroda>.Set(ref m_FK_CjenikStavka_TipBroda, this, value, "FK_CjenikStavka_TipBroda"); }
        }
        public VrstaBroda FK_CjenikStavka_VrstaBroda
        {
            get { return EntityContext<VrstaBroda>.Get(ref m_FK_CjenikStavka_VrstaBroda, this, "FK_CjenikStavka_VrstaBroda"); }
            set { EntityContext<VrstaBroda>.Set(ref m_FK_CjenikStavka_VrstaBroda, this, value, "FK_CjenikStavka_VrstaBroda"); }
        }
        public VrstaIzleta FK_CjenikStavka_VrstaIzleta
        {
            get { return EntityContext<VrstaIzleta>.Get(ref m_FK_CjenikStavka_VrstaIzleta, this, "FK_CjenikStavka_VrstaIzleta"); }
            set { EntityContext<VrstaIzleta>.Set(ref m_FK_CjenikStavka_VrstaIzleta, this, value, "FK_CjenikStavka_VrstaIzleta"); }
        }
        public VrstaUsluge FK_CjenikStavka_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_CjenikStavka_VrstaUsluge, this, "FK_CjenikStavka_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_CjenikStavka_VrstaUsluge, this, value, "FK_CjenikStavka_VrstaUsluge"); }
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