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
    /// Gost entity.
    /// </summary>
    public sealed partial class Gost : Entity
    {
		#region Members
		private Base.Drzava m_FK_Gost_DrzavaRodjenja;
        private Base.Drzava m_FK_Gost_Drzavljanstvo;
        private Base.Spol m_FK_Gost_Spol;
        private VrstaPutneIsprave m_FK_Gost_VrstaPutneIsprave;
        #endregion
        
		#region Constructors
        static Gost()
        {
            // Cache field metadata.
            EntityMeta<Gost>.LoadColumnMetadata
			(
				new ColumnMetadata("GostGost", @"GostGost", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("GostIme", @"GostIme", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("GostPrezime", @"GostPrezime", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("GostSrednjeIme", @"GostSrednjeIme", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("GostSpol", @"GostSpol", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("GostDrzavaRodjenja", @"GostDrzavaRodjenja", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("GostMjestoRodjenja", @"GostMjestoRodjenja", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("GostDatumRodjenja", @"GostDatumRodjenja", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("GostDrzavljanstvo", @"GostDrzavljanstvo", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("GostVrstaPutneIsprave", @"GostVrstaPutneIsprave", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("GostBrojPutneIsprave", @"GostBrojPutneIsprave", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("GostMobitel1", @"GostMobitel1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("GostMobitel2", @"GostMobitel2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("GostEmail", @"GostEmail", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("GostUradio", @"GostUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("GostDatumIzmjene", @"GostDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Gost>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Gost_DrzavaRodjenja", "GostDrzavaRodjenja", "DrzavaDrzava"),
                new RelationMetadata("FK_Gost_Drzavljanstvo", "GostDrzavljanstvo", "DrzavaDrzava"),
                new RelationMetadata("FK_Gost_Spol", "GostSpol", "SpolSpol"),
                new RelationMetadata("FK_Gost_VrstaPutneIsprave", "GostVrstaPutneIsprave", "VrstaPutneIspraveVrstaPutneIsprave")
			);

			// Cache table metadata.
			EntityMeta<Gost>.HasLanguageTable = false;
            EntityMeta<Gost>.TableSchema = @"Turist";
            EntityMeta<Gost>.TableName = @"Gost";
            EntityMeta<Gost>.LanguageTableSchema = null;
            EntityMeta<Gost>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? GostGost { get; private set; }
        public string GostIme { get; set; }
        public string GostPrezime { get; set; }
        public string GostSrednjeIme { get; set; }
        public string GostSpol { get; set; }
        public string GostDrzavaRodjenja { get; set; }
        public string GostMjestoRodjenja { get; set; }
        public DateTime? GostDatumRodjenja { get; set; }
        public string GostDrzavljanstvo { get; set; }
        public string GostVrstaPutneIsprave { get; set; }
        public string GostBrojPutneIsprave { get; set; }
        public string GostMobitel1 { get; set; }
        public string GostMobitel2 { get; set; }
        public string GostEmail { get; set; }
        public string GostUradio { get; set; }
        public DateTime? GostDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public Base.Drzava FK_Gost_DrzavaRodjenja
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_FK_Gost_DrzavaRodjenja, this, "FK_Gost_DrzavaRodjenja"); }
            set { EntityContext<Base.Drzava>.Set(ref m_FK_Gost_DrzavaRodjenja, this, value, "FK_Gost_DrzavaRodjenja"); }
        }
        public Base.Drzava FK_Gost_Drzavljanstvo
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_FK_Gost_Drzavljanstvo, this, "FK_Gost_Drzavljanstvo"); }
            set { EntityContext<Base.Drzava>.Set(ref m_FK_Gost_Drzavljanstvo, this, value, "FK_Gost_Drzavljanstvo"); }
        }
        public Base.Spol FK_Gost_Spol
        {
            get { return EntityContext<Base.Spol>.Get(ref m_FK_Gost_Spol, this, "FK_Gost_Spol"); }
            set { EntityContext<Base.Spol>.Set(ref m_FK_Gost_Spol, this, value, "FK_Gost_Spol"); }
        }
        public VrstaPutneIsprave FK_Gost_VrstaPutneIsprave
        {
            get { return EntityContext<VrstaPutneIsprave>.Get(ref m_FK_Gost_VrstaPutneIsprave, this, "FK_Gost_VrstaPutneIsprave"); }
            set { EntityContext<VrstaPutneIsprave>.Set(ref m_FK_Gost_VrstaPutneIsprave, this, value, "FK_Gost_VrstaPutneIsprave"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Gost>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Gost>(queryConditions);
        }
        public static async Task<IEnumerable<Gost>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Gost>(columnName, queryOp, value);
        }
		public static async Task<Gost> GetByPrimaryKeyAsync(int GostGost)
        {
            return await GetByPrimaryKeyAsync<Gost>(GostGost);
        }
		public static async Task<Gost> TryGetByPrimaryKeyAsync(int GostGost)
        {
            return await TryGetByPrimaryKeyAsync<Gost>(GostGost);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Gost> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Gost>(queryConditions);
        }
        public static IEnumerable<Gost> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Gost>(columnName, queryOp, value);
        }
		public static Gost GetByPrimaryKey(int GostGost)
        {
            return GetByPrimaryKey<Gost>(GostGost);
        }
		public static Gost TryGetByPrimaryKey(int GostGost)
        {
            return TryGetByPrimaryKey<Gost>(GostGost);
        }
        #endregion
    }
}