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

namespace Orko.SebastianArt
{
    /// <summary>
    /// VrstaArtikla entity.
    /// </summary>
    public sealed partial class VrstaArtikla : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaArtikla()
        {
            // Cache field metadata.
            EntityMeta<VrstaArtikla>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaArtiklaVrstaArtikla), @"VrstaArtiklaVrstaArtikla", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaArtiklaPostojiKolicina), @"VrstaArtiklaPostojiKolicina", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaArtiklaAktivnost), @"VrstaArtiklaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaArtiklaJezik), @"VrstaArtiklaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaArtiklaNaziv), @"VrstaArtiklaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaArtiklaOpis), @"VrstaArtiklaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaArtikla>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaArtikla>.HasLanguageTable = true;
            EntityMeta<VrstaArtikla>.TableSchema = @"SebastianArt";
            EntityMeta<VrstaArtikla>.TableName = @"VrstaArtikla";
            EntityMeta<VrstaArtikla>.LanguageTableSchema = @"SebastianArt";
            EntityMeta<VrstaArtikla>.LanguageTableName = @"VrstaArtikla_jezik";
        }
        #endregion

        #region Columns
        public string VrstaArtiklaVrstaArtikla { get; set; }
        public bool? VrstaArtiklaPostojiKolicina { get; set; }
        public bool? VrstaArtiklaAktivnost { get; set; }
        public string VrstaArtiklaJezik { get; private set; }
        public string VrstaArtiklaNaziv { get; set; }
        public string VrstaArtiklaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaArtikla>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaArtikla>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaArtikla>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaArtikla>(columnName, queryOp, value);
        }
		public static async Task<VrstaArtikla> GetByPrimaryKeyAsync(string VrstaArtiklaVrstaArtikla)
        {
            return await GetByPrimaryKeyAsync<VrstaArtikla>(VrstaArtiklaVrstaArtikla);
        }
		public static async Task<VrstaArtikla> TryGetByPrimaryKeyAsync(string VrstaArtiklaVrstaArtikla)
        {
            return await TryGetByPrimaryKeyAsync<VrstaArtikla>(VrstaArtiklaVrstaArtikla);
        }
		#endregion
    }
}