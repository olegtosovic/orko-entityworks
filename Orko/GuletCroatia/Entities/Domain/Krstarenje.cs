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

namespace Orko.GuletCroatia
{
    /// <summary>
    /// Krstarenje entity.
    /// </summary>
    public sealed partial class Krstarenje : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Krstarenje()
        {
            // Cache field metadata.
            EntityMeta<Krstarenje>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(KrstarenjeKrstarenje), @"KrstarenjeKrstarenje", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KrstarenjeSlug), @"KrstarenjeSlug", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KrstarenjeHeaderImage), @"KrstarenjeHeaderImage", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(KrstarenjeThumbImage), @"KrstarenjeThumbImage", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(KrstarenjeBrojDana), @"KrstarenjeBrojDana", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(KrstarenjeAktivnost), @"KrstarenjeAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(KrstarenjeJezik), @"KrstarenjeJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(KrstarenjeNaziv), @"KrstarenjeNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(KrstarenjeUvodNaslov), @"KrstarenjeUvodNaslov", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(KrstarenjeUvodTekst), @"KrstarenjeUvodTekst", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(KrstarenjeIskrcajTekst), @"KrstarenjeIskrcajTekst", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(KrstarenjeMetaTitle), @"KrstarenjeMetaTitle", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(KrstarenjeMetaDescription), @"KrstarenjeMetaDescription", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Krstarenje>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Krstarenje>.HasLanguageTable = true;
            EntityMeta<Krstarenje>.TableSchema = @"GuletCroatia";
            EntityMeta<Krstarenje>.TableName = @"Krstarenje";
            EntityMeta<Krstarenje>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<Krstarenje>.LanguageTableName = @"Krstarenje_jezik";
        }
        #endregion

        #region Columns
        public string KrstarenjeKrstarenje { get; set; }
        public string KrstarenjeSlug { get; set; }
        public string KrstarenjeHeaderImage { get; set; }
        public string KrstarenjeThumbImage { get; set; }
        public int? KrstarenjeBrojDana { get; set; }
        public bool? KrstarenjeAktivnost { get; set; }
        public string KrstarenjeJezik { get; private set; }
        public string KrstarenjeNaziv { get; set; }
        public string KrstarenjeUvodNaslov { get; set; }
        public string KrstarenjeUvodTekst { get; set; }
        public string KrstarenjeIskrcajTekst { get; set; }
        public string KrstarenjeMetaTitle { get; set; }
        public string KrstarenjeMetaDescription { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Krstarenje>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Krstarenje>(queryConditions);
        }
        public static async Task<IEnumerable<Krstarenje>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Krstarenje>(columnName, queryOp, value);
        }
		public static async Task<Krstarenje> GetByPrimaryKeyAsync(string KrstarenjeKrstarenje)
        {
            return await GetByPrimaryKeyAsync<Krstarenje>(KrstarenjeKrstarenje);
        }
		public static async Task<Krstarenje> TryGetByPrimaryKeyAsync(string KrstarenjeKrstarenje)
        {
            return await TryGetByPrimaryKeyAsync<Krstarenje>(KrstarenjeKrstarenje);
        }
		#endregion
    }
}