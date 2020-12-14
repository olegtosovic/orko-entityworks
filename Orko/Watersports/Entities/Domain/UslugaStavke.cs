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
    /// UslugaStavke entity.
    /// </summary>
    public sealed partial class UslugaStavke : Entity
    {
		#region Members
		private VrstaUslugeStavke m_VrstaUslugeStavke;
        #endregion
        
		#region Constructors
        static UslugaStavke()
        {
            // Cache field metadata.
            EntityMeta<UslugaStavke>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(UslugaStavkeUslugaStavke), @"UslugaStavkeUslugaStavke", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(UslugaStavkeVrstaUslugeStavke), @"UslugaStavkeVrstaUslugeStavke", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(UslugaStavkeAktivnost), @"UslugaStavkeAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(UslugaStavkeJezik), @"UslugaStavkeJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(UslugaStavkeNaziv), @"UslugaStavkeNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(UslugaStavkeOpis), @"UslugaStavkeOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<UslugaStavke>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(VrstaUslugeStavke), nameof(UslugaStavkeVrstaUslugeStavke), nameof(Orko.Watersports.VrstaUslugeStavke.VrstaUslugeStavkeVrstaUslugeStavke))
			);

			// Cache table metadata.
			EntityMeta<UslugaStavke>.HasLanguageTable = true;
            EntityMeta<UslugaStavke>.TableSchema = @"Watersports";
            EntityMeta<UslugaStavke>.TableName = @"UslugaStavke";
            EntityMeta<UslugaStavke>.LanguageTableSchema = @"Watersports";
            EntityMeta<UslugaStavke>.LanguageTableName = @"UslugaStavke_jezik";
        }
        #endregion

        #region Columns
        public string UslugaStavkeUslugaStavke { get; set; }
        public string UslugaStavkeVrstaUslugeStavke { get; set; }
        public bool? UslugaStavkeAktivnost { get; set; }
        public string UslugaStavkeJezik { get; private set; }
        public string UslugaStavkeNaziv { get; set; }
        public string UslugaStavkeOpis { get; set; }
        #endregion

        #region Entities
		public VrstaUslugeStavke VrstaUslugeStavke
        {
            get { return EntityContext<VrstaUslugeStavke>.Get(ref m_VrstaUslugeStavke, this, nameof(VrstaUslugeStavke)); }
            set { EntityContext<VrstaUslugeStavke>.Set(ref m_VrstaUslugeStavke, this, value, nameof(VrstaUslugeStavke)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<UslugaStavke>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<UslugaStavke>(queryConditions);
        }
        public static async Task<IEnumerable<UslugaStavke>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<UslugaStavke>(columnName, queryOp, value);
        }
		public static async Task<UslugaStavke> GetByPrimaryKeyAsync(string UslugaStavkeUslugaStavke)
        {
            return await GetByPrimaryKeyAsync<UslugaStavke>(UslugaStavkeUslugaStavke);
        }
		public static async Task<UslugaStavke> TryGetByPrimaryKeyAsync(string UslugaStavkeUslugaStavke)
        {
            return await TryGetByPrimaryKeyAsync<UslugaStavke>(UslugaStavkeUslugaStavke);
        }
		#endregion
    }
}