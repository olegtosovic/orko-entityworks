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

namespace AdventureWorks.Dbo
{
    /// <summary>
    /// AWBuildVersion entity.
    /// </summary>
    public sealed partial class AWBuildVersion : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static AWBuildVersion()
        {
            // Cache field metadata.
            EntityMeta<AWBuildVersion>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(SystemInformationID), @"SystemInformationID", DbType.Byte, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(DatabaseVersion), @"Database Version", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VersionDate), @"VersionDate", DbType.DateTime, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<AWBuildVersion>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<AWBuildVersion>.HasLanguageTable = false;
            EntityMeta<AWBuildVersion>.TableSchema = @"dbo";
            EntityMeta<AWBuildVersion>.TableName = @"AWBuildVersion";
            EntityMeta<AWBuildVersion>.LanguageTableSchema = null;
            EntityMeta<AWBuildVersion>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public Byte? SystemInformationID { get; private set; }
        public string DatabaseVersion { get; set; }
        public DateTime? VersionDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<AWBuildVersion>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<AWBuildVersion>(queryConditions);
        }
        public static async Task<IEnumerable<AWBuildVersion>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<AWBuildVersion>(columnName, queryOp, value);
        }
		public static async Task<AWBuildVersion> GetByPrimaryKeyAsync(Byte SystemInformationID)
        {
            return await GetByPrimaryKeyAsync<AWBuildVersion>(SystemInformationID);
        }
		public static async Task<AWBuildVersion> TryGetByPrimaryKeyAsync(Byte SystemInformationID)
        {
            return await TryGetByPrimaryKeyAsync<AWBuildVersion>(SystemInformationID);
        }
		#endregion
    }
}