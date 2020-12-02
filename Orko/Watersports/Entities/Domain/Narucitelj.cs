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
    /// Narucitelj entity.
    /// </summary>
    public sealed partial class Narucitelj : Entity
    {
		#region Members
		private Base.Firma m_FK_Narucitelj_Firma;
        private Base.Osoba m_FK_Narucitelj_Osoba;
        private Base.PravnaOsobnost m_FK_Narucitelj_PravnaOsobnost;
        #endregion
        
		#region Constructors
        static Narucitelj()
        {
            // Cache field metadata.
            EntityMeta<Narucitelj>.LoadColumnMetadata
			(
				new ColumnMetadata("NaruciteljID", @"NaruciteljID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("NaruciteljPravnaOsobnost", @"NaruciteljPravnaOsobnost", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("NaruciteljOsobaID", @"NaruciteljOsobaID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("NaruciteljFirma", @"NaruciteljFirma", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaruciteljDomaci", @"NaruciteljDomaci", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("NaruciteljOIB", @"NaruciteljOIB", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaruciteljIme", @"NaruciteljIme", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaruciteljPrezime", @"NaruciteljPrezime", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaruciteljNaziv", @"NaruciteljNaziv", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaruciteljTelefon1", @"NaruciteljTelefon1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaruciteljTelefon2", @"NaruciteljTelefon2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaruciteljMobitel1", @"NaruciteljMobitel1", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaruciteljMobitel2", @"NaruciteljMobitel2", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaruciteljEmail", @"NaruciteljEmail", SqlDbType.NVarChar, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Narucitelj>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Narucitelj_Firma", "NaruciteljFirma", "FirmaFirma"),
                new RelationMetadata("FK_Narucitelj_Osoba", "NaruciteljOsobaID", "OsobaID"),
                new RelationMetadata("FK_Narucitelj_PravnaOsobnost", "NaruciteljPravnaOsobnost", "PravnaOsobnostPravnaOsobnost")
			);

			// Cache table metadata.
			EntityMeta<Narucitelj>.HasLanguageTable = false;
            EntityMeta<Narucitelj>.TableSchema = @"Watersports";
            EntityMeta<Narucitelj>.TableName = @"Narucitelj";
            EntityMeta<Narucitelj>.LanguageTableSchema = null;
            EntityMeta<Narucitelj>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? NaruciteljID { get; private set; }
        public string NaruciteljPravnaOsobnost { get; set; }
        public int? NaruciteljOsobaID { get; set; }
        public string NaruciteljFirma { get; set; }
        public bool? NaruciteljDomaci { get; set; }
        public string NaruciteljOIB { get; set; }
        public string NaruciteljIme { get; set; }
        public string NaruciteljPrezime { get; set; }
        public string NaruciteljNaziv { get; set; }
        public string NaruciteljTelefon1 { get; set; }
        public string NaruciteljTelefon2 { get; set; }
        public string NaruciteljMobitel1 { get; set; }
        public string NaruciteljMobitel2 { get; set; }
        public string NaruciteljEmail { get; set; }
        #endregion

        #region Entities
		public Base.Firma FK_Narucitelj_Firma
        {
            get { return EntityContext<Base.Firma>.Get(ref m_FK_Narucitelj_Firma, this, "FK_Narucitelj_Firma"); }
            set { EntityContext<Base.Firma>.Set(ref m_FK_Narucitelj_Firma, this, value, "FK_Narucitelj_Firma"); }
        }
        public Base.Osoba FK_Narucitelj_Osoba
        {
            get { return EntityContext<Base.Osoba>.Get(ref m_FK_Narucitelj_Osoba, this, "FK_Narucitelj_Osoba"); }
            set { EntityContext<Base.Osoba>.Set(ref m_FK_Narucitelj_Osoba, this, value, "FK_Narucitelj_Osoba"); }
        }
        public Base.PravnaOsobnost FK_Narucitelj_PravnaOsobnost
        {
            get { return EntityContext<Base.PravnaOsobnost>.Get(ref m_FK_Narucitelj_PravnaOsobnost, this, "FK_Narucitelj_PravnaOsobnost"); }
            set { EntityContext<Base.PravnaOsobnost>.Set(ref m_FK_Narucitelj_PravnaOsobnost, this, value, "FK_Narucitelj_PravnaOsobnost"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Narucitelj>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Narucitelj>(queryConditions);
        }
        public static async Task<IEnumerable<Narucitelj>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Narucitelj>(columnName, queryOp, value);
        }
		public static async Task<Narucitelj> GetByPrimaryKeyAsync(int NaruciteljID)
        {
            return await GetByPrimaryKeyAsync<Narucitelj>(NaruciteljID);
        }
		public static async Task<Narucitelj> TryGetByPrimaryKeyAsync(int NaruciteljID)
        {
            return await TryGetByPrimaryKeyAsync<Narucitelj>(NaruciteljID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Narucitelj> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Narucitelj>(queryConditions);
        }
        public static IEnumerable<Narucitelj> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Narucitelj>(columnName, queryOp, value);
        }
		public static Narucitelj GetByPrimaryKey(int NaruciteljID)
        {
            return GetByPrimaryKey<Narucitelj>(NaruciteljID);
        }
		public static Narucitelj TryGetByPrimaryKey(int NaruciteljID)
        {
            return TryGetByPrimaryKey<Narucitelj>(NaruciteljID);
        }
        #endregion
    }
}