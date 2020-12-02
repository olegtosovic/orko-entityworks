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
    /// PrijelazStatusaAkcija entity.
    /// </summary>
    public sealed partial class PrijelazStatusaAkcija : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static PrijelazStatusaAkcija()
        {
            // Cache field metadata.
            EntityMeta<PrijelazStatusaAkcija>.LoadColumnMetadata
			(
				new ColumnMetadata("PrijelazStatusaAkcijaPrijelazStatusaID", @"PrijelazStatusaAkcijaPrijelazStatusaID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("PrijelazStatusaAkcijaRedoslijed", @"PrijelazStatusaAkcijaRedoslijed", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("PrijelazStatusaAkcijaProcedura", @"PrijelazStatusaAkcijaProcedura", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("PrijelazStatusaAkcijaUputa", @"PrijelazStatusaAkcijaUputa", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("PrijelazStatusaAkcijaUradio", @"PrijelazStatusaAkcijaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("PrijelazStatusaAkcijaDatumIzmjene", @"PrijelazStatusaAkcijaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<PrijelazStatusaAkcija>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<PrijelazStatusaAkcija>.HasLanguageTable = false;
            EntityMeta<PrijelazStatusaAkcija>.TableSchema = @"Base";
            EntityMeta<PrijelazStatusaAkcija>.TableName = @"PrijelazStatusaAkcija";
            EntityMeta<PrijelazStatusaAkcija>.LanguageTableSchema = null;
            EntityMeta<PrijelazStatusaAkcija>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? PrijelazStatusaAkcijaPrijelazStatusaID { get; set; }
        public int? PrijelazStatusaAkcijaRedoslijed { get; set; }
        public string PrijelazStatusaAkcijaProcedura { get; set; }
        public string PrijelazStatusaAkcijaUputa { get; set; }
        public string PrijelazStatusaAkcijaUradio { get; set; }
        public DateTime? PrijelazStatusaAkcijaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<PrijelazStatusaAkcija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PrijelazStatusaAkcija>(queryConditions);
        }
        public static async Task<IEnumerable<PrijelazStatusaAkcija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PrijelazStatusaAkcija>(columnName, queryOp, value);
        }
		public static async Task<PrijelazStatusaAkcija> GetByPrimaryKeyAsync(int PrijelazStatusaAkcijaPrijelazStatusaID, int PrijelazStatusaAkcijaRedoslijed)
        {
            return await GetByPrimaryKeyAsync<PrijelazStatusaAkcija>(PrijelazStatusaAkcijaPrijelazStatusaID, PrijelazStatusaAkcijaRedoslijed);
        }
		public static async Task<PrijelazStatusaAkcija> TryGetByPrimaryKeyAsync(int PrijelazStatusaAkcijaPrijelazStatusaID, int PrijelazStatusaAkcijaRedoslijed)
        {
            return await TryGetByPrimaryKeyAsync<PrijelazStatusaAkcija>(PrijelazStatusaAkcijaPrijelazStatusaID, PrijelazStatusaAkcijaRedoslijed);
        }
		#endregion

        #region Public methods
		public static IEnumerable<PrijelazStatusaAkcija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<PrijelazStatusaAkcija>(queryConditions);
        }
        public static IEnumerable<PrijelazStatusaAkcija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<PrijelazStatusaAkcija>(columnName, queryOp, value);
        }
		public static PrijelazStatusaAkcija GetByPrimaryKey(int PrijelazStatusaAkcijaPrijelazStatusaID, int PrijelazStatusaAkcijaRedoslijed)
        {
            return GetByPrimaryKey<PrijelazStatusaAkcija>(PrijelazStatusaAkcijaPrijelazStatusaID, PrijelazStatusaAkcijaRedoslijed);
        }
		public static PrijelazStatusaAkcija TryGetByPrimaryKey(int PrijelazStatusaAkcijaPrijelazStatusaID, int PrijelazStatusaAkcijaRedoslijed)
        {
            return TryGetByPrimaryKey<PrijelazStatusaAkcija>(PrijelazStatusaAkcijaPrijelazStatusaID, PrijelazStatusaAkcijaRedoslijed);
        }
        #endregion
    }
}