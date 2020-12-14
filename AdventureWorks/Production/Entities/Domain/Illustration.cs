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

namespace AdventureWorks.Production
{
    /// <summary>
    /// Illustration entity.
    /// </summary>
    public sealed partial class Illustration : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Illustration()
        {
            // Cache field metadata.
            EntityMeta<Illustration>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(IllustrationID), @"IllustrationID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(Diagram), @"Diagram", DbType.Xml, isRequired: false),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Illustration>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Illustration>.HasLanguageTable = false;
            EntityMeta<Illustration>.TableSchema = @"Production";
            EntityMeta<Illustration>.TableName = @"Illustration";
            EntityMeta<Illustration>.LanguageTableSchema = null;
            EntityMeta<Illustration>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? IllustrationID { get; private set; }
        public XElement Diagram { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Illustration>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Illustration>(queryConditions);
        }
        public static async Task<IEnumerable<Illustration>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Illustration>(columnName, queryOp, value);
        }
		public static async Task<Illustration> GetByPrimaryKeyAsync(int IllustrationID)
        {
            return await GetByPrimaryKeyAsync<Illustration>(IllustrationID);
        }
		public static async Task<Illustration> TryGetByPrimaryKeyAsync(int IllustrationID)
        {
            return await TryGetByPrimaryKeyAsync<Illustration>(IllustrationID);
        }
		#endregion
    }
}