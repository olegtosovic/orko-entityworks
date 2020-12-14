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
    /// Jezik entity.
    /// </summary>
    public sealed partial class Jezik : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Jezik()
        {
            // Cache field metadata.
            EntityMeta<Jezik>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(JezikJezik), @"JezikJezik", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(JezikAktivnost), @"JezikAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(JezikJezikJezik), @"JezikJezikJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(JezikNaziv), @"JezikNaziv", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Jezik>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Jezik>.HasLanguageTable = true;
            EntityMeta<Jezik>.TableSchema = @"Base";
            EntityMeta<Jezik>.TableName = @"Jezik";
            EntityMeta<Jezik>.LanguageTableSchema = @"Base";
            EntityMeta<Jezik>.LanguageTableName = @"Jezik_jezik";
        }
        #endregion

        #region Columns
        public string JezikJezik { get; set; }
        public bool? JezikAktivnost { get; set; }
        public string JezikJezikJezik { get; private set; }
        public string JezikNaziv { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Jezik>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Jezik>(queryConditions);
        }
        public static async Task<IEnumerable<Jezik>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Jezik>(columnName, queryOp, value);
        }
		public static async Task<Jezik> GetByPrimaryKeyAsync(string JezikJezik)
        {
            return await GetByPrimaryKeyAsync<Jezik>(JezikJezik);
        }
		public static async Task<Jezik> TryGetByPrimaryKeyAsync(string JezikJezik)
        {
            return await TryGetByPrimaryKeyAsync<Jezik>(JezikJezik);
        }
		#endregion
    }
}