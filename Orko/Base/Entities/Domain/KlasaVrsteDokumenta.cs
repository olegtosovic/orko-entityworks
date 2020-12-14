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
    /// KlasaVrsteDokumenta entity.
    /// </summary>
    public sealed partial class KlasaVrsteDokumenta : Entity
    {
		#region Members
		private VrstaProtokola m_VrstaProtokola;
        #endregion
        
		#region Constructors
        static KlasaVrsteDokumenta()
        {
            // Cache field metadata.
            EntityMeta<KlasaVrsteDokumenta>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(KlasaVrsteDokumentaKlasaVrsteDokumenta), @"KlasaVrsteDokumentaKlasaVrsteDokumenta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KlasaVrsteDokumentaVrstaProtokola), @"KlasaVrsteDokumentaVrstaProtokola", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(KlasaVrsteDokumentaUradio), @"KlasaVrsteDokumentaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KlasaVrsteDokumentaDatumIzmjene), @"KlasaVrsteDokumentaDatumIzmjene", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(KlasaVrsteDokumentaJezik), @"KlasaVrsteDokumentaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(KlasaVrsteDokumentaNaziv), @"KlasaVrsteDokumentaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(KlasaVrsteDokumentaOpis), @"KlasaVrsteDokumentaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<KlasaVrsteDokumenta>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(VrstaProtokola), nameof(KlasaVrsteDokumentaVrstaProtokola), nameof(Orko.Base.VrstaProtokola.VrstaProtokolaVrstaProtokola))
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
		public VrstaProtokola VrstaProtokola
        {
            get { return EntityContext<VrstaProtokola>.Get(ref m_VrstaProtokola, this, nameof(VrstaProtokola)); }
            set { EntityContext<VrstaProtokola>.Set(ref m_VrstaProtokola, this, value, nameof(VrstaProtokola)); }
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
    }
}