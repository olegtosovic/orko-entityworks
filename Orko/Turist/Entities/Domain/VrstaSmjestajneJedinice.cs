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
    /// VrstaSmjestajneJedinice entity.
    /// </summary>
    public sealed partial class VrstaSmjestajneJedinice : Entity
    {
		#region Members
		private VrstaSmjestajnogObjekta m_FK_VrstaSmjestajneJedinice_VrstaSmjestajnogObjekta;
        #endregion
        
		#region Constructors
        static VrstaSmjestajneJedinice()
        {
            // Cache field metadata.
            EntityMeta<VrstaSmjestajneJedinice>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaSmjestajneJediniceVrstaSmjestajneJedinice", @"VrstaSmjestajneJediniceVrstaSmjestajneJedinice", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaSmjestajneJediniceVrstaSmjestajnogObjekta", @"VrstaSmjestajneJediniceVrstaSmjestajnogObjekta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta", @"VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaSmjestajneJediniceAktivnost", @"VrstaSmjestajneJediniceAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaSmjestajneJediniceJezik", @"VrstaSmjestajneJediniceJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaSmjestajneJediniceNaziv", @"VrstaSmjestajneJediniceNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("VrstaSmjestajneJediniceOpis", @"VrstaSmjestajneJediniceOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaSmjestajneJedinice>.LoadRelationMetadata
			(
				new RelationMetadata("FK_VrstaSmjestajneJedinice_VrstaSmjestajnogObjekta", "VrstaSmjestajneJediniceVrstaSmjestajnogObjekta", "VrstaSmjestajnogObjektaVrstaSmjestajnogObjekta"),
                new RelationMetadata("FK_VrstaSmjestajneJedinice_VrstaSmjestajnogObjekta", "VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta", "VrstaSmjestajnogObjektaSkupinaSmjestajnogObjekta")
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
		public VrstaSmjestajnogObjekta FK_VrstaSmjestajneJedinice_VrstaSmjestajnogObjekta
        {
            get { return EntityContext<VrstaSmjestajnogObjekta>.Get(ref m_FK_VrstaSmjestajneJedinice_VrstaSmjestajnogObjekta, this, "FK_VrstaSmjestajneJedinice_VrstaSmjestajnogObjekta"); }
            set { EntityContext<VrstaSmjestajnogObjekta>.Set(ref m_FK_VrstaSmjestajneJedinice_VrstaSmjestajnogObjekta, this, value, "FK_VrstaSmjestajneJedinice_VrstaSmjestajnogObjekta"); }
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

        #region Public methods
		public static IEnumerable<VrstaSmjestajneJedinice> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaSmjestajneJedinice>(queryConditions);
        }
        public static IEnumerable<VrstaSmjestajneJedinice> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaSmjestajneJedinice>(columnName, queryOp, value);
        }
		public static VrstaSmjestajneJedinice GetByPrimaryKey(string VrstaSmjestajneJediniceVrstaSmjestajneJedinice, string VrstaSmjestajneJediniceVrstaSmjestajnogObjekta, string VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta)
        {
            return GetByPrimaryKey<VrstaSmjestajneJedinice>(VrstaSmjestajneJediniceVrstaSmjestajneJedinice, VrstaSmjestajneJediniceVrstaSmjestajnogObjekta, VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta);
        }
		public static VrstaSmjestajneJedinice TryGetByPrimaryKey(string VrstaSmjestajneJediniceVrstaSmjestajneJedinice, string VrstaSmjestajneJediniceVrstaSmjestajnogObjekta, string VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta)
        {
            return TryGetByPrimaryKey<VrstaSmjestajneJedinice>(VrstaSmjestajneJediniceVrstaSmjestajneJedinice, VrstaSmjestajneJediniceVrstaSmjestajnogObjekta, VrstaSmjestajneJediniceSkupinaSmjestajnogObjekta);
        }
        #endregion
    }
}