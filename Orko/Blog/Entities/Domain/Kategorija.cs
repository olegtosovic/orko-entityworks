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

namespace Orko.Blog
{
    /// <summary>
    /// Kategorija entity.
    /// </summary>
    public sealed partial class Kategorija : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Kategorija()
        {
            // Cache field metadata.
            EntityMeta<Kategorija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(KategorijaID), @"KategorijaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(KategorijaAktivnost), @"KategorijaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(KategorijaJezik), @"KategorijaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(KategorijaNaziv), @"KategorijaNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(KategorijaOpis), @"KategorijaOpis", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Kategorija>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Kategorija>.HasLanguageTable = true;
            EntityMeta<Kategorija>.TableSchema = @"Blog";
            EntityMeta<Kategorija>.TableName = @"Kategorija";
            EntityMeta<Kategorija>.LanguageTableSchema = @"Blog";
            EntityMeta<Kategorija>.LanguageTableName = @"Kategorija_jezik";
        }
        #endregion

        #region Columns
        public int? KategorijaID { get; private set; }
        public bool? KategorijaAktivnost { get; set; }
        public string KategorijaJezik { get; private set; }
        public string KategorijaNaziv { get; set; }
        public string KategorijaOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Kategorija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Kategorija>(queryConditions);
        }
        public static async Task<IEnumerable<Kategorija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Kategorija>(columnName, queryOp, value);
        }
		public static async Task<Kategorija> GetByPrimaryKeyAsync(int KategorijaID)
        {
            return await GetByPrimaryKeyAsync<Kategorija>(KategorijaID);
        }
		public static async Task<Kategorija> TryGetByPrimaryKeyAsync(int KategorijaID)
        {
            return await TryGetByPrimaryKeyAsync<Kategorija>(KategorijaID);
        }
		#endregion
    }
}