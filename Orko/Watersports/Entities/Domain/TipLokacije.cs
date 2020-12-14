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
    /// TipLokacije entity.
    /// </summary>
    public sealed partial class TipLokacije : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TipLokacije()
        {
            // Cache field metadata.
            EntityMeta<TipLokacije>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TipLokacijeTipLokacije), @"TipLokacijeTipLokacije", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(TipLokacijeAktivnost), @"TipLokacijeAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(TipLokacijeJezik), @"TipLokacijeJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(TipLokacijeNaziv), @"TipLokacijeNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(TipLokacijeOpis), @"TipLokacijeOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<TipLokacije>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TipLokacije>.HasLanguageTable = true;
            EntityMeta<TipLokacije>.TableSchema = @"Watersports";
            EntityMeta<TipLokacije>.TableName = @"TipLokacije";
            EntityMeta<TipLokacije>.LanguageTableSchema = @"Watersports";
            EntityMeta<TipLokacije>.LanguageTableName = @"TipLokacije_jezik";
        }
        #endregion

        #region Columns
        public string TipLokacijeTipLokacije { get; set; }
        public bool? TipLokacijeAktivnost { get; set; }
        public string TipLokacijeJezik { get; private set; }
        public string TipLokacijeNaziv { get; set; }
        public string TipLokacijeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TipLokacije>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TipLokacije>(queryConditions);
        }
        public static async Task<IEnumerable<TipLokacije>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TipLokacije>(columnName, queryOp, value);
        }
		public static async Task<TipLokacije> GetByPrimaryKeyAsync(string TipLokacijeTipLokacije)
        {
            return await GetByPrimaryKeyAsync<TipLokacije>(TipLokacijeTipLokacije);
        }
		public static async Task<TipLokacije> TryGetByPrimaryKeyAsync(string TipLokacijeTipLokacije)
        {
            return await TryGetByPrimaryKeyAsync<TipLokacije>(TipLokacijeTipLokacije);
        }
		#endregion
    }
}