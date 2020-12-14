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

namespace Orko.Watersports
{
    /// <summary>
    /// UputaUslugaTermin entity.
    /// </summary>
    public sealed partial class UputaUslugaTermin : Entity
    {
		#region Members
		private Termin m_Termin;
        private VrstaIzleta m_VrstaIzleta;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static UputaUslugaTermin()
        {
            // Cache field metadata.
            EntityMeta<UputaUslugaTermin>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(UputaUslugaTerminID), @"UputaUslugaTerminID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaTerminVrstaUsluge), @"UputaUslugaTerminVrstaUsluge", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaTerminVrstaIzleta), @"UputaUslugaTerminVrstaIzleta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaTerminTerminID), @"UputaUslugaTerminTerminID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaTerminAktivnost), @"UputaUslugaTerminAktivnost", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<UputaUslugaTermin>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Termin), nameof(UputaUslugaTerminTerminID), nameof(Orko.Watersports.Termin.TerminID)),
                new RelationMetadata(nameof(VrstaIzleta), nameof(UputaUslugaTerminVrstaIzleta), nameof(Orko.Watersports.VrstaIzleta.VrstaIzletaVrstaIzleta)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(UputaUslugaTerminVrstaUsluge), nameof(Orko.Watersports.VrstaUsluge.VrstaUslugeVrstaUsluge))
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
		public Termin Termin
        {
            get { return EntityContext<Termin>.Get(ref m_Termin, this, nameof(Termin)); }
            set { EntityContext<Termin>.Set(ref m_Termin, this, value, nameof(Termin)); }
        }
        public VrstaIzleta VrstaIzleta
        {
            get { return EntityContext<VrstaIzleta>.Get(ref m_VrstaIzleta, this, nameof(VrstaIzleta)); }
            set { EntityContext<VrstaIzleta>.Set(ref m_VrstaIzleta, this, value, nameof(VrstaIzleta)); }
        }
        public VrstaUsluge VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_VrstaUsluge, this, nameof(VrstaUsluge)); }
            set { EntityContext<VrstaUsluge>.Set(ref m_VrstaUsluge, this, value, nameof(VrstaUsluge)); }
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
    }
}