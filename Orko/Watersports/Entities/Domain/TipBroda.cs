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

namespace Orko.Watersports
{
    /// <summary>
    /// TipBroda entity.
    /// </summary>
    public sealed partial class TipBroda : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TipBroda()
        {
            // Cache field metadata.
            EntityMeta<TipBroda>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TipBrodaTipBroda), @"TipBrodaTipBroda", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(TipBrodaAktivnost), @"TipBrodaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(TipBrodaJezik), @"TipBrodaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(TipBrodaNaziv), @"TipBrodaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(TipBrodaOpis), @"TipBrodaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<TipBroda>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TipBroda>.HasLanguageTable = true;
            EntityMeta<TipBroda>.TableSchema = @"Watersports";
            EntityMeta<TipBroda>.TableName = @"TipBroda";
            EntityMeta<TipBroda>.LanguageTableSchema = @"Watersports";
            EntityMeta<TipBroda>.LanguageTableName = @"TipBroda_jezik";
        }
        #endregion

        #region Columns
        public string TipBrodaTipBroda { get; set; }
        public bool? TipBrodaAktivnost { get; set; }
        public string TipBrodaJezik { get; private set; }
        public string TipBrodaNaziv { get; set; }
        public string TipBrodaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TipBroda>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TipBroda>(queryConditions);
        }
        public static async Task<IEnumerable<TipBroda>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TipBroda>(columnName, queryOp, value);
        }
		public static async Task<TipBroda> GetByPrimaryKeyAsync(string TipBrodaTipBroda)
        {
            return await GetByPrimaryKeyAsync<TipBroda>(TipBrodaTipBroda);
        }
		public static async Task<TipBroda> TryGetByPrimaryKeyAsync(string TipBrodaTipBroda)
        {
            return await TryGetByPrimaryKeyAsync<TipBroda>(TipBrodaTipBroda);
        }
		#endregion
    }
}