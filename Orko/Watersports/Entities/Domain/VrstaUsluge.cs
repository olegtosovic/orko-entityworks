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
    /// VrstaUsluge entity.
    /// </summary>
    public sealed partial class VrstaUsluge : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaUsluge()
        {
            // Cache field metadata.
            EntityMeta<VrstaUsluge>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaUslugeVrstaUsluge", @"VrstaUslugeVrstaUsluge", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaUslugeAktivnost", @"VrstaUslugeAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaUslugeJezik", @"VrstaUslugeJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaUslugeNaziv", @"VrstaUslugeNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaUslugeOpis", @"VrstaUslugeOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaUsluge>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaUsluge>.HasLanguageTable = true;
            EntityMeta<VrstaUsluge>.TableSchema = @"Watersports";
            EntityMeta<VrstaUsluge>.TableName = @"VrstaUsluge";
            EntityMeta<VrstaUsluge>.LanguageTableSchema = @"Watersports";
            EntityMeta<VrstaUsluge>.LanguageTableName = @"VrstaUsluge_jezik";
        }
        #endregion

        #region Columns
        public string VrstaUslugeVrstaUsluge { get; set; }
        public bool? VrstaUslugeAktivnost { get; set; }
        public string VrstaUslugeJezik { get; private set; }
        public string VrstaUslugeNaziv { get; set; }
        public string VrstaUslugeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaUsluge>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaUsluge>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaUsluge>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaUsluge>(columnName, queryOp, value);
        }
		public static async Task<VrstaUsluge> GetByPrimaryKeyAsync(string VrstaUslugeVrstaUsluge)
        {
            return await GetByPrimaryKeyAsync<VrstaUsluge>(VrstaUslugeVrstaUsluge);
        }
		public static async Task<VrstaUsluge> TryGetByPrimaryKeyAsync(string VrstaUslugeVrstaUsluge)
        {
            return await TryGetByPrimaryKeyAsync<VrstaUsluge>(VrstaUslugeVrstaUsluge);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VrstaUsluge> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaUsluge>(queryConditions);
        }
        public static IEnumerable<VrstaUsluge> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaUsluge>(columnName, queryOp, value);
        }
		public static VrstaUsluge GetByPrimaryKey(string VrstaUslugeVrstaUsluge)
        {
            return GetByPrimaryKey<VrstaUsluge>(VrstaUslugeVrstaUsluge);
        }
		public static VrstaUsluge TryGetByPrimaryKey(string VrstaUslugeVrstaUsluge)
        {
            return TryGetByPrimaryKey<VrstaUsluge>(VrstaUslugeVrstaUsluge);
        }
        #endregion
    }
}