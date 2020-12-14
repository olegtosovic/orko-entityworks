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

namespace Orko.Watersports
{
    /// <summary>
    /// VrstaIzleta entity.
    /// </summary>
    public sealed partial class VrstaIzleta : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaIzleta()
        {
            // Cache field metadata.
            EntityMeta<VrstaIzleta>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaIzletaVrstaIzleta), @"VrstaIzletaVrstaIzleta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaIzletaAktivnost), @"VrstaIzletaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaIzletaJezik), @"VrstaIzletaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaIzletaNaziv), @"VrstaIzletaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaIzletaOpis), @"VrstaIzletaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaIzleta>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaIzleta>.HasLanguageTable = true;
            EntityMeta<VrstaIzleta>.TableSchema = @"Watersports";
            EntityMeta<VrstaIzleta>.TableName = @"VrstaIzleta";
            EntityMeta<VrstaIzleta>.LanguageTableSchema = @"Watersports";
            EntityMeta<VrstaIzleta>.LanguageTableName = @"VrstaIzleta_jezik";
        }
        #endregion

        #region Columns
        public string VrstaIzletaVrstaIzleta { get; set; }
        public bool? VrstaIzletaAktivnost { get; set; }
        public string VrstaIzletaJezik { get; private set; }
        public string VrstaIzletaNaziv { get; set; }
        public string VrstaIzletaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaIzleta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaIzleta>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaIzleta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaIzleta>(columnName, queryOp, value);
        }
		public static async Task<VrstaIzleta> GetByPrimaryKeyAsync(string VrstaIzletaVrstaIzleta)
        {
            return await GetByPrimaryKeyAsync<VrstaIzleta>(VrstaIzletaVrstaIzleta);
        }
		public static async Task<VrstaIzleta> TryGetByPrimaryKeyAsync(string VrstaIzletaVrstaIzleta)
        {
            return await TryGetByPrimaryKeyAsync<VrstaIzleta>(VrstaIzletaVrstaIzleta);
        }
		#endregion
    }
}