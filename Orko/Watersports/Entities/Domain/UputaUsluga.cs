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

namespace Orko.Watersports
{
    /// <summary>
    /// UputaUsluga entity.
    /// </summary>
    public sealed partial class UputaUsluga : Entity
    {
		#region Members
		private Termin m_FK_UputaUsluga_Termin;
        private TipBroda m_FK_UputaUsluga_TipBroda;
        private VrstaIzleta m_FK_UputaUsluga_VrstaIzleta;
        private VrstaUsluge m_FK_UputaUsluga_VrstaUsluge;
        #endregion
        
		#region Constructors
        static UputaUsluga()
        {
            // Cache field metadata.
            EntityMeta<UputaUsluga>.LoadColumnMetadata
			(
				new ColumnMetadata("UputaUslugaID", @"UputaUslugaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("UputaUslugaVrstaUsluge", @"UputaUslugaVrstaUsluge", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("UputaUslugaVrstaIzleta", @"UputaUslugaVrstaIzleta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("UputaUslugaTipBroda", @"UputaUslugaTipBroda", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("UputaUslugaTerminID", @"UputaUslugaTerminID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("UputaUslugaSkiper", @"UputaUslugaSkiper", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("UputaUslugaGorivo", @"UputaUslugaGorivo", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("UputaUslugaAktivnost", @"UputaUslugaAktivnost", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<UputaUsluga>.LoadRelationMetadata
			(
				new RelationMetadata("FK_UputaUsluga_Termin", "UputaUslugaTerminID", "TerminID"),
                new RelationMetadata("FK_UputaUsluga_TipBroda", "UputaUslugaTipBroda", "TipBrodaTipBroda"),
                new RelationMetadata("FK_UputaUsluga_VrstaIzleta", "UputaUslugaVrstaIzleta", "VrstaIzletaVrstaIzleta"),
                new RelationMetadata("FK_UputaUsluga_VrstaUsluge", "UputaUslugaVrstaUsluge", "VrstaUslugeVrstaUsluge")
			);

			// Cache table metadata.
			EntityMeta<UputaUsluga>.HasLanguageTable = false;
            EntityMeta<UputaUsluga>.TableSchema = @"Watersports";
            EntityMeta<UputaUsluga>.TableName = @"UputaUsluga";
            EntityMeta<UputaUsluga>.LanguageTableSchema = null;
            EntityMeta<UputaUsluga>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? UputaUslugaID { get; private set; }
        public string UputaUslugaVrstaUsluge { get; set; }
        public string UputaUslugaVrstaIzleta { get; set; }
        public string UputaUslugaTipBroda { get; set; }
        public int? UputaUslugaTerminID { get; set; }
        public bool? UputaUslugaSkiper { get; set; }
        public bool? UputaUslugaGorivo { get; set; }
        public bool? UputaUslugaAktivnost { get; set; }
        #endregion

        #region Entities
		public Termin FK_UputaUsluga_Termin
        {
            get { return EntityContext<Termin>.Get(ref m_FK_UputaUsluga_Termin, this, "FK_UputaUsluga_Termin"); }
            set { EntityContext<Termin>.Set(ref m_FK_UputaUsluga_Termin, this, value, "FK_UputaUsluga_Termin"); }
        }
        public TipBroda FK_UputaUsluga_TipBroda
        {
            get { return EntityContext<TipBroda>.Get(ref m_FK_UputaUsluga_TipBroda, this, "FK_UputaUsluga_TipBroda"); }
            set { EntityContext<TipBroda>.Set(ref m_FK_UputaUsluga_TipBroda, this, value, "FK_UputaUsluga_TipBroda"); }
        }
        public VrstaIzleta FK_UputaUsluga_VrstaIzleta
        {
            get { return EntityContext<VrstaIzleta>.Get(ref m_FK_UputaUsluga_VrstaIzleta, this, "FK_UputaUsluga_VrstaIzleta"); }
            set { EntityContext<VrstaIzleta>.Set(ref m_FK_UputaUsluga_VrstaIzleta, this, value, "FK_UputaUsluga_VrstaIzleta"); }
        }
        public VrstaUsluge FK_UputaUsluga_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_UputaUsluga_VrstaUsluge, this, "FK_UputaUsluga_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_UputaUsluga_VrstaUsluge, this, value, "FK_UputaUsluga_VrstaUsluge"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<UputaUsluga>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<UputaUsluga>(queryConditions);
        }
        public static async Task<IEnumerable<UputaUsluga>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<UputaUsluga>(columnName, queryOp, value);
        }
		public static async Task<UputaUsluga> GetByPrimaryKeyAsync(int UputaUslugaID)
        {
            return await GetByPrimaryKeyAsync<UputaUsluga>(UputaUslugaID);
        }
		public static async Task<UputaUsluga> TryGetByPrimaryKeyAsync(int UputaUslugaID)
        {
            return await TryGetByPrimaryKeyAsync<UputaUsluga>(UputaUslugaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<UputaUsluga> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<UputaUsluga>(queryConditions);
        }
        public static IEnumerable<UputaUsluga> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<UputaUsluga>(columnName, queryOp, value);
        }
		public static UputaUsluga GetByPrimaryKey(int UputaUslugaID)
        {
            return GetByPrimaryKey<UputaUsluga>(UputaUslugaID);
        }
		public static UputaUsluga TryGetByPrimaryKey(int UputaUslugaID)
        {
            return TryGetByPrimaryKey<UputaUsluga>(UputaUslugaID);
        }
        public static UputaUsluga GetByUnique1(string UputaUslugaVrstaUsluge, string UputaUslugaVrstaIzleta, string UputaUslugaTipBroda, int UputaUslugaTerminID, bool UputaUslugaSkiper, bool UputaUslugaGorivo)
        {
            return GetByCallingParameters<UputaUsluga>(UputaUslugaVrstaUsluge, UputaUslugaVrstaIzleta, UputaUslugaTipBroda, UputaUslugaTerminID, UputaUslugaSkiper, UputaUslugaGorivo);
        }
		public static UputaUsluga TryGetByUnique1(string UputaUslugaVrstaUsluge, string UputaUslugaVrstaIzleta, string UputaUslugaTipBroda, int UputaUslugaTerminID, bool UputaUslugaSkiper, bool UputaUslugaGorivo)
        {
            return TryGetByCallingParameters<UputaUsluga>(UputaUslugaVrstaUsluge, UputaUslugaVrstaIzleta, UputaUslugaTipBroda, UputaUslugaTerminID, UputaUslugaSkiper, UputaUslugaGorivo);
        }
        #endregion
    }
}