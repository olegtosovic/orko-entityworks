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

namespace Orko.SebastianArt
{
    /// <summary>
    /// ArtikalEx entity.
    /// </summary>
    public sealed partial class ArtikalEx : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static ArtikalEx()
        {
            // Cache field metadata.
            EntityMeta<ArtikalEx>.LoadColumnMetadata
			(
				new ColumnMetadata("ArtikalExID", @"ArtikalExID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("ArtikalExAutor", @"ArtikalExAutor", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ArtikalExDimenzije", @"ArtikalExDimenzije", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ArtikalAktivnost", @"ArtikalAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("ArtikalBrojNaziv", @"ArtikalBrojNaziv", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ArtikalExJezik", @"ArtikalExJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("ArtikalExNaziv", @"ArtikalExNaziv", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("ArtikalExOpis", @"ArtikalExOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<ArtikalEx>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<ArtikalEx>.HasLanguageTable = true;
            EntityMeta<ArtikalEx>.TableSchema = @"SebastianArt";
            EntityMeta<ArtikalEx>.TableName = @"ArtikalEx";
            EntityMeta<ArtikalEx>.LanguageTableSchema = @"SebastianArt";
            EntityMeta<ArtikalEx>.LanguageTableName = @"ArtikalEx_jezik";
        }
        #endregion

        #region Columns
        public int? ArtikalExID { get; set; }
        public string ArtikalExAutor { get; set; }
        public string ArtikalExDimenzije { get; set; }
        public bool? ArtikalAktivnost { get; set; }
        public string ArtikalBrojNaziv { get; set; }
        public string ArtikalExJezik { get; private set; }
        public string ArtikalExNaziv { get; set; }
        public string ArtikalExOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<ArtikalEx>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<ArtikalEx>(queryConditions);
        }
        public static async Task<IEnumerable<ArtikalEx>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<ArtikalEx>(columnName, queryOp, value);
        }
		public static async Task<ArtikalEx> GetByPrimaryKeyAsync(int ArtikalExID)
        {
            return await GetByPrimaryKeyAsync<ArtikalEx>(ArtikalExID);
        }
		public static async Task<ArtikalEx> TryGetByPrimaryKeyAsync(int ArtikalExID)
        {
            return await TryGetByPrimaryKeyAsync<ArtikalEx>(ArtikalExID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<ArtikalEx> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<ArtikalEx>(queryConditions);
        }
        public static IEnumerable<ArtikalEx> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<ArtikalEx>(columnName, queryOp, value);
        }
		public static ArtikalEx GetByPrimaryKey(int ArtikalExID)
        {
            return GetByPrimaryKey<ArtikalEx>(ArtikalExID);
        }
		public static ArtikalEx TryGetByPrimaryKey(int ArtikalExID)
        {
            return TryGetByPrimaryKey<ArtikalEx>(ArtikalExID);
        }
        #endregion
    }
}