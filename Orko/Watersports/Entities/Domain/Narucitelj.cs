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
    /// Narucitelj entity.
    /// </summary>
    public sealed partial class Narucitelj : Entity
    {
		#region Members
		private Base.Firma m_Firma;
        private Base.Osoba m_Osoba;
        private Base.PravnaOsobnost m_PravnaOsobnost;
        #endregion
        
		#region Constructors
        static Narucitelj()
        {
            // Cache field metadata.
            EntityMeta<Narucitelj>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(NaruciteljID), @"NaruciteljID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(NaruciteljPravnaOsobnost), @"NaruciteljPravnaOsobnost", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljOsobaID), @"NaruciteljOsobaID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljFirma), @"NaruciteljFirma", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljDomaci), @"NaruciteljDomaci", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljOIB), @"NaruciteljOIB", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljIme), @"NaruciteljIme", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljPrezime), @"NaruciteljPrezime", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljNaziv), @"NaruciteljNaziv", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljTelefon1), @"NaruciteljTelefon1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljTelefon2), @"NaruciteljTelefon2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljMobitel1), @"NaruciteljMobitel1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljMobitel2), @"NaruciteljMobitel2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaruciteljEmail), @"NaruciteljEmail", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Narucitelj>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Firma), nameof(NaruciteljFirma), nameof(Orko.Base.Firma.FirmaFirma)),
                new RelationMetadata(nameof(Osoba), nameof(NaruciteljOsobaID), nameof(Orko.Base.Osoba.OsobaID)),
                new RelationMetadata(nameof(PravnaOsobnost), nameof(NaruciteljPravnaOsobnost), nameof(Orko.Base.PravnaOsobnost.PravnaOsobnostPravnaOsobnost))
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
    }
}