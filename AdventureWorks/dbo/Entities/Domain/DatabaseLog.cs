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

namespace AdventureWorks.Dbo
{
    /// <summary>
    /// DatabaseLog entity.
    /// </summary>
    public sealed partial class DatabaseLog : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static DatabaseLog()
        {
            // Cache field metadata.
            EntityMeta<DatabaseLog>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(DatabaseLogID), @"DatabaseLogID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(PostTime), @"PostTime", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(DatabaseUser), @"DatabaseUser", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Event), @"Event", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Schema), @"Schema", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(Object), @"Object", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(TSQL), @"TSQL", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(XmlEvent), @"XmlEvent", DbType.Xml, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<DatabaseLog>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<DatabaseLog>.HasLanguageTable = false;
            EntityMeta<DatabaseLog>.TableSchema = @"dbo";
            EntityMeta<DatabaseLog>.TableName = @"DatabaseLog";
            EntityMeta<DatabaseLog>.LanguageTableSchema = null;
            EntityMeta<DatabaseLog>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? DatabaseLogID { get; private set; }
        public DateTime? PostTime { get; set; }
        public string DatabaseUser { get; set; }
        public string Event { get; set; }
        public string Schema { get; set; }
        public string Object { get; set; }
        public string TSQL { get; set; }
        public XElement XmlEvent { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods
		public static async Task<IEnumerable<DatabaseLog>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<DatabaseLog>(queryConditions);
        }
        public static async Task<IEnumerable<DatabaseLog>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<DatabaseLog>(columnName, queryOp, value);
        }
		public static async Task<DatabaseLog> GetByPrimaryKeyAsync(int DatabaseLogID)
        {
            return await GetByPrimaryKeyAsync<DatabaseLog>(DatabaseLogID);
        }
		public static async Task<DatabaseLog> TryGetByPrimaryKeyAsync(int DatabaseLogID)
        {
            return await TryGetByPrimaryKeyAsync<DatabaseLog>(DatabaseLogID);
        }
		#endregion
    }
}