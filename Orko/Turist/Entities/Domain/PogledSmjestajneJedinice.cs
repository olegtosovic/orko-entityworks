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
				new ColumnMetadata(nameof(PogledSmjestajneJedinicePogledSmjestajneJedinice), @"PogledSmjestajneJedinicePogledSmjestajneJedinice", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(PogledSmjestajneJediniceAktivnost), @"PogledSmjestajneJediniceAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(PogledSmjestajneJediniceJezik), @"PogledSmjestajneJediniceJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(PogledSmjestajneJediniceNaziv), @"PogledSmjestajneJediniceNaziv", DbType.String, isRequired: true, isLanguage: true)
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
    }
}