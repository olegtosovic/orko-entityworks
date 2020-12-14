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
				new ColumnMetadata(nameof(KrevetnaDeklaracijaKrevetnaDeklaracija), @"KrevetnaDeklaracijaKrevetnaDeklaracija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KrevetnaDeklaracijaBrojLezaja), @"KrevetnaDeklaracijaBrojLezaja", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(KrevetnaDeklaracijaBrojPomocnihLezaja), @"KrevetnaDeklaracijaBrojPomocnihLezaja", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(KrevetnaDeklaracijaMaksimalniKapacitet), @"KrevetnaDeklaracijaMaksimalniKapacitet", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(KrevetnaDeklaracijaAktivnost), @"KrevetnaDeklaracijaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(KrevetnaDeklaracijaJezik), @"KrevetnaDeklaracijaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(KrevetnaDeklaracijaNaziv), @"KrevetnaDeklaracijaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(KrevetnaDeklaracijaOpis), @"KrevetnaDeklaracijaOpis", DbType.String, isRequired: false, isLanguage: true)
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
    }
}