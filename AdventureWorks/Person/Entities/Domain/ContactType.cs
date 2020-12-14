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
    /// ContactType entity.
    /// </summary>
    public sealed partial class ContactType : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static ContactType()
        {
            // Cache field metadata.
            EntityMeta<ContactType>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ContactTypeID), @"ContactTypeID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<ContactType>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<ContactType>.HasLanguageTable = false;
            EntityMeta<ContactType>.TableSchema = @"Person";
            EntityMeta<ContactType>.TableName = @"ContactType";
            EntityMeta<ContactType>.LanguageTableSchema = null;
            EntityMeta<ContactType>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? ContactTypeID { get; private set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ContactType>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ContactType>(queryConditions);
        }
        public static async Task<IEnumerable<ContactType>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ContactType>(columnName, queryOp, value);
        }
		public static async Task<ContactType> GetByPrimaryKeyAsync(int ContactTypeID)
        {
            return await GetByPrimaryKeyAsync<ContactType>(ContactTypeID);
        }
		public static async Task<ContactType> TryGetByPrimaryKeyAsync(int ContactTypeID)
        {
            return await TryGetByPrimaryKeyAsync<ContactType>(ContactTypeID);
        }
		#endregion
    }
}