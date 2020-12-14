// Generated on 12/14/2020 9:21 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Purchasing
{
    /// <summary>
    /// Vendor entity.
    /// </summary>
    public sealed partial class Vendor : Entity
    {
		#region Members
		private Person.BusinessEntity m_e_BusinessEntityID;
        #endregion
        
		#region Constructors
        static Vendor()
        {
            // Cache field metadata.
            EntityMeta<Vendor>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(AccountNumber), @"AccountNumber", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(CreditRating), @"CreditRating", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(PreferredVendorStatus), @"PreferredVendorStatus", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(ActiveFlag), @"ActiveFlag", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(PurchasingWebServiceURL), @"PurchasingWebServiceURL", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Vendor>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.BusinessEntity.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<Vendor>.HasLanguageTable = false;
            EntityMeta<Vendor>.TableSchema = @"Purchasing";
            EntityMeta<Vendor>.TableName = @"Vendor";
            EntityMeta<Vendor>.LanguageTableSchema = null;
            EntityMeta<Vendor>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public Byte? CreditRating { get; set; }
        public string PreferredVendorStatus { get; set; }
        public string ActiveFlag { get; set; }
        public string PurchasingWebServiceURL { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person.BusinessEntity e_BusinessEntityID
        {
            get { return EntityContext<Person.BusinessEntity>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Person.BusinessEntity>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Vendor>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Vendor>(queryConditions);
        }
        public static async Task<IEnumerable<Vendor>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Vendor>(columnName, queryOp, value);
        }
		public static async Task<Vendor> GetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await GetByPrimaryKeyAsync<Vendor>(BusinessEntityID);
        }
		public static async Task<Vendor> TryGetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await TryGetByPrimaryKeyAsync<Vendor>(BusinessEntityID);
        }
		#endregion
    }
}