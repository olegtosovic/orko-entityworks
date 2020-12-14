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
    /// VrstaSmjestajneJedinice entity.
    /// </summary>
    public sealed partial class VrstaSmjestajneJedinice : Entity
    {
		#region Members
		private VrstaSmjestajnogObjekta m_VrstaSmjestajnogObjekta;
        #endregion
        
		#region Constructors
        static VrstaSmjestajneJedinice()
        {
            // Cache field metadata.
            EntityMeta<VrstaSmjestajneJedinice>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VrstaSmjestajneJediniceVrstaSmjestajneJedinice), @"VrstaSmjestajneJediniceVrstaSmjestajneJedinice", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaSmjestajneJediniceVrstaSmjestajnogObjekta), @"VrstaSmjestajneJediniceVrstaSmjestajnogObjekta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta), @"VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VrstaSmjestajneJediniceAktivnost), @"VrstaSmjestajneJediniceAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(VrstaSmjestajneJediniceJezik), @"VrstaSmjestajneJediniceJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(VrstaSmjestajneJediniceNaziv), @"VrstaSmjestajneJediniceNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(VrstaSmjestajneJediniceOpis), @"VrstaSmjestajneJediniceOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaSmjestajneJedinice>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(VrstaSmjestajnogObjekta), nameof(VrstaSmjestajneJediniceVrstaSmjestajnogObjekta), nameof(Orko.Turist.VrstaSmjestajnogObjekta.VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta)),
                new RelationMetadata(nameof(VrstaSmjestajnogObjekta), nameof(VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta), nameof(Orko.Turist.VrstaSmjestajnogObjekta.VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta))
			);

			// Cache table metadata.
			EntityMeta<VrstaSmjestajneJedinice>.HasLanguageTable = true;
            EntityMeta<VrstaSmjestajneJedinice>.TableSchema = @"Turist";
            EntityMeta<VrstaSmjestajneJedinice>.TableName = @"VrstaSmjestajneJedinice";
            EntityMeta<VrstaSmjestajneJedinice>.LanguageTableSchema = @"Turist";
            EntityMeta<VrstaSmjestajneJedinice>.LanguageTableName = @"VrstaSmjestajneJedinice_jezik";
        }
        #endregion

        #region Columns
        public string VrstaSmjestajneJediniceVrstaSmjestajneJedinice { get; set; }
        public string VrstaSmjestajneJediniceVrstaSmjestajnogObjekta { get; set; }
        public string VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta { get; set; }
        public bool? VrstaSmjestajneJediniceAktivnost { get; set; }
        public string VrstaSmjestajneJediniceJezik { get; private set; }
        public string VrstaSmjestajneJediniceNaziv { get; set; }
        public string VrstaSmjestajneJediniceOpis { get; set; }
        #endregion

        #region Entities
		public VrstaSmjestajnogObjekta VrstaSmjestajnogObjekta
        {
            get { return EntityContext<VrstaSmjestajnogObjekta>.Get(ref m_VrstaSmjestajnogObjekta, this, nameof(VrstaSmjestajnogObjekta)); }
            set { EntityContext<VrstaSmjestajnogObjekta>.Set(ref m_VrstaSmjestajnogObjekta, this, value, nameof(VrstaSmjestajnogObjekta)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaSmjestajneJedinice>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaSmjestajneJedinice>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaSmjestajneJedinice>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaSmjestajneJedinice>(columnName, queryOp, value);
        }
		public static async Task<VrstaSmjestajneJedinice> GetByPrimaryKeyAsync(string VrstaSmjestajneJediniceVrstaSmjestajneJedinice, string VrstaSmjestajneJediniceVrstaSmjestajnogObjekta, string VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta)
        {
            return await GetByPrimaryKeyAsync<VrstaSmjestajneJedinice>(VrstaSmjestajneJediniceVrstaSmjestajneJedinice, VrstaSmjestajneJediniceVrstaSmjestajnogObjekta, VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta);
        }
		public static async Task<VrstaSmjestajneJedinice> TryGetByPrimaryKeyAsync(string VrstaSmjestajneJediniceVrstaSmjestajneJedinice, string VrstaSmjestajneJediniceVrstaSmjestajnogObjekta, string VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta)
        {
            return await TryGetByPrimaryKeyAsync<VrstaSmjestajneJedinice>(VrstaSmjestajneJediniceVrstaSmjestajneJedinice, VrstaSmjestajneJediniceVrstaSmjestajnogObjekta, VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta);
        }
		#endregion
    }
}