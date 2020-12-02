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
    /// Status entity.
    /// </summary>
    public sealed partial class Status : Entity
    {
		#region Members
		private VrstaDokumenta m_FK_Status_VrstaDokumenta;
        #endregion
        
		#region Constructors
        static Status()
        {
            // Cache field metadata.
            EntityMeta<Status>.LoadColumnMetadata
			(
				new ColumnMetadata("StatusStatus", @"StatusStatus", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("StatusVrstaDokumenta", @"StatusVrstaDokumenta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("StatusZakljucni", @"StatusZakljucni", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("StatusAktivnost", @"StatusAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("StatusUradio", @"StatusUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("StatusDatumIzmjene", @"StatusDatumIzmjene", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("StatusJezik", @"StatusJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("StatusNaziv", @"StatusNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Status>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Status_VrstaDokumenta", "StatusVrstaDokumenta", "VrstaDokumentaVrstaDokumenta")
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
		public VrstaDokumenta FK_Status_VrstaDokumenta
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_FK_Status_VrstaDokumenta, this, "FK_Status_VrstaDokumenta"); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_FK_Status_VrstaDokumenta, this, value, "FK_Status_VrstaDokumenta"); }
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

        #region Public methods
		public static IEnumerable<Status> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Status>(queryConditions);
        }
        public static IEnumerable<Status> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Status>(columnName, queryOp, value);
        }
		public static Status GetByPrimaryKey(int StatusStatus, string StatusVrstaDokumenta)
        {
            return GetByPrimaryKey<Status>(StatusStatus, StatusVrstaDokumenta);
        }
		public static Status TryGetByPrimaryKey(int StatusStatus, string StatusVrstaDokumenta)
        {
            return TryGetByPrimaryKey<Status>(StatusStatus, StatusVrstaDokumenta);
        }
        #endregion
    }
}