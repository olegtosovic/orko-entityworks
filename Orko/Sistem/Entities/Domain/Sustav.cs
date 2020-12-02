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

namespace Orko.Sistem
{
    /// <summary>
    /// Sustav entity.
    /// </summary>
    public sealed partial class Sustav : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Sustav()
        {
            // Cache field metadata.
            EntityMeta<Sustav>.LoadColumnMetadata
			(
				new ColumnMetadata("SustavSustav", @"SustavSustav", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("SustavAktivnost", @"SustavAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("SustavJezik", @"SustavJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("SustavNaziv", @"SustavNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("SustavOpis", @"SustavOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Sustav>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Sustav>.HasLanguageTable = true;
            EntityMeta<Sustav>.TableSchema = @"Sistem";
            EntityMeta<Sustav>.TableName = @"Sustav";
            EntityMeta<Sustav>.LanguageTableSchema = @"Sistem";
            EntityMeta<Sustav>.LanguageTableName = @"Sustav_jezik";
        }
        #endregion

        #region Columns
        public string SustavSustav { get; set; }
        public bool? SustavAktivnost { get; set; }
        public string SustavJezik { get; private set; }
        public string SustavNaziv { get; set; }
        public string SustavOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Sustav>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Sustav>(queryConditions);
        }
        public static async Task<IEnumerable<Sustav>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Sustav>(columnName, queryOp, value);
        }
		public static async Task<Sustav> GetByPrimaryKeyAsync(string SustavSustav)
        {
            return await GetByPrimaryKeyAsync<Sustav>(SustavSustav);
        }
		public static async Task<Sustav> TryGetByPrimaryKeyAsync(string SustavSustav)
        {
            return await TryGetByPrimaryKeyAsync<Sustav>(SustavSustav);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Sustav> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Sustav>(queryConditions);
        }
        public static IEnumerable<Sustav> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Sustav>(columnName, queryOp, value);
        }
		public static Sustav GetByPrimaryKey(string SustavSustav)
        {
            return GetByPrimaryKey<Sustav>(SustavSustav);
        }
		public static Sustav TryGetByPrimaryKey(string SustavSustav)
        {
            return TryGetByPrimaryKey<Sustav>(SustavSustav);
        }
        #endregion
    }
}