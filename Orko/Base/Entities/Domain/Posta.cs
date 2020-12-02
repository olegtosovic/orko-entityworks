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
    /// Posta entity.
    /// </summary>
    public sealed partial class Posta : Entity
    {
		#region Members
		private Drzava m_FK_Posta_Drzava;
        private Opcina m_FK_Posta_Opcina;
        private Zupanija m_FK_Posta_Zupanija;
        #endregion
        
		#region Constructors
        static Posta()
        {
            // Cache field metadata.
            EntityMeta<Posta>.LoadColumnMetadata
			(
				new ColumnMetadata("PostaPosta", @"PostaPosta", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("PostaDrzava", @"PostaDrzava", SqlDbType.Char, isPrimaryKey: true),
                new ColumnMetadata("PostaZupanija", @"PostaZupanija", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("PostaOpcina", @"PostaOpcina", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("PostaJezik", @"PostaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("PostaNaziv", @"PostaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Posta>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Posta_Drzava", "PostaDrzava", "DrzavaDrzava"),
                new RelationMetadata("FK_Posta_Opcina", "PostaOpcina", "OpcinaOpcina"),
                new RelationMetadata("FK_Posta_Opcina", "PostaDrzava", "OpcinaDrzava"),
                new RelationMetadata("FK_Posta_Zupanija", "PostaZupanija", "ZupanijaZupanija"),
                new RelationMetadata("FK_Posta_Zupanija", "PostaDrzava", "ZupanijaDrzava")
			);

			// Cache table metadata.
			EntityMeta<Posta>.HasLanguageTable = true;
            EntityMeta<Posta>.TableSchema = @"Base";
            EntityMeta<Posta>.TableName = @"Posta";
            EntityMeta<Posta>.LanguageTableSchema = @"Base";
            EntityMeta<Posta>.LanguageTableName = @"Posta_jezik";
        }
        #endregion

        #region Columns
        public int? PostaPosta { get; set; }
        public string PostaDrzava { get; set; }
        public string PostaZupanija { get; set; }
        public string PostaOpcina { get; set; }
        public string PostaJezik { get; private set; }
        public string PostaNaziv { get; set; }
        #endregion

        #region Entities
		public Drzava FK_Posta_Drzava
        {
            get { return EntityContext<Drzava>.Get(ref m_FK_Posta_Drzava, this, "FK_Posta_Drzava"); }
            set { EntityContext<Drzava>.Set(ref m_FK_Posta_Drzava, this, value, "FK_Posta_Drzava"); }
        }
        public Opcina FK_Posta_Opcina
        {
            get { return EntityContext<Opcina>.Get(ref m_FK_Posta_Opcina, this, "FK_Posta_Opcina"); }
            set { EntityContext<Opcina>.Set(ref m_FK_Posta_Opcina, this, value, "FK_Posta_Opcina"); }
        }
        public Zupanija FK_Posta_Zupanija
        {
            get { return EntityContext<Zupanija>.Get(ref m_FK_Posta_Zupanija, this, "FK_Posta_Zupanija"); }
            set { EntityContext<Zupanija>.Set(ref m_FK_Posta_Zupanija, this, value, "FK_Posta_Zupanija"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Posta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Posta>(queryConditions);
        }
        public static async Task<IEnumerable<Posta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Posta>(columnName, queryOp, value);
        }
		public static async Task<Posta> GetByPrimaryKeyAsync(int PostaPosta, string PostaDrzava)
        {
            return await GetByPrimaryKeyAsync<Posta>(PostaPosta, PostaDrzava);
        }
		public static async Task<Posta> TryGetByPrimaryKeyAsync(int PostaPosta, string PostaDrzava)
        {
            return await TryGetByPrimaryKeyAsync<Posta>(PostaPosta, PostaDrzava);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Posta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Posta>(queryConditions);
        }
        public static IEnumerable<Posta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Posta>(columnName, queryOp, value);
        }
		public static Posta GetByPrimaryKey(int PostaPosta, string PostaDrzava)
        {
            return GetByPrimaryKey<Posta>(PostaPosta, PostaDrzava);
        }
		public static Posta TryGetByPrimaryKey(int PostaPosta, string PostaDrzava)
        {
            return TryGetByPrimaryKey<Posta>(PostaPosta, PostaDrzava);
        }
        #endregion
    }
}