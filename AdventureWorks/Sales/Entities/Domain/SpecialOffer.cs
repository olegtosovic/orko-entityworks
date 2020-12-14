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
    /// SpecialOffer entity.
    /// </summary>
    public sealed partial class SpecialOffer : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static SpecialOffer()
        {
            // Cache field metadata.
            EntityMeta<SpecialOffer>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SpecialOfferID), @"SpecialOfferID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(Description), @"Description", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(DiscountPct), @"DiscountPct", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(Type), @"Type", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Category), @"Category", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(StartDate), @"StartDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(EndDate), @"EndDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(MinQty), @"MinQty", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(MaxQty), @"MaxQty", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<SpecialOffer>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<SpecialOffer>.HasLanguageTable = false;
            EntityMeta<SpecialOffer>.TableSchema = @"Sales";
            EntityMeta<SpecialOffer>.TableName = @"SpecialOffer";
            EntityMeta<SpecialOffer>.LanguageTableSchema = null;
            EntityMeta<SpecialOffer>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? SpecialOfferID { get; private set; }
        public string Description { get; set; }
        public decimal? DiscountPct { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? MinQty { get; set; }
        public int? MaxQty { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<SpecialOffer>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<SpecialOffer>(queryConditions);
        }
        public static async Task<IEnumerable<SpecialOffer>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<SpecialOffer>(columnName, queryOp, value);
        }
		public static async Task<SpecialOffer> GetByPrimaryKeyAsync(int SpecialOfferID)
        {
            return await GetByPrimaryKeyAsync<SpecialOffer>(SpecialOfferID);
        }
		public static async Task<SpecialOffer> TryGetByPrimaryKeyAsync(int SpecialOfferID)
        {
            return await TryGetByPrimaryKeyAsync<SpecialOffer>(SpecialOfferID);
        }
		#endregion
    }
}