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
				new ColumnMetadata("VrstaArtiklaVrstaArtikla", @"VrstaArtiklaVrstaArtikla", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaArtiklaPostojiKolicina", @"VrstaArtiklaPostojiKolicina", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaArtiklaAktivnost", @"VrstaArtiklaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaArtiklaJezik", @"VrstaArtiklaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaArtiklaNaziv", @"VrstaArtiklaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaArtiklaOpis", @"VrstaArtiklaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
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

        #region Public methods
		public static IEnumerable<VrstaArtikla> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaArtikla>(queryConditions);
        }
        public static IEnumerable<VrstaArtikla> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaArtikla>(columnName, queryOp, value);
        }
		public static VrstaArtikla GetByPrimaryKey(string VrstaArtiklaVrstaArtikla)
        {
            return GetByPrimaryKey<VrstaArtikla>(VrstaArtiklaVrstaArtikla);
        }
		public static VrstaArtikla TryGetByPrimaryKey(string VrstaArtiklaVrstaArtikla)
        {
            return TryGetByPrimaryKey<VrstaArtikla>(VrstaArtiklaVrstaArtikla);
        }
        #endregion
    }
}