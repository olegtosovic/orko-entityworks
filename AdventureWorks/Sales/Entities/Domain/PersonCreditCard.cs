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
    /// PersonCreditCard entity.
    /// </summary>
    public sealed partial class PersonCreditCard : Entity
    {
		#region Members
		private Person.Person m_e_BusinessEntityID;
        private CreditCard m_e_CreditCardID;
        #endregion
        
		#region Constructors
        static PersonCreditCard()
        {
            // Cache field metadata.
            EntityMeta<PersonCreditCard>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(CreditCardID), @"CreditCardID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<PersonCreditCard>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.Person.BusinessEntityID)),
                new RelationMetadata(nameof(e_CreditCardID), nameof(CreditCardID), nameof(AdventureWorks.Sales.CreditCard.CreditCardID))
			);

			// Cache table metadata.
			EntityMeta<PersonCreditCard>.HasLanguageTable = false;
            EntityMeta<PersonCreditCard>.TableSchema = @"Sales";
            EntityMeta<PersonCreditCard>.TableName = @"PersonCreditCard";
            EntityMeta<PersonCreditCard>.LanguageTableSchema = null;
            EntityMeta<PersonCreditCard>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public int? CreditCardID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Person.Person e_BusinessEntityID
        {
            get { return EntityContext<Person.Person>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Person.Person>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        public CreditCard e_CreditCardID
        {
            get { return EntityContext<CreditCard>.Get(ref m_e_CreditCardID, this, nameof(e_CreditCardID)); }
            set { EntityContext<CreditCard>.Set(ref m_e_CreditCardID, this, value, nameof(e_CreditCardID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<PersonCreditCard>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PersonCreditCard>(queryConditions);
        }
        public static async Task<IEnumerable<PersonCreditCard>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PersonCreditCard>(columnName, queryOp, value);
        }
		public static async Task<PersonCreditCard> GetByPrimaryKeyAsync(int BusinessEntityID, int CreditCardID)
        {
            return await GetByPrimaryKeyAsync<PersonCreditCard>(BusinessEntityID, CreditCardID);
        }
		public static async Task<PersonCreditCard> TryGetByPrimaryKeyAsync(int BusinessEntityID, int CreditCardID)
        {
            return await TryGetByPrimaryKeyAsync<PersonCreditCard>(BusinessEntityID, CreditCardID);
        }
		#endregion
    }
}