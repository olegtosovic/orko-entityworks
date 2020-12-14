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
    /// RezervacijaUsluga entity.
    /// </summary>
    public sealed partial class RezervacijaUsluga : Entity
    {
		#region Members
		private Cjenik m_Cjenik;
        private Gost m_Gost;
        private RazinaUsluge m_RazinaUsluge;
        private Rezervacija m_Rezervacija;
        private SmjestajnaJedinica m_SmjestajnaJedinica;
        private SmjestajniObjekt m_SmjestajniObjekt;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static RezervacijaUsluga()
        {
            // Cache field metadata.
            EntityMeta<RezervacijaUsluga>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(RezervacijaUslugaID), @"RezervacijaUslugaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugaProtokolID), @"RezervacijaUslugaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugaCjenikProtokolID), @"RezervacijaUslugaCjenikProtokolID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaUslugaRedniBroj), @"RezervacijaUslugaRedniBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugaVrstaUsluge), @"RezervacijaUslugaVrstaUsluge", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugaRazinaUsluge), @"RezervacijaUslugaRazinaUsluge", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugaSmjestajniObjekt), @"RezervacijaUslugaSmjestajniObjekt", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugaSmjestajnaJedinica), @"RezervacijaUslugaSmjestajnaJedinica", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaUslugaGost), @"RezervacijaUslugaGost", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaUslugaKolicina), @"RezervacijaUslugaKolicina", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugaUkupnoIznos), @"RezervacijaUslugaUkupnoIznos", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugaUradio), @"RezervacijaUslugaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugaDatumIzmjene), @"RezervacijaUslugaDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<RezervacijaUsluga>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Cjenik), nameof(RezervacijaUslugaCjenikProtokolID), nameof(Orko.Turist.Cjenik.CjenikProtokolID)),
                new RelationMetadata(nameof(Gost), nameof(RezervacijaUslugaGost), nameof(Orko.Turist.Gost.GostGost)),
                new RelationMetadata(nameof(RazinaUsluge), nameof(RezervacijaUslugaRazinaUsluge), nameof(Orko.Turist.RazinaUsluge.RazinaUslugeRazinaUsluge)),
                new RelationMetadata(nameof(Rezervacija), nameof(RezervacijaUslugaProtokolID), nameof(Orko.Turist.Rezervacija.RezervacijaProtokolID)),
                new RelationMetadata(nameof(SmjestajnaJedinica), nameof(RezervacijaUslugaSmjestajnaJedinica), nameof(Orko.Turist.SmjestajnaJedinica.SmjestajnaJedinicaSmjestajnaJedinica)),
                new RelationMetadata(nameof(SmjestajniObjekt), nameof(RezervacijaUslugaSmjestajniObjekt), nameof(Orko.Turist.SmjestajniObjekt.SmjestajniObjektSmjestajniObjekt)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(RezervacijaUslugaVrstaUsluge), nameof(Orko.Turist.VrstaUsluge.VrstaUslugeVrstaUsluge))
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
		public Cjenik Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_Cjenik, this, nameof(Cjenik)); }
            set { EntityContext<Cjenik>.Set(ref m_Cjenik, this, value, nameof(Cjenik)); }
        }
        public Gost Gost
        {
            get { return EntityContext<Gost>.Get(ref m_Gost, this, nameof(Gost)); }
            set { EntityContext<Gost>.Set(ref m_Gost, this, value, nameof(Gost)); }
        }
        public RazinaUsluge RazinaUsluge
        {
            get { return EntityContext<RazinaUsluge>.Get(ref m_RazinaUsluge, this, nameof(RazinaUsluge)); }
            set { EntityContext<RazinaUsluge>.Set(ref m_RazinaUsluge, this, value, nameof(RazinaUsluge)); }
        }
        public Rezervacija Rezervacija
        {
            get { return EntityContext<Rezervacija>.Get(ref m_Rezervacija, this, nameof(Rezervacija)); }
            set { EntityContext<Rezervacija>.Set(ref m_Rezervacija, this, value, nameof(Rezervacija)); }
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
        public VrstaUsluge VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_VrstaUsluge, this, nameof(VrstaUsluge)); }
            set { EntityContext<VrstaUsluge>.Set(ref m_VrstaUsluge, this, value, nameof(VrstaUsluge)); }
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
    }
}