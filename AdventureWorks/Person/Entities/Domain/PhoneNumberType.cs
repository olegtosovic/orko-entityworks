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
    /// PhoneNumberType entity.
    /// </summary>
    public sealed partial class PhoneNumberType : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static PhoneNumberType()
        {
            // Cache field metadata.
            EntityMeta<PhoneNumberType>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(PhoneNumberTypeID), @"PhoneNumberTypeID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<PhoneNumberType>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<PhoneNumberType>.HasLanguageTable = false;
            EntityMeta<PhoneNumberType>.TableSchema = @"Person";
            EntityMeta<PhoneNumberType>.TableName = @"PhoneNumberType";
            EntityMeta<PhoneNumberType>.LanguageTableSchema = null;
            EntityMeta<PhoneNumberType>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? PhoneNumberTypeID { get; private set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<PhoneNumberType>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PhoneNumberType>(queryConditions);
        }
        public static async Task<IEnumerable<PhoneNumberType>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PhoneNumberType>(columnName, queryOp, value);
        }
		public static async Task<PhoneNumberType> GetByPrimaryKeyAsync(int PhoneNumberTypeID)
        {
            return await GetByPrimaryKeyAsync<PhoneNumberType>(PhoneNumberTypeID);
        }
		public static async Task<PhoneNumberType> TryGetByPrimaryKeyAsync(int PhoneNumberTypeID)
        {
            return await TryGetByPrimaryKeyAsync<PhoneNumberType>(PhoneNumberTypeID);
        }
		#endregion
    }
}