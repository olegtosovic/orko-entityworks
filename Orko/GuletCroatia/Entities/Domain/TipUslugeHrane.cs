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

namespace Orko.GuletCroatia
{
    /// <summary>
    /// TipUslugeHrane entity.
    /// </summary>
    public sealed partial class TipUslugeHrane : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TipUslugeHrane()
        {
            // Cache field metadata.
            EntityMeta<TipUslugeHrane>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TipUslugeHraneTipUslugeHrane), @"TipUslugeHraneTipUslugeHrane", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(TipUslugeHraneAktivnost), @"TipUslugeHraneAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(TipUslugeHraneJezik), @"TipUslugeHraneJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(TipUslugeHraneNaziv), @"TipUslugeHraneNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(TipUslugeHraneOpis), @"TipUslugeHraneOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<TipUslugeHrane>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TipUslugeHrane>.HasLanguageTable = true;
            EntityMeta<TipUslugeHrane>.TableSchema = @"GuletCroatia";
            EntityMeta<TipUslugeHrane>.TableName = @"TipUslugeHrane";
            EntityMeta<TipUslugeHrane>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<TipUslugeHrane>.LanguageTableName = @"TipUslugeHrane_jezik";
        }
        #endregion

        #region Columns
        public string TipUslugeHraneTipUslugeHrane { get; set; }
        public bool? TipUslugeHraneAktivnost { get; set; }
        public string TipUslugeHraneJezik { get; private set; }
        public string TipUslugeHraneNaziv { get; set; }
        public string TipUslugeHraneOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TipUslugeHrane>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TipUslugeHrane>(queryConditions);
        }
        public static async Task<IEnumerable<TipUslugeHrane>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TipUslugeHrane>(columnName, queryOp, value);
        }
		public static async Task<TipUslugeHrane> GetByPrimaryKeyAsync(string TipUslugeHraneTipUslugeHrane)
        {
            return await GetByPrimaryKeyAsync<TipUslugeHrane>(TipUslugeHraneTipUslugeHrane);
        }
		public static async Task<TipUslugeHrane> TryGetByPrimaryKeyAsync(string TipUslugeHraneTipUslugeHrane)
        {
            return await TryGetByPrimaryKeyAsync<TipUslugeHrane>(TipUslugeHraneTipUslugeHrane);
        }
		#endregion
    }
}