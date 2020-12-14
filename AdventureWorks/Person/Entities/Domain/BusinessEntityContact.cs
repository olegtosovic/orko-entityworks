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

namespace AdventureWorks.Person
{
    /// <summary>
    /// BusinessEntityContact entity.
    /// </summary>
    public sealed partial class BusinessEntityContact : Entity
    {
		#region Members
		private BusinessEntity m_e_BusinessEntityID;
        private ContactType m_e_ContactTypeID;
        private Person m_e_PersonID;
        #endregion
        
		#region Constructors
        static BusinessEntityContact()
        {
            // Cache field metadata.
            EntityMeta<BusinessEntityContact>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PersonID), @"PersonID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ContactTypeID), @"ContactTypeID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<BusinessEntityContact>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.BusinessEntity.BusinessEntityID)),
                new RelationMetadata(nameof(e_ContactTypeID), nameof(ContactTypeID), nameof(AdventureWorks.Person.ContactType.ContactTypeID)),
                new RelationMetadata(nameof(e_PersonID), nameof(PersonID), nameof(AdventureWorks.Person.Person.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<BusinessEntityContact>.HasLanguageTable = false;
            EntityMeta<BusinessEntityContact>.TableSchema = @"Person";
            EntityMeta<BusinessEntityContact>.TableName = @"BusinessEntityContact";
            EntityMeta<BusinessEntityContact>.LanguageTableSchema = null;
            EntityMeta<BusinessEntityContact>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public int? PersonID { get; set; }
        public int? ContactTypeID { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public BusinessEntity e_BusinessEntityID
        {
            get { return EntityContext<BusinessEntity>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<BusinessEntity>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        public ContactType e_ContactTypeID
        {
            get { return EntityContext<ContactType>.Get(ref m_e_ContactTypeID, this, nameof(e_ContactTypeID)); }
            set { EntityContext<ContactType>.Set(ref m_e_ContactTypeID, this, value, nameof(e_ContactTypeID)); }
        }
        public Person e_PersonID
        {
            get { return EntityContext<Person>.Get(ref m_e_PersonID, this, nameof(e_PersonID)); }
            set { EntityContext<Person>.Set(ref m_e_PersonID, this, value, nameof(e_PersonID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<BusinessEntityContact>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<BusinessEntityContact>(queryConditions);
        }
        public static async Task<IEnumerable<BusinessEntityContact>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<BusinessEntityContact>(columnName, queryOp, value);
        }
		public static async Task<BusinessEntityContact> GetByPrimaryKeyAsync(int BusinessEntityID, int PersonID, int ContactTypeID)
        {
            return await GetByPrimaryKeyAsync<BusinessEntityContact>(BusinessEntityID, PersonID, ContactTypeID);
        }
		public static async Task<BusinessEntityContact> TryGetByPrimaryKeyAsync(int BusinessEntityID, int PersonID, int ContactTypeID)
        {
            return await TryGetByPrimaryKeyAsync<BusinessEntityContact>(BusinessEntityID, PersonID, ContactTypeID);
        }
		#endregion
    }
}