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
    /// SmjestajniObjektVrstaUsluge entity.
    /// </summary>
    public sealed partial class SmjestajniObjektVrstaUsluge : Entity
    {
		#region Members
		private SmjestajniObjekt m_FK_SmjestajniObjektVrstaUsluge_SmjestajniObjekt;
        private VrstaUsluge m_FK_SmjestajniObjektVrstaUsluge_VrstaUsluge;
        #endregion
        
		#region Constructors
        static SmjestajniObjektVrstaUsluge()
        {
            // Cache field metadata.
            EntityMeta<SmjestajniObjektVrstaUsluge>.LoadColumnMetadata
			(
				new ColumnMetadata("SmjestajniObjektVrstaUslugeID", @"SmjestajniObjektVrstaUslugeID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("SmjestajniObjektVrstaUslugeSmjestajniObjekt", @"SmjestajniObjektVrstaUslugeSmjestajniObjekt", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("SmjestajniObjektVrstaUslugeVrstaUsluge", @"SmjestajniObjektVrstaUslugeVrstaUsluge", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("SmjestajniObjektVrstaUslugeAktivnost", @"SmjestajniObjektVrstaUslugeAktivnost", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SmjestajniObjektVrstaUsluge>.LoadRelationMetadata
			(
				new RelationMetadata("FK_SmjestajniObjektVrstaUsluge_SmjestajniObjekt", "SmjestajniObjektVrstaUslugeSmjestajniObjekt", "SmjestajniObjektSmjestajniObjekt"),
                new RelationMetadata("FK_SmjestajniObjektVrstaUsluge_VrstaUsluge", "SmjestajniObjektVrstaUslugeVrstaUsluge", "VrstaUslugeVrstaUsluge")
			);

			// Cache table metadata.
			EntityMeta<SmjestajniObjektVrstaUsluge>.HasLanguageTable = false;
            EntityMeta<SmjestajniObjektVrstaUsluge>.TableSchema = @"Turist";
            EntityMeta<SmjestajniObjektVrstaUsluge>.TableName = @"SmjestajniObjektVrstaUsluge";
            EntityMeta<SmjestajniObjektVrstaUsluge>.LanguageTableSchema = null;
            EntityMeta<SmjestajniObjektVrstaUsluge>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SmjestajniObjektVrstaUslugeID { get; private set; }
        public int? SmjestajniObjektVrstaUslugeSmjestajniObjekt { get; set; }
        public int? SmjestajniObjektVrstaUslugeVrstaUsluge { get; set; }
        public bool? SmjestajniObjektVrstaUslugeAktivnost { get; set; }
        #endregion

        #region Entities
		public SmjestajniObjekt FK_SmjestajniObjektVrstaUsluge_SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_FK_SmjestajniObjektVrstaUsluge_SmjestajniObjekt, this, "FK_SmjestajniObjektVrstaUsluge_SmjestajniObjekt"); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_FK_SmjestajniObjektVrstaUsluge_SmjestajniObjekt, this, value, "FK_SmjestajniObjektVrstaUsluge_SmjestajniObjekt"); }
        }
        public VrstaUsluge FK_SmjestajniObjektVrstaUsluge_VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_FK_SmjestajniObjektVrstaUsluge_VrstaUsluge, this, "FK_SmjestajniObjektVrstaUsluge_VrstaUsluge"); }
            set { EntityContext<VrstaUsluge>.Set(ref m_FK_SmjestajniObjektVrstaUsluge_VrstaUsluge, this, value, "FK_SmjestajniObjektVrstaUsluge_VrstaUsluge"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SmjestajniObjektVrstaUsluge>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SmjestajniObjektVrstaUsluge>(queryConditions);
        }
        public static async Task<IEnumerable<SmjestajniObjektVrstaUsluge>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SmjestajniObjektVrstaUsluge>(columnName, queryOp, value);
        }
		public static async Task<SmjestajniObjektVrstaUsluge> GetByPrimaryKeyAsync(int SmjestajniObjektVrstaUslugeID)
        {
            return await GetByPrimaryKeyAsync<SmjestajniObjektVrstaUsluge>(SmjestajniObjektVrstaUslugeID);
        }
		public static async Task<SmjestajniObjektVrstaUsluge> TryGetByPrimaryKeyAsync(int SmjestajniObjektVrstaUslugeID)
        {
            return await TryGetByPrimaryKeyAsync<SmjestajniObjektVrstaUsluge>(SmjestajniObjektVrstaUslugeID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<SmjestajniObjektVrstaUsluge> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<SmjestajniObjektVrstaUsluge>(queryConditions);
        }
        public static IEnumerable<SmjestajniObjektVrstaUsluge> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<SmjestajniObjektVrstaUsluge>(columnName, queryOp, value);
        }
		public static SmjestajniObjektVrstaUsluge GetByPrimaryKey(int SmjestajniObjektVrstaUslugeID)
        {
            return GetByPrimaryKey<SmjestajniObjektVrstaUsluge>(SmjestajniObjektVrstaUslugeID);
        }
		public static SmjestajniObjektVrstaUsluge TryGetByPrimaryKey(int SmjestajniObjektVrstaUslugeID)
        {
            return TryGetByPrimaryKey<SmjestajniObjektVrstaUsluge>(SmjestajniObjektVrstaUslugeID);
        }
        public static SmjestajniObjektVrstaUsluge GetByUnique1(int SmjestajniObjektVrstaUslugeSmjestajniObjekt, int SmjestajniObjektVrstaUslugeVrstaUsluge)
        {
            return GetByCallingParameters<SmjestajniObjektVrstaUsluge>(SmjestajniObjektVrstaUslugeSmjestajniObjekt, SmjestajniObjektVrstaUslugeVrstaUsluge);
        }
		public static SmjestajniObjektVrstaUsluge TryGetByUnique1(int SmjestajniObjektVrstaUslugeSmjestajniObjekt, int SmjestajniObjektVrstaUslugeVrstaUsluge)
        {
            return TryGetByCallingParameters<SmjestajniObjektVrstaUsluge>(SmjestajniObjektVrstaUslugeSmjestajniObjekt, SmjestajniObjektVrstaUslugeVrstaUsluge);
        }
        #endregion
    }
}