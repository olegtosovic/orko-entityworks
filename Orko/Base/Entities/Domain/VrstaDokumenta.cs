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
    /// VrstaDokumenta entity.
    /// </summary>
    public sealed partial class VrstaDokumenta : Entity
    {
		#region Members
		private KlasaVrsteDokumenta m_FK_VrstaDokumenta_KlasaVrsteDokumenta;
        #endregion
        
		#region Constructors
        static VrstaDokumenta()
        {
            // Cache field metadata.
            EntityMeta<VrstaDokumenta>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaDokumentaVrstaDokumenta", @"VrstaDokumentaVrstaDokumenta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaDokumentaKlasaVrsteDokumenta", @"VrstaDokumentaKlasaVrsteDokumenta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("VrstaDokumentaPocetniStatus", @"VrstaDokumentaPocetniStatus", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("VrstaDokumentaAktivnost", @"VrstaDokumentaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaDokumentaUradio", @"VrstaDokumentaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("VrstaDokumentaDatumIzmjene", @"VrstaDokumentaDatumIzmjene", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("VrstaDokumentaJezik", @"VrstaDokumentaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaDokumentaNaziv", @"VrstaDokumentaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaDokumentaOpis", @"VrstaDokumentaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaDokumenta>.LoadRelationMetadata
			(
				new RelationMetadata("FK_VrstaDokumenta_KlasaVrsteDokumenta", "VrstaDokumentaKlasaVrsteDokumenta", "KlasaVrsteDokumentaKlasaVrsteDokumenta")
			);

			// Cache table metadata.
			EntityMeta<VrstaDokumenta>.HasLanguageTable = true;
            EntityMeta<VrstaDokumenta>.TableSchema = @"Base";
            EntityMeta<VrstaDokumenta>.TableName = @"VrstaDokumenta";
            EntityMeta<VrstaDokumenta>.LanguageTableSchema = @"Base";
            EntityMeta<VrstaDokumenta>.LanguageTableName = @"VrstaDokumenta_jezik";
        }
        #endregion

        #region Columns
        public string VrstaDokumentaVrstaDokumenta { get; set; }
        public string VrstaDokumentaKlasaVrsteDokumenta { get; set; }
        public int? VrstaDokumentaPocetniStatus { get; set; }
        public bool? VrstaDokumentaAktivnost { get; set; }
        public string VrstaDokumentaUradio { get; set; }
        public DateTime? VrstaDokumentaDatumIzmjene { get; set; }
        public string VrstaDokumentaJezik { get; private set; }
        public string VrstaDokumentaNaziv { get; set; }
        public string VrstaDokumentaOpis { get; set; }
        #endregion

        #region Entities
		public KlasaVrsteDokumenta FK_VrstaDokumenta_KlasaVrsteDokumenta
        {
            get { return EntityContext<KlasaVrsteDokumenta>.Get(ref m_FK_VrstaDokumenta_KlasaVrsteDokumenta, this, "FK_VrstaDokumenta_KlasaVrsteDokumenta"); }
            set { EntityContext<KlasaVrsteDokumenta>.Set(ref m_FK_VrstaDokumenta_KlasaVrsteDokumenta, this, value, "FK_VrstaDokumenta_KlasaVrsteDokumenta"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaDokumenta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaDokumenta>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaDokumenta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaDokumenta>(columnName, queryOp, value);
        }
		public static async Task<VrstaDokumenta> GetByPrimaryKeyAsync(string VrstaDokumentaVrstaDokumenta)
        {
            return await GetByPrimaryKeyAsync<VrstaDokumenta>(VrstaDokumentaVrstaDokumenta);
        }
		public static async Task<VrstaDokumenta> TryGetByPrimaryKeyAsync(string VrstaDokumentaVrstaDokumenta)
        {
            return await TryGetByPrimaryKeyAsync<VrstaDokumenta>(VrstaDokumentaVrstaDokumenta);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VrstaDokumenta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaDokumenta>(queryConditions);
        }
        public static IEnumerable<VrstaDokumenta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaDokumenta>(columnName, queryOp, value);
        }
		public static VrstaDokumenta GetByPrimaryKey(string VrstaDokumentaVrstaDokumenta)
        {
            return GetByPrimaryKey<VrstaDokumenta>(VrstaDokumentaVrstaDokumenta);
        }
		public static VrstaDokumenta TryGetByPrimaryKey(string VrstaDokumentaVrstaDokumenta)
        {
            return TryGetByPrimaryKey<VrstaDokumenta>(VrstaDokumentaVrstaDokumenta);
        }
        #endregion
    }
}