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

namespace Orko.Base
{
    /// <summary>
    /// Drzava entity.
    /// </summary>
    public sealed partial class Drzava : Entity
    {
		#region Members
		private Kontinent m_FK_Drzava_Kontinent;
        private Valuta m_FK_Drzava_Valuta;
        #endregion
        
		#region Constructors
        static Drzava()
        {
            // Cache field metadata.
            EntityMeta<Drzava>.LoadColumnMetadata
			(
				new ColumnMetadata("DrzavaDrzava", @"DrzavaDrzava", SqlDbType.Char, isPrimaryKey: true),
                new ColumnMetadata("DrzavaKontinent", @"DrzavaKontinent", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("DrzavaTroslovnaKratica", @"DrzavaTroslovnaKratica", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("DrzavaKod", @"DrzavaKod", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("DrzavaValuta", @"DrzavaValuta", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("DrzavaJezik", @"DrzavaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("DrzavaNaziv", @"DrzavaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Drzava>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Drzava_Kontinent", "DrzavaKontinent", "KontinentKontinent"),
                new RelationMetadata("FK_Drzava_Valuta", "DrzavaValuta", "ValutaValuta")
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
		public Kontinent FK_Drzava_Kontinent
        {
            get { return EntityContext<Kontinent>.Get(ref m_FK_Drzava_Kontinent, this, "FK_Drzava_Kontinent"); }
            set { EntityContext<Kontinent>.Set(ref m_FK_Drzava_Kontinent, this, value, "FK_Drzava_Kontinent"); }
        }
        public Valuta FK_Drzava_Valuta
        {
            get { return EntityContext<Valuta>.Get(ref m_FK_Drzava_Valuta, this, "FK_Drzava_Valuta"); }
            set { EntityContext<Valuta>.Set(ref m_FK_Drzava_Valuta, this, value, "FK_Drzava_Valuta"); }
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

        #region Public methods
		public static IEnumerable<Drzava> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Drzava>(queryConditions);
        }
        public static IEnumerable<Drzava> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Drzava>(columnName, queryOp, value);
        }
		public static Drzava GetByPrimaryKey(string DrzavaDrzava)
        {
            return GetByPrimaryKey<Drzava>(DrzavaDrzava);
        }
		public static Drzava TryGetByPrimaryKey(string DrzavaDrzava)
        {
            return TryGetByPrimaryKey<Drzava>(DrzavaDrzava);
        }
        #endregion
    }
}