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
    /// Naselje entity.
    /// </summary>
    public sealed partial class Naselje : Entity
    {
		#region Members
		private Drzava m_Drzava;
        private Opcina m_Opcina;
        private Posta m_Posta;
        #endregion
        
		#region Constructors
        static Naselje()
        {
            // Cache field metadata.
            EntityMeta<Naselje>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(NaseljeNaselje), @"NaseljeNaselje", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(NaseljeNaziv), @"NaseljeNaziv", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(NaseljeOpcina), @"NaseljeOpcina", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NaseljeDrzava), @"NaseljeDrzava", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(NaseljePosta), @"NaseljePosta", DbType.Int32, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Naselje>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Drzava), nameof(NaseljeDrzava), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(Opcina), nameof(NaseljeOpcina), nameof(Orko.Base.Opcina.OpcinaOpcina)),
                new RelationMetadata(nameof(Opcina), nameof(NaseljeDrzava), nameof(Orko.Base.Opcina.OpcinaDrzava)),
                new RelationMetadata(nameof(Posta), nameof(NaseljePosta), nameof(Orko.Base.Posta.PostaPosta)),
                new RelationMetadata(nameof(Posta), nameof(NaseljeDrzava), nameof(Orko.Base.Posta.PostaDrzava))
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
        public Posta Posta
        {
            get { return EntityContext<Posta>.Get(ref m_Posta, this, nameof(Posta)); }
            set { EntityContext<Posta>.Set(ref m_Posta, this, value, nameof(Posta)); }
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
    }
}