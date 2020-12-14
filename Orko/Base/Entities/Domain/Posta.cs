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
    /// Posta entity.
    /// </summary>
    public sealed partial class Posta : Entity
    {
		#region Members
		private Drzava m_Drzava;
        private Opcina m_Opcina;
        private Zupanija m_Zupanija;
        #endregion
        
		#region Constructors
        static Posta()
        {
            // Cache field metadata.
            EntityMeta<Posta>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(PostaPosta), @"PostaPosta", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PostaDrzava), @"PostaDrzava", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(PostaZupanija), @"PostaZupanija", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(PostaOpcina), @"PostaOpcina", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(PostaJezik), @"PostaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(PostaNaziv), @"PostaNaziv", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Posta>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Drzava), nameof(PostaDrzava), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(Opcina), nameof(PostaOpcina), nameof(Orko.Base.Opcina.OpcinaOpcina)),
                new RelationMetadata(nameof(Opcina), nameof(PostaDrzava), nameof(Orko.Base.Opcina.OpcinaDrzava)),
                new RelationMetadata(nameof(Zupanija), nameof(PostaZupanija), nameof(Orko.Base.Zupanija.ZupanijaZupanija)),
                new RelationMetadata(nameof(Zupanija), nameof(PostaDrzava), nameof(Orko.Base.Zupanija.ZupanijaDrzava))
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
		public Drzava Drzava
        {
            get { return EntityContext<Drzava>.Get(ref m_Drzava, this, nameof(Drzava)); }
            set { EntityContext<Drzava>.Set(ref m_Drzava, this, value, nameof(Drzava)); }
        }
        public Opcina Opcina
        {
            get { return EntityContext<Opcina>.Get(ref m_Opcina, this, nameof(Opcina)); }
            set { EntityContext<Opcina>.Set(ref m_Opcina, this, value, nameof(Opcina)); }
        }
        public Zupanija Zupanija
        {
            get { return EntityContext<Zupanija>.Get(ref m_Zupanija, this, nameof(Zupanija)); }
            set { EntityContext<Zupanija>.Set(ref m_Zupanija, this, value, nameof(Zupanija)); }
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
    }
}