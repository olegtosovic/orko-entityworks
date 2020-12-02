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
    /// Brod entity.
    /// </summary>
    public sealed partial class Brod : Entity
    {
		#region Members
		private Lokacija m_FK_Brod_Lokacija;
        private Obveznik m_FK_Brod_Obveznik;
        private TipBroda m_FK_Brod_TipBroda;
        private VrstaBroda m_FK_Brod_VrstaBroda;
        #endregion
        
		#region Constructors
        static Brod()
        {
            // Cache field metadata.
            EntityMeta<Brod>.LoadColumnMetadata
			(
				new ColumnMetadata("BrodBrod", @"BrodBrod", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("BrodObveznikID", @"BrodObveznikID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("BrodVrstaBroda", @"BrodVrstaBroda", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("BrodTipBroda", @"BrodTipBroda", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("BrodLokacija", @"BrodLokacija", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("BrodRegistracija", @"BrodRegistracija", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("BrodKapacitet", @"BrodKapacitet", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("BrodGodinaGradnje", @"BrodGodinaGradnje", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("BrodSirina", @"BrodSirina", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("BrodDuzina", @"BrodDuzina", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("BrodMotor", @"BrodMotor", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("BrodUNajmu", @"BrodUNajmu", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("BrodAktivnost", @"BrodAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("BrodJezik", @"BrodJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("BrodNaziv", @"BrodNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("BrodOpis", @"BrodOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Brod>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Brod_Lokacija", "BrodLokacija", "LokacijaLokacija"),
                new RelationMetadata("FK_Brod_Obveznik", "BrodObveznikID", "ObveznikID"),
                new RelationMetadata("FK_Brod_TipBroda", "BrodTipBroda", "TipBrodaTipBroda"),
                new RelationMetadata("FK_Brod_VrstaBroda", "BrodVrstaBroda", "VrstaBrodaVrstaBroda")
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
		public Lokacija FK_Brod_Lokacija
        {
            get { return EntityContext<Lokacija>.Get(ref m_FK_Brod_Lokacija, this, "FK_Brod_Lokacija"); }
            set { EntityContext<Lokacija>.Set(ref m_FK_Brod_Lokacija, this, value, "FK_Brod_Lokacija"); }
        }
        public Obveznik FK_Brod_Obveznik
        {
            get { return EntityContext<Obveznik>.Get(ref m_FK_Brod_Obveznik, this, "FK_Brod_Obveznik"); }
            set { EntityContext<Obveznik>.Set(ref m_FK_Brod_Obveznik, this, value, "FK_Brod_Obveznik"); }
        }
        public TipBroda FK_Brod_TipBroda
        {
            get { return EntityContext<TipBroda>.Get(ref m_FK_Brod_TipBroda, this, "FK_Brod_TipBroda"); }
            set { EntityContext<TipBroda>.Set(ref m_FK_Brod_TipBroda, this, value, "FK_Brod_TipBroda"); }
        }
        public VrstaBroda FK_Brod_VrstaBroda
        {
            get { return EntityContext<VrstaBroda>.Get(ref m_FK_Brod_VrstaBroda, this, "FK_Brod_VrstaBroda"); }
            set { EntityContext<VrstaBroda>.Set(ref m_FK_Brod_VrstaBroda, this, value, "FK_Brod_VrstaBroda"); }
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

        #region Public methods
		public static IEnumerable<Brod> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Brod>(queryConditions);
        }
        public static IEnumerable<Brod> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Brod>(columnName, queryOp, value);
        }
		public static Brod GetByPrimaryKey(int BrodBrod)
        {
            return GetByPrimaryKey<Brod>(BrodBrod);
        }
		public static Brod TryGetByPrimaryKey(int BrodBrod)
        {
            return TryGetByPrimaryKey<Brod>(BrodBrod);
        }
        #endregion
    }
}