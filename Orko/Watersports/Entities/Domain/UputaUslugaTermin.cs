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
    /// UputaUslugaTermin entity.
    /// </summary>
    public sealed partial class UputaUslugaTermin : Entity
    {
		#region Members
		private Termin m_FK_UputaUslugaTermin_Termin;
        private VrstaIzleta m_FK_UputaUslugaTermin_VrstaIzleta;
        private VrstaUsluge m_FK_UputaUslugaTermin_VrstaUsluge;
        #endregion
        
		#region Constructors
        static UputaUslugaTermin()
        {
            // Cache field metadata.
            EntityMeta<UputaUslugaTermin>.LoadColumnMetadata
			(
				new ColumnMetadata("UputaUslugaTerminID", @"UputaUslugaTerminID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("UputaUslugaTerminVrstaUsluge", @"UputaUslugaTerminVrstaUsluge", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("UputaUslugaTerminVrstaIzleta", @"UputaUslugaTerminVrstaIzleta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("UputaUslugaTerminTerminID", @"UputaUslugaTerminTerminID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("UputaUslugaTerminAktivnost", @"UputaUslugaTerminAktivnost", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<UputaUslugaTermin>.LoadRelationMetadata
			(
				new RelationMetadata("FK_UputaUslugaTermin_Termin", "UputaUslugaTerminTerminID", "TerminID"),
                new RelationMetadata("FK_UputaUslugaTermin_VrstaIzleta", "UputaUslugaTerminVrstaIzleta", "VrstaIzletaVrstaIzleta"),
                new RelationMetadata("FK_UputaUslugaTermin_VrstaUsluge", "UputaUslugaTerminVrstaUsluge", "VrstaUslugeVrstaUsluge")
			);

			// Cache table metadata.
			EntityMeta<UputaUslugaTermin>.HasLanguageTable = false;
            EntityMeta<UputaUslugaTermin>.TableSchema = @"Watersports";
            EntityMeta<UputaUslugaTermin>.TableName = @"UputaUslugaTermin";
            EntityMeta<UputaUslugaTermin>.LanguageTableSchema = null;
            EntityMeta<UputaUslugaTermin>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? UputaUslugaTerminID { get; private set; }
        public string UputaUslugaTerminVrstaUsluge { get; set; }
        public string UputaUslugaTerminVrstaIzleta { get; set; }
        public int? UputaUslugaTerminTerminID { get; set; }
        public bool? UputaUslugaTerminAktivnost { get; set; }
        #endregion

        #region Entities
		public Termin FK_UputaUslugaTermin_Termin
        {
            get { return EntityContext<Termin>.Get(ref m_FK_UputaUslugaTermin_Termin, this, "FK_UputaUslugaTermin_Termin"); }
            set { EntityContext<Termin>.Set(ref m_FK_UputaUslugaTermin_Termin, this, value, "FK_UputaUslugaTermin_Termin"); }
        }
        public VrstaIzleta FK_UputaUslugaTermin_VrstaIzleta
        {
            get { return EntityContext<VrstaIzleta>.Get(ref m_FK_UputaUslugaTermin_VrstaIzleta, this, "FK_UputaUslugaTermin_VrstaIzleta"); }
            set { EntityContext<VrstaIzleta>.Set(ref m_FK_UputaUslugaTermin_VrstaIzleta, this, value, "FK_UputaUslugaTermin_VrstaIzleta"); }
        }
        public VrstaUsluge FK_UputaUslugaTermin_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_UputaUslugaTermin_VrstaUsluge, this, "FK_UputaUslugaTermin_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_UputaUslugaTermin_VrstaUsluge, this, value, "FK_UputaUslugaTermin_VrstaUsluge"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<UputaUslugaTermin>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<UputaUslugaTermin>(queryConditions);
        }
        public static async Task<IEnumerable<UputaUslugaTermin>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<UputaUslugaTermin>(columnName, queryOp, value);
        }
		public static async Task<UputaUslugaTermin> GetByPrimaryKeyAsync(int UputaUslugaTerminID)
        {
            return await GetByPrimaryKeyAsync<UputaUslugaTermin>(UputaUslugaTerminID);
        }
		public static async Task<UputaUslugaTermin> TryGetByPrimaryKeyAsync(int UputaUslugaTerminID)
        {
            return await TryGetByPrimaryKeyAsync<UputaUslugaTermin>(UputaUslugaTerminID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<UputaUslugaTermin> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<UputaUslugaTermin>(queryConditions);
        }
        public static IEnumerable<UputaUslugaTermin> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<UputaUslugaTermin>(columnName, queryOp, value);
        }
		public static UputaUslugaTermin GetByPrimaryKey(int UputaUslugaTerminID)
        {
            return GetByPrimaryKey<UputaUslugaTermin>(UputaUslugaTerminID);
        }
		public static UputaUslugaTermin TryGetByPrimaryKey(int UputaUslugaTerminID)
        {
            return TryGetByPrimaryKey<UputaUslugaTermin>(UputaUslugaTerminID);
        }
        public static UputaUslugaTermin GetByUnique1(string UputaUslugaTerminVrstaUsluge, string UputaUslugaTerminVrstaIzleta, int UputaUslugaTerminTerminID)
        {
            return GetByCallingParameters<UputaUslugaTermin>(UputaUslugaTerminVrstaUsluge, UputaUslugaTerminVrstaIzleta, UputaUslugaTerminTerminID);
        }
		public static UputaUslugaTermin TryGetByUnique1(string UputaUslugaTerminVrstaUsluge, string UputaUslugaTerminVrstaIzleta, int UputaUslugaTerminTerminID)
        {
            return TryGetByCallingParameters<UputaUslugaTermin>(UputaUslugaTerminVrstaUsluge, UputaUslugaTerminVrstaIzleta, UputaUslugaTerminTerminID);
        }
        #endregion
    }
}