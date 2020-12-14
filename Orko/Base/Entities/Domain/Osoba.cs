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

namespace Orko.Base
{
    /// <summary>
    /// Osoba entity.
    /// </summary>
    public sealed partial class Osoba : Entity
    {
		#region Members
		private Drzava m_DrzavaRodjenja;
        private Opcina m_OpcinaRodjenja;
        private Spol m_Spol;
        #endregion
        
		#region Constructors
        static Osoba()
        {
            // Cache field metadata.
            EntityMeta<Osoba>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(OsobaID), @"OsobaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(OsobaIme), @"OsobaIme", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(OsobaPrezime), @"OsobaPrezime", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(OsobaPorezniBroj), @"OsobaPorezniBroj", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaSpol), @"OsobaSpol", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(OsobaTitula), @"OsobaTitula", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaDatumRodjenja), @"OsobaDatumRodjenja", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(OsobaRodjenoPrezime), @"OsobaRodjenoPrezime", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaMjestoRodjenja), @"OsobaMjestoRodjenja", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaOpcinaRodjenja), @"OsobaOpcinaRodjenja", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaDrzavaRodjenja), @"OsobaDrzavaRodjenja", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(OsobaNarodnost), @"OsobaNarodnost", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaTelefonPosao), @"OsobaTelefonPosao", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaTelefonKucni), @"OsobaTelefonKucni", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaFaxPosao), @"OsobaFaxPosao", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaFaxKucni), @"OsobaFaxKucni", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaMobitelOsobni), @"OsobaMobitelOsobni", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaMobitelSluzbeni), @"OsobaMobitelSluzbeni", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaEmailOsobni), @"OsobaEmailOsobni", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OsobaEmailPosao), @"OsobaEmailPosao", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Osoba>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(DrzavaRodjenja), nameof(OsobaDrzavaRodjenja), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(OpcinaRodjenja), nameof(OsobaOpcinaRodjenja), nameof(Orko.Base.Opcina.OpcinaOpcina)),
                new RelationMetadata(nameof(OpcinaRodjenja), nameof(OsobaDrzavaRodjenja), nameof(Orko.Base.Opcina.OpcinaDrzava)),
                new RelationMetadata(nameof(Spol), nameof(OsobaSpol), nameof(Orko.Base.Spol.SpolSpol))
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
		public Drzava DrzavaRodjenja
        {
            get { return EntityContext<Drzava>.Get(ref m_DrzavaRodjenja, this, nameof(DrzavaRodjenja)); }
            set { EntityContext<Drzava>.Set(ref m_DrzavaRodjenja, this, value, nameof(DrzavaRodjenja)); }
        }
        public Opcina OpcinaRodjenja
        {
            get { return EntityContext<Opcina>.Get(ref m_OpcinaRodjenja, this, nameof(OpcinaRodjenja)); }
            set { EntityContext<Opcina>.Set(ref m_OpcinaRodjenja, this, value, nameof(OpcinaRodjenja)); }
        }
        public Spol Spol
        {
            get { return EntityContext<Spol>.Get(ref m_Spol, this, nameof(Spol)); }
            set { EntityContext<Spol>.Set(ref m_Spol, this, value, nameof(Spol)); }
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
    }
}