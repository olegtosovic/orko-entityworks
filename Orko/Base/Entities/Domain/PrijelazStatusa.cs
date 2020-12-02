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
    /// PrijelazStatusa entity.
    /// </summary>
    public sealed partial class PrijelazStatusa : Entity
    {
		#region Members
		private Status m_FK_PrijelazStatusa_PocetniStatus;
        private VrstaDokumenta m_FK_PrijelazStatusa_VrstaDokumenta;
        private Status m_FK_PrijelazStatusa_ZavrsniStatus;
        #endregion
        
		#region Constructors
        static PrijelazStatusa()
        {
            // Cache field metadata.
            EntityMeta<PrijelazStatusa>.LoadColumnMetadata
			(
				new ColumnMetadata("PrijelazStatusaID", @"PrijelazStatusaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("PrijelazStatusaVrstaDokumenta", @"PrijelazStatusaVrstaDokumenta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("PrijelazStatusaStatusPocetni", @"PrijelazStatusaStatusPocetni", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("PrijelazStatusaStatusZavrsni", @"PrijelazStatusaStatusZavrsni", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("PrijelazStatusaSamoSistemski", @"PrijelazStatusaSamoSistemski", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("PrijelazStatusaAktivnost", @"PrijelazStatusaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("PrijelazStatusaUradio", @"PrijelazStatusaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("PrijelazStatusaDatumIzmjene", @"PrijelazStatusaDatumIzmjene", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("PrijelazStatusaJezik", @"PrijelazStatusaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("PrijelazStatusaOpis", @"PrijelazStatusaOpis", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<PrijelazStatusa>.LoadRelationMetadata
			(
				new RelationMetadata("FK_PrijelazStatusa_PocetniStatus", "PrijelazStatusaStatusPocetni", "StatusStatus"),
                new RelationMetadata("FK_PrijelazStatusa_PocetniStatus", "PrijelazStatusaVrstaDokumenta", "StatusVrstaDokumenta"),
                new RelationMetadata("FK_PrijelazStatusa_VrstaDokumenta", "PrijelazStatusaVrstaDokumenta", "VrstaDokumentaVrstaDokumenta"),
                new RelationMetadata("FK_PrijelazStatusa_ZavrsniStatus", "PrijelazStatusaStatusZavrsni", "StatusStatus"),
                new RelationMetadata("FK_PrijelazStatusa_ZavrsniStatus", "PrijelazStatusaVrstaDokumenta", "StatusVrstaDokumenta")
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
		public Status FK_PrijelazStatusa_PocetniStatus
        {
            get { return EntityContext<Status>.Get(ref m_FK_PrijelazStatusa_PocetniStatus, this, "FK_PrijelazStatusa_PocetniStatus"); }
            set { EntityContext<Status>.Set(ref m_FK_PrijelazStatusa_PocetniStatus, this, value, "FK_PrijelazStatusa_PocetniStatus"); }
        }
        public VrstaDokumenta FK_PrijelazStatusa_VrstaDokumenta
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_FK_PrijelazStatusa_VrstaDokumenta, this, "FK_PrijelazStatusa_VrstaDokumenta"); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_FK_PrijelazStatusa_VrstaDokumenta, this, value, "FK_PrijelazStatusa_VrstaDokumenta"); }
        }
        public Status FK_PrijelazStatusa_ZavrsniStatus
        {
            get { return EntityContext<Status>.Get(ref m_FK_PrijelazStatusa_ZavrsniStatus, this, "FK_PrijelazStatusa_ZavrsniStatus"); }
            set { EntityContext<Status>.Set(ref m_FK_PrijelazStatusa_ZavrsniStatus, this, value, "FK_PrijelazStatusa_ZavrsniStatus"); }
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

        #region Public methods
		public static IEnumerable<PrijelazStatusa> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<PrijelazStatusa>(queryConditions);
        }
        public static IEnumerable<PrijelazStatusa> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<PrijelazStatusa>(columnName, queryOp, value);
        }
		public static PrijelazStatusa GetByPrimaryKey(int PrijelazStatusaID)
        {
            return GetByPrimaryKey<PrijelazStatusa>(PrijelazStatusaID);
        }
		public static PrijelazStatusa TryGetByPrimaryKey(int PrijelazStatusaID)
        {
            return TryGetByPrimaryKey<PrijelazStatusa>(PrijelazStatusaID);
        }
        #endregion
    }
}