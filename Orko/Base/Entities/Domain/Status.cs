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
    /// Status entity.
    /// </summary>
    public sealed partial class Status : Entity
    {
		#region Members
		private VrstaDokumenta m_VrstaDokumenta;
        #endregion
        
		#region Constructors
        static Status()
        {
            // Cache field metadata.
            EntityMeta<Status>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(StatusStatus), @"StatusStatus", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(StatusVrstaDokumenta), @"StatusVrstaDokumenta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(StatusZakljucni), @"StatusZakljucni", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(StatusAktivnost), @"StatusAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(StatusUradio), @"StatusUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(StatusDatumIzmjene), @"StatusDatumIzmjene", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(StatusJezik), @"StatusJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(StatusNaziv), @"StatusNaziv", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Status>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(VrstaDokumenta), nameof(StatusVrstaDokumenta), nameof(Orko.Base.VrstaDokumenta.VrstaDokumentaVrstaDokumenta))
			);

			// Cache table metadata.
			EntityMeta<Status>.HasLanguageTable = true;
            EntityMeta<Status>.TableSchema = @"Base";
            EntityMeta<Status>.TableName = @"Status";
            EntityMeta<Status>.LanguageTableSchema = @"Base";
            EntityMeta<Status>.LanguageTableName = @"Status_jezik";
        }
        #endregion

        #region Columns
        public int? StatusStatus { get; set; }
        public string StatusVrstaDokumenta { get; set; }
        public bool? StatusZakljucni { get; set; }
        public bool? StatusAktivnost { get; set; }
        public string StatusUradio { get; set; }
        public DateTime? StatusDatumIzmjene { get; set; }
        public string StatusJezik { get; private set; }
        public string StatusNaziv { get; set; }
        #endregion

        #region Entities
		public VrstaDokumenta VrstaDokumenta
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_VrstaDokumenta, this, nameof(VrstaDokumenta)); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_VrstaDokumenta, this, value, nameof(VrstaDokumenta)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Status>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Status>(queryConditions);
        }
        public static async Task<IEnumerable<Status>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Status>(columnName, queryOp, value);
        }
		public static async Task<Status> GetByPrimaryKeyAsync(int StatusStatus, string StatusVrstaDokumenta)
        {
            return await GetByPrimaryKeyAsync<Status>(StatusStatus, StatusVrstaDokumenta);
        }
		public static async Task<Status> TryGetByPrimaryKeyAsync(int StatusStatus, string StatusVrstaDokumenta)
        {
            return await TryGetByPrimaryKeyAsync<Status>(StatusStatus, StatusVrstaDokumenta);
        }
		#endregion
    }
}