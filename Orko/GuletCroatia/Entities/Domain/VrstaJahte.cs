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
    /// VrstaJahte entity.
    /// </summary>
    public sealed partial class VrstaJahte : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaJahte()
        {
            // Cache field metadata.
            EntityMeta<VrstaJahte>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaJahteVrstaJahte", @"VrstaJahteVrstaJahte", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaJahteAktivnost", @"VrstaJahteAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaJahteJezik", @"VrstaJahteJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaJahteNaziv", @"VrstaJahteNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaJahteOpis", @"VrstaJahteOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaJahte>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaJahte>.HasLanguageTable = true;
            EntityMeta<VrstaJahte>.TableSchema = @"GuletCroatia";
            EntityMeta<VrstaJahte>.TableName = @"VrstaJahte";
            EntityMeta<VrstaJahte>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<VrstaJahte>.LanguageTableName = @"VrstaJahte_jezik";
        }
        #endregion

        #region Columns
        public string VrstaJahteVrstaJahte { get; set; }
        public bool? VrstaJahteAktivnost { get; set; }
        public string VrstaJahteJezik { get; private set; }
        public string VrstaJahteNaziv { get; set; }
        public string VrstaJahteOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaJahte>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaJahte>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaJahte>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaJahte>(columnName, queryOp, value);
        }
		public static async Task<VrstaJahte> GetByPrimaryKeyAsync(string VrstaJahteVrstaJahte)
        {
            return await GetByPrimaryKeyAsync<VrstaJahte>(VrstaJahteVrstaJahte);
        }
		public static async Task<VrstaJahte> TryGetByPrimaryKeyAsync(string VrstaJahteVrstaJahte)
        {
            return await TryGetByPrimaryKeyAsync<VrstaJahte>(VrstaJahteVrstaJahte);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VrstaJahte> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaJahte>(queryConditions);
        }
        public static IEnumerable<VrstaJahte> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaJahte>(columnName, queryOp, value);
        }
		public static VrstaJahte GetByPrimaryKey(string VrstaJahteVrstaJahte)
        {
            return GetByPrimaryKey<VrstaJahte>(VrstaJahteVrstaJahte);
        }
		public static VrstaJahte TryGetByPrimaryKey(string VrstaJahteVrstaJahte)
        {
            return TryGetByPrimaryKey<VrstaJahte>(VrstaJahteVrstaJahte);
        }
        #endregion
    }
}