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

namespace Orko.Watersports
{
    /// <summary>
    /// VrstaBroda entity.
    /// </summary>
    public sealed partial class VrstaBroda : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaBroda()
        {
            // Cache field metadata.
            EntityMeta<VrstaBroda>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaBrodaVrstaBroda), @"VrstaBrodaVrstaBroda", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaBrodaAktivnost), @"VrstaBrodaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaBrodaJezik), @"VrstaBrodaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaBrodaNaziv), @"VrstaBrodaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaBrodaOpis), @"VrstaBrodaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaBroda>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaBroda>.HasLanguageTable = true;
            EntityMeta<VrstaBroda>.TableSchema = @"Watersports";
            EntityMeta<VrstaBroda>.TableName = @"VrstaBroda";
            EntityMeta<VrstaBroda>.LanguageTableSchema = @"Watersports";
            EntityMeta<VrstaBroda>.LanguageTableName = @"VrstaBroda_jezik";
        }
        #endregion

        #region Columns
        public string VrstaBrodaVrstaBroda { get; set; }
        public bool? VrstaBrodaAktivnost { get; set; }
        public string VrstaBrodaJezik { get; private set; }
        public string VrstaBrodaNaziv { get; set; }
        public string VrstaBrodaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaBroda>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaBroda>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaBroda>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaBroda>(columnName, queryOp, value);
        }
		public static async Task<VrstaBroda> GetByPrimaryKeyAsync(string VrstaBrodaVrstaBroda)
        {
            return await GetByPrimaryKeyAsync<VrstaBroda>(VrstaBrodaVrstaBroda);
        }
		public static async Task<VrstaBroda> TryGetByPrimaryKeyAsync(string VrstaBrodaVrstaBroda)
        {
            return await TryGetByPrimaryKeyAsync<VrstaBroda>(VrstaBrodaVrstaBroda);
        }
		#endregion
    }
}