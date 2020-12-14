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
    /// CjenikStavka entity.
    /// </summary>
    public sealed partial class CjenikStavka : Entity
    {
		#region Members
		private Cjenik m_Cjenik;
        private Base.Evidencija m_Evidencija;
        private TipBroda m_TipBroda;
        private VrstaBroda m_VrstaBroda;
        private VrstaIzleta m_VrstaIzleta;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static CjenikStavka()
        {
            // Cache field metadata.
            EntityMeta<CjenikStavka>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CjenikStavkaID), @"CjenikStavkaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaProtokolID), @"CjenikStavkaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaVrstaUsluge), @"CjenikStavkaVrstaUsluge", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaVrstaIzleta), @"CjenikStavkaVrstaIzleta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaVrstaBroda), @"CjenikStavkaVrstaBroda", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaTipBroda), @"CjenikStavkaTipBroda", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaTrajanje), @"CjenikStavkaTrajanje", DbType.Time, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaSkiperUkljucen), @"CjenikStavkaSkiperUkljucen", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaGorivoUkljuceno), @"CjenikStavkaGorivoUkljuceno", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(CjenikStavkaCijena), @"CjenikStavkaCijena", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(CjenikStavkaEvidencijaID), @"CjenikStavkaEvidencijaID", DbType.Int32, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<CjenikStavka>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Cjenik), nameof(CjenikStavkaProtokolID), nameof(Orko.Watersports.Cjenik.CjenikProtokolID)),
                new RelationMetadata(nameof(Evidencija), nameof(CjenikStavkaEvidencijaID), nameof(Orko.Base.Evidencija.EvidencijaID)),
                new RelationMetadata(nameof(TipBroda), nameof(CjenikStavkaTipBroda), nameof(Orko.Watersports.TipBroda.TipBrodaTipBroda)),
                new RelationMetadata(nameof(VrstaBroda), nameof(CjenikStavkaVrstaBroda), nameof(Orko.Watersports.VrstaBroda.VrstaBrodaVrstaBroda)),
                new RelationMetadata(nameof(VrstaIzleta), nameof(CjenikStavkaVrstaIzleta), nameof(Orko.Watersports.VrstaIzleta.VrstaIzletaVrstaIzleta)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(CjenikStavkaVrstaUsluge), nameof(Orko.Watersports.VrstaUsluge.VrstaUslugeVrstaUsluge))
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
		public Cjenik Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_Cjenik, this, nameof(Cjenik)); }
            set { EntityContext<Cjenik>.Set(ref m_Cjenik, this, value, nameof(Cjenik)); }
        }
        public Base.Evidencija Evidencija
        {
            get { return EntityContext<Base.Evidencija>.Get(ref m_Evidencija, this, nameof(Evidencija)); }
            set { EntityContext<Base.Evidencija>.Set(ref m_Evidencija, this, value, nameof(Evidencija)); }
        }
        public TipBroda TipBroda
        {
            get { return EntityContext<TipBroda>.Get(ref m_TipBroda, this, nameof(TipBroda)); }
            set { EntityContext<TipBroda>.Set(ref m_TipBroda, this, value, nameof(TipBroda)); }
        }
        public VrstaBroda VrstaBroda
        {
            get { return EntityContext<VrstaBroda>.Get(ref m_VrstaBroda, this, nameof(VrstaBroda)); }
            set { EntityContext<VrstaBroda>.Set(ref m_VrstaBroda, this, value, nameof(VrstaBroda)); }
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