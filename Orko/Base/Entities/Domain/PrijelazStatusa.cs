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
    /// PrijelazStatusa entity.
    /// </summary>
    public sealed partial class PrijelazStatusa : Entity
    {
		#region Members
		private Status m_PocetniStatus;
        private VrstaDokumenta m_VrstaDokumenta;
        private Status m_ZavrsniStatus;
        #endregion
        
		#region Constructors
        static PrijelazStatusa()
        {
            // Cache field metadata.
            EntityMeta<PrijelazStatusa>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(PrijelazStatusaID), @"PrijelazStatusaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaVrstaDokumenta), @"PrijelazStatusaVrstaDokumenta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaStatusPocetni), @"PrijelazStatusaStatusPocetni", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaStatusZavrsni), @"PrijelazStatusaStatusZavrsni", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaSamoSistemski), @"PrijelazStatusaSamoSistemski", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaAktivnost), @"PrijelazStatusaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaUradio), @"PrijelazStatusaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaDatumIzmjene), @"PrijelazStatusaDatumIzmjene", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(PrijelazStatusaJezik), @"PrijelazStatusaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(PrijelazStatusaOpis), @"PrijelazStatusaOpis", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<PrijelazStatusa>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(PocetniStatus), nameof(PrijelazStatusaStatusPocetni), nameof(Orko.Base.Status.StatusStatus)),
                new RelationMetadata(nameof(PocetniStatus), nameof(PrijelazStatusaVrstaDokumenta), nameof(Orko.Base.Status.StatusVrstaDokumenta)),
                new RelationMetadata(nameof(VrstaDokumenta), nameof(PrijelazStatusaVrstaDokumenta), nameof(Orko.Base.VrstaDokumenta.VrstaDokumentaVrstaDokumenta)),
                new RelationMetadata(nameof(ZavrsniStatus), nameof(PrijelazStatusaStatusZavrsni), nameof(Orko.Base.Status.StatusStatus)),
                new RelationMetadata(nameof(ZavrsniStatus), nameof(PrijelazStatusaVrstaDokumenta), nameof(Orko.Base.Status.StatusVrstaDokumenta))
			);

			// Cache table metadata.
			EntityMeta<PrijelazStatusa>.HasLanguageTable = true;
            EntityMeta<PrijelazStatusa>.TableSchema = @"Base";
            EntityMeta<PrijelazStatusa>.TableName = @"PrijelazStatusa";
            EntityMeta<PrijelazStatusa>.LanguageTableSchema = @"Base";
            EntityMeta<PrijelazStatusa>.LanguageTableName = @"PrijelazStatusa_jezik";
        }
        #endregion

        #region Columns
        public int? PrijelazStatusaID { get; private set; }
        public string PrijelazStatusaVrstaDokumenta { get; set; }
        public int? PrijelazStatusaStatusPocetni { get; set; }
        public int? PrijelazStatusaStatusZavrsni { get; set; }
        public bool? PrijelazStatusaSamoSistemski { get; set; }
        public bool? PrijelazStatusaAktivnost { get; set; }
        public string PrijelazStatusaUradio { get; set; }
        public DateTime? PrijelazStatusaDatumIzmjene { get; set; }
        public string PrijelazStatusaJezik { get; private set; }
        public string PrijelazStatusaOpis { get; set; }
        #endregion

        #region Entities
		public Status PocetniStatus
        {
            get { return EntityContext<Status>.Get(ref m_PocetniStatus, this, nameof(PocetniStatus)); }
            set { EntityContext<Status>.Set(ref m_PocetniStatus, this, value, nameof(PocetniStatus)); }
        }
        public VrstaDokumenta VrstaDokumenta
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_VrstaDokumenta, this, nameof(VrstaDokumenta)); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_VrstaDokumenta, this, value, nameof(VrstaDokumenta)); }
        }
        public Status ZavrsniStatus
        {
            get { return EntityContext<Status>.Get(ref m_ZavrsniStatus, this, nameof(ZavrsniStatus)); }
            set { EntityContext<Status>.Set(ref m_ZavrsniStatus, this, value, nameof(ZavrsniStatus)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<PrijelazStatusa>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PrijelazStatusa>(queryConditions);
        }
        public static async Task<IEnumerable<PrijelazStatusa>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PrijelazStatusa>(columnName, queryOp, value);
        }
		public static async Task<PrijelazStatusa> GetByPrimaryKeyAsync(int PrijelazStatusaID)
        {
            return await GetByPrimaryKeyAsync<PrijelazStatusa>(PrijelazStatusaID);
        }
		public static async Task<PrijelazStatusa> TryGetByPrimaryKeyAsync(int PrijelazStatusaID)
        {
            return await TryGetByPrimaryKeyAsync<PrijelazStatusa>(PrijelazStatusaID);
        }
		#endregion
    }
}