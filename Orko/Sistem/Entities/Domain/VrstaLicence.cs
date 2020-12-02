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
    /// VrstaLicence entity.
    /// </summary>
    public sealed partial class VrstaLicence : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaLicence()
        {
            // Cache field metadata.
            EntityMeta<VrstaLicence>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaLicenceVrstaLicence", @"VrstaLicenceVrstaLicence", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaLicenceBrojJedinica", @"VrstaLicenceBrojJedinica", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("VrstaLicenceJezik", @"VrstaLicenceJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaLicenceNaziv", @"VrstaLicenceNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaLicenceOpis", @"VrstaLicenceOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaLicence>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaLicence>.HasLanguageTable = true;
            EntityMeta<VrstaLicence>.TableSchema = @"Sistem";
            EntityMeta<VrstaLicence>.TableName = @"VrstaLicence";
            EntityMeta<VrstaLicence>.LanguageTableSchema = @"Sistem";
            EntityMeta<VrstaLicence>.LanguageTableName = @"VrstaLicence_jezik";
        }
        #endregion

        #region Columns
        public string VrstaLicenceVrstaLicence { get; set; }
        public int? VrstaLicenceBrojJedinica { get; set; }
        public string VrstaLicenceJezik { get; private set; }
        public string VrstaLicenceNaziv { get; set; }
        public string VrstaLicenceOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaLicence>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaLicence>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaLicence>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaLicence>(columnName, queryOp, value);
        }
		public static async Task<VrstaLicence> GetByPrimaryKeyAsync(string VrstaLicenceVrstaLicence)
        {
            return await GetByPrimaryKeyAsync<VrstaLicence>(VrstaLicenceVrstaLicence);
        }
		public static async Task<VrstaLicence> TryGetByPrimaryKeyAsync(string VrstaLicenceVrstaLicence)
        {
            return await TryGetByPrimaryKeyAsync<VrstaLicence>(VrstaLicenceVrstaLicence);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VrstaLicence> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaLicence>(queryConditions);
        }
        public static IEnumerable<VrstaLicence> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaLicence>(columnName, queryOp, value);
        }
		public static VrstaLicence GetByPrimaryKey(string VrstaLicenceVrstaLicence)
        {
            return GetByPrimaryKey<VrstaLicence>(VrstaLicenceVrstaLicence);
        }
		public static VrstaLicence TryGetByPrimaryKey(string VrstaLicenceVrstaLicence)
        {
            return TryGetByPrimaryKey<VrstaLicence>(VrstaLicenceVrstaLicence);
        }
        #endregion
    }
}