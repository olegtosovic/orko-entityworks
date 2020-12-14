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
    /// Protokol entity.
    /// </summary>
    public sealed partial class Protokol : Entity
    {
		#region Members
		private Evidencija m_Evidencija;
        private VrstaDokumenta m_VrstaDokumenta;
        private VrstaProtokola m_VrstaProtokola;
        #endregion
        
		#region Constructors
        static Protokol()
        {
            // Cache field metadata.
            EntityMeta<Protokol>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ProtokolID), @"ProtokolID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(ProtokolProtokol), @"ProtokolProtokol", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ProtokolGodina), @"ProtokolGodina", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProtokolBroj), @"ProtokolBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProtokolVrstaDokumenta), @"ProtokolVrstaDokumenta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ProtokolVrstaProtokola), @"ProtokolVrstaProtokola", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ProtokolDatumDokumenta), @"ProtokolDatumDokumenta", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(ProtokolEvidencijaID), @"ProtokolEvidencijaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProtokolStatus), @"ProtokolStatus", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProtokolOpis), @"ProtokolOpis", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Protokol>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Evidencija), nameof(ProtokolEvidencijaID), nameof(Orko.Base.Evidencija.EvidencijaID)),
                new RelationMetadata(nameof(VrstaDokumenta), nameof(ProtokolVrstaDokumenta), nameof(Orko.Base.VrstaDokumenta.VrstaDokumentaVrstaDokumenta)),
                new RelationMetadata(nameof(VrstaProtokola), nameof(ProtokolVrstaProtokola), nameof(Orko.Base.VrstaProtokola.VrstaProtokolaVrstaProtokola))
			);

			// Cache table metadata.
			EntityMeta<Protokol>.HasLanguageTable = false;
            EntityMeta<Protokol>.TableSchema = @"Base";
            EntityMeta<Protokol>.TableName = @"Protokol";
            EntityMeta<Protokol>.LanguageTableSchema = null;
            EntityMeta<Protokol>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ProtokolID { get; private set; }
        public string ProtokolProtokol { get; set; }
        public int? ProtokolGodina { get; set; }
        public int? ProtokolBroj { get; set; }
        public string ProtokolVrstaDokumenta { get; set; }
        public string ProtokolVrstaProtokola { get; set; }
        public DateTime? ProtokolDatumDokumenta { get; set; }
        public int? ProtokolEvidencijaID { get; set; }
        public int? ProtokolStatus { get; set; }
        public string ProtokolOpis { get; set; }
        #endregion

        #region Entities
		public Evidencija Evidencija
        {
            get { return EntityContext<Evidencija>.Get(ref m_Evidencija, this, nameof(Evidencija)); }
            set { EntityContext<Evidencija>.Set(ref m_Evidencija, this, value, nameof(Evidencija)); }
        }
        public VrstaDokumenta VrstaDokumenta
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_VrstaDokumenta, this, nameof(VrstaDokumenta)); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_VrstaDokumenta, this, value, nameof(VrstaDokumenta)); }
        }
        public VrstaProtokola VrstaProtokola
        {
            get { return EntityContext<VrstaProtokola>.Get(ref m_VrstaProtokola, this, nameof(VrstaProtokola)); }
            set { EntityContext<VrstaProtokola>.Set(ref m_VrstaProtokola, this, value, nameof(VrstaProtokola)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Protokol>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Protokol>(queryConditions);
        }
        public static async Task<IEnumerable<Protokol>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Protokol>(columnName, queryOp, value);
        }
		public static async Task<Protokol> GetByPrimaryKeyAsync(int ProtokolID)
        {
            return await GetByPrimaryKeyAsync<Protokol>(ProtokolID);
        }
		public static async Task<Protokol> TryGetByPrimaryKeyAsync(int ProtokolID)
        {
            return await TryGetByPrimaryKeyAsync<Protokol>(ProtokolID);
        }
		#endregion
    }
}