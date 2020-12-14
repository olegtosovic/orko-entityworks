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
    /// VrstaUslugeStavke entity.
    /// </summary>
    public sealed partial class VrstaUslugeStavke : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaUslugeStavke()
        {
            // Cache field metadata.
            EntityMeta<VrstaUslugeStavke>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaUslugeStavkeVrstaUslugeStavke), @"VrstaUslugeStavkeVrstaUslugeStavke", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaUslugeStavkeAktivnost), @"VrstaUslugeStavkeAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaUslugeStavkeJezik), @"VrstaUslugeStavkeJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaUslugeStavkeNaziv), @"VrstaUslugeStavkeNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaUslugeStavkeOpis), @"VrstaUslugeStavkeOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaUslugeStavke>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaUslugeStavke>.HasLanguageTable = true;
            EntityMeta<VrstaUslugeStavke>.TableSchema = @"Watersports";
            EntityMeta<VrstaUslugeStavke>.TableName = @"VrstaUslugeStavke";
            EntityMeta<VrstaUslugeStavke>.LanguageTableSchema = @"Watersports";
            EntityMeta<VrstaUslugeStavke>.LanguageTableName = @"VrstaUslugeStavke_jezik";
        }
        #endregion

        #region Columns
        public string VrstaUslugeStavkeVrstaUslugeStavke { get; set; }
        public bool? VrstaUslugeStavkeAktivnost { get; set; }
        public string VrstaUslugeStavkeJezik { get; private set; }
        public string VrstaUslugeStavkeNaziv { get; set; }
        public string VrstaUslugeStavkeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaUslugeStavke>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaUslugeStavke>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaUslugeStavke>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaUslugeStavke>(columnName, queryOp, value);
        }
		public static async Task<VrstaUslugeStavke> GetByPrimaryKeyAsync(string VrstaUslugeStavkeVrstaUslugeStavke)
        {
            return await GetByPrimaryKeyAsync<VrstaUslugeStavke>(VrstaUslugeStavkeVrstaUslugeStavke);
        }
		public static async Task<VrstaUslugeStavke> TryGetByPrimaryKeyAsync(string VrstaUslugeStavkeVrstaUslugeStavke)
        {
            return await TryGetByPrimaryKeyAsync<VrstaUslugeStavke>(VrstaUslugeStavkeVrstaUslugeStavke);
        }
		#endregion
    }
}