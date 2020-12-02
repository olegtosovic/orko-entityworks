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

namespace Orko.Watersports
{
    /// <summary>
    /// UslugaStavke entity.
    /// </summary>
    public sealed partial class UslugaStavke : Entity
    {
		#region Members
		private VrstaUslugeStavke m_FK_UslugaStavke_VrstaUslugeStavke;
        #endregion
        
		#region Constructors
        static UslugaStavke()
        {
            // Cache field metadata.
            EntityMeta<UslugaStavke>.LoadColumnMetadata
			(
				new ColumnMetadata("UslugaStavkeUslugaStavke", @"UslugaStavkeUslugaStavke", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("UslugaStavkeVrstaUslugeStavke", @"UslugaStavkeVrstaUslugeStavke", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("UslugaStavkeAktivnost", @"UslugaStavkeAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("UslugaStavkeJezik", @"UslugaStavkeJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("UslugaStavkeNaziv", @"UslugaStavkeNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("UslugaStavkeOpis", @"UslugaStavkeOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<UslugaStavke>.LoadRelationMetadata
			(
				new RelationMetadata("FK_UslugaStavke_VrstaUslugeStavke", "UslugaStavkeVrstaUslugeStavke", "VrstaUslugeStavkeVrstaUslugeStavke")
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
		public VrstaUslugeStavke FK_UslugaStavke_VrstaUslugeStavke
        {
            get { return EntityContext<VrstaUslugeStavke>.Get(ref m_FK_UslugaStavke_VrstaUslugeStavke, this, "FK_UslugaStavke_VrstaUslugeStavke"); }
            set { EntityContext<VrstaUslugeStavke>.Set(ref m_FK_UslugaStavke_VrstaUslugeStavke, this, value, "FK_UslugaStavke_VrstaUslugeStavke"); }
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

        #region Public methods
		public static IEnumerable<UslugaStavke> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<UslugaStavke>(queryConditions);
        }
        public static IEnumerable<UslugaStavke> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<UslugaStavke>(columnName, queryOp, value);
        }
		public static UslugaStavke GetByPrimaryKey(string UslugaStavkeUslugaStavke)
        {
            return GetByPrimaryKey<UslugaStavke>(UslugaStavkeUslugaStavke);
        }
		public static UslugaStavke TryGetByPrimaryKey(string UslugaStavkeUslugaStavke)
        {
            return TryGetByPrimaryKey<UslugaStavke>(UslugaStavkeUslugaStavke);
        }
        #endregion
    }
}