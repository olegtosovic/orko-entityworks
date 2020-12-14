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
    /// Brod entity.
    /// </summary>
    public sealed partial class Brod : Entity
    {
		#region Members
		private Lokacija m_Lokacija;
        private Obveznik m_Obveznik;
        private TipBroda m_TipBroda;
        private VrstaBroda m_VrstaBroda;
        #endregion
        
		#region Constructors
        static Brod()
        {
            // Cache field metadata.
            EntityMeta<Brod>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BrodBrod), @"BrodBrod", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(BrodObveznikID), @"BrodObveznikID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(BrodVrstaBroda), @"BrodVrstaBroda", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(BrodTipBroda), @"BrodTipBroda", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(BrodLokacija), @"BrodLokacija", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(BrodRegistracija), @"BrodRegistracija", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(BrodKapacitet), @"BrodKapacitet", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(BrodGodinaGradnje), @"BrodGodinaGradnje", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(BrodSirina), @"BrodSirina", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(BrodDuzina), @"BrodDuzina", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(BrodMotor), @"BrodMotor", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(BrodUNajmu), @"BrodUNajmu", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(BrodAktivnost), @"BrodAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(BrodJezik), @"BrodJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(BrodNaziv), @"BrodNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(BrodOpis), @"BrodOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Brod>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Lokacija), nameof(BrodLokacija), nameof(Orko.Watersports.Lokacija.LokacijaLokacija)),
                new RelationMetadata(nameof(Obveznik), nameof(BrodObveznikID), nameof(Orko.Watersports.Obveznik.ObveznikID)),
                new RelationMetadata(nameof(TipBroda), nameof(BrodTipBroda), nameof(Orko.Watersports.TipBroda.TipBrodaTipBroda)),
                new RelationMetadata(nameof(VrstaBroda), nameof(BrodVrstaBroda), nameof(Orko.Watersports.VrstaBroda.VrstaBrodaVrstaBroda))
			);

			// Cache table metadata.
			EntityMeta<Brod>.HasLanguageTable = true;
            EntityMeta<Brod>.TableSchema = @"Watersports";
            EntityMeta<Brod>.TableName = @"Brod";
            EntityMeta<Brod>.LanguageTableSchema = @"Watersports";
            EntityMeta<Brod>.LanguageTableName = @"Brod_jezik";
        }
        #endregion

        #region Columns
        public int? BrodBrod { get; private set; }
        public int? BrodObveznikID { get; set; }
        public string BrodVrstaBroda { get; set; }
        public string BrodTipBroda { get; set; }
        public int? BrodLokacija { get; set; }
        public string BrodRegistracija { get; set; }
        public int? BrodKapacitet { get; set; }
        public int? BrodGodinaGradnje { get; set; }
        public decimal? BrodSirina { get; set; }
        public decimal? BrodDuzina { get; set; }
        public string BrodMotor { get; set; }
        public bool? BrodUNajmu { get; set; }
        public bool? BrodAktivnost { get; set; }
        public string BrodJezik { get; private set; }
        public string BrodNaziv { get; set; }
        public string BrodOpis { get; set; }
        #endregion

        #region Entities
		public Lokacija Lokacija
        {
            get { return EntityContext<Lokacija>.Get(ref m_Lokacija, this, nameof(Lokacija)); }
            set { EntityContext<Lokacija>.Set(ref m_Lokacija, this, value, nameof(Lokacija)); }
        }
        public Obveznik Obveznik
        {
            get { return EntityContext<Obveznik>.Get(ref m_Obveznik, this, nameof(Obveznik)); }
            set { EntityContext<Obveznik>.Set(ref m_Obveznik, this, value, nameof(Obveznik)); }
        }
        public TipBroda TipBroda
        {
            get { return EntityContext<TipBroda>.Get(ref m_TipBroda, this, nameof(TipBroda)); }
            set { EntityContext<TipBroda>.Set(ref m_TipBroda, this, value, nameof(TipBroda)); }
        }
        public VrstaBroda VrstaBroda
        {
            get { return EntityContext<VrstaBroda>.Get(ref m_VrstaBroda, this, nameof(VrstaBroda)); }
            set { EntityContext<VrstaBroda>.Set(ref m_VrstaBroda, this, value, nameof(VrstaBroda)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Brod>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Brod>(queryConditions);
        }
        public static async Task<IEnumerable<Brod>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Brod>(columnName, queryOp, value);
        }
		public static async Task<Brod> GetByPrimaryKeyAsync(int BrodBrod)
        {
            return await GetByPrimaryKeyAsync<Brod>(BrodBrod);
        }
		public static async Task<Brod> TryGetByPrimaryKeyAsync(int BrodBrod)
        {
            return await TryGetByPrimaryKeyAsync<Brod>(BrodBrod);
        }
		#endregion
    }
}