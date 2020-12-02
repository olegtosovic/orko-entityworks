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
    /// TecajnaListaValuta entity.
    /// </summary>
    public sealed partial class TecajnaListaValuta : Entity
    {
		#region Members
		private TecajnaLista m_FK_TecajnaListaValuta_TecajnaLista;
        private Valuta m_FK_TecajnaListaValuta_Valuta;
        #endregion
        
		#region Constructors
        static TecajnaListaValuta()
        {
            // Cache field metadata.
            EntityMeta<TecajnaListaValuta>.LoadColumnMetadata
			(
				new ColumnMetadata("TecajnaListaValutaTecajnaListaID", @"TecajnaListaValutaTecajnaListaID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("TecajnaListaValutaValuta", @"TecajnaListaValutaValuta", SqlDbType.Char, isPrimaryKey: true),
                new ColumnMetadata("TecajnaListaValutaRedosljed", @"TecajnaListaValutaRedosljed", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("TecajnaListaValutaJedinica", @"TecajnaListaValutaJedinica", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("TecajnaListaValutaKupovni", @"TecajnaListaValutaKupovni", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("TecajnaListaValutaSrednji", @"TecajnaListaValutaSrednji", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("TecajnaListaValutaProdajni", @"TecajnaListaValutaProdajni", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("TecajnaListaValutaUradio", @"TecajnaListaValutaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("TecajnaListaValutaDatumIzmjene", @"TecajnaListaValutaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<TecajnaListaValuta>.LoadRelationMetadata
			(
				new RelationMetadata("FK_TecajnaListaValuta_TecajnaLista", "TecajnaListaValutaTecajnaListaID", "TecajnaListaID"),
                new RelationMetadata("FK_TecajnaListaValuta_Valuta", "TecajnaListaValutaValuta", "ValutaValuta")
			);

			// Cache table metadata.
			EntityMeta<TecajnaListaValuta>.HasLanguageTable = false;
            EntityMeta<TecajnaListaValuta>.TableSchema = @"Base";
            EntityMeta<TecajnaListaValuta>.TableName = @"TecajnaListaValuta";
            EntityMeta<TecajnaListaValuta>.LanguageTableSchema = null;
            EntityMeta<TecajnaListaValuta>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? TecajnaListaValutaTecajnaListaID { get; set; }
        public string TecajnaListaValutaValuta { get; set; }
        public int? TecajnaListaValutaRedosljed { get; set; }
        public int? TecajnaListaValutaJedinica { get; set; }
        public decimal? TecajnaListaValutaKupovni { get; set; }
        public decimal? TecajnaListaValutaSrednji { get; set; }
        public decimal? TecajnaListaValutaProdajni { get; set; }
        public string TecajnaListaValutaUradio { get; set; }
        public DateTime? TecajnaListaValutaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public TecajnaLista FK_TecajnaListaValuta_TecajnaLista
        {
            get { return EntityContext<TecajnaLista>.Get(ref m_FK_TecajnaListaValuta_TecajnaLista, this, "FK_TecajnaListaValuta_TecajnaLista"); }
            set { EntityContext<TecajnaLista>.Set(ref m_FK_TecajnaListaValuta_TecajnaLista, this, value, "FK_TecajnaListaValuta_TecajnaLista"); }
        }
        public Valuta FK_TecajnaListaValuta_Valuta
        {
            get { return EntityContext<Valuta>.Get(ref m_FK_TecajnaListaValuta_Valuta, this, "FK_TecajnaListaValuta_Valuta"); }
            set { EntityContext<Valuta>.Set(ref m_FK_TecajnaListaValuta_Valuta, this, value, "FK_TecajnaListaValuta_Valuta"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TecajnaListaValuta>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TecajnaListaValuta>(queryConditions);
        }
        public static async Task<IEnumerable<TecajnaListaValuta>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TecajnaListaValuta>(columnName, queryOp, value);
        }
		public static async Task<TecajnaListaValuta> GetByPrimaryKeyAsync(int TecajnaListaValutaTecajnaListaID, string TecajnaListaValutaValuta)
        {
            return await GetByPrimaryKeyAsync<TecajnaListaValuta>(TecajnaListaValutaTecajnaListaID, TecajnaListaValutaValuta);
        }
		public static async Task<TecajnaListaValuta> TryGetByPrimaryKeyAsync(int TecajnaListaValutaTecajnaListaID, string TecajnaListaValutaValuta)
        {
            return await TryGetByPrimaryKeyAsync<TecajnaListaValuta>(TecajnaListaValutaTecajnaListaID, TecajnaListaValutaValuta);
        }
		#endregion

        #region Public methods
		public static IEnumerable<TecajnaListaValuta> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<TecajnaListaValuta>(queryConditions);
        }
        public static IEnumerable<TecajnaListaValuta> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<TecajnaListaValuta>(columnName, queryOp, value);
        }
		public static TecajnaListaValuta GetByPrimaryKey(int TecajnaListaValutaTecajnaListaID, string TecajnaListaValutaValuta)
        {
            return GetByPrimaryKey<TecajnaListaValuta>(TecajnaListaValutaTecajnaListaID, TecajnaListaValutaValuta);
        }
		public static TecajnaListaValuta TryGetByPrimaryKey(int TecajnaListaValutaTecajnaListaID, string TecajnaListaValutaValuta)
        {
            return TryGetByPrimaryKey<TecajnaListaValuta>(TecajnaListaValutaTecajnaListaID, TecajnaListaValutaValuta);
        }
        #endregion
    }
}