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
				new ColumnMetadata("VrstaCjenikaVrstaCjenika", @"VrstaCjenikaVrstaCjenika", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaCjenikaAktivnost", @"VrstaCjenikaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaCjenikaJezik", @"VrstaCjenikaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaCjenikaNaziv", @"VrstaCjenikaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaCjenikaOpis", @"VrstaCjenikaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
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

        #region Public methods
		public static IEnumerable<VrstaCjenika> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaCjenika>(queryConditions);
        }
        public static IEnumerable<VrstaCjenika> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaCjenika>(columnName, queryOp, value);
        }
		public static VrstaCjenika GetByPrimaryKey(string VrstaCjenikaVrstaCjenika)
        {
            return GetByPrimaryKey<VrstaCjenika>(VrstaCjenikaVrstaCjenika);
        }
		public static VrstaCjenika TryGetByPrimaryKey(string VrstaCjenikaVrstaCjenika)
        {
            return TryGetByPrimaryKey<VrstaCjenika>(VrstaCjenikaVrstaCjenika);
        }
        #endregion
    }
}