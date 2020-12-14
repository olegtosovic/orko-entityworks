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
				new ColumnMetadata(nameof(PrijelazStatusaAkcijaPrijelazStatusaID), @"PrijelazStatusaAkcijaPrijelazStatusaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaAkcijaRedoslijed), @"PrijelazStatusaAkcijaRedoslijed", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaAkcijaProcedura), @"PrijelazStatusaAkcijaProcedura", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(PrijelazStatusaAkcijaUputa), @"PrijelazStatusaAkcijaUputa", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(PrijelazStatusaAkcijaUradio), @"PrijelazStatusaAkcijaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaAkcijaDatumIzmjene), @"PrijelazStatusaAkcijaDatumIzmjene", DbType.DateTime2, isRequired: true)
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
    }
}