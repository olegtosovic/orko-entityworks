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

namespace AdventureWorks.Sales
{
    /// <summary>
    /// SalesTaxRate entity.
    /// </summary>
    public sealed partial class SalesTaxRate : Entity
    {
		#region Members
		private Person.StateProvince m_e_StateProvinceID;
        #endregion
        
		#region Constructors
        static SalesTaxRate()
        {
            // Cache field metadata.
            EntityMeta<SalesTaxRate>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SalesTaxRateID), @"SalesTaxRateID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(StateProvinceID), @"StateProvinceID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TaxType), @"TaxType", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(TaxRate), @"TaxRate", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SalesTaxRate>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_StateProvinceID), nameof(StateProvinceID), nameof(AdventureWorks.Person.StateProvince.StateProvinceID))
			);

			// Cache table metadata.
			EntityMeta<SalesTaxRate>.HasLanguageTable = false;
            EntityMeta<SalesTaxRate>.TableSchema = @"Sales";
            EntityMeta<SalesTaxRate>.TableName = @"SalesTaxRate";
            EntityMeta<SalesTaxRate>.LanguageTableSchema = null;
            EntityMeta<SalesTaxRate>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SalesTaxRateID { get; private set; }
        public int? StateProvinceID { get; set; }
        public Byte? TaxType { get; set; }
        public decimal? TaxRate { get; set; }
        public string Name { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person.StateProvince e_StateProvinceID
        {
            get { return EntityContext<Person.StateProvince>.Get(ref m_e_StateProvinceID, this, nameof(e_StateProvinceID)); }
            set { EntityContext<Person.StateProvince>.Set(ref m_e_StateProvinceID, this, value, nameof(e_StateProvinceID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<SalesTaxRate>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SalesTaxRate>(queryConditions);
        }
        public static async Task<IEnumerable<SalesTaxRate>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SalesTaxRate>(columnName, queryOp, value);
        }
		public static async Task<SalesTaxRate> GetByPrimaryKeyAsync(int SalesTaxRateID)
        {
            return await GetByPrimaryKeyAsync<SalesTaxRate>(SalesTaxRateID);
        }
		public static async Task<SalesTaxRate> TryGetByPrimaryKeyAsync(int SalesTaxRateID)
        {
            return await TryGetByPrimaryKeyAsync<SalesTaxRate>(SalesTaxRateID);
        }
		#endregion
    }
}