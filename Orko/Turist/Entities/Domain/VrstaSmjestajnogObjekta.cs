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
    /// VrstaSmjestajnogObjekta entity.
    /// </summary>
    public sealed partial class VrstaSmjestajnogObjekta : Entity
    {
		#region Members
		private SkupinaSmjestajnogObjekta m_SkupinaSmjestajnogObjekta;
        #endregion
        
		#region Constructors
        static VrstaSmjestajnogObjekta()
        {
            // Cache field metadata.
            EntityMeta<VrstaSmjestajnogObjekta>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta), @"VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta), @"VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaSmjestajnogObjektaAktivnost), @"VrstaSmjestajnogObjektaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaSmjestajnogObjektaJezik), @"VrstaSmjestajnogObjektaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaSmjestajnogObjektaNaziv), @"VrstaSmjestajnogObjektaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaSmjestajnogObjektaOpis), @"VrstaSmjestajnogObjektaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaSmjestajnogObjekta>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(SkupinaSmjestajnogObjekta), nameof(VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta), nameof(Orko.Turist.SkupinaSmjestajnogObjekta.SkupinaSmjestajnogObjektaSkupinaSmjestajnogObjekta))
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
		public SkupinaSmjestajnogObjekta SkupinaSmjestajnogObjekta
        {
            get { return EntityContext<SkupinaSmjestajnogObjekta>.Get(ref m_SkupinaSmjestajnogObjekta, this, nameof(SkupinaSmjestajnogObjekta)); }
            set { EntityContext<SkupinaSmjestajnogObjekta>.Set(ref m_SkupinaSmjestajnogObjekta, this, value, nameof(SkupinaSmjestajnogObjekta)); }
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
    }
}