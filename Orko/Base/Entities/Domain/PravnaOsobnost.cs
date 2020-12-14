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
    /// PravnaOsobnost entity.
    /// </summary>
    public sealed partial class PravnaOsobnost : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static PravnaOsobnost()
        {
            // Cache field metadata.
            EntityMeta<PravnaOsobnost>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(PravnaOsobnostPravnaOsobnost), @"PravnaOsobnostPravnaOsobnost", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(PravnaOsobnostJezik), @"PravnaOsobnostJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(PravnaOsobnostNaziv), @"PravnaOsobnostNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(PravnaOsobnostOpis), @"PravnaOsobnostOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<PravnaOsobnost>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<PravnaOsobnost>.HasLanguageTable = true;
            EntityMeta<PravnaOsobnost>.TableSchema = @"Base";
            EntityMeta<PravnaOsobnost>.TableName = @"PravnaOsobnost";
            EntityMeta<PravnaOsobnost>.LanguageTableSchema = @"Base";
            EntityMeta<PravnaOsobnost>.LanguageTableName = @"PravnaOsobnost_jezik";
        }
        #endregion

        #region Columns
        public string PravnaOsobnostPravnaOsobnost { get; set; }
        public string PravnaOsobnostJezik { get; private set; }
        public string PravnaOsobnostNaziv { get; set; }
        public string PravnaOsobnostOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<PravnaOsobnost>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PravnaOsobnost>(queryConditions);
        }
        public static async Task<IEnumerable<PravnaOsobnost>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PravnaOsobnost>(columnName, queryOp, value);
        }
		public static async Task<PravnaOsobnost> GetByPrimaryKeyAsync(string PravnaOsobnostPravnaOsobnost)
        {
            return await GetByPrimaryKeyAsync<PravnaOsobnost>(PravnaOsobnostPravnaOsobnost);
        }
		public static async Task<PravnaOsobnost> TryGetByPrimaryKeyAsync(string PravnaOsobnostPravnaOsobnost)
        {
            return await TryGetByPrimaryKeyAsync<PravnaOsobnost>(PravnaOsobnostPravnaOsobnost);
        }
		#endregion
    }
}