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

namespace Orko.Turist
{
    /// <summary>
    /// VrstaUsluge entity.
    /// </summary>
    public sealed partial class VrstaUsluge : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaUsluge()
        {
            // Cache field metadata.
            EntityMeta<VrstaUsluge>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaUslugeVrstaUsluge), @"VrstaUslugeVrstaUsluge", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(VrstaUslugeAktivnost), @"VrstaUslugeAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaUslugeJezik), @"VrstaUslugeJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaUslugeNaziv), @"VrstaUslugeNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaUslugeOpis), @"VrstaUslugeOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaUsluge>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaUsluge>.HasLanguageTable = true;
            EntityMeta<VrstaUsluge>.TableSchema = @"Turist";
            EntityMeta<VrstaUsluge>.TableName = @"VrstaUsluge";
            EntityMeta<VrstaUsluge>.LanguageTableSchema = @"Turist";
            EntityMeta<VrstaUsluge>.LanguageTableName = @"VrstaUsluge_jezik";
        }
        #endregion

        #region Columns
        public int? VrstaUslugeVrstaUsluge { get; private set; }
        public bool? VrstaUslugeAktivnost { get; set; }
        public string VrstaUslugeJezik { get; private set; }
        public string VrstaUslugeNaziv { get; set; }
        public string VrstaUslugeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaUsluge>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaUsluge>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaUsluge>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaUsluge>(columnName, queryOp, value);
        }
		public static async Task<VrstaUsluge> GetByPrimaryKeyAsync(int VrstaUslugeVrstaUsluge)
        {
            return await GetByPrimaryKeyAsync<VrstaUsluge>(VrstaUslugeVrstaUsluge);
        }
		public static async Task<VrstaUsluge> TryGetByPrimaryKeyAsync(int VrstaUslugeVrstaUsluge)
        {
            return await TryGetByPrimaryKeyAsync<VrstaUsluge>(VrstaUslugeVrstaUsluge);
        }
		#endregion
    }
}