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

namespace Orko.Base
{
    /// <summary>
    /// Valuta entity.
    /// </summary>
    public sealed partial class Valuta : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Valuta()
        {
            // Cache field metadata.
            EntityMeta<Valuta>.LoadColumnMetadata
			(
				new ColumnMetadata("ValutaValuta", @"ValutaValuta", SqlDbType.Char, isPrimaryKey: true),
                new ColumnMetadata("ValutaOznaka", @"ValutaOznaka", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ValutaBrojcanaSifra", @"ValutaBrojcanaSifra", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("ValutaAktivnost", @"ValutaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("ValutaJezik", @"ValutaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("ValutaNaziv", @"ValutaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Valuta>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Valuta>.HasLanguageTable = true;
            EntityMeta<Valuta>.TableSchema = @"Base";
            EntityMeta<Valuta>.TableName = @"Valuta";
            EntityMeta<Valuta>.LanguageTableSchema = @"Base";
            EntityMeta<Valuta>.LanguageTableName = @"Valuta_jezik";
        }
        #endregion

        #region Columns
        public string ValutaValuta { get; set; }
        public string ValutaOznaka { get; set; }
        public string ValutaBrojcanaSifra { get; set; }
        public bool? ValutaAktivnost { get; set; }
        public string ValutaJezik { get; private set; }
        public string ValutaNaziv { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Valuta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Valuta>(queryConditions);
        }
        public static async Task<IEnumerable<Valuta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Valuta>(columnName, queryOp, value);
        }
		public static async Task<Valuta> GetByPrimaryKeyAsync(string ValutaValuta)
        {
            return await GetByPrimaryKeyAsync<Valuta>(ValutaValuta);
        }
		public static async Task<Valuta> TryGetByPrimaryKeyAsync(string ValutaValuta)
        {
            return await TryGetByPrimaryKeyAsync<Valuta>(ValutaValuta);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Valuta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Valuta>(queryConditions);
        }
        public static IEnumerable<Valuta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Valuta>(columnName, queryOp, value);
        }
		public static Valuta GetByPrimaryKey(string ValutaValuta)
        {
            return GetByPrimaryKey<Valuta>(ValutaValuta);
        }
		public static Valuta TryGetByPrimaryKey(string ValutaValuta)
        {
            return TryGetByPrimaryKey<Valuta>(ValutaValuta);
        }
        #endregion
    }
}