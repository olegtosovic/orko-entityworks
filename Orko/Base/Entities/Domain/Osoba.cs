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

namespace Orko.Base
{
    /// <summary>
    /// Osoba entity.
    /// </summary>
    public sealed partial class Osoba : Entity
    {
		#region Members
		private Drzava m_FK_Osoba_DrzavaRodjenja;
        private Opcina m_FK_Osoba_OpcinaRodjenja;
        private Spol m_FK_Osoba_Spol;
        #endregion
        
		#region Constructors
        static Osoba()
        {
            // Cache field metadata.
            EntityMeta<Osoba>.LoadColumnMetadata
			(
				new ColumnMetadata("OsobaID", @"OsobaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("OsobaIme", @"OsobaIme", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("OsobaPrezime", @"OsobaPrezime", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("OsobaPorezniBroj", @"OsobaPorezniBroj", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaSpol", @"OsobaSpol", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("OsobaTitula", @"OsobaTitula", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaDatumRodjenja", @"OsobaDatumRodjenja", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("OsobaRodjenoPrezime", @"OsobaRodjenoPrezime", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaMjestoRodjenja", @"OsobaMjestoRodjenja", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaOpcinaRodjenja", @"OsobaOpcinaRodjenja", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaDrzavaRodjenja", @"OsobaDrzavaRodjenja", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("OsobaNarodnost", @"OsobaNarodnost", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaTelefonPosao", @"OsobaTelefonPosao", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaTelefonKucni", @"OsobaTelefonKucni", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaFaxPosao", @"OsobaFaxPosao", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaFaxKucni", @"OsobaFaxKucni", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaMobitelOsobni", @"OsobaMobitelOsobni", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaMobitelSluzbeni", @"OsobaMobitelSluzbeni", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaEmailOsobni", @"OsobaEmailOsobni", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OsobaEmailPosao", @"OsobaEmailPosao", SqlDbType.NVarChar, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Osoba>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Osoba_DrzavaRodjenja", "OsobaDrzavaRodjenja", "DrzavaDrzava"),
                new RelationMetadata("FK_Osoba_OpcinaRodjenja", "OsobaOpcinaRodjenja", "OpcinaOpcina"),
                new RelationMetadata("FK_Osoba_OpcinaRodjenja", "OsobaDrzavaRodjenja", "OpcinaDrzava"),
                new RelationMetadata("FK_Osoba_Spol", "OsobaSpol", "SpolSpol")
			);

			// Cache table metadata.
			EntityMeta<Osoba>.HasLanguageTable = false;
            EntityMeta<Osoba>.TableSchema = @"Base";
            EntityMeta<Osoba>.TableName = @"Osoba";
            EntityMeta<Osoba>.LanguageTableSchema = null;
            EntityMeta<Osoba>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? OsobaID { get; private set; }
        public string OsobaIme { get; set; }
        public string OsobaPrezime { get; set; }
        public string OsobaPorezniBroj { get; set; }
        public string OsobaSpol { get; set; }
        public string OsobaTitula { get; set; }
        public DateTime? OsobaDatumRodjenja { get; set; }
        public string OsobaRodjenoPrezime { get; set; }
        public string OsobaMjestoRodjenja { get; set; }
        public string OsobaOpcinaRodjenja { get; set; }
        public string OsobaDrzavaRodjenja { get; set; }
        public string OsobaNarodnost { get; set; }
        public string OsobaTelefonPosao { get; set; }
        public string OsobaTelefonKucni { get; set; }
        public string OsobaFaxPosao { get; set; }
        public string OsobaFaxKucni { get; set; }
        public string OsobaMobitelOsobni { get; set; }
        public string OsobaMobitelSluzbeni { get; set; }
        public string OsobaEmailOsobni { get; set; }
        public string OsobaEmailPosao { get; set; }
        #endregion

        #region Entities
		public Drzava FK_Osoba_DrzavaRodjenja
        {
            get { return EntityContext<Drzava>.Get(ref m_FK_Osoba_DrzavaRodjenja, this, "FK_Osoba_DrzavaRodjenja"); }
            set { EntityContext<Drzava>.Set(ref m_FK_Osoba_DrzavaRodjenja, this, value, "FK_Osoba_DrzavaRodjenja"); }
        }
        public Opcina FK_Osoba_OpcinaRodjenja
        {
            get { return EntityContext<Opcina>.Get(ref m_FK_Osoba_OpcinaRodjenja, this, "FK_Osoba_OpcinaRodjenja"); }
            set { EntityContext<Opcina>.Set(ref m_FK_Osoba_OpcinaRodjenja, this, value, "FK_Osoba_OpcinaRodjenja"); }
        }
        public Spol FK_Osoba_Spol
        {
            get { return EntityContext<Spol>.Get(ref m_FK_Osoba_Spol, this, "FK_Osoba_Spol"); }
            set { EntityContext<Spol>.Set(ref m_FK_Osoba_Spol, this, value, "FK_Osoba_Spol"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Osoba>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Osoba>(queryConditions);
        }
        public static async Task<IEnumerable<Osoba>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Osoba>(columnName, queryOp, value);
        }
		public static async Task<Osoba> GetByPrimaryKeyAsync(int OsobaID)
        {
            return await GetByPrimaryKeyAsync<Osoba>(OsobaID);
        }
		public static async Task<Osoba> TryGetByPrimaryKeyAsync(int OsobaID)
        {
            return await TryGetByPrimaryKeyAsync<Osoba>(OsobaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Osoba> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Osoba>(queryConditions);
        }
        public static IEnumerable<Osoba> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Osoba>(columnName, queryOp, value);
        }
		public static Osoba GetByPrimaryKey(int OsobaID)
        {
            return GetByPrimaryKey<Osoba>(OsobaID);
        }
		public static Osoba TryGetByPrimaryKey(int OsobaID)
        {
            return TryGetByPrimaryKey<Osoba>(OsobaID);
        }
        #endregion
    }
}