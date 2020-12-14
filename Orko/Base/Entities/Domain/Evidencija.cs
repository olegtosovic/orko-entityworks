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
    /// Evidencija entity.
    /// </summary>
    public sealed partial class Evidencija : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Evidencija()
        {
            // Cache field metadata.
            EntityMeta<Evidencija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(EvidencijaID), @"EvidencijaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(EvidencijaDatumIzrade), @"EvidencijaDatumIzrade", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(EvidencijaDatumIzmjene), @"EvidencijaDatumIzmjene", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(EvidencijaKorisnikIzradioID), @"EvidencijaKorisnikIzradioID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(EvidencijaKorisnikIzmjenioID), @"EvidencijaKorisnikIzmjenioID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(EvidencijaTimeStamp), @"EvidencijaTimeStamp", DbType.Binary, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Evidencija>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Evidencija>.HasLanguageTable = false;
            EntityMeta<Evidencija>.TableSchema = @"Base";
            EntityMeta<Evidencija>.TableName = @"Evidencija";
            EntityMeta<Evidencija>.LanguageTableSchema = null;
            EntityMeta<Evidencija>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? EvidencijaID { get; private set; }
        public DateTime? EvidencijaDatumIzrade { get; set; }
        public DateTime? EvidencijaDatumIzmjene { get; set; }
        public int? EvidencijaKorisnikIzradioID { get; set; }
        public int? EvidencijaKorisnikIzmjenioID { get; set; }
        public Byte[] EvidencijaTimeStamp { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Evidencija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Evidencija>(queryConditions);
        }
        public static async Task<IEnumerable<Evidencija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Evidencija>(columnName, queryOp, value);
        }
		public static async Task<Evidencija> GetByPrimaryKeyAsync(int EvidencijaID)
        {
            return await GetByPrimaryKeyAsync<Evidencija>(EvidencijaID);
        }
		public static async Task<Evidencija> TryGetByPrimaryKeyAsync(int EvidencijaID)
        {
            return await TryGetByPrimaryKeyAsync<Evidencija>(EvidencijaID);
        }
		#endregion
    }
}