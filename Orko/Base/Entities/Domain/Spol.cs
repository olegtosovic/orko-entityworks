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
    /// Spol entity.
    /// </summary>
    public sealed partial class Spol : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Spol()
        {
            // Cache field metadata.
            EntityMeta<Spol>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SpolSpol), @"SpolSpol", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(SpolJezik), @"SpolJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(SpolNaziv), @"SpolNaziv", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Spol>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Spol>.HasLanguageTable = true;
            EntityMeta<Spol>.TableSchema = @"Base";
            EntityMeta<Spol>.TableName = @"Spol";
            EntityMeta<Spol>.LanguageTableSchema = @"Base";
            EntityMeta<Spol>.LanguageTableName = @"Spol_jezik";
        }
        #endregion

        #region Columns
        public string SpolSpol { get; set; }
        public string SpolJezik { get; private set; }
        public string SpolNaziv { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Spol>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Spol>(queryConditions);
        }
        public static async Task<IEnumerable<Spol>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Spol>(columnName, queryOp, value);
        }
		public static async Task<Spol> GetByPrimaryKeyAsync(string SpolSpol)
        {
            return await GetByPrimaryKeyAsync<Spol>(SpolSpol);
        }
		public static async Task<Spol> TryGetByPrimaryKeyAsync(string SpolSpol)
        {
            return await TryGetByPrimaryKeyAsync<Spol>(SpolSpol);
        }
		#endregion
    }
}