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
    /// Protokol entity.
    /// </summary>
    public sealed partial class Protokol : Entity
    {
		#region Members
		private Evidencija m_FK_Protokol_Evidencija;
        private VrstaDokumenta m_FK_Protokol_VrstaDokumenta;
        private VrstaProtokola m_FK_Protokol_VrstaProtokola;
        #endregion
        
		#region Constructors
        static Protokol()
        {
            // Cache field metadata.
            EntityMeta<Protokol>.LoadColumnMetadata
			(
				new ColumnMetadata("ProtokolID", @"ProtokolID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("ProtokolProtokol", @"ProtokolProtokol", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ProtokolGodina", @"ProtokolGodina", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("ProtokolBroj", @"ProtokolBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("ProtokolVrstaDokumenta", @"ProtokolVrstaDokumenta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ProtokolVrstaProtokola", @"ProtokolVrstaProtokola", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ProtokolDatumDokumenta", @"ProtokolDatumDokumenta", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("ProtokolEvidencijaID", @"ProtokolEvidencijaID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("ProtokolStatus", @"ProtokolStatus", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("ProtokolOpis", @"ProtokolOpis", SqlDbType.NVarChar, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Protokol>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Protokol_Evidencija", "ProtokolEvidencijaID", "EvidencijaID"),
                new RelationMetadata("FK_Protokol_VrstaDokumenta", "ProtokolVrstaDokumenta", "VrstaDokumentaVrstaDokumenta"),
                new RelationMetadata("FK_Protokol_VrstaProtokola", "ProtokolVrstaProtokola", "VrstaProtokolaVrstaProtokola")
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
		public Evidencija FK_Protokol_Evidencija
        {
            get { return EntityContext<Evidencija>.Get(ref m_FK_Protokol_Evidencija, this, "FK_Protokol_Evidencija"); }
            set { EntityContext<Evidencija>.Set(ref m_FK_Protokol_Evidencija, this, value, "FK_Protokol_Evidencija"); }
        }
        public VrstaDokumenta FK_Protokol_VrstaDokumenta
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_FK_Protokol_VrstaDokumenta, this, "FK_Protokol_VrstaDokumenta"); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_FK_Protokol_VrstaDokumenta, this, value, "FK_Protokol_VrstaDokumenta"); }
        }
        public VrstaProtokola FK_Protokol_VrstaProtokola
        {
            get { return EntityContext<VrstaProtokola>.Get(ref m_FK_Protokol_VrstaProtokola, this, "FK_Protokol_VrstaProtokola"); }
            set { EntityContext<VrstaProtokola>.Set(ref m_FK_Protokol_VrstaProtokola, this, value, "FK_Protokol_VrstaProtokola"); }
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

        #region Public methods
		public static IEnumerable<Protokol> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Protokol>(queryConditions);
        }
        public static IEnumerable<Protokol> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Protokol>(columnName, queryOp, value);
        }
		public static Protokol GetByPrimaryKey(int ProtokolID)
        {
            return GetByPrimaryKey<Protokol>(ProtokolID);
        }
		public static Protokol TryGetByPrimaryKey(int ProtokolID)
        {
            return TryGetByPrimaryKey<Protokol>(ProtokolID);
        }
        public static Protokol GetByUnique1(int ProtokolGodina, int ProtokolBroj, string ProtokolVrstaDokumenta)
        {
            return GetByCallingParameters<Protokol>(ProtokolGodina, ProtokolBroj, ProtokolVrstaDokumenta);
        }
		public static Protokol TryGetByUnique1(int ProtokolGodina, int ProtokolBroj, string ProtokolVrstaDokumenta)
        {
            return TryGetByCallingParameters<Protokol>(ProtokolGodina, ProtokolBroj, ProtokolVrstaDokumenta);
        }
        public static Protokol GetByUnique2(string ProtokolProtokol)
        {
            return GetByCallingParameters<Protokol>(ProtokolProtokol);
        }
		public static Protokol TryGetByUnique2(string ProtokolProtokol)
        {
            return TryGetByCallingParameters<Protokol>(ProtokolProtokol);
        }
        #endregion
    }
}