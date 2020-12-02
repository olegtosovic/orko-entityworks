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

namespace Orko.Base
{
    /// <summary>
    /// Jezik entity.
    /// </summary>
    public sealed partial class Jezik : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Jezik()
        {
            // Cache field metadata.
            EntityMeta<Jezik>.LoadColumnMetadata
			(
				new ColumnMetadata("JezikJezik", @"JezikJezik", SqlDbType.Char, isPrimaryKey: true),
                new ColumnMetadata("JezikAktivnost", @"JezikAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("JezikJezikJezik", @"JezikJezikJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("JezikNaziv", @"JezikNaziv", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Jezik>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Jezik>.HasLanguageTable = true;
            EntityMeta<Jezik>.TableSchema = @"Base";
            EntityMeta<Jezik>.TableName = @"Jezik";
            EntityMeta<Jezik>.LanguageTableSchema = @"Base";
            EntityMeta<Jezik>.LanguageTableName = @"Jezik_jezik";
        }
        #endregion

        #region Columns
        public string JezikJezik { get; set; }
        public bool? JezikAktivnost { get; set; }
        public string JezikJezikJezik { get; private set; }
        public string JezikNaziv { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Jezik>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Jezik>(queryConditions);
        }
        public static async Task<IEnumerable<Jezik>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Jezik>(columnName, queryOp, value);
        }
		public static async Task<Jezik> GetByPrimaryKeyAsync(string JezikJezik)
        {
            return await GetByPrimaryKeyAsync<Jezik>(JezikJezik);
        }
		public static async Task<Jezik> TryGetByPrimaryKeyAsync(string JezikJezik)
        {
            return await TryGetByPrimaryKeyAsync<Jezik>(JezikJezik);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Jezik> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Jezik>(queryConditions);
        }
        public static IEnumerable<Jezik> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Jezik>(columnName, queryOp, value);
        }
		public static Jezik GetByPrimaryKey(string JezikJezik)
        {
            return GetByPrimaryKey<Jezik>(JezikJezik);
        }
		public static Jezik TryGetByPrimaryKey(string JezikJezik)
        {
            return TryGetByPrimaryKey<Jezik>(JezikJezik);
        }
        #endregion
    }
}