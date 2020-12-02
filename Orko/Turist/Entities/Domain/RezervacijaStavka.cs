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
    /// RezervacijaStavka entity.
    /// </summary>
    public sealed partial class RezervacijaStavka : Entity
    {
		#region Members
		private Cjenik m_FK_RezervacijaStavka_Cjenik;
        private Rezervacija m_FK_RezervacijaStavka_Rezervacija;
        private SmjestajnaJedinica m_FK_RezervacijaStavka_SmjestajnaJedinica;
        #endregion
        
		#region Constructors
        static RezervacijaStavka()
        {
            // Cache field metadata.
            EntityMeta<RezervacijaStavka>.LoadColumnMetadata
			(
				new ColumnMetadata("RezervacijaStavkaID", @"RezervacijaStavkaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("RezervacijaStavkaProtokolID", @"RezervacijaStavkaProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaCjenikProtokolID", @"RezervacijaStavkaCjenikProtokolID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaSmjestajnaJedinica", @"RezervacijaStavkaSmjestajnaJedinica", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaRedniBroj", @"RezervacijaStavkaRedniBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaRezerviranoOd", @"RezervacijaStavkaRezerviranoOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaRezerviranoDo", @"RezervacijaStavkaRezerviranoDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaBrojNoci", @"RezervacijaStavkaBrojNoci", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaBrojOdraslih", @"RezervacijaStavkaBrojOdraslih", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaBrojDjece", @"RezervacijaStavkaBrojDjece", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaNapomena", @"RezervacijaStavkaNapomena", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaNocIznos", @"RezervacijaStavkaNocIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaPopustPostotak", @"RezervacijaStavkaPopustPostotak", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaPopustIznos", @"RezervacijaStavkaPopustIznos", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaUkupnoIznos", @"RezervacijaStavkaUkupnoIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaUkupnoIznosDevize", @"RezervacijaStavkaUkupnoIznosDevize", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("RezervacijaStavkaUradio", @"RezervacijaStavkaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaDatumIzmjene", @"RezervacijaStavkaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<RezervacijaStavka>.LoadRelationMetadata
			(
				new RelationMetadata("FK_RezervacijaStavka_Cjenik", "RezervacijaStavkaCjenikProtokolID", "CjenikProtokolID"),
                new RelationMetadata("FK_RezervacijaStavka_Rezervacija", "RezervacijaStavkaProtokolID", "RezervacijaProtokolID"),
                new RelationMetadata("FK_RezervacijaStavka_SmjestajnaJedinica", "RezervacijaStavkaSmjestajnaJedinica", "SmjestajnaJedinicaSmjestajnaJedinica")
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
		public Cjenik FK_RezervacijaStavka_Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_FK_RezervacijaStavka_Cjenik, this, "FK_RezervacijaStavka_Cjenik"); }
            set { EntityContext<Cjenik>.Set(ref m_FK_RezervacijaStavka_Cjenik, this, value, "FK_RezervacijaStavka_Cjenik"); }
        }
        public Rezervacija FK_RezervacijaStavka_Rezervacija
        {
            get { return EntityContext<Rezervacija>.Get(ref m_FK_RezervacijaStavka_Rezervacija, this, "FK_RezervacijaStavka_Rezervacija"); }
            set { EntityContext<Rezervacija>.Set(ref m_FK_RezervacijaStavka_Rezervacija, this, value, "FK_RezervacijaStavka_Rezervacija"); }
        }
        public SmjestajnaJedinica FK_RezervacijaStavka_SmjestajnaJedinica
        {
            get { return EntityContext<SmjestajnaJedinica>.Get(ref m_FK_RezervacijaStavka_SmjestajnaJedinica, this, "FK_RezervacijaStavka_SmjestajnaJedinica"); }
            set { EntityContext<SmjestajnaJedinica>.Set(ref m_FK_RezervacijaStavka_SmjestajnaJedinica, this, value, "FK_RezervacijaStavka_SmjestajnaJedinica"); }
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

        #region Public methods
		public static IEnumerable<RezervacijaStavka> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<RezervacijaStavka>(queryConditions);
        }
        public static IEnumerable<RezervacijaStavka> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<RezervacijaStavka>(columnName, queryOp, value);
        }
		public static RezervacijaStavka GetByPrimaryKey(int RezervacijaStavkaID)
        {
            return GetByPrimaryKey<RezervacijaStavka>(RezervacijaStavkaID);
        }
		public static RezervacijaStavka TryGetByPrimaryKey(int RezervacijaStavkaID)
        {
            return TryGetByPrimaryKey<RezervacijaStavka>(RezervacijaStavkaID);
        }
        #endregion
    }
}