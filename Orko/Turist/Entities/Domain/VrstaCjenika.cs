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
    /// VrstaCjenika entity.
    /// </summary>
    public sealed partial class VrstaCjenika : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaCjenika()
        {
            // Cache field metadata.
            EntityMeta<VrstaCjenika>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaCjenikaVrstaCjenika), @"VrstaCjenikaVrstaCjenika", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaCjenikaAktivnost), @"VrstaCjenikaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaCjenikaJezik), @"VrstaCjenikaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaCjenikaNaziv), @"VrstaCjenikaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaCjenikaOpis), @"VrstaCjenikaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaCjenika>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaCjenika>.HasLanguageTable = true;
            EntityMeta<VrstaCjenika>.TableSchema = @"Turist";
            EntityMeta<VrstaCjenika>.TableName = @"VrstaCjenika";
            EntityMeta<VrstaCjenika>.LanguageTableSchema = @"Turist";
            EntityMeta<VrstaCjenika>.LanguageTableName = @"VrstaCjenika_jezik";
        }
        #endregion

        #region Columns
        public string VrstaCjenikaVrstaCjenika { get; set; }
        public bool? VrstaCjenikaAktivnost { get; set; }
        public string VrstaCjenikaJezik { get; private set; }
        public string VrstaCjenikaNaziv { get; set; }
        public string VrstaCjenikaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaCjenika>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaCjenika>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaCjenika>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaCjenika>(columnName, queryOp, value);
        }
		public static async Task<VrstaCjenika> GetByPrimaryKeyAsync(string VrstaCjenikaVrstaCjenika)
        {
            return await GetByPrimaryKeyAsync<VrstaCjenika>(VrstaCjenikaVrstaCjenika);
        }
		public static async Task<VrstaCjenika> TryGetByPrimaryKeyAsync(string VrstaCjenikaVrstaCjenika)
        {
            return await TryGetByPrimaryKeyAsync<VrstaCjenika>(VrstaCjenikaVrstaCjenika);
        }
		#endregion
    }
}