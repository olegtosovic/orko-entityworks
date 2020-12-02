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
    /// Naselje entity.
    /// </summary>
    public sealed partial class Naselje : Entity
    {
		#region Members
		private Drzava m_FK_Naselje_Drzava;
        private Opcina m_FK_Naselje_Opcina;
        private Posta m_FK_Naselje_Posta;
        #endregion
        
		#region Constructors
        static Naselje()
        {
            // Cache field metadata.
            EntityMeta<Naselje>.LoadColumnMetadata
			(
				new ColumnMetadata("NaseljeNaselje", @"NaseljeNaselje", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("NaseljeNaziv", @"NaseljeNaziv", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("NaseljeOpcina", @"NaseljeOpcina", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NaseljeDrzava", @"NaseljeDrzava", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("NaseljePosta", @"NaseljePosta", SqlDbType.Int, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Naselje>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Naselje_Drzava", "NaseljeDrzava", "DrzavaDrzava"),
                new RelationMetadata("FK_Naselje_Opcina", "NaseljeOpcina", "OpcinaOpcina"),
                new RelationMetadata("FK_Naselje_Opcina", "NaseljeDrzava", "OpcinaDrzava"),
                new RelationMetadata("FK_Naselje_Posta", "NaseljePosta", "PostaPosta"),
                new RelationMetadata("FK_Naselje_Posta", "NaseljeDrzava", "PostaDrzava")
			);

			// Cache table metadata.
			EntityMeta<Naselje>.HasLanguageTable = false;
            EntityMeta<Naselje>.TableSchema = @"Base";
            EntityMeta<Naselje>.TableName = @"Naselje";
            EntityMeta<Naselje>.LanguageTableSchema = null;
            EntityMeta<Naselje>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string NaseljeNaselje { get; set; }
        public string NaseljeNaziv { get; set; }
        public string NaseljeOpcina { get; set; }
        public string NaseljeDrzava { get; set; }
        public int? NaseljePosta { get; set; }
        #endregion

        #region Entities
		public Drzava FK_Naselje_Drzava
        {
            get { return EntityContext<Drzava>.Get(ref m_FK_Naselje_Drzava, this, "FK_Naselje_Drzava"); }
            set { EntityContext<Drzava>.Set(ref m_FK_Naselje_Drzava, this, value, "FK_Naselje_Drzava"); }
        }
        public Opcina FK_Naselje_Opcina
        {
            get { return EntityContext<Opcina>.Get(ref m_FK_Naselje_Opcina, this, "FK_Naselje_Opcina"); }
            set { EntityContext<Opcina>.Set(ref m_FK_Naselje_Opcina, this, value, "FK_Naselje_Opcina"); }
        }
        public Posta FK_Naselje_Posta
        {
            get { return EntityContext<Posta>.Get(ref m_FK_Naselje_Posta, this, "FK_Naselje_Posta"); }
            set { EntityContext<Posta>.Set(ref m_FK_Naselje_Posta, this, value, "FK_Naselje_Posta"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Naselje>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Naselje>(queryConditions);
        }
        public static async Task<IEnumerable<Naselje>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Naselje>(columnName, queryOp, value);
        }
		public static async Task<Naselje> GetByPrimaryKeyAsync(string NaseljeNaselje)
        {
            return await GetByPrimaryKeyAsync<Naselje>(NaseljeNaselje);
        }
		public static async Task<Naselje> TryGetByPrimaryKeyAsync(string NaseljeNaselje)
        {
            return await TryGetByPrimaryKeyAsync<Naselje>(NaseljeNaselje);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Naselje> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Naselje>(queryConditions);
        }
        public static IEnumerable<Naselje> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Naselje>(columnName, queryOp, value);
        }
		public static Naselje GetByPrimaryKey(string NaseljeNaselje)
        {
            return GetByPrimaryKey<Naselje>(NaseljeNaselje);
        }
		public static Naselje TryGetByPrimaryKey(string NaseljeNaselje)
        {
            return TryGetByPrimaryKey<Naselje>(NaseljeNaselje);
        }
        #endregion
    }
}