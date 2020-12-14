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
    /// AddressType entity.
    /// </summary>
    public sealed partial class AddressType : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static AddressType()
        {
            // Cache field metadata.
            EntityMeta<AddressType>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(AddressTypeID), @"AddressTypeID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(Name), @"Name", DbType.Object, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<AddressType>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<AddressType>.HasLanguageTable = false;
            EntityMeta<AddressType>.TableSchema = @"Person";
            EntityMeta<AddressType>.TableName = @"AddressType";
            EntityMeta<AddressType>.LanguageTableSchema = null;
            EntityMeta<AddressType>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? AddressTypeID { get; private set; }
        public string Name { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<AddressType>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<AddressType>(queryConditions);
        }
        public static async Task<IEnumerable<AddressType>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<AddressType>(columnName, queryOp, value);
        }
		public static async Task<AddressType> GetByPrimaryKeyAsync(int AddressTypeID)
        {
            return await GetByPrimaryKeyAsync<AddressType>(AddressTypeID);
        }
		public static async Task<AddressType> TryGetByPrimaryKeyAsync(int AddressTypeID)
        {
            return await TryGetByPrimaryKeyAsync<AddressType>(AddressTypeID);
        }
		#endregion
    }
}