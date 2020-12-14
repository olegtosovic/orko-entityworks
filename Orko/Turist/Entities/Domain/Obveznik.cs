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
    /// Obveznik entity.
    /// </summary>
    public sealed partial class Obveznik : Entity
    {
		#region Members
		private Base.Drzava m_Drzava;
        private Base.Opcina m_Opcina;
        private Base.Posta m_Posta;
        private Base.PravnaOsobnost m_PravnaOsobnost;
        private Base.Zupanija m_Zupanija;
        #endregion
        
		#region Constructors
        static Obveznik()
        {
            // Cache field metadata.
            EntityMeta<Obveznik>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ObveznikObveznik), @"ObveznikObveznik", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(ObveznikOIB), @"ObveznikOIB", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ObveznikIme), @"ObveznikIme", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikPrezime), @"ObveznikPrezime", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikNaziv), @"ObveznikNaziv", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ObveznikPravnaOsobnost), @"ObveznikPravnaOsobnost", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(ObveznikPrebivalisteDrzava), @"ObveznikPrebivalisteDrzava", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(ObveznikPrebivalisteOpcina), @"ObveznikPrebivalisteOpcina", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikPrebivalisteZupanija), @"ObveznikPrebivalisteZupanija", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikPrebivalistePosta), @"ObveznikPrebivalistePosta", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(ObveznikPrebivalisteUlica), @"ObveznikPrebivalisteUlica", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ObveznikPrebivalisteKucniBroj), @"ObveznikPrebivalisteKucniBroj", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ObveznikTelefon1), @"ObveznikTelefon1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikTelefon2), @"ObveznikTelefon2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikMobitel1), @"ObveznikMobitel1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikMobitel2), @"ObveznikMobitel2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikEmail1), @"ObveznikEmail1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikEmail2), @"ObveznikEmail2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObveznikAktivnost), @"ObveznikAktivnost", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Obveznik>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Drzava), nameof(ObveznikPrebivalisteDrzava), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(Opcina), nameof(ObveznikPrebivalisteOpcina), nameof(Orko.Base.Opcina.OpcinaOpcina)),
                new RelationMetadata(nameof(Opcina), nameof(ObveznikPrebivalisteDrzava), nameof(Orko.Base.Opcina.OpcinaDrzava)),
                new RelationMetadata(nameof(Posta), nameof(ObveznikPrebivalistePosta), nameof(Orko.Base.Posta.PostaPosta)),
                new RelationMetadata(nameof(Posta), nameof(ObveznikPrebivalisteDrzava), nameof(Orko.Base.Posta.PostaDrzava)),
                new RelationMetadata(nameof(PravnaOsobnost), nameof(ObveznikPravnaOsobnost), nameof(Orko.Base.PravnaOsobnost.PravnaOsobnostPravnaOsobnost)),
                new RelationMetadata(nameof(Zupanija), nameof(ObveznikPrebivalisteZupanija), nameof(Orko.Base.Zupanija.ZupanijaZupanija)),
                new RelationMetadata(nameof(Zupanija), nameof(ObveznikPrebivalisteDrzava), nameof(Orko.Base.Zupanija.ZupanijaDrzava))
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
		public Base.Drzava Drzava
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_Drzava, this, nameof(Drzava)); }
            set { EntityContext<Base.Drzava>.Set(ref m_Drzava, this, value, nameof(Drzava)); }
        }
        public Base.Opcina Opcina
        {
            get { return EntityContext<Base.Opcina>.Get(ref m_Opcina, this, nameof(Opcina)); }
            set { EntityContext<Base.Opcina>.Set(ref m_Opcina, this, value, nameof(Opcina)); }
        }
        public Base.Posta Posta
        {
            get { return EntityContext<Base.Posta>.Get(ref m_Posta, this, nameof(Posta)); }
            set { EntityContext<Base.Posta>.Set(ref m_Posta, this, value, nameof(Posta)); }
        }
        public Base.PravnaOsobnost PravnaOsobnost
        {
            get { return EntityContext<Base.PravnaOsobnost>.Get(ref m_PravnaOsobnost, this, nameof(PravnaOsobnost)); }
            set { EntityContext<Base.PravnaOsobnost>.Set(ref m_PravnaOsobnost, this, value, nameof(PravnaOsobnost)); }
        }
        public Base.Zupanija Zupanija
        {
            get { return EntityContext<Base.Zupanija>.Get(ref m_Zupanija, this, nameof(Zupanija)); }
            set { EntityContext<Base.Zupanija>.Set(ref m_Zupanija, this, value, nameof(Zupanija)); }
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
    }
}