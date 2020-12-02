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

namespace Orko.GuletCroatia
{
    /// <summary>
    /// VrstaZaposlenika entity.
    /// </summary>
    public sealed partial class VrstaZaposlenika : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaZaposlenika()
        {
            // Cache field metadata.
            EntityMeta<VrstaZaposlenika>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaZaposlenikaVrstaZaposlenika", @"VrstaZaposlenikaVrstaZaposlenika", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaZaposlenikaAktivnost", @"VrstaZaposlenikaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaZaposlenikaJezik", @"VrstaZaposlenikaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaZaposlenikaNaziv", @"VrstaZaposlenikaNaziv", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("VrstaZaposlenikaOpis", @"VrstaZaposlenikaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaZaposlenika>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaZaposlenika>.HasLanguageTable = true;
            EntityMeta<VrstaZaposlenika>.TableSchema = @"GuletCroatia";
            EntityMeta<VrstaZaposlenika>.TableName = @"VrstaZaposlenika";
            EntityMeta<VrstaZaposlenika>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<VrstaZaposlenika>.LanguageTableName = @"VrstaZaposlenika_jezik";
        }
        #endregion

        #region Columns
        public string VrstaZaposlenikaVrstaZaposlenika { get; set; }
        public bool? VrstaZaposlenikaAktivnost { get; set; }
        public string VrstaZaposlenikaJezik { get; private set; }
        public string VrstaZaposlenikaNaziv { get; set; }
        public string VrstaZaposlenikaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaZaposlenika>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaZaposlenika>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaZaposlenika>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaZaposlenika>(columnName, queryOp, value);
        }
		public static async Task<VrstaZaposlenika> GetByPrimaryKeyAsync(string VrstaZaposlenikaVrstaZaposlenika)
        {
            return await GetByPrimaryKeyAsync<VrstaZaposlenika>(VrstaZaposlenikaVrstaZaposlenika);
        }
		public static async Task<VrstaZaposlenika> TryGetByPrimaryKeyAsync(string VrstaZaposlenikaVrstaZaposlenika)
        {
            return await TryGetByPrimaryKeyAsync<VrstaZaposlenika>(VrstaZaposlenikaVrstaZaposlenika);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VrstaZaposlenika> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaZaposlenika>(queryConditions);
        }
        public static IEnumerable<VrstaZaposlenika> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaZaposlenika>(columnName, queryOp, value);
        }
		public static VrstaZaposlenika GetByPrimaryKey(string VrstaZaposlenikaVrstaZaposlenika)
        {
            return GetByPrimaryKey<VrstaZaposlenika>(VrstaZaposlenikaVrstaZaposlenika);
        }
		public static VrstaZaposlenika TryGetByPrimaryKey(string VrstaZaposlenikaVrstaZaposlenika)
        {
            return TryGetByPrimaryKey<VrstaZaposlenika>(VrstaZaposlenikaVrstaZaposlenika);
        }
        #endregion
    }
}