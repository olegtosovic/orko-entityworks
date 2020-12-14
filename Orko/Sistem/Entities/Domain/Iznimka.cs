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

namespace Orko.Sistem
{
    /// <summary>
    /// Iznimka entity.
    /// </summary>
    public sealed partial class Iznimka : Entity
    {
		#region Members
		private Iznimka m_UnutarnjaIznimka;
        #endregion
        
		#region Constructors
        static Iznimka()
        {
            // Cache field metadata.
            EntityMeta<Iznimka>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(IznimkaID), @"IznimkaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(IznimkaMessage), @"IznimkaMessage", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(IznimkaSource), @"IznimkaSource", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(IznimkaStackTrace), @"IznimkaStackTrace", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(IznimkaTargetSite), @"IznimkaTargetSite", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(IznimkaInnerExceptionID), @"IznimkaInnerExceptionID", DbType.Int32, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Iznimka>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(UnutarnjaIznimka), nameof(IznimkaInnerExceptionID), nameof(Orko.Sistem.Iznimka.IznimkaID))
			);

			// Cache table metadata.
			EntityMeta<Iznimka>.HasLanguageTable = false;
            EntityMeta<Iznimka>.TableSchema = @"Sistem";
            EntityMeta<Iznimka>.TableName = @"Iznimka";
            EntityMeta<Iznimka>.LanguageTableSchema = null;
            EntityMeta<Iznimka>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? IznimkaID { get; set; }
        public string IznimkaMessage { get; set; }
        public string IznimkaSource { get; set; }
        public string IznimkaStackTrace { get; set; }
        public string IznimkaTargetSite { get; set; }
        public int? IznimkaInnerExceptionID { get; set; }
        #endregion

        #region Entities
		public Iznimka UnutarnjaIznimka
        {
            get { return EntityContext<Iznimka>.Get(ref m_UnutarnjaIznimka, this, nameof(UnutarnjaIznimka)); }
            set { EntityContext<Iznimka>.Set(ref m_UnutarnjaIznimka, this, value, nameof(UnutarnjaIznimka)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Iznimka>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Iznimka>(queryConditions);
        }
        public static async Task<IEnumerable<Iznimka>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Iznimka>(columnName, queryOp, value);
        }
		public static async Task<Iznimka> GetByPrimaryKeyAsync(int IznimkaID)
        {
            return await GetByPrimaryKeyAsync<Iznimka>(IznimkaID);
        }
		public static async Task<Iznimka> TryGetByPrimaryKeyAsync(int IznimkaID)
        {
            return await TryGetByPrimaryKeyAsync<Iznimka>(IznimkaID);
        }
		#endregion
    }
}