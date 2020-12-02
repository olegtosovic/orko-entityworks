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
    /// RezervacijaUsluga entity.
    /// </summary>
    public sealed partial class RezervacijaUsluga : Entity
    {
		#region Members
		private Cjenik m_FK_RezervacijaUsluga_Cjenik;
        private Gost m_FK_RezervacijaUsluga_Gost;
        private RazinaUsluge m_FK_RezervacijaUsluga_RazinaUsluge;
        private Rezervacija m_FK_RezervacijaUsluga_Rezervacija;
        private SmjestajnaJedinica m_FK_RezervacijaUsluga_SmjestajnaJedinica;
        private SmjestajniObjekt m_FK_RezervacijaUsluga_SmjestajniObjekt;
        private VrstaUsluge m_FK_RezervacijaUsluga_VrstaUsluge;
        #endregion
        
		#region Constructors
        static RezervacijaUsluga()
        {
            // Cache field metadata.
            EntityMeta<RezervacijaUsluga>.LoadColumnMetadata
			(
				new ColumnMetadata("RezervacijaUslugaID", @"RezervacijaUslugaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("RezervacijaUslugaProtokolID", @"RezervacijaUslugaProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaUslugaCjenikProtokolID", @"RezervacijaUslugaCjenikProtokolID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaUslugaRedniBroj", @"RezervacijaUslugaRedniBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaUslugaVrstaUsluge", @"RezervacijaUslugaVrstaUsluge", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaUslugaRazinaUsluge", @"RezervacijaUslugaRazinaUsluge", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("RezervacijaUslugaSmjestajniObjekt", @"RezervacijaUslugaSmjestajniObjekt", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaUslugaSmjestajnaJedinica", @"RezervacijaUslugaSmjestajnaJedinica", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaUslugaGost", @"RezervacijaUslugaGost", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaUslugaKolicina", @"RezervacijaUslugaKolicina", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("RezervacijaUslugaUkupnoIznos", @"RezervacijaUslugaUkupnoIznos", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("RezervacijaUslugaUradio", @"RezervacijaUslugaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("RezervacijaUslugaDatumIzmjene", @"RezervacijaUslugaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<RezervacijaUsluga>.LoadRelationMetadata
			(
				new RelationMetadata("FK_RezervacijaUsluga_Cjenik", "RezervacijaUslugaCjenikProtokolID", "CjenikProtokolID"),
                new RelationMetadata("FK_RezervacijaUsluga_Gost", "RezervacijaUslugaGost", "GostGost"),
                new RelationMetadata("FK_RezervacijaUsluga_RazinaUsluge", "RezervacijaUslugaRazinaUsluge", "RazinaUslugeRazinaUsluge"),
                new RelationMetadata("FK_RezervacijaUsluga_Rezervacija", "RezervacijaUslugaProtokolID", "RezervacijaProtokolID"),
                new RelationMetadata("FK_RezervacijaUsluga_SmjestajnaJedinica", "RezervacijaUslugaSmjestajnaJedinica", "SmjestajnaJedinicaSmjestajnaJedinica"),
                new RelationMetadata("FK_RezervacijaUsluga_SmjestajniObjekt", "RezervacijaUslugaSmjestajniObjekt", "SmjestajniObjektSmjestajniObjekt"),
                new RelationMetadata("FK_RezervacijaUsluga_VrstaUsluge", "RezervacijaUslugaVrstaUsluge", "VrstaUslugeVrstaUsluge")
			);

			// Cache table metadata.
			EntityMeta<RezervacijaUsluga>.HasLanguageTable = false;
            EntityMeta<RezervacijaUsluga>.TableSchema = @"Turist";
            EntityMeta<RezervacijaUsluga>.TableName = @"RezervacijaUsluga";
            EntityMeta<RezervacijaUsluga>.LanguageTableSchema = null;
            EntityMeta<RezervacijaUsluga>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? RezervacijaUslugaID { get; private set; }
        public int? RezervacijaUslugaProtokolID { get; set; }
        public int? RezervacijaUslugaCjenikProtokolID { get; set; }
        public int? RezervacijaUslugaRedniBroj { get; set; }
        public int? RezervacijaUslugaVrstaUsluge { get; set; }
        public string RezervacijaUslugaRazinaUsluge { get; set; }
        public int? RezervacijaUslugaSmjestajniObjekt { get; set; }
        public int? RezervacijaUslugaSmjestajnaJedinica { get; set; }
        public int? RezervacijaUslugaGost { get; set; }
        public decimal? RezervacijaUslugaKolicina { get; set; }
        public decimal? RezervacijaUslugaUkupnoIznos { get; set; }
        public string RezervacijaUslugaUradio { get; set; }
        public DateTime? RezervacijaUslugaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public Cjenik FK_RezervacijaUsluga_Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_FK_RezervacijaUsluga_Cjenik, this, "FK_RezervacijaUsluga_Cjenik"); }
            set { EntityContext<Cjenik>.Set(ref m_FK_RezervacijaUsluga_Cjenik, this, value, "FK_RezervacijaUsluga_Cjenik"); }
        }
        public Gost FK_RezervacijaUsluga_Gost
        {
            get { return EntityContext<Gost>.Get(ref m_FK_RezervacijaUsluga_Gost, this, "FK_RezervacijaUsluga_Gost"); }
            set { EntityContext<Gost>.Set(ref m_FK_RezervacijaUsluga_Gost, this, value, "FK_RezervacijaUsluga_Gost"); }
        }
        public RazinaUsluge FK_RezervacijaUsluga_RazinaUsluge
        {
            get { return EntityContext<RazinaUsluge>.Get(ref m_FK_RezervacijaUsluga_RazinaUsluge, this, "FK_RezervacijaUsluga_RazinaUsluge"); }
            set { EntityContext<RazinaUsluge>.Set(ref m_FK_RezervacijaUsluga_RazinaUsluge, this, value, "FK_RezervacijaUsluga_RazinaUsluge"); }
        }
        public Rezervacija FK_RezervacijaUsluga_Rezervacija
        {
            get { return EntityContext<Rezervacija>.Get(ref m_FK_RezervacijaUsluga_Rezervacija, this, "FK_RezervacijaUsluga_Rezervacija"); }
            set { EntityContext<Rezervacija>.Set(ref m_FK_RezervacijaUsluga_Rezervacija, this, value, "FK_RezervacijaUsluga_Rezervacija"); }
        }
        public SmjestajnaJedinica FK_RezervacijaUsluga_SmjestajnaJedinica
        {
            get { return EntityContext<SmjestajnaJedinica>.Get(ref m_FK_RezervacijaUsluga_SmjestajnaJedinica, this, "FK_RezervacijaUsluga_SmjestajnaJedinica"); }
            set { EntityContext<SmjestajnaJedinica>.Set(ref m_FK_RezervacijaUsluga_SmjestajnaJedinica, this, value, "FK_RezervacijaUsluga_SmjestajnaJedinica"); }
        }
        public SmjestajniObjekt FK_RezervacijaUsluga_SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_FK_RezervacijaUsluga_SmjestajniObjekt, this, "FK_RezervacijaUsluga_SmjestajniObjekt"); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_FK_RezervacijaUsluga_SmjestajniObjekt, this, value, "FK_RezervacijaUsluga_SmjestajniObjekt"); }
        }
        public VrstaUsluge FK_RezervacijaUsluga_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_RezervacijaUsluga_VrstaUsluge, this, "FK_RezervacijaUsluga_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_RezervacijaUsluga_VrstaUsluge, this, value, "FK_RezervacijaUsluga_VrstaUsluge"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<RezervacijaUsluga>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<RezervacijaUsluga>(queryConditions);
        }
        public static async Task<IEnumerable<RezervacijaUsluga>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<RezervacijaUsluga>(columnName, queryOp, value);
        }
		public static async Task<RezervacijaUsluga> GetByPrimaryKeyAsync(int RezervacijaUslugaID)
        {
            return await GetByPrimaryKeyAsync<RezervacijaUsluga>(RezervacijaUslugaID);
        }
		public static async Task<RezervacijaUsluga> TryGetByPrimaryKeyAsync(int RezervacijaUslugaID)
        {
            return await TryGetByPrimaryKeyAsync<RezervacijaUsluga>(RezervacijaUslugaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<RezervacijaUsluga> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<RezervacijaUsluga>(queryConditions);
        }
        public static IEnumerable<RezervacijaUsluga> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<RezervacijaUsluga>(columnName, queryOp, value);
        }
		public static RezervacijaUsluga GetByPrimaryKey(int RezervacijaUslugaID)
        {
            return GetByPrimaryKey<RezervacijaUsluga>(RezervacijaUslugaID);
        }
		public static RezervacijaUsluga TryGetByPrimaryKey(int RezervacijaUslugaID)
        {
            return TryGetByPrimaryKey<RezervacijaUsluga>(RezervacijaUslugaID);
        }
        #endregion
    }
}