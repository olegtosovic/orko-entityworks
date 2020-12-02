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
    /// UputaUslugaBrod entity.
    /// </summary>
    public sealed partial class UputaUslugaBrod : Entity
    {
		#region Members
		private TipBroda m_FK_UputaUslugaBrod_TipBroda;
        private VrstaIzleta m_FK_UputaUslugaBrod_VrstaIzleta;
        private VrstaUsluge m_FK_UputaUslugaBrod_VrstaUsluge;
        #endregion
        
		#region Constructors
        static UputaUslugaBrod()
        {
            // Cache field metadata.
            EntityMeta<UputaUslugaBrod>.LoadColumnMetadata
			(
				new ColumnMetadata("UputaUslugaBrodID", @"UputaUslugaBrodID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("UputaUslugaBrodVrstaUsluge", @"UputaUslugaBrodVrstaUsluge", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("UputaUslugaBrodVrstaIzleta", @"UputaUslugaBrodVrstaIzleta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("UputaUslugaBrodTipBroda", @"UputaUslugaBrodTipBroda", SqlDbType.NVarChar, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<UputaUslugaBrod>.LoadRelationMetadata
			(
				new RelationMetadata("FK_UputaUslugaBrod_TipBroda", "UputaUslugaBrodTipBroda", "TipBrodaTipBroda"),
                new RelationMetadata("FK_UputaUslugaBrod_VrstaIzleta", "UputaUslugaBrodVrstaIzleta", "VrstaIzletaVrstaIzleta"),
                new RelationMetadata("FK_UputaUslugaBrod_VrstaUsluge", "UputaUslugaBrodVrstaUsluge", "VrstaUslugeVrstaUsluge")
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
		public TipBroda FK_UputaUslugaBrod_TipBroda
        {
            get { return EntityContext<TipBroda>.Get(ref m_FK_UputaUslugaBrod_TipBroda, this, "FK_UputaUslugaBrod_TipBroda"); }
            set { EntityContext<TipBroda>.Set(ref m_FK_UputaUslugaBrod_TipBroda, this, value, "FK_UputaUslugaBrod_TipBroda"); }
        }
        public VrstaIzleta FK_UputaUslugaBrod_VrstaIzleta
        {
            get { return EntityContext<VrstaIzleta>.Get(ref m_FK_UputaUslugaBrod_VrstaIzleta, this, "FK_UputaUslugaBrod_VrstaIzleta"); }
            set { EntityContext<VrstaIzleta>.Set(ref m_FK_UputaUslugaBrod_VrstaIzleta, this, value, "FK_UputaUslugaBrod_VrstaIzleta"); }
        }
        public VrstaUsluge FK_UputaUslugaBrod_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_UputaUslugaBrod_VrstaUsluge, this, "FK_UputaUslugaBrod_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_UputaUslugaBrod_VrstaUsluge, this, value, "FK_UputaUslugaBrod_VrstaUsluge"); }
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

        #region Public methods
		public static IEnumerable<UputaUslugaBrod> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<UputaUslugaBrod>(queryConditions);
        }
        public static IEnumerable<UputaUslugaBrod> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<UputaUslugaBrod>(columnName, queryOp, value);
        }
		public static UputaUslugaBrod GetByPrimaryKey(int UputaUslugaBrodID)
        {
            return GetByPrimaryKey<UputaUslugaBrod>(UputaUslugaBrodID);
        }
		public static UputaUslugaBrod TryGetByPrimaryKey(int UputaUslugaBrodID)
        {
            return TryGetByPrimaryKey<UputaUslugaBrod>(UputaUslugaBrodID);
        }
        public static UputaUslugaBrod GetByUnique1(string UputaUslugaBrodVrstaUsluge, string UputaUslugaBrodVrstaIzleta, string UputaUslugaBrodTipBroda)
        {
            return GetByCallingParameters<UputaUslugaBrod>(UputaUslugaBrodVrstaUsluge, UputaUslugaBrodVrstaIzleta, UputaUslugaBrodTipBroda);
        }
		public static UputaUslugaBrod TryGetByUnique1(string UputaUslugaBrodVrstaUsluge, string UputaUslugaBrodVrstaIzleta, string UputaUslugaBrodTipBroda)
        {
            return TryGetByCallingParameters<UputaUslugaBrod>(UputaUslugaBrodVrstaUsluge, UputaUslugaBrodVrstaIzleta, UputaUslugaBrodTipBroda);
        }
        #endregion
    }
}