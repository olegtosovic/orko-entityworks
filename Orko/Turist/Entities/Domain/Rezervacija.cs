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
    /// Rezervacija entity.
    /// </summary>
    public sealed partial class Rezervacija : Entity
    {
		#region Members
		private Gost m_Gost;
        private IzvorRezervacije m_IzvorRezervacije;
        private Base.Protokol m_Protokol;
        private Base.Valuta m_Valuta;
        #endregion
        
		#region Constructors
        static Rezervacija()
        {
            // Cache field metadata.
            EntityMeta<Rezervacija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(RezervacijaProtokolID), @"RezervacijaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaGost), @"RezervacijaGost", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaValuta), @"RezervacijaValuta", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaIzvorRezervacije), @"RezervacijaIzvorRezervacije", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaDatumNajave), @"RezervacijaDatumNajave", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaOd), @"RezervacijaOd", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaDo), @"RezervacijaDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaBrojNoci), @"RezervacijaBrojNoci", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaBrojNociKalkulativno), @"RezervacijaBrojNociKalkulativno", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaBrojOdraslih), @"RezervacijaBrojOdraslih", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaBrojDjece), @"RezervacijaBrojDjece", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaNapomena), @"RezervacijaNapomena", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaCijenaCjenikIznos), @"RezervacijaCijenaCjenikIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaCijenaKonacnoIznos), @"RezervacijaCijenaKonacnoIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaPopustPostotak), @"RezervacijaPopustPostotak", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaPopustIznos), @"RezervacijaPopustIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaDepozitPostotak), @"RezervacijaDepozitPostotak", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaDepozitIznos), @"RezervacijaDepozitIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaPlacena), @"RezervacijaPlacena", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaDepozitPlacen), @"RezervacijaDepozitPlacen", DbType.Boolean, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Rezervacija>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Gost), nameof(RezervacijaGost), nameof(Orko.Turist.Gost.GostGost)),
                new RelationMetadata(nameof(IzvorRezervacije), nameof(RezervacijaIzvorRezervacije), nameof(Orko.Turist.IzvorRezervacije.IzvorRezervacijeIzvorRezervacije)),
                new RelationMetadata(nameof(Protokol), nameof(RezervacijaProtokolID), nameof(Orko.Base.Protokol.ProtokolID)),
                new RelationMetadata(nameof(Valuta), nameof(RezervacijaValuta), nameof(Orko.Base.Valuta.ValutaValuta))
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
		public Gost Gost
        {
            get { return EntityContext<Gost>.Get(ref m_Gost, this, nameof(Gost)); }
            set { EntityContext<Gost>.Set(ref m_Gost, this, value, nameof(Gost)); }
        }
        public IzvorRezervacije IzvorRezervacije
        {
            get { return EntityContext<IzvorRezervacije>.Get(ref m_IzvorRezervacije, this, nameof(IzvorRezervacije)); }
            set { EntityContext<IzvorRezervacije>.Set(ref m_IzvorRezervacije, this, value, nameof(IzvorRezervacije)); }
        }
        public Base.Protokol Protokol
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_Protokol, this, nameof(Protokol)); }
            set { EntityContext<Base.Protokol>.Set(ref m_Protokol, this, value, nameof(Protokol)); }
        }
        public Base.Valuta Valuta
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_Valuta, this, nameof(Valuta)); }
            set { EntityContext<Base.Valuta>.Set(ref m_Valuta, this, value, nameof(Valuta)); }
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
    }
}