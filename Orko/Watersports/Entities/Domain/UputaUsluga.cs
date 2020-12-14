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
    /// UputaUsluga entity.
    /// </summary>
    public sealed partial class UputaUsluga : Entity
    {
		#region Members
		private Termin m_Termin;
        private TipBroda m_TipBroda;
        private VrstaIzleta m_VrstaIzleta;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static UputaUsluga()
        {
            // Cache field metadata.
            EntityMeta<UputaUsluga>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(UputaUslugaID), @"UputaUslugaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaVrstaUsluge), @"UputaUslugaVrstaUsluge", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaVrstaIzleta), @"UputaUslugaVrstaIzleta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaTipBroda), @"UputaUslugaTipBroda", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaTerminID), @"UputaUslugaTerminID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaSkiper), @"UputaUslugaSkiper", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaGorivo), @"UputaUslugaGorivo", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaAktivnost), @"UputaUslugaAktivnost", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<UputaUsluga>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Termin), nameof(UputaUslugaTerminID), nameof(Orko.Watersports.Termin.TerminID)),
                new RelationMetadata(nameof(TipBroda), nameof(UputaUslugaTipBroda), nameof(Orko.Watersports.TipBroda.TipBrodaTipBroda)),
                new RelationMetadata(nameof(VrstaIzleta), nameof(UputaUslugaVrstaIzleta), nameof(Orko.Watersports.VrstaIzleta.VrstaIzletaVrstaIzleta)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(UputaUslugaVrstaUsluge), nameof(Orko.Watersports.VrstaUsluge.VrstaUslugeVrstaUsluge))
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
		public Termin Termin
        {
            get { return EntityContext<Termin>.Get(ref m_Termin, this, nameof(Termin)); }
            set { EntityContext<Termin>.Set(ref m_Termin, this, value, nameof(Termin)); }
        }
        public TipBroda TipBroda
        {
            get { return EntityContext<TipBroda>.Get(ref m_TipBroda, this, nameof(TipBroda)); }
            set { EntityContext<TipBroda>.Set(ref m_TipBroda, this, value, nameof(TipBroda)); }
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
    }
}