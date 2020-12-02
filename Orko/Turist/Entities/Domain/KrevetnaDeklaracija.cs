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

namespace Orko.Turist
{
    /// <summary>
    /// KrevetnaDeklaracija entity.
    /// </summary>
    public sealed partial class KrevetnaDeklaracija : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static KrevetnaDeklaracija()
        {
            // Cache field metadata.
            EntityMeta<KrevetnaDeklaracija>.LoadColumnMetadata
			(
				new ColumnMetadata("KrevetnaDeklaracijaKrevetnaDeklaracija", @"KrevetnaDeklaracijaKrevetnaDeklaracija", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("KrevetnaDeklaracijaBrojLezaja", @"KrevetnaDeklaracijaBrojLezaja", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("KrevetnaDeklaracijaBrojPomocnihLezaja", @"KrevetnaDeklaracijaBrojPomocnihLezaja", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("KrevetnaDeklaracijaMaksimalniKapacitet", @"KrevetnaDeklaracijaMaksimalniKapacitet", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("KrevetnaDeklaracijaAktivnost", @"KrevetnaDeklaracijaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("KrevetnaDeklaracijaJezik", @"KrevetnaDeklaracijaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("KrevetnaDeklaracijaNaziv", @"KrevetnaDeklaracijaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("KrevetnaDeklaracijaOpis", @"KrevetnaDeklaracijaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<KrevetnaDeklaracija>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<KrevetnaDeklaracija>.HasLanguageTable = true;
            EntityMeta<KrevetnaDeklaracija>.TableSchema = @"Turist";
            EntityMeta<KrevetnaDeklaracija>.TableName = @"KrevetnaDeklaracija";
            EntityMeta<KrevetnaDeklaracija>.LanguageTableSchema = @"Turist";
            EntityMeta<KrevetnaDeklaracija>.LanguageTableName = @"KrevetnaDeklaracija_jezik";
        }
        #endregion

        #region Columns
        public string KrevetnaDeklaracijaKrevetnaDeklaracija { get; set; }
        public int? KrevetnaDeklaracijaBrojLezaja { get; set; }
        public int? KrevetnaDeklaracijaBrojPomocnihLezaja { get; set; }
        public int? KrevetnaDeklaracijaMaksimalniKapacitet { get; set; }
        public bool? KrevetnaDeklaracijaAktivnost { get; set; }
        public string KrevetnaDeklaracijaJezik { get; private set; }
        public string KrevetnaDeklaracijaNaziv { get; set; }
        public string KrevetnaDeklaracijaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<KrevetnaDeklaracija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<KrevetnaDeklaracija>(queryConditions);
        }
        public static async Task<IEnumerable<KrevetnaDeklaracija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<KrevetnaDeklaracija>(columnName, queryOp, value);
        }
		public static async Task<KrevetnaDeklaracija> GetByPrimaryKeyAsync(string KrevetnaDeklaracijaKrevetnaDeklaracija)
        {
            return await GetByPrimaryKeyAsync<KrevetnaDeklaracija>(KrevetnaDeklaracijaKrevetnaDeklaracija);
        }
		public static async Task<KrevetnaDeklaracija> TryGetByPrimaryKeyAsync(string KrevetnaDeklaracijaKrevetnaDeklaracija)
        {
            return await TryGetByPrimaryKeyAsync<KrevetnaDeklaracija>(KrevetnaDeklaracijaKrevetnaDeklaracija);
        }
		#endregion

        #region Public methods
		public static IEnumerable<KrevetnaDeklaracija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<KrevetnaDeklaracija>(queryConditions);
        }
        public static IEnumerable<KrevetnaDeklaracija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<KrevetnaDeklaracija>(columnName, queryOp, value);
        }
		public static KrevetnaDeklaracija GetByPrimaryKey(string KrevetnaDeklaracijaKrevetnaDeklaracija)
        {
            return GetByPrimaryKey<KrevetnaDeklaracija>(KrevetnaDeklaracijaKrevetnaDeklaracija);
        }
		public static KrevetnaDeklaracija TryGetByPrimaryKey(string KrevetnaDeklaracijaKrevetnaDeklaracija)
        {
            return TryGetByPrimaryKey<KrevetnaDeklaracija>(KrevetnaDeklaracijaKrevetnaDeklaracija);
        }
        #endregion
    }
}