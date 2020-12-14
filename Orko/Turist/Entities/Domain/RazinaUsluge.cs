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
    /// RazinaUsluge entity.
    /// </summary>
    public sealed partial class RazinaUsluge : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static RazinaUsluge()
        {
            // Cache field metadata.
            EntityMeta<RazinaUsluge>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(RazinaUslugeRazinaUsluge), @"RazinaUslugeRazinaUsluge", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(RazinaUslugeAktivnost), @"RazinaUslugeAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(RazinaUslugeJezik), @"RazinaUslugeJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(RazinaUslugeNaziv), @"RazinaUslugeNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(RazinaUslugeOpis), @"RazinaUslugeOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<RazinaUsluge>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<RazinaUsluge>.HasLanguageTable = true;
            EntityMeta<RazinaUsluge>.TableSchema = @"Turist";
            EntityMeta<RazinaUsluge>.TableName = @"RazinaUsluge";
            EntityMeta<RazinaUsluge>.LanguageTableSchema = @"Turist";
            EntityMeta<RazinaUsluge>.LanguageTableName = @"RazinaUsluge_jezik";
        }
        #endregion

        #region Columns
        public string RazinaUslugeRazinaUsluge { get; set; }
        public bool? RazinaUslugeAktivnost { get; set; }
        public string RazinaUslugeJezik { get; private set; }
        public string RazinaUslugeNaziv { get; set; }
        public string RazinaUslugeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<RazinaUsluge>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<RazinaUsluge>(queryConditions);
        }
        public static async Task<IEnumerable<RazinaUsluge>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<RazinaUsluge>(columnName, queryOp, value);
        }
		public static async Task<RazinaUsluge> GetByPrimaryKeyAsync(string RazinaUslugeRazinaUsluge)
        {
            return await GetByPrimaryKeyAsync<RazinaUsluge>(RazinaUslugeRazinaUsluge);
        }
		public static async Task<RazinaUsluge> TryGetByPrimaryKeyAsync(string RazinaUslugeRazinaUsluge)
        {
            return await TryGetByPrimaryKeyAsync<RazinaUsluge>(RazinaUslugeRazinaUsluge);
        }
		#endregion
    }
}