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
    /// VrstaPutneIsprave entity.
    /// </summary>
    public sealed partial class VrstaPutneIsprave : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaPutneIsprave()
        {
            // Cache field metadata.
            EntityMeta<VrstaPutneIsprave>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaPutneIspraveVrstaPutneIsprave), @"VrstaPutneIspraveVrstaPutneIsprave", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaPutneIspraveAktivnost), @"VrstaPutneIspraveAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaPutneIspraveJezik), @"VrstaPutneIspraveJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaPutneIspraveNaziv), @"VrstaPutneIspraveNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaPutneIspraveOpis), @"VrstaPutneIspraveOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaPutneIsprave>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaPutneIsprave>.HasLanguageTable = true;
            EntityMeta<VrstaPutneIsprave>.TableSchema = @"Turist";
            EntityMeta<VrstaPutneIsprave>.TableName = @"VrstaPutneIsprave";
            EntityMeta<VrstaPutneIsprave>.LanguageTableSchema = @"Turist";
            EntityMeta<VrstaPutneIsprave>.LanguageTableName = @"VrstaPutneIsprave_jezik";
        }
        #endregion

        #region Columns
        public string VrstaPutneIspraveVrstaPutneIsprave { get; set; }
        public bool? VrstaPutneIspraveAktivnost { get; set; }
        public string VrstaPutneIspraveJezik { get; private set; }
        public string VrstaPutneIspraveNaziv { get; set; }
        public string VrstaPutneIspraveOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaPutneIsprave>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaPutneIsprave>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaPutneIsprave>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaPutneIsprave>(columnName, queryOp, value);
        }
		public static async Task<VrstaPutneIsprave> GetByPrimaryKeyAsync(string VrstaPutneIspraveVrstaPutneIsprave)
        {
            return await GetByPrimaryKeyAsync<VrstaPutneIsprave>(VrstaPutneIspraveVrstaPutneIsprave);
        }
		public static async Task<VrstaPutneIsprave> TryGetByPrimaryKeyAsync(string VrstaPutneIspraveVrstaPutneIsprave)
        {
            return await TryGetByPrimaryKeyAsync<VrstaPutneIsprave>(VrstaPutneIspraveVrstaPutneIsprave);
        }
		#endregion
    }
}