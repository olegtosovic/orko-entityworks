// Generated on 12/14/2020 9:29 PM using EntityWorks code generation tool.
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
				new ColumnMetadata(nameof(ArtikalExID), @"ArtikalExID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ArtikalExAutor), @"ArtikalExAutor", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ArtikalExDimenzije), @"ArtikalExDimenzije", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ArtikalAktivnost), @"ArtikalAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(ArtikalBrojNaziv), @"ArtikalBrojNaziv", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ArtikalExJezik), @"ArtikalExJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(ArtikalExNaziv), @"ArtikalExNaziv", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(ArtikalExOpis), @"ArtikalExOpis", DbType.String, isRequired: false, isLanguage: true)
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
    }
}