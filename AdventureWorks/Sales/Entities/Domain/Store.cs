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
    /// Store entity.
    /// </summary>
    public sealed partial class Store : Entity
    {
		#region Members
		private Person.BusinessEntity m_e_BusinessEntityID;
        private SalesPerson m_e_SalesPersonID;
        #endregion
        
		#region Constructors
        static Store()
        {
            // Cache field metadata.
            EntityMeta<Store>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SalesPersonID), @"SalesPersonID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(Demographics), @"Demographics", DbType.Xml, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Store>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.BusinessEntity.BusinessEntityID)),
                new RelationMetadata(nameof(e_SalesPersonID), nameof(SalesPersonID), nameof(AdventureWorks.Sales.SalesPerson.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<Store>.HasLanguageTable = false;
            EntityMeta<Store>.TableSchema = @"Sales";
            EntityMeta<Store>.TableName = @"Store";
            EntityMeta<Store>.LanguageTableSchema = null;
            EntityMeta<Store>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public string Name { get; set; }
        public int? SalesPersonID { get; set; }
        public XElement Demographics { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person.BusinessEntity e_BusinessEntityID
        {
            get { return EntityContext<Person.BusinessEntity>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Person.BusinessEntity>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        public SalesPerson e_SalesPersonID
        {
            get { return EntityContext<SalesPerson>.Get(ref m_e_SalesPersonID, this, nameof(e_SalesPersonID)); }
            set { EntityContext<SalesPerson>.Set(ref m_e_SalesPersonID, this, value, nameof(e_SalesPersonID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Store>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Store>(queryConditions);
        }
        public static async Task<IEnumerable<Store>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Store>(columnName, queryOp, value);
        }
		public static async Task<Store> GetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await GetByPrimaryKeyAsync<Store>(BusinessEntityID);
        }
		public static async Task<Store> TryGetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await TryGetByPrimaryKeyAsync<Store>(BusinessEntityID);
        }
		#endregion
    }
}