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
    /// Rezervacija entity.
    /// </summary>
    public sealed partial class Rezervacija : Entity
    {
		#region Members
		private Gost m_FK_Rezervacija_Gost;
        private IzvorRezervacije m_FK_Rezervacija_IzvorRezervacije;
        private Base.Protokol m_FK_Rezervacija_Protokol;
        private Base.Valuta m_FK_Rezervacija_Valuta;
        #endregion
        
		#region Constructors
        static Rezervacija()
        {
            // Cache field metadata.
            EntityMeta<Rezervacija>.LoadColumnMetadata
			(
				new ColumnMetadata("RezervacijaProtokolID", @"RezervacijaProtokolID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("RezervacijaGost", @"RezervacijaGost", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaValuta", @"RezervacijaValuta", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("RezervacijaIzvorRezervacije", @"RezervacijaIzvorRezervacije", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("RezervacijaDatumNajave", @"RezervacijaDatumNajave", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("RezervacijaOd", @"RezervacijaOd", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("RezervacijaDo", @"RezervacijaDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("RezervacijaBrojNoci", @"RezervacijaBrojNoci", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaBrojNociKalkulativno", @"RezervacijaBrojNociKalkulativno", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaBrojOdraslih", @"RezervacijaBrojOdraslih", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaBrojDjece", @"RezervacijaBrojDjece", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaNapomena", @"RezervacijaNapomena", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("RezervacijaCijenaCjenikIznos", @"RezervacijaCijenaCjenikIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaCijenaKonacnoIznos", @"RezervacijaCijenaKonacnoIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaPopustPostotak", @"RezervacijaPopustPostotak", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaPopustIznos", @"RezervacijaPopustIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaDepozitPostotak", @"RezervacijaDepozitPostotak", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaDepozitIznos", @"RezervacijaDepozitIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaPlacena", @"RezervacijaPlacena", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("RezervacijaDepozitPlacen", @"RezervacijaDepozitPlacen", SqlDbType.Bit, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Rezervacija>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Rezervacija_Gost", "RezervacijaGost", "GostGost"),
                new RelationMetadata("FK_Rezervacija_IzvorRezervacije", "RezervacijaIzvorRezervacije", "IzvorRezervacijeIzvorRezervacije"),
                new RelationMetadata("FK_Rezervacija_Protokol", "RezervacijaProtokolID", "ProtokolID"),
                new RelationMetadata("FK_Rezervacija_Valuta", "RezervacijaValuta", "ValutaValuta")
			);

			// Cache table metadata.
			EntityMeta<Rezervacija>.HasLanguageTable = false;
            EntityMeta<Rezervacija>.TableSchema = @"Turist";
            EntityMeta<Rezervacija>.TableName = @"Rezervacija";
            EntityMeta<Rezervacija>.LanguageTableSchema = null;
            EntityMeta<Rezervacija>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? RezervacijaProtokolID { get; set; }
        public int? RezervacijaGost { get; set; }
        public string RezervacijaValuta { get; set; }
        public string RezervacijaIzvorRezervacije { get; set; }
        public DateTime? RezervacijaDatumNajave { get; set; }
        public DateTime? RezervacijaOd { get; set; }
        public DateTime? RezervacijaDo { get; set; }
        public int? RezervacijaBrojNoci { get; set; }
        public int? RezervacijaBrojNociKalkulativno { get; set; }
        public int? RezervacijaBrojOdraslih { get; set; }
        public int? RezervacijaBrojDjece { get; set; }
        public string RezervacijaNapomena { get; set; }
        public decimal? RezervacijaCijenaCjenikIznos { get; set; }
        public decimal? RezervacijaCijenaKonacnoIznos { get; set; }
        public decimal? RezervacijaPopustPostotak { get; set; }
        public decimal? RezervacijaPopustIznos { get; set; }
        public decimal? RezervacijaDepozitPostotak { get; set; }
        public decimal? RezervacijaDepozitIznos { get; set; }
        public bool? RezervacijaPlacena { get; set; }
        public bool? RezervacijaDepozitPlacen { get; set; }
        #endregion

        #region Entities
		public Gost FK_Rezervacija_Gost
        {
            get { return EntityContext<Gost>.Get(ref m_FK_Rezervacija_Gost, this, "FK_Rezervacija_Gost"); }
            set { EntityContext<Gost>.Set(ref m_FK_Rezervacija_Gost, this, value, "FK_Rezervacija_Gost"); }
        }
        public IzvorRezervacije FK_Rezervacija_IzvorRezervacije
        {
            get { return EntityContext<IzvorRezervacije>.Get(ref m_FK_Rezervacija_IzvorRezervacije, this, "FK_Rezervacija_IzvorRezervacije"); }
            set { EntityContext<IzvorRezervacije>.Set(ref m_FK_Rezervacija_IzvorRezervacije, this, value, "FK_Rezervacija_IzvorRezervacije"); }
        }
        public Base.Protokol FK_Rezervacija_Protokol
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_FK_Rezervacija_Protokol, this, "FK_Rezervacija_Protokol"); }
            set { EntityContext<Base.Protokol>.Set(ref m_FK_Rezervacija_Protokol, this, value, "FK_Rezervacija_Protokol"); }
        }
        public Base.Valuta FK_Rezervacija_Valuta
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_FK_Rezervacija_Valuta, this, "FK_Rezervacija_Valuta"); }
            set { EntityContext<Base.Valuta>.Set(ref m_FK_Rezervacija_Valuta, this, value, "FK_Rezervacija_Valuta"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Rezervacija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Rezervacija>(queryConditions);
        }
        public static async Task<IEnumerable<Rezervacija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Rezervacija>(columnName, queryOp, value);
        }
		public static async Task<Rezervacija> GetByPrimaryKeyAsync(int RezervacijaProtokolID)
        {
            return await GetByPrimaryKeyAsync<Rezervacija>(RezervacijaProtokolID);
        }
		public static async Task<Rezervacija> TryGetByPrimaryKeyAsync(int RezervacijaProtokolID)
        {
            return await TryGetByPrimaryKeyAsync<Rezervacija>(RezervacijaProtokolID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Rezervacija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Rezervacija>(queryConditions);
        }
        public static IEnumerable<Rezervacija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Rezervacija>(columnName, queryOp, value);
        }
		public static Rezervacija GetByPrimaryKey(int RezervacijaProtokolID)
        {
            return GetByPrimaryKey<Rezervacija>(RezervacijaProtokolID);
        }
		public static Rezervacija TryGetByPrimaryKey(int RezervacijaProtokolID)
        {
            return TryGetByPrimaryKey<Rezervacija>(RezervacijaProtokolID);
        }
        #endregion
    }
}