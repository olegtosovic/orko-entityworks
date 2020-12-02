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

namespace Orko.Sistem
{
    /// <summary>
    /// Iznimka entity.
    /// </summary>
    public sealed partial class Iznimka : Entity
    {
		#region Members
		private Iznimka m_FK_Iznimka_UnutarnjaIznimka;
        #endregion
        
		#region Constructors
        static Iznimka()
        {
            // Cache field metadata.
            EntityMeta<Iznimka>.LoadColumnMetadata
			(
				new ColumnMetadata("IznimkaID", @"IznimkaID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("IznimkaMessage", @"IznimkaMessage", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("IznimkaSource", @"IznimkaSource", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("IznimkaStackTrace", @"IznimkaStackTrace", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("IznimkaTargetSite", @"IznimkaTargetSite", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("IznimkaInnerExceptionID", @"IznimkaInnerExceptionID", SqlDbType.Int, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Iznimka>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Iznimka_UnutarnjaIznimka", "IznimkaInnerExceptionID", "IznimkaID")
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
		public Iznimka FK_Iznimka_UnutarnjaIznimka
        {
            get { return EntityContext<Iznimka>.Get(ref m_FK_Iznimka_UnutarnjaIznimka, this, "FK_Iznimka_UnutarnjaIznimka"); }
            set { EntityContext<Iznimka>.Set(ref m_FK_Iznimka_UnutarnjaIznimka, this, value, "FK_Iznimka_UnutarnjaIznimka"); }
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

        #region Public methods
		public static IEnumerable<Iznimka> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Iznimka>(queryConditions);
        }
        public static IEnumerable<Iznimka> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Iznimka>(columnName, queryOp, value);
        }
		public static Iznimka GetByPrimaryKey(int IznimkaID)
        {
            return GetByPrimaryKey<Iznimka>(IznimkaID);
        }
		public static Iznimka TryGetByPrimaryKey(int IznimkaID)
        {
            return TryGetByPrimaryKey<Iznimka>(IznimkaID);
        }
        #endregion
    }
}