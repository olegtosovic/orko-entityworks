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
    /// FakturaStavka entity.
    /// </summary>
    public sealed partial class FakturaStavka : Entity
    {
		#region Members
		private Faktura m_Faktura;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static FakturaStavka()
        {
            // Cache field metadata.
            EntityMeta<FakturaStavka>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(FakturaStavkaID), @"FakturaStavkaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaProtokolID), @"FakturaStavkaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaRedniBroj), @"FakturaStavkaRedniBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaVrstaUsluge), @"FakturaStavkaVrstaUsluge", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaOpisUsluge), @"FakturaStavkaOpisUsluge", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaKolicina), @"FakturaStavkaKolicina", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaIznosBezPopusta), @"FakturaStavkaIznosBezPopusta", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaPopustPostotak), @"FakturaStavkaPopustPostotak", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaPopustIznos), @"FakturaStavkaPopustIznos", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaUkupnoIznos), @"FakturaStavkaUkupnoIznos", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaUkupniIznosDevize), @"FakturaStavkaUkupniIznosDevize", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaUradio), @"FakturaStavkaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(FakturaStavkaDatumIzmjene), @"FakturaStavkaDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<FakturaStavka>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Faktura), nameof(FakturaStavkaProtokolID), nameof(Orko.Turist.Faktura.FakturaProtokolID)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(FakturaStavkaVrstaUsluge), nameof(Orko.Turist.VrstaUsluge.VrstaUslugeVrstaUsluge))
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
		public Faktura Faktura
        {
            get { return EntityContext<Faktura>.Get(ref m_Faktura, this, nameof(Faktura)); }
            set { EntityContext<Faktura>.Set(ref m_Faktura, this, value, nameof(Faktura)); }
        }
        public VrstaUsluge VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_VrstaUsluge, this, nameof(VrstaUsluge)); }
            set { EntityContext<VrstaUsluge>.Set(ref m_VrstaUsluge, this, value, nameof(VrstaUsluge)); }
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
    }
}