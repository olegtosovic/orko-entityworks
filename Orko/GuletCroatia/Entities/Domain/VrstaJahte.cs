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
				new ColumnMetadata(nameof(VrstaJahteVrstaJahte), @"VrstaJahteVrstaJahte", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaJahteAktivnost), @"VrstaJahteAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaJahteJezik), @"VrstaJahteJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaJahteNaziv), @"VrstaJahteNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaJahteOpis), @"VrstaJahteOpis", DbType.String, isRequired: false, isLanguage: true)
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
    }
}