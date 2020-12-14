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
    /// Kontinent entity.
    /// </summary>
    public sealed partial class Kontinent : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Kontinent()
        {
            // Cache field metadata.
            EntityMeta<Kontinent>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(KontinentKontinent), @"KontinentKontinent", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KontinentJezik), @"KontinentJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(KontinentNaziv), @"KontinentNaziv", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Kontinent>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Kontinent>.HasLanguageTable = true;
            EntityMeta<Kontinent>.TableSchema = @"Base";
            EntityMeta<Kontinent>.TableName = @"Kontinent";
            EntityMeta<Kontinent>.LanguageTableSchema = @"Base";
            EntityMeta<Kontinent>.LanguageTableName = @"Kontinent_jezik";
        }
        #endregion

        #region Columns
        public string KontinentKontinent { get; set; }
        public string KontinentJezik { get; private set; }
        public string KontinentNaziv { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Kontinent>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Kontinent>(queryConditions);
        }
        public static async Task<IEnumerable<Kontinent>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Kontinent>(columnName, queryOp, value);
        }
		public static async Task<Kontinent> GetByPrimaryKeyAsync(string KontinentKontinent)
        {
            return await GetByPrimaryKeyAsync<Kontinent>(KontinentKontinent);
        }
		public static async Task<Kontinent> TryGetByPrimaryKeyAsync(string KontinentKontinent)
        {
            return await TryGetByPrimaryKeyAsync<Kontinent>(KontinentKontinent);
        }
		#endregion
    }
}