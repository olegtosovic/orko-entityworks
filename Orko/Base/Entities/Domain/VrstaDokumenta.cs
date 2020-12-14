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
    /// VrstaDokumenta entity.
    /// </summary>
    public sealed partial class VrstaDokumenta : Entity
    {
		#region Members
		private KlasaVrsteDokumenta m_KlasaVrsteDokumenta;
        #endregion
        
		#region Constructors
        static VrstaDokumenta()
        {
            // Cache field metadata.
            EntityMeta<VrstaDokumenta>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaDokumentaVrstaDokumenta), @"VrstaDokumentaVrstaDokumenta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaDokumentaKlasaVrsteDokumenta), @"VrstaDokumentaKlasaVrsteDokumenta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaDokumentaPocetniStatus), @"VrstaDokumentaPocetniStatus", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(VrstaDokumentaAktivnost), @"VrstaDokumentaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaDokumentaUradio), @"VrstaDokumentaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaDokumentaDatumIzmjene), @"VrstaDokumentaDatumIzmjene", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(VrstaDokumentaJezik), @"VrstaDokumentaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaDokumentaNaziv), @"VrstaDokumentaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaDokumentaOpis), @"VrstaDokumentaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaDokumenta>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(KlasaVrsteDokumenta), nameof(VrstaDokumentaKlasaVrsteDokumenta), nameof(Orko.Base.KlasaVrsteDokumenta.KlasaVrsteDokumentaKlasaVrsteDokumenta))
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
		public KlasaVrsteDokumenta KlasaVrsteDokumenta
        {
            get { return EntityContext<KlasaVrsteDokumenta>.Get(ref m_KlasaVrsteDokumenta, this, nameof(KlasaVrsteDokumenta)); }
            set { EntityContext<KlasaVrsteDokumenta>.Set(ref m_KlasaVrsteDokumenta, this, value, nameof(KlasaVrsteDokumenta)); }
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
    }
}