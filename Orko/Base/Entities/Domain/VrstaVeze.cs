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

namespace Orko.Base
{
    /// <summary>
    /// VrstaVeze entity.
    /// </summary>
    public sealed partial class VrstaVeze : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaVeze()
        {
            // Cache field metadata.
            EntityMeta<VrstaVeze>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaVezeVrstaVeze", @"VrstaVezeVrstaVeze", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("VrstaVezeUradio", @"VrstaVezeUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("VrstaVezeDatumIzmjene", @"VrstaVezeDatumIzmjene", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("VrstaVezeJezik", @"VrstaVezeJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaVezeNaziv", @"VrstaVezeNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaVezeOpis", @"VrstaVezeOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaVeze>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaVeze>.HasLanguageTable = true;
            EntityMeta<VrstaVeze>.TableSchema = @"Base";
            EntityMeta<VrstaVeze>.TableName = @"VrstaVeze";
            EntityMeta<VrstaVeze>.LanguageTableSchema = @"Base";
            EntityMeta<VrstaVeze>.LanguageTableName = @"VrstaVeze_jezik";
        }
        #endregion

        #region Columns
        public int? VrstaVezeVrstaVeze { get; set; }
        public string VrstaVezeUradio { get; set; }
        public DateTime? VrstaVezeDatumIzmjene { get; set; }
        public string VrstaVezeJezik { get; private set; }
        public string VrstaVezeNaziv { get; set; }
        public string VrstaVezeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaVeze>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaVeze>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaVeze>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaVeze>(columnName, queryOp, value);
        }
		public static async Task<VrstaVeze> GetByPrimaryKeyAsync(int VrstaVezeVrstaVeze)
        {
            return await GetByPrimaryKeyAsync<VrstaVeze>(VrstaVezeVrstaVeze);
        }
		public static async Task<VrstaVeze> TryGetByPrimaryKeyAsync(int VrstaVezeVrstaVeze)
        {
            return await TryGetByPrimaryKeyAsync<VrstaVeze>(VrstaVezeVrstaVeze);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VrstaVeze> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaVeze>(queryConditions);
        }
        public static IEnumerable<VrstaVeze> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaVeze>(columnName, queryOp, value);
        }
		public static VrstaVeze GetByPrimaryKey(int VrstaVezeVrstaVeze)
        {
            return GetByPrimaryKey<VrstaVeze>(VrstaVezeVrstaVeze);
        }
		public static VrstaVeze TryGetByPrimaryKey(int VrstaVezeVrstaVeze)
        {
            return TryGetByPrimaryKey<VrstaVeze>(VrstaVezeVrstaVeze);
        }
        #endregion
    }
}