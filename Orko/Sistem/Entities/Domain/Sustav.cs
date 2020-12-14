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
    /// Sustav entity.
    /// </summary>
    public sealed partial class Sustav : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Sustav()
        {
            // Cache field metadata.
            EntityMeta<Sustav>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SustavSustav), @"SustavSustav", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SustavAktivnost), @"SustavAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(SustavJezik), @"SustavJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(SustavNaziv), @"SustavNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(SustavOpis), @"SustavOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Sustav>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Sustav>.HasLanguageTable = true;
            EntityMeta<Sustav>.TableSchema = @"Sistem";
            EntityMeta<Sustav>.TableName = @"Sustav";
            EntityMeta<Sustav>.LanguageTableSchema = @"Sistem";
            EntityMeta<Sustav>.LanguageTableName = @"Sustav_jezik";
        }
        #endregion

        #region Columns
        public string SustavSustav { get; set; }
        public bool? SustavAktivnost { get; set; }
        public string SustavJezik { get; private set; }
        public string SustavNaziv { get; set; }
        public string SustavOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Sustav>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Sustav>(queryConditions);
        }
        public static async Task<IEnumerable<Sustav>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Sustav>(columnName, queryOp, value);
        }
		public static async Task<Sustav> GetByPrimaryKeyAsync(string SustavSustav)
        {
            return await GetByPrimaryKeyAsync<Sustav>(SustavSustav);
        }
		public static async Task<Sustav> TryGetByPrimaryKeyAsync(string SustavSustav)
        {
            return await TryGetByPrimaryKeyAsync<Sustav>(SustavSustav);
        }
		#endregion
    }
}