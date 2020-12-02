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
    /// Obveznik entity.
    /// </summary>
    public sealed partial class Obveznik : Entity
    {
		#region Members
		private Base.Firma m_FK_Obveznik_Firma;
        private Base.Osoba m_FK_Obveznik_Osoba;
        private Base.PravnaOsobnost m_FK_Obveznik_PravnaOsobnost;
        #endregion
        
		#region Constructors
        static Obveznik()
        {
            // Cache field metadata.
            EntityMeta<Obveznik>.LoadColumnMetadata
			(
				new ColumnMetadata("ObveznikID", @"ObveznikID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("ObveznikPravnaOsobnost", @"ObveznikPravnaOsobnost", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("ObveznikOsobaID", @"ObveznikOsobaID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("ObveznikFirma", @"ObveznikFirma", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikIme", @"ObveznikIme", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikPrezime", @"ObveznikPrezime", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikNaziv", @"ObveznikNaziv", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikTelefon1", @"ObveznikTelefon1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikTelefon2", @"ObveznikTelefon2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikMobitel1", @"ObveznikMobitel1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikMobitel2", @"ObveznikMobitel2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikEmail", @"ObveznikEmail", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObveznikAktivnost", @"ObveznikAktivnost", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Obveznik>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Obveznik_Firma", "ObveznikFirma", "FirmaFirma"),
                new RelationMetadata("FK_Obveznik_Osoba", "ObveznikOsobaID", "OsobaID"),
                new RelationMetadata("FK_Obveznik_PravnaOsobnost", "ObveznikPravnaOsobnost", "PravnaOsobnostPravnaOsobnost")
			);

			// Cache table metadata.
			EntityMeta<Obveznik>.HasLanguageTable = false;
            EntityMeta<Obveznik>.TableSchema = @"Watersports";
            EntityMeta<Obveznik>.TableName = @"Obveznik";
            EntityMeta<Obveznik>.LanguageTableSchema = null;
            EntityMeta<Obveznik>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ObveznikID { get; private set; }
        public string ObveznikPravnaOsobnost { get; set; }
        public int? ObveznikOsobaID { get; set; }
        public string ObveznikFirma { get; set; }
        public string ObveznikIme { get; set; }
        public string ObveznikPrezime { get; set; }
        public string ObveznikNaziv { get; set; }
        public string ObveznikTelefon1 { get; set; }
        public string ObveznikTelefon2 { get; set; }
        public string ObveznikMobitel1 { get; set; }
        public string ObveznikMobitel2 { get; set; }
        public string ObveznikEmail { get; set; }
        public bool? ObveznikAktivnost { get; set; }
        #endregion

        #region Entities
		public Base.Firma FK_Obveznik_Firma
        {
            get { return EntityContext<Base.Firma>.Get(ref m_FK_Obveznik_Firma, this, "FK_Obveznik_Firma"); }
            set { EntityContext<Base.Firma>.Set(ref m_FK_Obveznik_Firma, this, value, "FK_Obveznik_Firma"); }
        }
        public Base.Osoba FK_Obveznik_Osoba
        {
            get { return EntityContext<Base.Osoba>.Get(ref m_FK_Obveznik_Osoba, this, "FK_Obveznik_Osoba"); }
            set { EntityContext<Base.Osoba>.Set(ref m_FK_Obveznik_Osoba, this, value, "FK_Obveznik_Osoba"); }
        }
        public Base.PravnaOsobnost FK_Obveznik_PravnaOsobnost
        {
            get { return EntityContext<Base.PravnaOsobnost>.Get(ref m_FK_Obveznik_PravnaOsobnost, this, "FK_Obveznik_PravnaOsobnost"); }
            set { EntityContext<Base.PravnaOsobnost>.Set(ref m_FK_Obveznik_PravnaOsobnost, this, value, "FK_Obveznik_PravnaOsobnost"); }
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
		public static async Task<Obveznik> GetByPrimaryKeyAsync(int ObveznikID)
        {
            return await GetByPrimaryKeyAsync<Obveznik>(ObveznikID);
        }
		public static async Task<Obveznik> TryGetByPrimaryKeyAsync(int ObveznikID)
        {
            return await TryGetByPrimaryKeyAsync<Obveznik>(ObveznikID);
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
		public static Obveznik GetByPrimaryKey(int ObveznikID)
        {
            return GetByPrimaryKey<Obveznik>(ObveznikID);
        }
		public static Obveznik TryGetByPrimaryKey(int ObveznikID)
        {
            return TryGetByPrimaryKey<Obveznik>(ObveznikID);
        }
        #endregion
    }
}