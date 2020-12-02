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
    /// VrstaTermina entity.
    /// </summary>
    public sealed partial class VrstaTermina : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaTermina()
        {
            // Cache field metadata.
            EntityMeta<VrstaTermina>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaTerminaVrstaTermina", @"VrstaTerminaVrstaTermina", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaTerminaAktivnost", @"VrstaTerminaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaTerminaJezik", @"VrstaTerminaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaTerminaNaziv", @"VrstaTerminaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaTerminaOpis", @"VrstaTerminaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaTermina>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaTermina>.HasLanguageTable = true;
            EntityMeta<VrstaTermina>.TableSchema = @"Watersports";
            EntityMeta<VrstaTermina>.TableName = @"VrstaTermina";
            EntityMeta<VrstaTermina>.LanguageTableSchema = @"Watersports";
            EntityMeta<VrstaTermina>.LanguageTableName = @"VrstaTermina_jezik";
        }
        #endregion

        #region Columns
        public string VrstaTerminaVrstaTermina { get; set; }
        public bool? VrstaTerminaAktivnost { get; set; }
        public string VrstaTerminaJezik { get; private set; }
        public string VrstaTerminaNaziv { get; set; }
        public string VrstaTerminaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaTermina>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaTermina>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaTermina>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaTermina>(columnName, queryOp, value);
        }
		public static async Task<VrstaTermina> GetByPrimaryKeyAsync(string VrstaTerminaVrstaTermina)
        {
            return await GetByPrimaryKeyAsync<VrstaTermina>(VrstaTerminaVrstaTermina);
        }
		public static async Task<VrstaTermina> TryGetByPrimaryKeyAsync(string VrstaTerminaVrstaTermina)
        {
            return await TryGetByPrimaryKeyAsync<VrstaTermina>(VrstaTerminaVrstaTermina);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VrstaTermina> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaTermina>(queryConditions);
        }
        public static IEnumerable<VrstaTermina> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaTermina>(columnName, queryOp, value);
        }
		public static VrstaTermina GetByPrimaryKey(string VrstaTerminaVrstaTermina)
        {
            return GetByPrimaryKey<VrstaTermina>(VrstaTerminaVrstaTermina);
        }
		public static VrstaTermina TryGetByPrimaryKey(string VrstaTerminaVrstaTermina)
        {
            return TryGetByPrimaryKey<VrstaTermina>(VrstaTerminaVrstaTermina);
        }
        #endregion
    }
}