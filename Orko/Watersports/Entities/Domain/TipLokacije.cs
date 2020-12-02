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
    /// TipLokacije entity.
    /// </summary>
    public sealed partial class TipLokacije : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TipLokacije()
        {
            // Cache field metadata.
            EntityMeta<TipLokacije>.LoadColumnMetadata
			(
				new ColumnMetadata("TipLokacijeTipLokacije", @"TipLokacijeTipLokacije", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("TipLokacijeAktivnost", @"TipLokacijeAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("TipLokacijeJezik", @"TipLokacijeJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("TipLokacijeNaziv", @"TipLokacijeNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("TipLokacijeOpis", @"TipLokacijeOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<TipLokacije>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TipLokacije>.HasLanguageTable = true;
            EntityMeta<TipLokacije>.TableSchema = @"Watersports";
            EntityMeta<TipLokacije>.TableName = @"TipLokacije";
            EntityMeta<TipLokacije>.LanguageTableSchema = @"Watersports";
            EntityMeta<TipLokacije>.LanguageTableName = @"TipLokacije_jezik";
        }
        #endregion

        #region Columns
        public string TipLokacijeTipLokacije { get; set; }
        public bool? TipLokacijeAktivnost { get; set; }
        public string TipLokacijeJezik { get; private set; }
        public string TipLokacijeNaziv { get; set; }
        public string TipLokacijeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TipLokacije>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TipLokacije>(queryConditions);
        }
        public static async Task<IEnumerable<TipLokacije>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TipLokacije>(columnName, queryOp, value);
        }
		public static async Task<TipLokacije> GetByPrimaryKeyAsync(string TipLokacijeTipLokacije)
        {
            return await GetByPrimaryKeyAsync<TipLokacije>(TipLokacijeTipLokacije);
        }
		public static async Task<TipLokacije> TryGetByPrimaryKeyAsync(string TipLokacijeTipLokacije)
        {
            return await TryGetByPrimaryKeyAsync<TipLokacije>(TipLokacijeTipLokacije);
        }
		#endregion

        #region Public methods
		public static IEnumerable<TipLokacije> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<TipLokacije>(queryConditions);
        }
        public static IEnumerable<TipLokacije> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<TipLokacije>(columnName, queryOp, value);
        }
		public static TipLokacije GetByPrimaryKey(string TipLokacijeTipLokacije)
        {
            return GetByPrimaryKey<TipLokacije>(TipLokacijeTipLokacije);
        }
		public static TipLokacije TryGetByPrimaryKey(string TipLokacijeTipLokacije)
        {
            return TryGetByPrimaryKey<TipLokacije>(TipLokacijeTipLokacije);
        }
        #endregion
    }
}