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
    /// Obveznik entity.
    /// </summary>
    public sealed partial class Obveznik : Entity
    {
		#region Members
		private Base.Drzava m_FK_Obveznik_Drzava;
        private Base.Opcina m_FK_Obveznik_Opcina;
        private Base.Posta m_FK_Obveznik_Posta;
        private Base.PravnaOsobnost m_FK_Obveznik_PravnaOsobnost;
        private Base.Zupanija m_FK_Obveznik_Zupanija;
        #endregion
        
		#region Constructors
        static Obveznik()
        {
            // Cache field metadata.
            EntityMeta<Obveznik>.LoadColumnMetadata
			(
				new ColumnMetadata("ObveznikObveznik", @"ObveznikObveznik", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("ObveznikOIB", @"ObveznikOIB", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ObveznikIme", @"ObveznikIme", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikPrezime", @"ObveznikPrezime", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikNaziv", @"ObveznikNaziv", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ObveznikPravnaOsobnost", @"ObveznikPravnaOsobnost", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("ObveznikPrebivalisteDrzava", @"ObveznikPrebivalisteDrzava", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("ObveznikPrebivalisteOpcina", @"ObveznikPrebivalisteOpcina", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikPrebivalisteZupanija", @"ObveznikPrebivalisteZupanija", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikPrebivalistePosta", @"ObveznikPrebivalistePosta", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("ObveznikPrebivalisteUlica", @"ObveznikPrebivalisteUlica", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ObveznikPrebivalisteKucniBroj", @"ObveznikPrebivalisteKucniBroj", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ObveznikTelefon1", @"ObveznikTelefon1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikTelefon2", @"ObveznikTelefon2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikMobitel1", @"ObveznikMobitel1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikMobitel2", @"ObveznikMobitel2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikEmail1", @"ObveznikEmail1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikEmail2", @"ObveznikEmail2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikAktivnost", @"ObveznikAktivnost", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Obveznik>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Obveznik_Drzava", "ObveznikPrebivalisteDrzava", "DrzavaDrzava"),
                new RelationMetadata("FK_Obveznik_Opcina", "ObveznikPrebivalisteOpcina", "OpcinaOpcina"),
                new RelationMetadata("FK_Obveznik_Opcina", "ObveznikPrebivalisteDrzava", "OpcinaDrzava"),
                new RelationMetadata("FK_Obveznik_Posta", "ObveznikPrebivalistePosta", "PostaPosta"),
                new RelationMetadata("FK_Obveznik_Posta", "ObveznikPrebivalisteDrzava", "PostaDrzava"),
                new RelationMetadata("FK_Obveznik_PravnaOsobnost", "ObveznikPravnaOsobnost", "PravnaOsobnostPravnaOsobnost"),
                new RelationMetadata("FK_Obveznik_Zupanija", "ObveznikPrebivalisteZupanija", "ZupanijaZupanija"),
                new RelationMetadata("FK_Obveznik_Zupanija", "ObveznikPrebivalisteDrzava", "ZupanijaDrzava")
			);

			// Cache table metadata.
			EntityMeta<Obveznik>.HasLanguageTable = false;
            EntityMeta<Obveznik>.TableSchema = @"Turist";
            EntityMeta<Obveznik>.TableName = @"Obveznik";
            EntityMeta<Obveznik>.LanguageTableSchema = null;
            EntityMeta<Obveznik>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ObveznikObveznik { get; private set; }
        public string ObveznikOIB { get; set; }
        public string ObveznikIme { get; set; }
        public string ObveznikPrezime { get; set; }
        public string ObveznikNaziv { get; set; }
        public string ObveznikPravnaOsobnost { get; set; }
        public string ObveznikPrebivalisteDrzava { get; set; }
        public string ObveznikPrebivalisteOpcina { get; set; }
        public string ObveznikPrebivalisteZupanija { get; set; }
        public int? ObveznikPrebivalistePosta { get; set; }
        public string ObveznikPrebivalisteUlica { get; set; }
        public string ObveznikPrebivalisteKucniBroj { get; set; }
        public string ObveznikTelefon1 { get; set; }
        public string ObveznikTelefon2 { get; set; }
        public string ObveznikMobitel1 { get; set; }
        public string ObveznikMobitel2 { get; set; }
        public string ObveznikEmail1 { get; set; }
        public string ObveznikEmail2 { get; set; }
        public bool? ObveznikAktivnost { get; set; }
        #endregion

        #region Entities
		public Base.Drzava FK_Obveznik_Drzava
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_FK_Obveznik_Drzava, this, "FK_Obveznik_Drzava"); }
            set { EntityContext<Base.Drzava>.Set(ref m_FK_Obveznik_Drzava, this, value, "FK_Obveznik_Drzava"); }
        }
        public Base.Opcina FK_Obveznik_Opcina
        {
            get { return EntityContext<Base.Opcina>.Get(ref m_FK_Obveznik_Opcina, this, "FK_Obveznik_Opcina"); }
            set { EntityContext<Base.Opcina>.Set(ref m_FK_Obveznik_Opcina, this, value, "FK_Obveznik_Opcina"); }
        }
        public Base.Posta FK_Obveznik_Posta
        {
            get { return EntityContext<Base.Posta>.Get(ref m_FK_Obveznik_Posta, this, "FK_Obveznik_Posta"); }
            set { EntityContext<Base.Posta>.Set(ref m_FK_Obveznik_Posta, this, value, "FK_Obveznik_Posta"); }
        }
        public Base.PravnaOsobnost FK_Obveznik_PravnaOsobnost
        {
            get { return EntityContext<Base.PravnaOsobnost>.Get(ref m_FK_Obveznik_PravnaOsobnost, this, "FK_Obveznik_PravnaOsobnost"); }
            set { EntityContext<Base.PravnaOsobnost>.Set(ref m_FK_Obveznik_PravnaOsobnost, this, value, "FK_Obveznik_PravnaOsobnost"); }
        }
        public Base.Zupanija FK_Obveznik_Zupanija
        {
            get { return EntityContext<Base.Zupanija>.Get(ref m_FK_Obveznik_Zupanija, this, "FK_Obveznik_Zupanija"); }
            set { EntityContext<Base.Zupanija>.Set(ref m_FK_Obveznik_Zupanija, this, value, "FK_Obveznik_Zupanija"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Obveznik>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Obveznik>(queryConditions);
        }
        public static async Task<IEnumerable<Obveznik>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Obveznik>(columnName, queryOp, value);
        }
		public static async Task<Obveznik> GetByPrimaryKeyAsync(int ObveznikObveznik)
        {
            return await GetByPrimaryKeyAsync<Obveznik>(ObveznikObveznik);
        }
		public static async Task<Obveznik> TryGetByPrimaryKeyAsync(int ObveznikObveznik)
        {
            return await TryGetByPrimaryKeyAsync<Obveznik>(ObveznikObveznik);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Obveznik> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Obveznik>(queryConditions);
        }
        public static IEnumerable<Obveznik> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Obveznik>(columnName, queryOp, value);
        }
		public static Obveznik GetByPrimaryKey(int ObveznikObveznik)
        {
            return GetByPrimaryKey<Obveznik>(ObveznikObveznik);
        }
		public static Obveznik TryGetByPrimaryKey(int ObveznikObveznik)
        {
            return TryGetByPrimaryKey<Obveznik>(ObveznikObveznik);
        }
        public static Obveznik GetByUnique1(string ObveznikOIB)
        {
            return GetByCallingParameters<Obveznik>(ObveznikOIB);
        }
		public static Obveznik TryGetByUnique1(string ObveznikOIB)
        {
            return TryGetByCallingParameters<Obveznik>(ObveznikOIB);
        }
        #endregion
    }
}