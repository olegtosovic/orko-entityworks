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
    /// FakturaStavka entity.
    /// </summary>
    public sealed partial class FakturaStavka : Entity
    {
		#region Members
		private Faktura m_FK_FakturaStavka_Faktura;
        private VrstaUsluge m_FK_FakturaStavka_VrstaUsluge;
        #endregion
        
		#region Constructors
        static FakturaStavka()
        {
            // Cache field metadata.
            EntityMeta<FakturaStavka>.LoadColumnMetadata
			(
				new ColumnMetadata("FakturaStavkaID", @"FakturaStavkaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("FakturaStavkaProtokolID", @"FakturaStavkaProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("FakturaStavkaRedniBroj", @"FakturaStavkaRedniBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("FakturaStavkaVrstaUsluge", @"FakturaStavkaVrstaUsluge", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("FakturaStavkaOpisUsluge", @"FakturaStavkaOpisUsluge", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("FakturaStavkaKolicina", @"FakturaStavkaKolicina", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaStavkaIznosBezPopusta", @"FakturaStavkaIznosBezPopusta", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaStavkaPopustPostotak", @"FakturaStavkaPopustPostotak", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaStavkaPopustIznos", @"FakturaStavkaPopustIznos", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaStavkaUkupnoIznos", @"FakturaStavkaUkupnoIznos", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaStavkaUkupniIznosDevize", @"FakturaStavkaUkupniIznosDevize", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaStavkaUradio", @"FakturaStavkaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("FakturaStavkaDatumIzmjene", @"FakturaStavkaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<FakturaStavka>.LoadRelationMetadata
			(
				new RelationMetadata("FK_FakturaStavka_Faktura", "FakturaStavkaProtokolID", "FakturaProtokolID"),
                new RelationMetadata("FK_FakturaStavka_VrstaUsluge", "FakturaStavkaVrstaUsluge", "VrstaUslugeVrstaUsluge")
			);

			// Cache table metadata.
			EntityMeta<FakturaStavka>.HasLanguageTable = false;
            EntityMeta<FakturaStavka>.TableSchema = @"Turist";
            EntityMeta<FakturaStavka>.TableName = @"FakturaStavka";
            EntityMeta<FakturaStavka>.LanguageTableSchema = null;
            EntityMeta<FakturaStavka>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? FakturaStavkaID { get; private set; }
        public int? FakturaStavkaProtokolID { get; set; }
        public int? FakturaStavkaRedniBroj { get; set; }
        public int? FakturaStavkaVrstaUsluge { get; set; }
        public string FakturaStavkaOpisUsluge { get; set; }
        public decimal? FakturaStavkaKolicina { get; set; }
        public decimal? FakturaStavkaIznosBezPopusta { get; set; }
        public decimal? FakturaStavkaPopustPostotak { get; set; }
        public decimal? FakturaStavkaPopustIznos { get; set; }
        public decimal? FakturaStavkaUkupnoIznos { get; set; }
        public decimal? FakturaStavkaUkupniIznosDevize { get; set; }
        public string FakturaStavkaUradio { get; set; }
        public DateTime? FakturaStavkaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public Faktura FK_FakturaStavka_Faktura
        {
            get { return EntityContext<Faktura>.Get(ref m_FK_FakturaStavka_Faktura, this, "FK_FakturaStavka_Faktura"); }
            set { EntityContext<Faktura>.Set(ref m_FK_FakturaStavka_Faktura, this, value, "FK_FakturaStavka_Faktura"); }
        }
        public VrstaUsluge FK_FakturaStavka_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_FakturaStavka_VrstaUsluge, this, "FK_FakturaStavka_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_FakturaStavka_VrstaUsluge, this, value, "FK_FakturaStavka_VrstaUsluge"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<FakturaStavka>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<FakturaStavka>(queryConditions);
        }
        public static async Task<IEnumerable<FakturaStavka>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<FakturaStavka>(columnName, queryOp, value);
        }
		public static async Task<FakturaStavka> GetByPrimaryKeyAsync(int FakturaStavkaID)
        {
            return await GetByPrimaryKeyAsync<FakturaStavka>(FakturaStavkaID);
        }
		public static async Task<FakturaStavka> TryGetByPrimaryKeyAsync(int FakturaStavkaID)
        {
            return await TryGetByPrimaryKeyAsync<FakturaStavka>(FakturaStavkaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<FakturaStavka> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<FakturaStavka>(queryConditions);
        }
        public static IEnumerable<FakturaStavka> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<FakturaStavka>(columnName, queryOp, value);
        }
		public static FakturaStavka GetByPrimaryKey(int FakturaStavkaID)
        {
            return GetByPrimaryKey<FakturaStavka>(FakturaStavkaID);
        }
		public static FakturaStavka TryGetByPrimaryKey(int FakturaStavkaID)
        {
            return TryGetByPrimaryKey<FakturaStavka>(FakturaStavkaID);
        }
        #endregion
    }
}