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
    /// VrstaKabine entity.
    /// </summary>
    public sealed partial class VrstaKabine : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaKabine()
        {
            // Cache field metadata.
            EntityMeta<VrstaKabine>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaKabineVrstaKabine), @"VrstaKabineVrstaKabine", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaKabineAktivnost), @"VrstaKabineAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaKabineJezik), @"VrstaKabineJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaKabineNaziv), @"VrstaKabineNaziv", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaKabine>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaKabine>.HasLanguageTable = true;
            EntityMeta<VrstaKabine>.TableSchema = @"GuletCroatia";
            EntityMeta<VrstaKabine>.TableName = @"VrstaKabine";
            EntityMeta<VrstaKabine>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<VrstaKabine>.LanguageTableName = @"VrstaKabine_jezik";
        }
        #endregion

        #region Columns
        public string VrstaKabineVrstaKabine { get; set; }
        public bool? VrstaKabineAktivnost { get; set; }
        public string VrstaKabineJezik { get; private set; }
        public string VrstaKabineNaziv { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaKabine>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaKabine>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaKabine>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaKabine>(columnName, queryOp, value);
        }
		public static async Task<VrstaKabine> GetByPrimaryKeyAsync(string VrstaKabineVrstaKabine)
        {
            return await GetByPrimaryKeyAsync<VrstaKabine>(VrstaKabineVrstaKabine);
        }
		public static async Task<VrstaKabine> TryGetByPrimaryKeyAsync(string VrstaKabineVrstaKabine)
        {
            return await TryGetByPrimaryKeyAsync<VrstaKabine>(VrstaKabineVrstaKabine);
        }
		#endregion
    }
}