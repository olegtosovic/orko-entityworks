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
    /// Address entity.
    /// </summary>
    public sealed partial class Address : Entity
    {
		#region Members
		private StateProvince m_e_StateProvinceID;
        #endregion
        
		#region Constructors
        static Address()
        {
            // Cache field metadata.
            EntityMeta<Address>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(AddressID), @"AddressID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(AddressLine1), @"AddressLine1", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(AddressLine2), @"AddressLine2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(City), @"City", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(StateProvinceID), @"StateProvinceID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(PostalCode), @"PostalCode", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(SpatialLocation), @"SpatialLocation", DbType.Binary, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Address>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_StateProvinceID), nameof(StateProvinceID), nameof(AdventureWorks.Person.StateProvince.StateProvinceID))
			);

			// Cache table metadata.
			EntityMeta<Address>.HasLanguageTable = false;
            EntityMeta<Address>.TableSchema = @"Person";
            EntityMeta<Address>.TableName = @"Address";
            EntityMeta<Address>.LanguageTableSchema = null;
            EntityMeta<Address>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? AddressID { get; private set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int? StateProvinceID { get; set; }
        public string PostalCode { get; set; }
        public Byte[] SpatialLocation { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public StateProvince e_StateProvinceID
        {
            get { return EntityContext<StateProvince>.Get(ref m_e_StateProvinceID, this, nameof(e_StateProvinceID)); }
            set { EntityContext<StateProvince>.Set(ref m_e_StateProvinceID, this, value, nameof(e_StateProvinceID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Address>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Address>(queryConditions);
        }
        public static async Task<IEnumerable<Address>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Address>(columnName, queryOp, value);
        }
		public static async Task<Address> GetByPrimaryKeyAsync(int AddressID)
        {
            return await GetByPrimaryKeyAsync<Address>(AddressID);
        }
		public static async Task<Address> TryGetByPrimaryKeyAsync(int AddressID)
        {
            return await TryGetByPrimaryKeyAsync<Address>(AddressID);
        }
		#endregion
    }
}