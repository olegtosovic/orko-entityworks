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
    /// TecajnaListaValuta entity.
    /// </summary>
    public sealed partial class TecajnaListaValuta : Entity
    {
		#region Members
		private TecajnaLista m_TecajnaLista;
        private Valuta m_Valuta;
        #endregion
        
		#region Constructors
        static TecajnaListaValuta()
        {
            // Cache field metadata.
            EntityMeta<TecajnaListaValuta>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TecajnaListaValutaTecajnaListaID), @"TecajnaListaValutaTecajnaListaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaValutaValuta), @"TecajnaListaValutaValuta", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaValutaRedosljed), @"TecajnaListaValutaRedosljed", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaValutaJedinica), @"TecajnaListaValutaJedinica", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaValutaKupovni), @"TecajnaListaValutaKupovni", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaValutaSrednji), @"TecajnaListaValutaSrednji", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaValutaProdajni), @"TecajnaListaValutaProdajni", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaValutaUradio), @"TecajnaListaValutaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(TecajnaListaValutaDatumIzmjene), @"TecajnaListaValutaDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<TecajnaListaValuta>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(TecajnaLista), nameof(TecajnaListaValutaTecajnaListaID), nameof(Orko.Base.TecajnaLista.TecajnaListaID)),
                new RelationMetadata(nameof(Valuta), nameof(TecajnaListaValutaValuta), nameof(Orko.Base.Valuta.ValutaValuta))
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
		public TecajnaLista TecajnaLista
        {
            get { return EntityContext<TecajnaLista>.Get(ref m_TecajnaLista, this, nameof(TecajnaLista)); }
            set { EntityContext<TecajnaLista>.Set(ref m_TecajnaLista, this, value, nameof(TecajnaLista)); }
        }
        public Valuta Valuta
        {
            get { return EntityContext<Valuta>.Get(ref m_Valuta, this, nameof(Valuta)); }
            set { EntityContext<Valuta>.Set(ref m_Valuta, this, value, nameof(Valuta)); }
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
    }
}