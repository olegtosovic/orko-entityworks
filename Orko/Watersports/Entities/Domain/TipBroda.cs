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
    /// TipBroda entity.
    /// </summary>
    public sealed partial class TipBroda : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TipBroda()
        {
            // Cache field metadata.
            EntityMeta<TipBroda>.LoadColumnMetadata
			(
				new ColumnMetadata("TipBrodaTipBroda", @"TipBrodaTipBroda", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("TipBrodaAktivnost", @"TipBrodaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("TipBrodaJezik", @"TipBrodaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("TipBrodaNaziv", @"TipBrodaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("TipBrodaOpis", @"TipBrodaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<TipBroda>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TipBroda>.HasLanguageTable = true;
            EntityMeta<TipBroda>.TableSchema = @"Watersports";
            EntityMeta<TipBroda>.TableName = @"TipBroda";
            EntityMeta<TipBroda>.LanguageTableSchema = @"Watersports";
            EntityMeta<TipBroda>.LanguageTableName = @"TipBroda_jezik";
        }
        #endregion

        #region Columns
        public string TipBrodaTipBroda { get; set; }
        public bool? TipBrodaAktivnost { get; set; }
        public string TipBrodaJezik { get; private set; }
        public string TipBrodaNaziv { get; set; }
        public string TipBrodaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TipBroda>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TipBroda>(queryConditions);
        }
        public static async Task<IEnumerable<TipBroda>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TipBroda>(columnName, queryOp, value);
        }
		public static async Task<TipBroda> GetByPrimaryKeyAsync(string TipBrodaTipBroda)
        {
            return await GetByPrimaryKeyAsync<TipBroda>(TipBrodaTipBroda);
        }
		public static async Task<TipBroda> TryGetByPrimaryKeyAsync(string TipBrodaTipBroda)
        {
            return await TryGetByPrimaryKeyAsync<TipBroda>(TipBrodaTipBroda);
        }
		#endregion

        #region Public methods
		public static IEnumerable<TipBroda> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<TipBroda>(queryConditions);
        }
        public static IEnumerable<TipBroda> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<TipBroda>(columnName, queryOp, value);
        }
		public static TipBroda GetByPrimaryKey(string TipBrodaTipBroda)
        {
            return GetByPrimaryKey<TipBroda>(TipBrodaTipBroda);
        }
		public static TipBroda TryGetByPrimaryKey(string TipBrodaTipBroda)
        {
            return TryGetByPrimaryKey<TipBroda>(TipBrodaTipBroda);
        }
        #endregion
    }
}