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

namespace Orko.Sistem
{
    /// <summary>
    /// Korisnik entity.
    /// </summary>
    public sealed partial class Korisnik : Entity
    {
		#region Members
		private Base.Firma m_Firma;
        private Base.Osoba m_Osoba;
        #endregion
        
		#region Constructors
        static Korisnik()
        {
            // Cache field metadata.
            EntityMeta<Korisnik>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(KorisnikID), @"KorisnikID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(KorisnikOsobaID), @"KorisnikOsobaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(KorisnikFirma), @"KorisnikFirma", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KorisnikUsername), @"KorisnikUsername", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KorisnikPassword), @"KorisnikPassword", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KorisnikPasswordSalt), @"KorisnikPasswordSalt", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(KorisnikEmailRegistracije), @"KorisnikEmailRegistracije", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(KorisnikTrajanjeLozinke), @"KorisnikTrajanjeLozinke", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(KorisnikTrajanjeKorisnika), @"KorisnikTrajanjeKorisnika", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(KorisnikDatumRegistracije), @"KorisnikDatumRegistracije", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(KorisnikAdministrator), @"KorisnikAdministrator", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(KorisnikBaza), @"KorisnikBaza", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(KorisnikAktivnost), @"KorisnikAktivnost", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Korisnik>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Firma), nameof(KorisnikFirma), nameof(Orko.Base.Firma.FirmaFirma)),
                new RelationMetadata(nameof(Osoba), nameof(KorisnikOsobaID), nameof(Orko.Base.Osoba.OsobaID))
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
		public Base.Firma Firma
        {
            get { return EntityContext<Base.Firma>.Get(ref m_Firma, this, nameof(Firma)); }
            set { EntityContext<Base.Firma>.Set(ref m_Firma, this, value, nameof(Firma)); }
        }
        public Base.Osoba Osoba
        {
            get { return EntityContext<Base.Osoba>.Get(ref m_Osoba, this, nameof(Osoba)); }
            set { EntityContext<Base.Osoba>.Set(ref m_Osoba, this, value, nameof(Osoba)); }
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
    }
}