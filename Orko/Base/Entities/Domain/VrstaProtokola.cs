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
    /// VrstaProtokola entity.
    /// </summary>
    public sealed partial class VrstaProtokola : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaProtokola()
        {
            // Cache field metadata.
            EntityMeta<VrstaProtokola>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaProtokolaVrstaProtokola), @"VrstaProtokolaVrstaProtokola", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaProtokolaAktivnost), @"VrstaProtokolaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaProtokolaUradio), @"VrstaProtokolaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaProtokolaDatumIzmjene), @"VrstaProtokolaDatumIzmjene", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(VrstaProtokolaJezik), @"VrstaProtokolaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaProtokolaNaziv), @"VrstaProtokolaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaProtokolaOpis), @"VrstaProtokolaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaProtokola>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaProtokola>.HasLanguageTable = true;
            EntityMeta<VrstaProtokola>.TableSchema = @"Base";
            EntityMeta<VrstaProtokola>.TableName = @"VrstaProtokola";
            EntityMeta<VrstaProtokola>.LanguageTableSchema = @"Base";
            EntityMeta<VrstaProtokola>.LanguageTableName = @"VrstaProtokola_jezik";
        }
        #endregion

        #region Columns
        public string VrstaProtokolaVrstaProtokola { get; set; }
        public bool? VrstaProtokolaAktivnost { get; set; }
        public string VrstaProtokolaUradio { get; set; }
        public DateTime? VrstaProtokolaDatumIzmjene { get; set; }
        public string VrstaProtokolaJezik { get; private set; }
        public string VrstaProtokolaNaziv { get; set; }
        public string VrstaProtokolaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaProtokola>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaProtokola>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaProtokola>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaProtokola>(columnName, queryOp, value);
        }
		public static async Task<VrstaProtokola> GetByPrimaryKeyAsync(string VrstaProtokolaVrstaProtokola)
        {
            return await GetByPrimaryKeyAsync<VrstaProtokola>(VrstaProtokolaVrstaProtokola);
        }
		public static async Task<VrstaProtokola> TryGetByPrimaryKeyAsync(string VrstaProtokolaVrstaProtokola)
        {
            return await TryGetByPrimaryKeyAsync<VrstaProtokola>(VrstaProtokolaVrstaProtokola);
        }
		#endregion
    }
}