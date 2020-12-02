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
				new ColumnMetadata("OrijentacijaOrijentacija", @"OrijentacijaOrijentacija", SqlDbType.Char, isPrimaryKey: true),
                new ColumnMetadata("OrijentacijaAktivnost", @"OrijentacijaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("OrijentacijaJezik", @"OrijentacijaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("OrijentacijaNaziv", @"OrijentacijaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
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

        #region Public methods
		public static IEnumerable<Orijentacija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Orijentacija>(queryConditions);
        }
        public static IEnumerable<Orijentacija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Orijentacija>(columnName, queryOp, value);
        }
		public static Orijentacija GetByPrimaryKey(string OrijentacijaOrijentacija)
        {
            return GetByPrimaryKey<Orijentacija>(OrijentacijaOrijentacija);
        }
		public static Orijentacija TryGetByPrimaryKey(string OrijentacijaOrijentacija)
        {
            return TryGetByPrimaryKey<Orijentacija>(OrijentacijaOrijentacija);
        }
        #endregion
    }
}