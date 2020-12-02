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

namespace Orko.Base
{
    /// <summary>
    /// KlasaVrsteDokumenta entity.
    /// </summary>
    public sealed partial class KlasaVrsteDokumenta : Entity
    {
		#region Members
		private VrstaProtokola m_FK_KlasaVrsteDokumenta_VrstaProtokola;
        #endregion
        
		#region Constructors
        static KlasaVrsteDokumenta()
        {
            // Cache field metadata.
            EntityMeta<KlasaVrsteDokumenta>.LoadColumnMetadata
			(
				new ColumnMetadata("KlasaVrsteDokumentaKlasaVrsteDokumenta", @"KlasaVrsteDokumentaKlasaVrsteDokumenta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("KlasaVrsteDokumentaVrstaProtokola", @"KlasaVrsteDokumentaVrstaProtokola", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("KlasaVrsteDokumentaUradio", @"KlasaVrsteDokumentaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("KlasaVrsteDokumentaDatumIzmjene", @"KlasaVrsteDokumentaDatumIzmjene", SqlDbType.DateTime, isRequired: true),
                new ColumnMetadata("KlasaVrsteDokumentaJezik", @"KlasaVrsteDokumentaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("KlasaVrsteDokumentaNaziv", @"KlasaVrsteDokumentaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("KlasaVrsteDokumentaOpis", @"KlasaVrsteDokumentaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<KlasaVrsteDokumenta>.LoadRelationMetadata
			(
				new RelationMetadata("FK_KlasaVrsteDokumenta_VrstaProtokola", "KlasaVrsteDokumentaVrstaProtokola", "VrstaProtokolaVrstaProtokola")
			);

			// Cache table metadata.
			EntityMeta<KlasaVrsteDokumenta>.HasLanguageTable = true;
            EntityMeta<KlasaVrsteDokumenta>.TableSchema = @"Base";
            EntityMeta<KlasaVrsteDokumenta>.TableName = @"KlasaVrsteDokumenta";
            EntityMeta<KlasaVrsteDokumenta>.LanguageTableSchema = @"Base";
            EntityMeta<KlasaVrsteDokumenta>.LanguageTableName = @"KlasaVrsteDokumenta_jezik";
        }
        #endregion

        #region Columns
        public string KlasaVrsteDokumentaKlasaVrsteDokumenta { get; set; }
        public string KlasaVrsteDokumentaVrstaProtokola { get; set; }
        public string KlasaVrsteDokumentaUradio { get; set; }
        public DateTime? KlasaVrsteDokumentaDatumIzmjene { get; set; }
        public string KlasaVrsteDokumentaJezik { get; private set; }
        public string KlasaVrsteDokumentaNaziv { get; set; }
        public string KlasaVrsteDokumentaOpis { get; set; }
        #endregion

        #region Entities
		public VrstaProtokola FK_KlasaVrsteDokumenta_VrstaProtokola
        {
            get { return EntityContext<VrstaProtokola>.Get(ref m_FK_KlasaVrsteDokumenta_VrstaProtokola, this, "FK_KlasaVrsteDokumenta_VrstaProtokola"); }
            set { EntityContext<VrstaProtokola>.Set(ref m_FK_KlasaVrsteDokumenta_VrstaProtokola, this, value, "FK_KlasaVrsteDokumenta_VrstaProtokola"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<KlasaVrsteDokumenta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<KlasaVrsteDokumenta>(queryConditions);
        }
        public static async Task<IEnumerable<KlasaVrsteDokumenta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<KlasaVrsteDokumenta>(columnName, queryOp, value);
        }
		public static async Task<KlasaVrsteDokumenta> GetByPrimaryKeyAsync(string KlasaVrsteDokumentaKlasaVrsteDokumenta)
        {
            return await GetByPrimaryKeyAsync<KlasaVrsteDokumenta>(KlasaVrsteDokumentaKlasaVrsteDokumenta);
        }
		public static async Task<KlasaVrsteDokumenta> TryGetByPrimaryKeyAsync(string KlasaVrsteDokumentaKlasaVrsteDokumenta)
        {
            return await TryGetByPrimaryKeyAsync<KlasaVrsteDokumenta>(KlasaVrsteDokumentaKlasaVrsteDokumenta);
        }
		#endregion

        #region Public methods
		public static IEnumerable<KlasaVrsteDokumenta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<KlasaVrsteDokumenta>(queryConditions);
        }
        public static IEnumerable<KlasaVrsteDokumenta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<KlasaVrsteDokumenta>(columnName, queryOp, value);
        }
		public static KlasaVrsteDokumenta GetByPrimaryKey(string KlasaVrsteDokumentaKlasaVrsteDokumenta)
        {
            return GetByPrimaryKey<KlasaVrsteDokumenta>(KlasaVrsteDokumentaKlasaVrsteDokumenta);
        }
		public static KlasaVrsteDokumenta TryGetByPrimaryKey(string KlasaVrsteDokumentaKlasaVrsteDokumenta)
        {
            return TryGetByPrimaryKey<KlasaVrsteDokumenta>(KlasaVrsteDokumentaKlasaVrsteDokumenta);
        }
        #endregion
    }
}