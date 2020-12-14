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
    /// PersonPhone entity.
    /// </summary>
    public sealed partial class PersonPhone : Entity
    {
		#region Members
		private Person m_e_BusinessEntityID;
        private PhoneNumberType m_e_PhoneNumberTypeID;
        #endregion
        
		#region Constructors
        static PersonPhone()
        {
            // Cache field metadata.
            EntityMeta<PersonPhone>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PhoneNumber), @"PhoneNumber", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(PhoneNumberTypeID), @"PhoneNumberTypeID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<PersonPhone>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.Person.BusinessEntityID)),
                new RelationMetadata(nameof(e_PhoneNumberTypeID), nameof(PhoneNumberTypeID), nameof(AdventureWorks.Person.PhoneNumberType.PhoneNumberTypeID))
			);

			// Cache table metadata.
			EntityMeta<PersonPhone>.HasLanguageTable = false;
            EntityMeta<PersonPhone>.TableSchema = @"Person";
            EntityMeta<PersonPhone>.TableName = @"PersonPhone";
            EntityMeta<PersonPhone>.LanguageTableSchema = null;
            EntityMeta<PersonPhone>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public string PhoneNumber { get; set; }
        public int? PhoneNumberTypeID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person e_BusinessEntityID
        {
            get { return EntityContext<Person>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Person>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        public PhoneNumberType e_PhoneNumberTypeID
        {
            get { return EntityContext<PhoneNumberType>.Get(ref m_e_PhoneNumberTypeID, this, nameof(e_PhoneNumberTypeID)); }
            set { EntityContext<PhoneNumberType>.Set(ref m_e_PhoneNumberTypeID, this, value, nameof(e_PhoneNumberTypeID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<PersonPhone>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PersonPhone>(queryConditions);
        }
        public static async Task<IEnumerable<PersonPhone>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PersonPhone>(columnName, queryOp, value);
        }
		public static async Task<PersonPhone> GetByPrimaryKeyAsync(int BusinessEntityID, string PhoneNumber, int PhoneNumberTypeID)
        {
            return await GetByPrimaryKeyAsync<PersonPhone>(BusinessEntityID, PhoneNumber, PhoneNumberTypeID);
        }
		public static async Task<PersonPhone> TryGetByPrimaryKeyAsync(int BusinessEntityID, string PhoneNumber, int PhoneNumberTypeID)
        {
            return await TryGetByPrimaryKeyAsync<PersonPhone>(BusinessEntityID, PhoneNumber, PhoneNumberTypeID);
        }
		#endregion
    }
}