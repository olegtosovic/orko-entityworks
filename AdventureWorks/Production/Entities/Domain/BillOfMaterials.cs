// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    /// <summary>
    /// BillOfMaterials entity.
    /// </summary>
    public sealed partial class BillOfMaterials : Entity
    {
		#region Members
		private Product m_e_ComponentID;
        private Product m_e_ProductAssemblyID;
        private UnitMeasure m_e_UnitMeasureCode;
        #endregion
        
		#region Constructors
        static BillOfMaterials()
        {
            // Cache field metadata.
            EntityMeta<BillOfMaterials>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BillOfMaterialsID), @"BillOfMaterialsID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(ProductAssemblyID), @"ProductAssemblyID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(ComponentID), @"ComponentID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(StartDate), @"StartDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(EndDate), @"EndDate", DbType.DateTime, isRequired: false),
                new ColumnMetadata(nameof(UnitMeasureCode), @"UnitMeasureCode", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(BOMLevel), @"BOMLevel", DbType.Int16, isRequired: true),
                new ColumnMetadata(nameof(PerAssemblyQty), @"PerAssemblyQty", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<BillOfMaterials>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ComponentID), nameof(ComponentID), nameof(AdventureWorks.Production.Product.ProductID)),
                new RelationMetadata(nameof(e_ProductAssemblyID), nameof(ProductAssemblyID), nameof(AdventureWorks.Production.Product.ProductID)),
                new RelationMetadata(nameof(e_UnitMeasureCode), nameof(UnitMeasureCode), nameof(AdventureWorks.Production.UnitMeasure.UnitMeasureCode))
			);

			// Cache table metadata.
			EntityMeta<BillOfMaterials>.HasLanguageTable = false;
            EntityMeta<BillOfMaterials>.TableSchema = @"Production";
            EntityMeta<BillOfMaterials>.TableName = @"BillOfMaterials";
            EntityMeta<BillOfMaterials>.LanguageTableSchema = null;
            EntityMeta<BillOfMaterials>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BillOfMaterialsID { get; private set; }
        public int? ProductAssemblyID { get; set; }
        public int? ComponentID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UnitMeasureCode { get; set; }
        public short? BOMLevel { get; set; }
        public decimal? PerAssemblyQty { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Product e_ComponentID
        {
            get { return EntityContext<Product>.Get(ref m_e_ComponentID, this, nameof(e_ComponentID)); }
            set { EntityContext<Product>.Set(ref m_e_ComponentID, this, value, nameof(e_ComponentID)); }
        }
        public Product e_ProductAssemblyID
        {
            get { return EntityContext<Product>.Get(ref m_e_ProductAssemblyID, this, nameof(e_ProductAssemblyID)); }
            set { EntityContext<Product>.Set(ref m_e_ProductAssemblyID, this, value, nameof(e_ProductAssemblyID)); }
        }
        public UnitMeasure e_UnitMeasureCode
        {
            get { return EntityContext<UnitMeasure>.Get(ref m_e_UnitMeasureCode, this, nameof(e_UnitMeasureCode)); }
            set { EntityContext<UnitMeasure>.Set(ref m_e_UnitMeasureCode, this, value, nameof(e_UnitMeasureCode)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<BillOfMaterials>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<BillOfMaterials>(queryConditions);
        }
        public static async Task<IEnumerable<BillOfMaterials>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<BillOfMaterials>(columnName, queryOp, value);
        }
		public static async Task<BillOfMaterials> GetByPrimaryKeyAsync(int BillOfMaterialsID)
        {
            return await GetByPrimaryKeyAsync<BillOfMaterials>(BillOfMaterialsID);
        }
		public static async Task<BillOfMaterials> TryGetByPrimaryKeyAsync(int BillOfMaterialsID)
        {
            return await TryGetByPrimaryKeyAsync<BillOfMaterials>(BillOfMaterialsID);
        }
		#endregion
    }
}