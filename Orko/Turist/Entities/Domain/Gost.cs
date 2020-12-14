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
    /// Gost entity.
    /// </summary>
    public sealed partial class Gost : Entity
    {
		#region Members
		private Base.Drzava m_DrzavaRodjenja;
        private Base.Drzava m_Drzavljanstvo;
        private Base.Spol m_Spol;
        private VrstaPutneIsprave m_VrstaPutneIsprave;
        #endregion
        
		#region Constructors
        static Gost()
        {
            // Cache field metadata.
            EntityMeta<Gost>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(GostGost), @"GostGost", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(GostIme), @"GostIme", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(GostPrezime), @"GostPrezime", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(GostSrednjeIme), @"GostSrednjeIme", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(GostSpol), @"GostSpol", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(GostDrzavaRodjenja), @"GostDrzavaRodjenja", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(GostMjestoRodjenja), @"GostMjestoRodjenja", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(GostDatumRodjenja), @"GostDatumRodjenja", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(GostDrzavljanstvo), @"GostDrzavljanstvo", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(GostVrstaPutneIsprave), @"GostVrstaPutneIsprave", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(GostBrojPutneIsprave), @"GostBrojPutneIsprave", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(GostMobitel1), @"GostMobitel1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(GostMobitel2), @"GostMobitel2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(GostEmail), @"GostEmail", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(GostUradio), @"GostUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(GostDatumIzmjene), @"GostDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Gost>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(DrzavaRodjenja), nameof(GostDrzavaRodjenja), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(Drzavljanstvo), nameof(GostDrzavljanstvo), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(Spol), nameof(GostSpol), nameof(Orko.Base.Spol.SpolSpol)),
                new RelationMetadata(nameof(VrstaPutneIsprave), nameof(GostVrstaPutneIsprave), nameof(Orko.Turist.VrstaPutneIsprave.VrstaPutneIspraveVrstaPutneIsprave))
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
		public Base.Drzava DrzavaRodjenja
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_DrzavaRodjenja, this, nameof(DrzavaRodjenja)); }
            set { EntityContext<Base.Drzava>.Set(ref m_DrzavaRodjenja, this, value, nameof(DrzavaRodjenja)); }
        }
        public Base.Drzava Drzavljanstvo
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_Drzavljanstvo, this, nameof(Drzavljanstvo)); }
            set { EntityContext<Base.Drzava>.Set(ref m_Drzavljanstvo, this, value, nameof(Drzavljanstvo)); }
        }
        public Base.Spol Spol
        {
            get { return EntityContext<Base.Spol>.Get(ref m_Spol, this, nameof(Spol)); }
            set { EntityContext<Base.Spol>.Set(ref m_Spol, this, value, nameof(Spol)); }
        }
        public VrstaPutneIsprave VrstaPutneIsprave
        {
            get { return EntityContext<VrstaPutneIsprave>.Get(ref m_VrstaPutneIsprave, this, nameof(VrstaPutneIsprave)); }
            set { EntityContext<VrstaPutneIsprave>.Set(ref m_VrstaPutneIsprave, this, value, nameof(VrstaPutneIsprave)); }
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
    }
}