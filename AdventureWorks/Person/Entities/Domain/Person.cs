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
    /// Person entity.
    /// </summary>
    public sealed partial class Person : Entity
    {
		#region Members
		private BusinessEntity m_e_BusinessEntityID;
        #endregion
        
		#region Constructors
        static Person()
        {
            // Cache field metadata.
            EntityMeta<Person>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(PersonType), @"PersonType", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(NameStyle), @"NameStyle", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(Title), @"Title", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(FirstName), @"FirstName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(MiddleName), @"MiddleName", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(LastName), @"LastName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Suffix), @"Suffix", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(EmailPromotion), @"EmailPromotion", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(AdditionalContactInfo), @"AdditionalContactInfo", DbType.Xml, isRequired: false),
                new ColumnMetadata(nameof(Demographics), @"Demographics", DbType.Xml, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Person>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.BusinessEntity.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<Person>.HasLanguageTable = false;
            EntityMeta<Person>.TableSchema = @"Person";
            EntityMeta<Person>.TableName = @"Person";
            EntityMeta<Person>.LanguageTableSchema = null;
            EntityMeta<Person>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public bool? NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int? EmailPromotion { get; set; }
        public XElement AdditionalContactInfo { get; set; }
        public XElement Demographics { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public BusinessEntity e_BusinessEntityID
        {
            get { return EntityContext<BusinessEntity>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<BusinessEntity>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Person>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Person>(queryConditions);
        }
        public static async Task<IEnumerable<Person>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Person>(columnName, queryOp, value);
        }
		public static async Task<Person> GetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await GetByPrimaryKeyAsync<Person>(BusinessEntityID);
        }
		public static async Task<Person> TryGetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await TryGetByPrimaryKeyAsync<Person>(BusinessEntityID);
        }
		#endregion
    }
}