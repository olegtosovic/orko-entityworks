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

namespace AdventureWorks.Person
{
    /// <summary>
    /// BusinessEntityAddress entity.
    /// </summary>
    public sealed partial class BusinessEntityAddress : Entity
    {
		#region Members
		private Address m_e_AddressID;
        private AddressType m_e_AddressTypeID;
        private BusinessEntity m_e_BusinessEntityID;
        #endregion
        
		#region Constructors
        static BusinessEntityAddress()
        {
            // Cache field metadata.
            EntityMeta<BusinessEntityAddress>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(AddressID), @"AddressID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(AddressTypeID), @"AddressTypeID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<BusinessEntityAddress>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_AddressID), nameof(AddressID), nameof(AdventureWorks.Person.Address.AddressID)),
                new RelationMetadata(nameof(e_AddressTypeID), nameof(AddressTypeID), nameof(AdventureWorks.Person.AddressType.AddressTypeID)),
                new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.BusinessEntity.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<BusinessEntityAddress>.HasLanguageTable = false;
            EntityMeta<BusinessEntityAddress>.TableSchema = @"Person";
            EntityMeta<BusinessEntityAddress>.TableName = @"BusinessEntityAddress";
            EntityMeta<BusinessEntityAddress>.LanguageTableSchema = null;
            EntityMeta<BusinessEntityAddress>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public int? AddressID { get; set; }
        public int? AddressTypeID { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Address e_AddressID
        {
            get { return EntityContext<Address>.Get(ref m_e_AddressID, this, nameof(e_AddressID)); }
            set { EntityContext<Address>.Set(ref m_e_AddressID, this, value, nameof(e_AddressID)); }
        }
        public AddressType e_AddressTypeID
        {
            get { return EntityContext<AddressType>.Get(ref m_e_AddressTypeID, this, nameof(e_AddressTypeID)); }
            set { EntityContext<AddressType>.Set(ref m_e_AddressTypeID, this, value, nameof(e_AddressTypeID)); }
        }
        public BusinessEntity e_BusinessEntityID
        {
            get { return EntityContext<BusinessEntity>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<BusinessEntity>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<BusinessEntityAddress>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<BusinessEntityAddress>(queryConditions);
        }
        public static async Task<IEnumerable<BusinessEntityAddress>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<BusinessEntityAddress>(columnName, queryOp, value);
        }
		public static async Task<BusinessEntityAddress> GetByPrimaryKeyAsync(int BusinessEntityID, int AddressID, int AddressTypeID)
        {
            return await GetByPrimaryKeyAsync<BusinessEntityAddress>(BusinessEntityID, AddressID, AddressTypeID);
        }
		public static async Task<BusinessEntityAddress> TryGetByPrimaryKeyAsync(int BusinessEntityID, int AddressID, int AddressTypeID)
        {
            return await TryGetByPrimaryKeyAsync<BusinessEntityAddress>(BusinessEntityID, AddressID, AddressTypeID);
        }
		#endregion
    }
}