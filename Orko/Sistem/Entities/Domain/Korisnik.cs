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

namespace Orko.Sistem
{
    /// <summary>
    /// Korisnik entity.
    /// </summary>
    public sealed partial class Korisnik : Entity
    {
		#region Members
		private Base.Firma m_FK_Korisnik_Firma;
        private Base.Osoba m_FK_Korisnik_Osoba;
        #endregion
        
		#region Constructors
        static Korisnik()
        {
            // Cache field metadata.
            EntityMeta<Korisnik>.LoadColumnMetadata
			(
				new ColumnMetadata("KorisnikID", @"KorisnikID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("KorisnikOsobaID", @"KorisnikOsobaID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("KorisnikFirma", @"KorisnikFirma", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("KorisnikUsername", @"KorisnikUsername", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("KorisnikPassword", @"KorisnikPassword", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("KorisnikPasswordSalt", @"KorisnikPasswordSalt", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("KorisnikEmailRegistracije", @"KorisnikEmailRegistracije", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("KorisnikTrajanjeLozinke", @"KorisnikTrajanjeLozinke", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("KorisnikTrajanjeKorisnika", @"KorisnikTrajanjeKorisnika", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("KorisnikDatumRegistracije", @"KorisnikDatumRegistracije", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("KorisnikAdministrator", @"KorisnikAdministrator", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("KorisnikBaza", @"KorisnikBaza", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("KorisnikAktivnost", @"KorisnikAktivnost", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Korisnik>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Korisnik_Firma", "KorisnikFirma", "FirmaFirma"),
                new RelationMetadata("FK_Korisnik_Osoba", "KorisnikOsobaID", "OsobaID")
			);

			// Cache table metadata.
			EntityMeta<Korisnik>.HasLanguageTable = false;
            EntityMeta<Korisnik>.TableSchema = @"Sistem";
            EntityMeta<Korisnik>.TableName = @"Korisnik";
            EntityMeta<Korisnik>.LanguageTableSchema = null;
            EntityMeta<Korisnik>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? KorisnikID { get; private set; }
        public int? KorisnikOsobaID { get; set; }
        public string KorisnikFirma { get; set; }
        public string KorisnikUsername { get; set; }
        public string KorisnikPassword { get; set; }
        public string KorisnikPasswordSalt { get; set; }
        public string KorisnikEmailRegistracije { get; set; }
        public DateTime? KorisnikTrajanjeLozinke { get; set; }
        public DateTime? KorisnikTrajanjeKorisnika { get; set; }
        public DateTime? KorisnikDatumRegistracije { get; set; }
        public bool? KorisnikAdministrator { get; set; }
        public string KorisnikBaza { get; set; }
        public bool? KorisnikAktivnost { get; set; }
        #endregion

        #region Entities
		public Base.Firma FK_Korisnik_Firma
        {
            get { return EntityContext<Base.Firma>.Get(ref m_FK_Korisnik_Firma, this, "FK_Korisnik_Firma"); }
            set { EntityContext<Base.Firma>.Set(ref m_FK_Korisnik_Firma, this, value, "FK_Korisnik_Firma"); }
        }
        public Base.Osoba FK_Korisnik_Osoba
        {
            get { return EntityContext<Base.Osoba>.Get(ref m_FK_Korisnik_Osoba, this, "FK_Korisnik_Osoba"); }
            set { EntityContext<Base.Osoba>.Set(ref m_FK_Korisnik_Osoba, this, value, "FK_Korisnik_Osoba"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Korisnik>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Korisnik>(queryConditions);
        }
        public static async Task<IEnumerable<Korisnik>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Korisnik>(columnName, queryOp, value);
        }
		public static async Task<Korisnik> GetByPrimaryKeyAsync(int KorisnikID)
        {
            return await GetByPrimaryKeyAsync<Korisnik>(KorisnikID);
        }
		public static async Task<Korisnik> TryGetByPrimaryKeyAsync(int KorisnikID)
        {
            return await TryGetByPrimaryKeyAsync<Korisnik>(KorisnikID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Korisnik> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Korisnik>(queryConditions);
        }
        public static IEnumerable<Korisnik> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Korisnik>(columnName, queryOp, value);
        }
		public static Korisnik GetByPrimaryKey(int KorisnikID)
        {
            return GetByPrimaryKey<Korisnik>(KorisnikID);
        }
		public static Korisnik TryGetByPrimaryKey(int KorisnikID)
        {
            return TryGetByPrimaryKey<Korisnik>(KorisnikID);
        }
        public static Korisnik GetByUnique1(int KorisnikOsobaID)
        {
            return GetByCallingParameters<Korisnik>(KorisnikOsobaID);
        }
		public static Korisnik TryGetByUnique1(int KorisnikOsobaID)
        {
            return TryGetByCallingParameters<Korisnik>(KorisnikOsobaID);
        }
        #endregion
    }
}