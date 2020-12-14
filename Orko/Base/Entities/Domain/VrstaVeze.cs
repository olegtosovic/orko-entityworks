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
				new ColumnMetadata(nameof(VrstaVezeVrstaVeze), @"VrstaVezeVrstaVeze", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(VrstaVezeUradio), @"VrstaVezeUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaVezeDatumIzmjene), @"VrstaVezeDatumIzmjene", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(VrstaVezeJezik), @"VrstaVezeJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaVezeNaziv), @"VrstaVezeNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaVezeOpis), @"VrstaVezeOpis", DbType.String, isRequired: false, isLanguage: true)
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
    }
}