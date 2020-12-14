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
    /// Rezervacija entity.
    /// </summary>
    public sealed partial class Rezervacija : Entity
    {
		#region Members
		private Narucitelj m_Narucitelj;
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
                new ColumnMetadata(nameof(RezervacijaNaruciteljID), @"RezervacijaNaruciteljID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaValuta), @"RezervacijaValuta", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaUslugeOd), @"RezervacijaUslugeOd", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaUslugeDo), @"RezervacijaUslugeDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaBrojDana), @"RezervacijaBrojDana", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaBrojOdraslih), @"RezervacijaBrojOdraslih", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaBrojDjece), @"RezervacijaBrojDjece", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaCijenaUslugeCjenik), @"RezervacijaCijenaUslugeCjenik", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaCijenaUslugePopustPostotak), @"RezervacijaCijenaUslugePopustPostotak", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaCijenaUslugePopustIznos), @"RezervacijaCijenaUslugePopustIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaCijenaUslugeNaplaceno), @"RezervacijaCijenaUslugeNaplaceno", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaCijenaUslugeKonacno), @"RezervacijaCijenaUslugeKonacno", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaNapomena), @"RezervacijaNapomena", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Rezervacija>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Narucitelj), nameof(RezervacijaNaruciteljID), nameof(Orko.Watersports.Narucitelj.NaruciteljID)),
                new RelationMetadata(nameof(Protokol), nameof(RezervacijaProtokolID), nameof(Orko.Base.Protokol.ProtokolID)),
                new RelationMetadata(nameof(Valuta), nameof(RezervacijaValuta), nameof(Orko.Base.Valuta.ValutaValuta))
			);

			// Cache table metadata.
			EntityMeta<Rezervacija>.HasLanguageTable = false;
            EntityMeta<Rezervacija>.TableSchema = @"Watersports";
            EntityMeta<Rezervacija>.TableName = @"Rezervacija";
            EntityMeta<Rezervacija>.LanguageTableSchema = null;
            EntityMeta<Rezervacija>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? RezervacijaProtokolID { get; set; }
        public int? RezervacijaNaruciteljID { get; set; }
        public string RezervacijaValuta { get; set; }
        public DateTime? RezervacijaUslugeOd { get; set; }
        public DateTime? RezervacijaUslugeDo { get; set; }
        public int? RezervacijaBrojDana { get; set; }
        public int? RezervacijaBrojOdraslih { get; set; }
        public int? RezervacijaBrojDjece { get; set; }
        public decimal? RezervacijaCijenaUslugeCjenik { get; set; }
        public decimal? RezervacijaCijenaUslugePopustPostotak { get; set; }
        public decimal? RezervacijaCijenaUslugePopustIznos { get; set; }
        public decimal? RezervacijaCijenaUslugeNaplaceno { get; set; }
        public decimal? RezervacijaCijenaUslugeKonacno { get; set; }
        public string RezervacijaNapomena { get; set; }
        #endregion

        #region Entities
		public Narucitelj Narucitelj
        {
            get { return EntityContext<Narucitelj>.Get(ref m_Narucitelj, this, nameof(Narucitelj)); }
            set { EntityContext<Narucitelj>.Set(ref m_Narucitelj, this, value, nameof(Narucitelj)); }
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