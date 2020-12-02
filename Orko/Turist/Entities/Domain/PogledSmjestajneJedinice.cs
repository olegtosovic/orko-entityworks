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

namespace Orko.Turist
{
    /// <summary>
    /// PogledSmjestajneJedinice entity.
    /// </summary>
    public sealed partial class PogledSmjestajneJedinice : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static PogledSmjestajneJedinice()
        {
            // Cache field metadata.
            EntityMeta<PogledSmjestajneJedinice>.LoadColumnMetadata
			(
				new ColumnMetadata("PogledSmjestajneJedinicePogledSmjestajneJedinice", @"PogledSmjestajneJedinicePogledSmjestajneJedinice", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("PogledSmjestajneJediniceAktivnost", @"PogledSmjestajneJediniceAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("PogledSmjestajneJediniceJezik", @"PogledSmjestajneJediniceJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("PogledSmjestajneJediniceNaziv", @"PogledSmjestajneJediniceNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<PogledSmjestajneJedinice>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<PogledSmjestajneJedinice>.HasLanguageTable = true;
            EntityMeta<PogledSmjestajneJedinice>.TableSchema = @"Turist";
            EntityMeta<PogledSmjestajneJedinice>.TableName = @"PogledSmjestajneJedinice";
            EntityMeta<PogledSmjestajneJedinice>.LanguageTableSchema = @"Turist";
            EntityMeta<PogledSmjestajneJedinice>.LanguageTableName = @"PogledSmjestajneJedinice_jezik";
        }
        #endregion

        #region Columns
        public string PogledSmjestajneJedinicePogledSmjestajneJedinice { get; set; }
        public bool? PogledSmjestajneJediniceAktivnost { get; set; }
        public string PogledSmjestajneJediniceJezik { get; private set; }
        public string PogledSmjestajneJediniceNaziv { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<PogledSmjestajneJedinice>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<PogledSmjestajneJedinice>(queryConditions);
        }
        public static async Task<IEnumerable<PogledSmjestajneJedinice>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<PogledSmjestajneJedinice>(columnName, queryOp, value);
        }
		public static async Task<PogledSmjestajneJedinice> GetByPrimaryKeyAsync(string PogledSmjestajneJedinicePogledSmjestajneJedinice)
        {
            return await GetByPrimaryKeyAsync<PogledSmjestajneJedinice>(PogledSmjestajneJedinicePogledSmjestajneJedinice);
        }
		public static async Task<PogledSmjestajneJedinice> TryGetByPrimaryKeyAsync(string PogledSmjestajneJedinicePogledSmjestajneJedinice)
        {
            return await TryGetByPrimaryKeyAsync<PogledSmjestajneJedinice>(PogledSmjestajneJedinicePogledSmjestajneJedinice);
        }
		#endregion

        #region Public methods
		public static IEnumerable<PogledSmjestajneJedinice> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<PogledSmjestajneJedinice>(queryConditions);
        }
        public static IEnumerable<PogledSmjestajneJedinice> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<PogledSmjestajneJedinice>(columnName, queryOp, value);
        }
		public static PogledSmjestajneJedinice GetByPrimaryKey(string PogledSmjestajneJedinicePogledSmjestajneJedinice)
        {
            return GetByPrimaryKey<PogledSmjestajneJedinice>(PogledSmjestajneJedinicePogledSmjestajneJedinice);
        }
		public static PogledSmjestajneJedinice TryGetByPrimaryKey(string PogledSmjestajneJedinicePogledSmjestajneJedinice)
        {
            return TryGetByPrimaryKey<PogledSmjestajneJedinice>(PogledSmjestajneJedinicePogledSmjestajneJedinice);
        }
        #endregion
    }
}