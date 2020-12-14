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

namespace Orko.Base
{
    /// <summary>
    /// TecajnaLista entity.
    /// </summary>
    public sealed partial class TecajnaLista : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static TecajnaLista()
        {
            // Cache field metadata.
            EntityMeta<TecajnaLista>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TecajnaListaID), @"TecajnaListaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaBroj), @"TecajnaListaBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaGodina), @"TecajnaListaGodina", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaDatumOd), @"TecajnaListaDatumOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaDatumDo), @"TecajnaListaDatumDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(TecajnaListaUradio), @"TecajnaListaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaDatumIzmjene), @"TecajnaListaDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<TecajnaLista>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<TecajnaLista>.HasLanguageTable = false;
            EntityMeta<TecajnaLista>.TableSchema = @"Base";
            EntityMeta<TecajnaLista>.TableName = @"TecajnaLista";
            EntityMeta<TecajnaLista>.LanguageTableSchema = null;
            EntityMeta<TecajnaLista>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? TecajnaListaID { get; set; }
        public int? TecajnaListaBroj { get; set; }
        public int? TecajnaListaGodina { get; set; }
        public DateTime? TecajnaListaDatumOd { get; set; }
        public DateTime? TecajnaListaDatumDo { get; set; }
        public string TecajnaListaUradio { get; set; }
        public DateTime? TecajnaListaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TecajnaLista>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TecajnaLista>(queryConditions);
        }
        public static async Task<IEnumerable<TecajnaLista>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TecajnaLista>(columnName, queryOp, value);
        }
		public static async Task<TecajnaLista> GetByPrimaryKeyAsync(int TecajnaListaID)
        {
            return await GetByPrimaryKeyAsync<TecajnaLista>(TecajnaListaID);
        }
		public static async Task<TecajnaLista> TryGetByPrimaryKeyAsync(int TecajnaListaID)
        {
            return await TryGetByPrimaryKeyAsync<TecajnaLista>(TecajnaListaID);
        }
		#endregion
    }
}