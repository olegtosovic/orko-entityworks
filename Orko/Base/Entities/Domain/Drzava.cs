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
    /// Drzava entity.
    /// </summary>
    public sealed partial class Drzava : Entity
    {
		#region Members
		private Kontinent m_Kontinent;
        private Valuta m_Valuta;
        #endregion
        
		#region Constructors
        static Drzava()
        {
            // Cache field metadata.
            EntityMeta<Drzava>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(DrzavaDrzava), @"DrzavaDrzava", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(DrzavaKontinent), @"DrzavaKontinent", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(DrzavaTroslovnaKratica), @"DrzavaTroslovnaKratica", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(DrzavaKod), @"DrzavaKod", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(DrzavaValuta), @"DrzavaValuta", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(DrzavaJezik), @"DrzavaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(DrzavaNaziv), @"DrzavaNaziv", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Drzava>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Kontinent), nameof(DrzavaKontinent), nameof(Orko.Base.Kontinent.KontinentKontinent)),
                new RelationMetadata(nameof(Valuta), nameof(DrzavaValuta), nameof(Orko.Base.Valuta.ValutaValuta))
			);

			// Cache table metadata.
			EntityMeta<Drzava>.HasLanguageTable = true;
            EntityMeta<Drzava>.TableSchema = @"Base";
            EntityMeta<Drzava>.TableName = @"Drzava";
            EntityMeta<Drzava>.LanguageTableSchema = @"Base";
            EntityMeta<Drzava>.LanguageTableName = @"Drzava_jezik";
        }
        #endregion

        #region Columns
        public string DrzavaDrzava { get; set; }
        public string DrzavaKontinent { get; set; }
        public string DrzavaTroslovnaKratica { get; set; }
        public string DrzavaKod { get; set; }
        public string DrzavaValuta { get; set; }
        public string DrzavaJezik { get; private set; }
        public string DrzavaNaziv { get; set; }
        #endregion

        #region Entities
		public Kontinent Kontinent
        {
            get { return EntityContext<Kontinent>.Get(ref m_Kontinent, this, nameof(Kontinent)); }
            set { EntityContext<Kontinent>.Set(ref m_Kontinent, this, value, nameof(Kontinent)); }
        }
        public Valuta Valuta
        {
            get { return EntityContext<Valuta>.Get(ref m_Valuta, this, nameof(Valuta)); }
            set { EntityContext<Valuta>.Set(ref m_Valuta, this, value, nameof(Valuta)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Drzava>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Drzava>(queryConditions);
        }
        public static async Task<IEnumerable<Drzava>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Drzava>(columnName, queryOp, value);
        }
		public static async Task<Drzava> GetByPrimaryKeyAsync(string DrzavaDrzava)
        {
            return await GetByPrimaryKeyAsync<Drzava>(DrzavaDrzava);
        }
		public static async Task<Drzava> TryGetByPrimaryKeyAsync(string DrzavaDrzava)
        {
            return await TryGetByPrimaryKeyAsync<Drzava>(DrzavaDrzava);
        }
		#endregion
    }
}