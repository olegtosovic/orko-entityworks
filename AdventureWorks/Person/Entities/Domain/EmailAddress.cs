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
    /// EmailAddress entity.
    /// </summary>
    public sealed partial class EmailAddress : Entity
    {
		#region Members
		private Person m_e_BusinessEntityID;
        #endregion
        
		#region Constructors
        static EmailAddress()
        {
            // Cache field metadata.
            EntityMeta<EmailAddress>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(EmailAddressID), @"EmailAddressID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(c_EmailAddress), @"EmailAddress", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<EmailAddress>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.Person.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<EmailAddress>.HasLanguageTable = false;
            EntityMeta<EmailAddress>.TableSchema = @"Person";
            EntityMeta<EmailAddress>.TableName = @"EmailAddress";
            EntityMeta<EmailAddress>.LanguageTableSchema = null;
            EntityMeta<EmailAddress>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public int? EmailAddressID { get; private set; }
        public string c_EmailAddress { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person e_BusinessEntityID
        {
            get { return EntityContext<Person>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Person>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<EmailAddress>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<EmailAddress>(queryConditions);
        }
        public static async Task<IEnumerable<EmailAddress>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<EmailAddress>(columnName, queryOp, value);
        }
		public static async Task<EmailAddress> GetByPrimaryKeyAsync(int BusinessEntityID, int EmailAddressID)
        {
            return await GetByPrimaryKeyAsync<EmailAddress>(BusinessEntityID, EmailAddressID);
        }
		public static async Task<EmailAddress> TryGetByPrimaryKeyAsync(int BusinessEntityID, int EmailAddressID)
        {
            return await TryGetByPrimaryKeyAsync<EmailAddress>(BusinessEntityID, EmailAddressID);
        }
		#endregion
    }
}