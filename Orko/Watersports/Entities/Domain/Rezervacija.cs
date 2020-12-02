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
    /// Rezervacija entity.
    /// </summary>
    public sealed partial class Rezervacija : Entity
    {
		#region Members
		private Narucitelj m_FK_Rezervacija_Narucitelj;
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
                new ColumnMetadata("RezervacijaNaruciteljID", @"RezervacijaNaruciteljID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaValuta", @"RezervacijaValuta", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("RezervacijaUslugeOd", @"RezervacijaUslugeOd", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("RezervacijaUslugeDo", @"RezervacijaUslugeDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("RezervacijaBrojDana", @"RezervacijaBrojDana", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaBrojOdraslih", @"RezervacijaBrojOdraslih", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaBrojDjece", @"RezervacijaBrojDjece", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaCijenaUslugeCjenik", @"RezervacijaCijenaUslugeCjenik", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaCijenaUslugePopustPostotak", @"RezervacijaCijenaUslugePopustPostotak", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaCijenaUslugePopustIznos", @"RezervacijaCijenaUslugePopustIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaCijenaUslugeNaplaceno", @"RezervacijaCijenaUslugeNaplaceno", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaCijenaUslugeKonacno", @"RezervacijaCijenaUslugeKonacno", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaNapomena", @"RezervacijaNapomena", SqlDbType.NVarChar, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Rezervacija>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Rezervacija_Narucitelj", "RezervacijaNaruciteljID", "NaruciteljID"),
                new RelationMetadata("FK_Rezervacija_Protokol", "RezervacijaProtokolID", "ProtokolID"),
                new RelationMetadata("FK_Rezervacija_Valuta", "RezervacijaValuta", "ValutaValuta")
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
		public Narucitelj FK_Rezervacija_Narucitelj
        {
            get { return EntityContext<Narucitelj>.Get(ref m_FK_Rezervacija_Narucitelj, this, "FK_Rezervacija_Narucitelj"); }
            set { EntityContext<Narucitelj>.Set(ref m_FK_Rezervacija_Narucitelj, this, value, "FK_Rezervacija_Narucitelj"); }
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