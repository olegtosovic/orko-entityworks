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
    /// TipRezervacije entity.
    /// </summary>
    public sealed partial class TipRezervacije : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TipRezervacije()
        {
            // Cache field metadata.
            EntityMeta<TipRezervacije>.LoadColumnMetadata
			(
				new ColumnMetadata("TipRezervacijeTipRezervacije", @"TipRezervacijeTipRezervacije", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("TipRezervacijeAktivnost", @"TipRezervacijeAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("TipRezervacijeJezik", @"TipRezervacijeJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("TipRezervacijeNaziv", @"TipRezervacijeNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("TipRezervacijeOpis", @"TipRezervacijeOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<TipRezervacije>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TipRezervacije>.HasLanguageTable = true;
            EntityMeta<TipRezervacije>.TableSchema = @"Watersports";
            EntityMeta<TipRezervacije>.TableName = @"TipRezervacije";
            EntityMeta<TipRezervacije>.LanguageTableSchema = @"Watersports";
            EntityMeta<TipRezervacije>.LanguageTableName = @"TipRezervacije_jezik";
        }
        #endregion

        #region Columns
        public string TipRezervacijeTipRezervacije { get; set; }
        public bool? TipRezervacijeAktivnost { get; set; }
        public string TipRezervacijeJezik { get; private set; }
        public string TipRezervacijeNaziv { get; set; }
        public string TipRezervacijeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TipRezervacije>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TipRezervacije>(queryConditions);
        }
        public static async Task<IEnumerable<TipRezervacije>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TipRezervacije>(columnName, queryOp, value);
        }
		public static async Task<TipRezervacije> GetByPrimaryKeyAsync(string TipRezervacijeTipRezervacije)
        {
            return await GetByPrimaryKeyAsync<TipRezervacije>(TipRezervacijeTipRezervacije);
        }
		public static async Task<TipRezervacije> TryGetByPrimaryKeyAsync(string TipRezervacijeTipRezervacije)
        {
            return await TryGetByPrimaryKeyAsync<TipRezervacije>(TipRezervacijeTipRezervacije);
        }
		#endregion

        #region Public methods
		public static IEnumerable<TipRezervacije> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<TipRezervacije>(queryConditions);
        }
        public static IEnumerable<TipRezervacije> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<TipRezervacije>(columnName, queryOp, value);
        }
		public static TipRezervacije GetByPrimaryKey(string TipRezervacijeTipRezervacije)
        {
            return GetByPrimaryKey<TipRezervacije>(TipRezervacijeTipRezervacije);
        }
		public static TipRezervacije TryGetByPrimaryKey(string TipRezervacijeTipRezervacije)
        {
            return TryGetByPrimaryKey<TipRezervacije>(TipRezervacijeTipRezervacije);
        }
        #endregion
    }
}