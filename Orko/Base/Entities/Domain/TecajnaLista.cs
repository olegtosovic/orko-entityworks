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
				new ColumnMetadata("TecajnaListaID", @"TecajnaListaID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("TecajnaListaBroj", @"TecajnaListaBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("TecajnaListaGodina", @"TecajnaListaGodina", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("TecajnaListaDatumOd", @"TecajnaListaDatumOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("TecajnaListaDatumDo", @"TecajnaListaDatumDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("TecajnaListaUradio", @"TecajnaListaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("TecajnaListaDatumIzmjene", @"TecajnaListaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
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

        #region Public methods
		public static IEnumerable<TecajnaLista> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<TecajnaLista>(queryConditions);
        }
        public static IEnumerable<TecajnaLista> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<TecajnaLista>(columnName, queryOp, value);
        }
		public static TecajnaLista GetByPrimaryKey(int TecajnaListaID)
        {
            return GetByPrimaryKey<TecajnaLista>(TecajnaListaID);
        }
		public static TecajnaLista TryGetByPrimaryKey(int TecajnaListaID)
        {
            return TryGetByPrimaryKey<TecajnaLista>(TecajnaListaID);
        }
        #endregion
    }
}