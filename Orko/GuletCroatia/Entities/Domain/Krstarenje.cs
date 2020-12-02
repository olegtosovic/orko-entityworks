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
				new ColumnMetadata("KrstarenjeKrstarenje", @"KrstarenjeKrstarenje", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("KrstarenjeSlug", @"KrstarenjeSlug", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("KrstarenjeHeaderImage", @"KrstarenjeHeaderImage", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("KrstarenjeThumbImage", @"KrstarenjeThumbImage", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("KrstarenjeBrojDana", @"KrstarenjeBrojDana", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("KrstarenjeAktivnost", @"KrstarenjeAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("KrstarenjeJezik", @"KrstarenjeJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("KrstarenjeNaziv", @"KrstarenjeNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("KrstarenjeUvodNaslov", @"KrstarenjeUvodNaslov", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("KrstarenjeUvodTekst", @"KrstarenjeUvodTekst", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("KrstarenjeIskrcajTekst", @"KrstarenjeIskrcajTekst", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("KrstarenjeMetaTitle", @"KrstarenjeMetaTitle", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("KrstarenjeMetaDescription", @"KrstarenjeMetaDescription", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
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

        #region Public methods
		public static IEnumerable<Krstarenje> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Krstarenje>(queryConditions);
        }
        public static IEnumerable<Krstarenje> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Krstarenje>(columnName, queryOp, value);
        }
		public static Krstarenje GetByPrimaryKey(string KrstarenjeKrstarenje)
        {
            return GetByPrimaryKey<Krstarenje>(KrstarenjeKrstarenje);
        }
		public static Krstarenje TryGetByPrimaryKey(string KrstarenjeKrstarenje)
        {
            return TryGetByPrimaryKey<Krstarenje>(KrstarenjeKrstarenje);
        }
        public static Krstarenje GetByUnique1(string KrstarenjeSlug)
        {
            return GetByCallingParameters<Krstarenje>(KrstarenjeSlug);
        }
		public static Krstarenje TryGetByUnique1(string KrstarenjeSlug)
        {
            return TryGetByCallingParameters<Krstarenje>(KrstarenjeSlug);
        }
        #endregion
    }
}