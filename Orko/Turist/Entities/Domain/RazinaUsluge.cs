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
    /// RazinaUsluge entity.
    /// </summary>
    public sealed partial class RazinaUsluge : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static RazinaUsluge()
        {
            // Cache field metadata.
            EntityMeta<RazinaUsluge>.LoadColumnMetadata
			(
				new ColumnMetadata("RazinaUslugeRazinaUsluge", @"RazinaUslugeRazinaUsluge", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("RazinaUslugeAktivnost", @"RazinaUslugeAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("RazinaUslugeJezik", @"RazinaUslugeJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("RazinaUslugeNaziv", @"RazinaUslugeNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("RazinaUslugeOpis", @"RazinaUslugeOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<RazinaUsluge>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<RazinaUsluge>.HasLanguageTable = true;
            EntityMeta<RazinaUsluge>.TableSchema = @"Turist";
            EntityMeta<RazinaUsluge>.TableName = @"RazinaUsluge";
            EntityMeta<RazinaUsluge>.LanguageTableSchema = @"Turist";
            EntityMeta<RazinaUsluge>.LanguageTableName = @"RazinaUsluge_jezik";
        }
        #endregion

        #region Columns
        public string RazinaUslugeRazinaUsluge { get; set; }
        public bool? RazinaUslugeAktivnost { get; set; }
        public string RazinaUslugeJezik { get; private set; }
        public string RazinaUslugeNaziv { get; set; }
        public string RazinaUslugeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<RazinaUsluge>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<RazinaUsluge>(queryConditions);
        }
        public static async Task<IEnumerable<RazinaUsluge>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<RazinaUsluge>(columnName, queryOp, value);
        }
		public static async Task<RazinaUsluge> GetByPrimaryKeyAsync(string RazinaUslugeRazinaUsluge)
        {
            return await GetByPrimaryKeyAsync<RazinaUsluge>(RazinaUslugeRazinaUsluge);
        }
		public static async Task<RazinaUsluge> TryGetByPrimaryKeyAsync(string RazinaUslugeRazinaUsluge)
        {
            return await TryGetByPrimaryKeyAsync<RazinaUsluge>(RazinaUslugeRazinaUsluge);
        }
		#endregion

        #region Public methods
		public static IEnumerable<RazinaUsluge> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<RazinaUsluge>(queryConditions);
        }
        public static IEnumerable<RazinaUsluge> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<RazinaUsluge>(columnName, queryOp, value);
        }
		public static RazinaUsluge GetByPrimaryKey(string RazinaUslugeRazinaUsluge)
        {
            return GetByPrimaryKey<RazinaUsluge>(RazinaUslugeRazinaUsluge);
        }
		public static RazinaUsluge TryGetByPrimaryKey(string RazinaUslugeRazinaUsluge)
        {
            return TryGetByPrimaryKey<RazinaUsluge>(RazinaUslugeRazinaUsluge);
        }
        #endregion
    }
}