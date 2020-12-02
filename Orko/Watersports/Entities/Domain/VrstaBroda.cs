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
				new ColumnMetadata("VrstaBrodaVrstaBroda", @"VrstaBrodaVrstaBroda", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaBrodaAktivnost", @"VrstaBrodaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaBrodaJezik", @"VrstaBrodaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaBrodaNaziv", @"VrstaBrodaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaBrodaOpis", @"VrstaBrodaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
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

        #region Public methods
		public static IEnumerable<VrstaBroda> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaBroda>(queryConditions);
        }
        public static IEnumerable<VrstaBroda> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaBroda>(columnName, queryOp, value);
        }
		public static VrstaBroda GetByPrimaryKey(string VrstaBrodaVrstaBroda)
        {
            return GetByPrimaryKey<VrstaBroda>(VrstaBrodaVrstaBroda);
        }
		public static VrstaBroda TryGetByPrimaryKey(string VrstaBrodaVrstaBroda)
        {
            return TryGetByPrimaryKey<VrstaBroda>(VrstaBrodaVrstaBroda);
        }
        #endregion
    }
}