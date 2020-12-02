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

namespace Orko.Turist
{
    /// <summary>
    /// CjenikUsluga entity.
    /// </summary>
    public sealed partial class CjenikUsluga : Entity
    {
		#region Members
		private Cjenik m_FK_CjenikUsluga_Cjenik;
        private VrstaUsluge m_FK_CjenikUsluga_VrstaUsluge;
        #endregion
        
		#region Constructors
        static CjenikUsluga()
        {
            // Cache field metadata.
            EntityMeta<CjenikUsluga>.LoadColumnMetadata
			(
				new ColumnMetadata("CjenikUslugaID", @"CjenikUslugaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("CjenikUslugaProtokolID", @"CjenikUslugaProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("CjenikUslugaVrstaUsluge", @"CjenikUslugaVrstaUsluge", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("CjenikUslugaPredmetPopusta", @"CjenikUslugaPredmetPopusta", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("CjenikUslugaIznos", @"CjenikUslugaIznos", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("CjenikUslugaAlotmanskiIznos", @"CjenikUslugaAlotmanskiIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikUslugaVrijediOd", @"CjenikUslugaVrijediOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("CjenikUslugaUradio", @"CjenikUslugaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("CjenikUslugaDatumIzmjene", @"CjenikUslugaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<CjenikUsluga>.LoadRelationMetadata
			(
				new RelationMetadata("FK_CjenikUsluga_Cjenik", "CjenikUslugaProtokolID", "CjenikProtokolID"),
                new RelationMetadata("FK_CjenikUsluga_VrstaUsluge", "CjenikUslugaVrstaUsluge", "VrstaUslugeVrstaUsluge")
			);

			// Cache table metadata.
			EntityMeta<CjenikUsluga>.HasLanguageTable = false;
            EntityMeta<CjenikUsluga>.TableSchema = @"Turist";
            EntityMeta<CjenikUsluga>.TableName = @"CjenikUsluga";
            EntityMeta<CjenikUsluga>.LanguageTableSchema = null;
            EntityMeta<CjenikUsluga>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CjenikUslugaID { get; private set; }
        public int? CjenikUslugaProtokolID { get; set; }
        public int? CjenikUslugaVrstaUsluge { get; set; }
        public bool? CjenikUslugaPredmetPopusta { get; set; }
        public decimal? CjenikUslugaIznos { get; set; }
        public decimal? CjenikUslugaAlotmanskiIznos { get; set; }
        public DateTime? CjenikUslugaVrijediOd { get; set; }
        public string CjenikUslugaUradio { get; set; }
        public DateTime? CjenikUslugaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public Cjenik FK_CjenikUsluga_Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_FK_CjenikUsluga_Cjenik, this, "FK_CjenikUsluga_Cjenik"); }
            set { EntityContext<Cjenik>.Set(ref m_FK_CjenikUsluga_Cjenik, this, value, "FK_CjenikUsluga_Cjenik"); }
        }
        public VrstaUsluge FK_CjenikUsluga_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_CjenikUsluga_VrstaUsluge, this, "FK_CjenikUsluga_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_CjenikUsluga_VrstaUsluge, this, value, "FK_CjenikUsluga_VrstaUsluge"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CjenikUsluga>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CjenikUsluga>(queryConditions);
        }
        public static async Task<IEnumerable<CjenikUsluga>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CjenikUsluga>(columnName, queryOp, value);
        }
		public static async Task<CjenikUsluga> GetByPrimaryKeyAsync(int CjenikUslugaID)
        {
            return await GetByPrimaryKeyAsync<CjenikUsluga>(CjenikUslugaID);
        }
		public static async Task<CjenikUsluga> TryGetByPrimaryKeyAsync(int CjenikUslugaID)
        {
            return await TryGetByPrimaryKeyAsync<CjenikUsluga>(CjenikUslugaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<CjenikUsluga> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<CjenikUsluga>(queryConditions);
        }
        public static IEnumerable<CjenikUsluga> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<CjenikUsluga>(columnName, queryOp, value);
        }
		public static CjenikUsluga GetByPrimaryKey(int CjenikUslugaID)
        {
            return GetByPrimaryKey<CjenikUsluga>(CjenikUslugaID);
        }
		public static CjenikUsluga TryGetByPrimaryKey(int CjenikUslugaID)
        {
            return TryGetByPrimaryKey<CjenikUsluga>(CjenikUslugaID);
        }
        public static CjenikUsluga GetByUnique1(int CjenikUslugaProtokolID, int CjenikUslugaVrstaUsluge)
        {
            return GetByCallingParameters<CjenikUsluga>(CjenikUslugaProtokolID, CjenikUslugaVrstaUsluge);
        }
		public static CjenikUsluga TryGetByUnique1(int CjenikUslugaProtokolID, int CjenikUslugaVrstaUsluge)
        {
            return TryGetByCallingParameters<CjenikUsluga>(CjenikUslugaProtokolID, CjenikUslugaVrstaUsluge);
        }
        #endregion
    }
}