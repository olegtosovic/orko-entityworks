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

namespace Orko.Turist
{
    /// <summary>
    /// SmjestajniObjektVrstaUsluge entity.
    /// </summary>
    public sealed partial class SmjestajniObjektVrstaUsluge : Entity
    {
		#region Members
		private SmjestajniObjekt m_SmjestajniObjekt;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static SmjestajniObjektVrstaUsluge()
        {
            // Cache field metadata.
            EntityMeta<SmjestajniObjektVrstaUsluge>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SmjestajniObjektVrstaUslugeID), @"SmjestajniObjektVrstaUslugeID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektVrstaUslugeSmjestajniObjekt), @"SmjestajniObjektVrstaUslugeSmjestajniObjekt", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektVrstaUslugeVrstaUsluge), @"SmjestajniObjektVrstaUslugeVrstaUsluge", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(SmjestajniObjektVrstaUslugeAktivnost), @"SmjestajniObjektVrstaUslugeAktivnost", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SmjestajniObjektVrstaUsluge>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(SmjestajniObjekt), nameof(SmjestajniObjektVrstaUslugeSmjestajniObjekt), nameof(Orko.Turist.SmjestajniObjekt.SmjestajniObjektSmjestajniObjekt)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(SmjestajniObjektVrstaUslugeVrstaUsluge), nameof(Orko.Turist.VrstaUsluge.VrstaUslugeVrstaUsluge))
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
		public SmjestajniObjekt SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_SmjestajniObjekt, this, nameof(SmjestajniObjekt)); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_SmjestajniObjekt, this, value, nameof(SmjestajniObjekt)); }
        }
        public VrstaUsluge VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_VrstaUsluge, this, nameof(VrstaUsluge)); }
            set { EntityContext<VrstaUsluge>.Set(ref m_VrstaUsluge, this, value, nameof(VrstaUsluge)); }
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
    }
}