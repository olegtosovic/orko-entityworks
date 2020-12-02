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
    /// VrstaSmjestajnogObjekta entity.
    /// </summary>
    public sealed partial class VrstaSmjestajnogObjekta : Entity
    {
		#region Members
		private SkupinaSmjestajnogObjekta m_FK_VrstaSmjestajnogObjekta_SkupinaSmjestajnogObjekta;
        #endregion
        
		#region Constructors
        static VrstaSmjestajnogObjekta()
        {
            // Cache field metadata.
            EntityMeta<VrstaSmjestajnogObjekta>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta", @"VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta", @"VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaSmjestajnogObjektaAktivnost", @"VrstaSmjestajnogObjektaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaSmjestajnogObjektaJezik", @"VrstaSmjestajnogObjektaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaSmjestajnogObjektaNaziv", @"VrstaSmjestajnogObjektaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaSmjestajnogObjektaOpis", @"VrstaSmjestajnogObjektaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaSmjestajnogObjekta>.LoadRelationMetadata
			(
				new RelationMetadata("FK_VrstaSmjestajnogObjekta_SkupinaSmjestajnogObjekta", "VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta", "SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta")
			);

			// Cache table metadata.
			EntityMeta<VrstaSmjestajnogObjekta>.HasLanguageTable = true;
            EntityMeta<VrstaSmjestajnogObjekta>.TableSchema = @"Turist";
            EntityMeta<VrstaSmjestajnogObjekta>.TableName = @"VrstaSmjestajnogObjekta";
            EntityMeta<VrstaSmjestajnogObjekta>.LanguageTableSchema = @"Turist";
            EntityMeta<VrstaSmjestajnogObjekta>.LanguageTableName = @"VrstaSmjestajnogObjekta_jezik";
        }
        #endregion

        #region Columns
        public string VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta { get; set; }
        public string VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta { get; set; }
        public bool? VrstaSmjestajnogObjektaAktivnost { get; set; }
        public string VrstaSmjestajnogObjektaJezik { get; private set; }
        public string VrstaSmjestajnogObjektaNaziv { get; set; }
        public string VrstaSmjestajnogObjektaOpis { get; set; }
        #endregion

        #region Entities
		public SkupinaSmjestajnogObjekta FK_VrstaSmjestajnogObjekta_SkupinaSmjestajnogObjekta
        {
            get { return EntityContext<SkupinaSmjestajnogObjekta>.Get(ref m_FK_VrstaSmjestajnogObjekta_SkupinaSmjestajnogObjekta, this, "FK_VrstaSmjestajnogObjekta_SkupinaSmjestajnogObjekta"); }
            set { EntityContext<SkupinaSmjestajnogObjekta>.Set(ref m_FK_VrstaSmjestajnogObjekta_SkupinaSmjestajnogObjekta, this, value, "FK_VrstaSmjestajnogObjekta_SkupinaSmjestajnogObjekta"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaSmjestajnogObjekta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaSmjestajnogObjekta>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaSmjestajnogObjekta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaSmjestajnogObjekta>(columnName, queryOp, value);
        }
		public static async Task<VrstaSmjestajnogObjekta> GetByPrimaryKeyAsync(string VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta, string VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta)
        {
            return await GetByPrimaryKeyAsync<VrstaSmjestajnogObjekta>(VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta, VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta);
        }
		public static async Task<VrstaSmjestajnogObjekta> TryGetByPrimaryKeyAsync(string VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta, string VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta)
        {
            return await TryGetByPrimaryKeyAsync<VrstaSmjestajnogObjekta>(VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta, VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VrstaSmjestajnogObjekta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaSmjestajnogObjekta>(queryConditions);
        }
        public static IEnumerable<VrstaSmjestajnogObjekta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaSmjestajnogObjekta>(columnName, queryOp, value);
        }
		public static VrstaSmjestajnogObjekta GetByPrimaryKey(string VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta, string VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta)
        {
            return GetByPrimaryKey<VrstaSmjestajnogObjekta>(VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta, VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta);
        }
		public static VrstaSmjestajnogObjekta TryGetByPrimaryKey(string VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta, string VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta)
        {
            return TryGetByPrimaryKey<VrstaSmjestajnogObjekta>(VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta, VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta);
        }
        #endregion
    }
}