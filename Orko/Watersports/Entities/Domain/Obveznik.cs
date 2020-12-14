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
    /// Obveznik entity.
    /// </summary>
    public sealed partial class Obveznik : Entity
    {
		#region Members
		private Base.Firma m_Firma;
        private Base.Osoba m_Osoba;
        private Base.PravnaOsobnost m_PravnaOsobnost;
        #endregion
        
		#region Constructors
        static Obveznik()
        {
            // Cache field metadata.
            EntityMeta<Obveznik>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ObveznikID), @"ObveznikID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(ObveznikPravnaOsobnost), @"ObveznikPravnaOsobnost", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(ObveznikOsobaID), @"ObveznikOsobaID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(ObveznikFirma), @"ObveznikFirma", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikIme), @"ObveznikIme", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikPrezime), @"ObveznikPrezime", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikNaziv), @"ObveznikNaziv", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikTelefon1), @"ObveznikTelefon1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikTelefon2), @"ObveznikTelefon2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikMobitel1), @"ObveznikMobitel1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikMobitel2), @"ObveznikMobitel2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikEmail), @"ObveznikEmail", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikAktivnost), @"ObveznikAktivnost", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Obveznik>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Firma), nameof(ObveznikFirma), nameof(Orko.Base.Firma.FirmaFirma)),
                new RelationMetadata(nameof(Osoba), nameof(ObveznikOsobaID), nameof(Orko.Base.Osoba.OsobaID)),
                new RelationMetadata(nameof(PravnaOsobnost), nameof(ObveznikPravnaOsobnost), nameof(Orko.Base.PravnaOsobnost.PravnaOsobnostPravnaOsobnost))
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
        public Base.PravnaOsobnost PravnaOsobnost
        {
            get { return EntityContext<Base.PravnaOsobnost>.Get(ref m_PravnaOsobnost, this, nameof(PravnaOsobnost)); }
            set { EntityContext<Base.PravnaOsobnost>.Set(ref m_PravnaOsobnost, this, value, nameof(PravnaOsobnost)); }
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
    }
}