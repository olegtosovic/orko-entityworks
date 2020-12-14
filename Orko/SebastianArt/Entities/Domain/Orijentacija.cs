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

namespace Orko.SebastianArt
{
    /// <summary>
    /// Orijentacija entity.
    /// </summary>
    public sealed partial class Orijentacija : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Orijentacija()
        {
            // Cache field metadata.
            EntityMeta<Orijentacija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(OrijentacijaOrijentacija), @"OrijentacijaOrijentacija", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(OrijentacijaAktivnost), @"OrijentacijaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(OrijentacijaJezik), @"OrijentacijaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(OrijentacijaNaziv), @"OrijentacijaNaziv", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Orijentacija>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Orijentacija>.HasLanguageTable = true;
            EntityMeta<Orijentacija>.TableSchema = @"SebastianArt";
            EntityMeta<Orijentacija>.TableName = @"Orijentacija";
            EntityMeta<Orijentacija>.LanguageTableSchema = @"SebastianArt";
            EntityMeta<Orijentacija>.LanguageTableName = @"Orijentacija_jezik";
        }
        #endregion

        #region Columns
        public string OrijentacijaOrijentacija { get; set; }
        public bool? OrijentacijaAktivnost { get; set; }
        public string OrijentacijaJezik { get; private set; }
        public string OrijentacijaNaziv { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Orijentacija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Orijentacija>(queryConditions);
        }
        public static async Task<IEnumerable<Orijentacija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Orijentacija>(columnName, queryOp, value);
        }
		public static async Task<Orijentacija> GetByPrimaryKeyAsync(string OrijentacijaOrijentacija)
        {
            return await GetByPrimaryKeyAsync<Orijentacija>(OrijentacijaOrijentacija);
        }
		public static async Task<Orijentacija> TryGetByPrimaryKeyAsync(string OrijentacijaOrijentacija)
        {
            return await TryGetByPrimaryKeyAsync<Orijentacija>(OrijentacijaOrijentacija);
        }
		#endregion
    }
}