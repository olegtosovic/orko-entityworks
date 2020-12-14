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
    /// CjenikJahte entity.
    /// </summary>
    public sealed partial class CjenikJahte : Entity
    {
		#region Members
		private Jahta m_Jahta;
        private Base.Valuta m_Valuta;
        private Base.Valuta m_Valuta1;
        #endregion
        
		#region Constructors
        static CjenikJahte()
        {
            // Cache field metadata.
            EntityMeta<CjenikJahte>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CjenikJahteID), @"CjenikJahteID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CjenikJahteJahta), @"CjenikJahteJahta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CjenikJahteOd), @"CjenikJahteOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(CjenikJahteDo), @"CjenikJahteDo", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(CjenikJahteCijena), @"CjenikJahteCijena", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(CjenikJahteValuta), @"CjenikJahteValuta", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(CjenikJahteCijena2), @"CjenikJahteCijena2", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikJahteValuta2), @"CjenikJahteValuta2", DbType.AnsiStringFixedLength, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<CjenikJahte>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Jahta), nameof(CjenikJahteJahta), nameof(Orko.GuletCroatia.Jahta.JahtaJahta)),
                new RelationMetadata(nameof(Valuta), nameof(CjenikJahteValuta), nameof(Orko.Base.Valuta.ValutaValuta)),
                new RelationMetadata(nameof(Valuta1), nameof(CjenikJahteValuta2), nameof(Orko.Base.Valuta.ValutaValuta))
			);

			// Cache table metadata.
			EntityMeta<CjenikJahte>.HasLanguageTable = false;
            EntityMeta<CjenikJahte>.TableSchema = @"GuletCroatia";
            EntityMeta<CjenikJahte>.TableName = @"CjenikJahte";
            EntityMeta<CjenikJahte>.LanguageTableSchema = null;
            EntityMeta<CjenikJahte>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CjenikJahteID { get; private set; }
        public string CjenikJahteJahta { get; set; }
        public DateTime? CjenikJahteOd { get; set; }
        public DateTime? CjenikJahteDo { get; set; }
        public decimal? CjenikJahteCijena { get; set; }
        public string CjenikJahteValuta { get; set; }
        public decimal? CjenikJahteCijena2 { get; set; }
        public string CjenikJahteValuta2 { get; set; }
        #endregion

        #region Entities
		public Jahta Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_Jahta, this, nameof(Jahta)); }
            set { EntityContext<Jahta>.Set(ref m_Jahta, this, value, nameof(Jahta)); }
        }
        public Base.Valuta Valuta
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_Valuta, this, nameof(Valuta)); }
            set { EntityContext<Base.Valuta>.Set(ref m_Valuta, this, value, nameof(Valuta)); }
        }
        public Base.Valuta Valuta1
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_Valuta1, this, nameof(Valuta1)); }
            set { EntityContext<Base.Valuta>.Set(ref m_Valuta1, this, value, nameof(Valuta1)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CjenikJahte>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CjenikJahte>(queryConditions);
        }
        public static async Task<IEnumerable<CjenikJahte>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CjenikJahte>(columnName, queryOp, value);
        }
		public static async Task<CjenikJahte> GetByPrimaryKeyAsync(int CjenikJahteID)
        {
            return await GetByPrimaryKeyAsync<CjenikJahte>(CjenikJahteID);
        }
		public static async Task<CjenikJahte> TryGetByPrimaryKeyAsync(int CjenikJahteID)
        {
            return await TryGetByPrimaryKeyAsync<CjenikJahte>(CjenikJahteID);
        }
		#endregion
    }
}