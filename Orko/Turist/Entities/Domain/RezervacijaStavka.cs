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
    /// RezervacijaStavka entity.
    /// </summary>
    public sealed partial class RezervacijaStavka : Entity
    {
		#region Members
		private Cjenik m_Cjenik;
        private Rezervacija m_Rezervacija;
        private SmjestajnaJedinica m_SmjestajnaJedinica;
        #endregion
        
		#region Constructors
        static RezervacijaStavka()
        {
            // Cache field metadata.
            EntityMeta<RezervacijaStavka>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(RezervacijaStavkaID), @"RezervacijaStavkaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaProtokolID), @"RezervacijaStavkaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaCjenikProtokolID), @"RezervacijaStavkaCjenikProtokolID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaSmjestajnaJedinica), @"RezervacijaStavkaSmjestajnaJedinica", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaRedniBroj), @"RezervacijaStavkaRedniBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaRezerviranoOd), @"RezervacijaStavkaRezerviranoOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaRezerviranoDo), @"RezervacijaStavkaRezerviranoDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaBrojNoci), @"RezervacijaStavkaBrojNoci", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaBrojOdraslih), @"RezervacijaStavkaBrojOdraslih", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaBrojDjece), @"RezervacijaStavkaBrojDjece", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaNapomena), @"RezervacijaStavkaNapomena", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaNocIznos), @"RezervacijaStavkaNocIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaPopustPostotak), @"RezervacijaStavkaPopustPostotak", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaPopustIznos), @"RezervacijaStavkaPopustIznos", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaUkupnoIznos), @"RezervacijaStavkaUkupnoIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaUkupnoIznosDevize), @"RezervacijaStavkaUkupnoIznosDevize", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(RezervacijaStavkaUradio), @"RezervacijaStavkaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaDatumIzmjene), @"RezervacijaStavkaDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<RezervacijaStavka>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Cjenik), nameof(RezervacijaStavkaCjenikProtokolID), nameof(Orko.Turist.Cjenik.CjenikProtokolID)),
                new RelationMetadata(nameof(Rezervacija), nameof(RezervacijaStavkaProtokolID), nameof(Orko.Turist.Rezervacija.RezervacijaProtokolID)),
                new RelationMetadata(nameof(SmjestajnaJedinica), nameof(RezervacijaStavkaSmjestajnaJedinica), nameof(Orko.Turist.SmjestajnaJedinica.SmjestajnaJedinicaSmjestajnaJedinica))
			);

			// Cache table metadata.
			EntityMeta<RezervacijaStavka>.HasLanguageTable = false;
            EntityMeta<RezervacijaStavka>.TableSchema = @"Turist";
            EntityMeta<RezervacijaStavka>.TableName = @"RezervacijaStavka";
            EntityMeta<RezervacijaStavka>.LanguageTableSchema = null;
            EntityMeta<RezervacijaStavka>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? RezervacijaStavkaID { get; private set; }
        public int? RezervacijaStavkaProtokolID { get; set; }
        public int? RezervacijaStavkaCjenikProtokolID { get; set; }
        public int? RezervacijaStavkaSmjestajnaJedinica { get; set; }
        public int? RezervacijaStavkaRedniBroj { get; set; }
        public DateTime? RezervacijaStavkaRezerviranoOd { get; set; }
        public DateTime? RezervacijaStavkaRezerviranoDo { get; set; }
        public int? RezervacijaStavkaBrojNoci { get; set; }
        public int? RezervacijaStavkaBrojOdraslih { get; set; }
        public int? RezervacijaStavkaBrojDjece { get; set; }
        public string RezervacijaStavkaNapomena { get; set; }
        public decimal? RezervacijaStavkaNocIznos { get; set; }
        public decimal? RezervacijaStavkaPopustPostotak { get; set; }
        public decimal? RezervacijaStavkaPopustIznos { get; set; }
        public decimal? RezervacijaStavkaUkupnoIznos { get; set; }
        public decimal? RezervacijaStavkaUkupnoIznosDevize { get; set; }
        public string RezervacijaStavkaUradio { get; set; }
        public DateTime? RezervacijaStavkaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public Cjenik Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_Cjenik, this, nameof(Cjenik)); }
            set { EntityContext<Cjenik>.Set(ref m_Cjenik, this, value, nameof(Cjenik)); }
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
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<RezervacijaStavka>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<RezervacijaStavka>(queryConditions);
        }
        public static async Task<IEnumerable<RezervacijaStavka>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<RezervacijaStavka>(columnName, queryOp, value);
        }
		public static async Task<RezervacijaStavka> GetByPrimaryKeyAsync(int RezervacijaStavkaID)
        {
            return await GetByPrimaryKeyAsync<RezervacijaStavka>(RezervacijaStavkaID);
        }
		public static async Task<RezervacijaStavka> TryGetByPrimaryKeyAsync(int RezervacijaStavkaID)
        {
            return await TryGetByPrimaryKeyAsync<RezervacijaStavka>(RezervacijaStavkaID);
        }
		#endregion
    }
}