// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Sistem
{
    /// <summary>
    /// WebObjekt entity.
    /// </summary>
    public sealed partial class WebObjekt : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static WebObjekt()
        {
            // Cache field metadata.
            EntityMeta<WebObjekt>.LoadColumnMetadata
			(
				new ColumnMetadata("WebObjektID", @"WebObjektID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("WebObjektArea", @"WebObjektArea", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("WebObjektController", @"WebObjektController", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("WebObjektAkcija", @"WebObjektAkcija", SqlDbType.NVarChar, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<WebObjekt>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<WebObjekt>.HasLanguageTable = false;
            EntityMeta<WebObjekt>.TableSchema = @"Sistem";
            EntityMeta<WebObjekt>.TableName = @"WebObjekt";
            EntityMeta<WebObjekt>.LanguageTableSchema = null;
            EntityMeta<WebObjekt>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? WebObjektID { get; private set; }
        public string WebObjektArea { get; set; }
        public string WebObjektController { get; set; }
        public string WebObjektAkcija { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<WebObjekt>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<WebObjekt>(queryConditions);
        }
        public static async Task<IEnumerable<WebObjekt>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<WebObjekt>(columnName, queryOp, value);
        }
		public static async Task<WebObjekt> GetByPrimaryKeyAsync(int WebObjektID)
        {
            return await GetByPrimaryKeyAsync<WebObjekt>(WebObjektID);
        }
		public static async Task<WebObjekt> TryGetByPrimaryKeyAsync(int WebObjektID)
        {
            return await TryGetByPrimaryKeyAsync<WebObjekt>(WebObjektID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<WebObjekt> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<WebObjekt>(queryConditions);
        }
        public static IEnumerable<WebObjekt> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<WebObjekt>(columnName, queryOp, value);
        }
		public static WebObjekt GetByPrimaryKey(int WebObjektID)
        {
            return GetByPrimaryKey<WebObjekt>(WebObjektID);
        }
		public static WebObjekt TryGetByPrimaryKey(int WebObjektID)
        {
            return TryGetByPrimaryKey<WebObjekt>(WebObjektID);
        }
        #endregion
    }
}