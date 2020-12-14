// Generated on 12/14/2020 9:29 PM using EntityWorks code generation tool.
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
				new ColumnMetadata(nameof(VrstaLicenceVrstaLicence), @"VrstaLicenceVrstaLicence", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaLicenceBrojJedinica), @"VrstaLicenceBrojJedinica", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(VrstaLicenceJezik), @"VrstaLicenceJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaLicenceNaziv), @"VrstaLicenceNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaLicenceOpis), @"VrstaLicenceOpis", DbType.String, isRequired: false, isLanguage: true)
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
    }
}