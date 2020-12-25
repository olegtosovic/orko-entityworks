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
    /// Password entity.
    /// </summary>
    public sealed partial class Password : Entity
    {
		#region Members
		private Person m_e_BusinessEntityID;
        #endregion
        
		#region Constructors
        static Password()
        {
            // Cache field metadata.
            EntityMeta<Password>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isPrimaryKey: true),
                new ColumnMetadata(nameof(PasswordHash), @"PasswordHash", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(PasswordSalt), @"PasswordSalt", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Password>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.Person.Person.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<Password>.HasLanguageTable = false;
            EntityMeta<Password>.TableSchema = @"Person";
            EntityMeta<Password>.TableName = @"Password";
            EntityMeta<Password>.LanguageTableSchema = null;
            EntityMeta<Password>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? BusinessEntityID { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
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
		public static async Task<IEnumerable<Password>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Password>(queryConditions);
        }
        public static async Task<IEnumerable<Password>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Password>(columnName, queryOp, value);
        }
		public static async Task<Password> GetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await GetByPrimaryKeyAsync<Password>(BusinessEntityID);
        }
		public static async Task<Password> TryGetByPrimaryKeyAsync(int BusinessEntityID)
        {
            return await TryGetByPrimaryKeyAsync<Password>(BusinessEntityID);
        }
		#endregion
    }
}