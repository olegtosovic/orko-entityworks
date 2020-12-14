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

namespace AdventureWorks.Sales
{
    /// <summary>
    /// SpecialOfferProduct entity.
    /// </summary>
    public sealed partial class SpecialOfferProduct : Entity
    {
		#region Members
		private Production.Product m_e_ProductID;
        private SpecialOffer m_e_SpecialOfferID;
        #endregion
        
		#region Constructors
        static SpecialOfferProduct()
        {
            // Cache field metadata.
            EntityMeta<SpecialOfferProduct>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SpecialOfferID), @"SpecialOfferID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ProductID), @"ProductID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SpecialOfferProduct>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_ProductID), nameof(ProductID), nameof(AdventureWorks.Production.Product.ProductID)),
                new RelationMetadata(nameof(e_SpecialOfferID), nameof(SpecialOfferID), nameof(AdventureWorks.Sales.SpecialOffer.SpecialOfferID))
			);

			// Cache table metadata.
			EntityMeta<SpecialOfferProduct>.HasLanguageTable = false;
            EntityMeta<SpecialOfferProduct>.TableSchema = @"Sales";
            EntityMeta<SpecialOfferProduct>.TableName = @"SpecialOfferProduct";
            EntityMeta<SpecialOfferProduct>.LanguageTableSchema = null;
            EntityMeta<SpecialOfferProduct>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SpecialOfferID { get; set; }
        public int? ProductID { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Production.Product e_ProductID
        {
            get { return EntityContext<Production.Product>.Get(ref m_e_ProductID, this, nameof(e_ProductID)); }
            set { EntityContext<Production.Product>.Set(ref m_e_ProductID, this, value, nameof(e_ProductID)); }
        }
        public SpecialOffer e_SpecialOfferID
        {
            get { return EntityContext<SpecialOffer>.Get(ref m_e_SpecialOfferID, this, nameof(e_SpecialOfferID)); }
            set { EntityContext<SpecialOffer>.Set(ref m_e_SpecialOfferID, this, value, nameof(e_SpecialOfferID)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SpecialOfferProduct>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SpecialOfferProduct>(queryConditions);
        }
        public static async Task<IEnumerable<SpecialOfferProduct>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SpecialOfferProduct>(columnName, queryOp, value);
        }
		public static async Task<SpecialOfferProduct> GetByPrimaryKeyAsync(int SpecialOfferID, int ProductID)
        {
            return await GetByPrimaryKeyAsync<SpecialOfferProduct>(SpecialOfferID, ProductID);
        }
		public static async Task<SpecialOfferProduct> TryGetByPrimaryKeyAsync(int SpecialOfferID, int ProductID)
        {
            return await TryGetByPrimaryKeyAsync<SpecialOfferProduct>(SpecialOfferID, ProductID);
        }
		#endregion
    }
}