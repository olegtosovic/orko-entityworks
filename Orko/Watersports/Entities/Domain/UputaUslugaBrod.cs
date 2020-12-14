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
    /// UputaUslugaBrod entity.
    /// </summary>
    public sealed partial class UputaUslugaBrod : Entity
    {
		#region Members
		private TipBroda m_TipBroda;
        private VrstaIzleta m_VrstaIzleta;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static UputaUslugaBrod()
        {
            // Cache field metadata.
            EntityMeta<UputaUslugaBrod>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(UputaUslugaBrodID), @"UputaUslugaBrodID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaBrodVrstaUsluge), @"UputaUslugaBrodVrstaUsluge", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaBrodVrstaIzleta), @"UputaUslugaBrodVrstaIzleta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(UputaUslugaBrodTipBroda), @"UputaUslugaBrodTipBroda", DbType.String, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<UputaUslugaBrod>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(TipBroda), nameof(UputaUslugaBrodTipBroda), nameof(Orko.Watersports.TipBroda.TipBrodaTipBroda)),
                new RelationMetadata(nameof(VrstaIzleta), nameof(UputaUslugaBrodVrstaIzleta), nameof(Orko.Watersports.VrstaIzleta.VrstaIzletaVrstaIzleta)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(UputaUslugaBrodVrstaUsluge), nameof(Orko.Watersports.VrstaUsluge.VrstaUslugeVrstaUsluge))
			);

			// Cache table metadata.
			EntityMeta<UputaUslugaBrod>.HasLanguageTable = false;
            EntityMeta<UputaUslugaBrod>.TableSchema = @"Watersports";
            EntityMeta<UputaUslugaBrod>.TableName = @"UputaUslugaBrod";
            EntityMeta<UputaUslugaBrod>.LanguageTableSchema = null;
            EntityMeta<UputaUslugaBrod>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? UputaUslugaBrodID { get; private set; }
        public string UputaUslugaBrodVrstaUsluge { get; set; }
        public string UputaUslugaBrodVrstaIzleta { get; set; }
        public string UputaUslugaBrodTipBroda { get; set; }
        #endregion

        #region Entities
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
		public static async Task<IEnumerable<UputaUslugaBrod>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<UputaUslugaBrod>(queryConditions);
        }
        public static async Task<IEnumerable<UputaUslugaBrod>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<UputaUslugaBrod>(columnName, queryOp, value);
        }
		public static async Task<UputaUslugaBrod> GetByPrimaryKeyAsync(int UputaUslugaBrodID)
        {
            return await GetByPrimaryKeyAsync<UputaUslugaBrod>(UputaUslugaBrodID);
        }
		public static async Task<UputaUslugaBrod> TryGetByPrimaryKeyAsync(int UputaUslugaBrodID)
        {
            return await TryGetByPrimaryKeyAsync<UputaUslugaBrod>(UputaUslugaBrodID);
        }
		#endregion
    }
}