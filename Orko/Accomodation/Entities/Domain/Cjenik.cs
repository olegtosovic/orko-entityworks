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

namespace Orko.Accomodation
{
    /// <summary>
    /// Cjenik entity.
    /// </summary>
    public sealed partial class Cjenik : Entity
    {
		#region Members
		private SmjestajnaJedinica m_SmjestajnaJedinica;
        #endregion
        
		#region Constructors
        static Cjenik()
        {
            // Cache field metadata.
            EntityMeta<Cjenik>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CjenikID), @"CjenikID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CjenikSmjestajnaJedinicaID), @"CjenikSmjestajnaJedinicaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(CjenikPeriodOd), @"CjenikPeriodOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(CjenikPeriodDo), @"CjenikPeriodDo", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(CjenikIznosHRK), @"CjenikIznosHRK", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikIznosEUR), @"CjenikIznosEUR", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikIznosGBP), @"CjenikIznosGBP", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikIznosUSD), @"CjenikIznosUSD", DbType.Decimal, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Cjenik>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(SmjestajnaJedinica), nameof(CjenikSmjestajnaJedinicaID), nameof(Orko.Accomodation.SmjestajnaJedinica.SmjestajnaJedinicaID))
			);

			// Cache table metadata.
			EntityMeta<Cjenik>.HasLanguageTable = false;
            EntityMeta<Cjenik>.TableSchema = @"Accomodation";
            EntityMeta<Cjenik>.TableName = @"Cjenik";
            EntityMeta<Cjenik>.LanguageTableSchema = null;
            EntityMeta<Cjenik>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CjenikID { get; private set; }
        public int? CjenikSmjestajnaJedinicaID { get; set; }
        public DateTime? CjenikPeriodOd { get; set; }
        public DateTime? CjenikPeriodDo { get; set; }
        public decimal? CjenikIznosHRK { get; set; }
        public decimal? CjenikIznosEUR { get; set; }
        public decimal? CjenikIznosGBP { get; set; }
        public decimal? CjenikIznosUSD { get; set; }
        #endregion

        #region Entities
		public SmjestajnaJedinica SmjestajnaJedinica
        {
            get { return EntityContext<SmjestajnaJedinica>.Get(ref m_SmjestajnaJedinica, this, nameof(SmjestajnaJedinica)); }
            set { EntityContext<SmjestajnaJedinica>.Set(ref m_SmjestajnaJedinica, this, value, nameof(SmjestajnaJedinica)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Cjenik>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Cjenik>(queryConditions);
        }
        public static async Task<IEnumerable<Cjenik>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Cjenik>(columnName, queryOp, value);
        }
		public static async Task<Cjenik> GetByPrimaryKeyAsync(int CjenikID)
        {
            return await GetByPrimaryKeyAsync<Cjenik>(CjenikID);
        }
		public static async Task<Cjenik> TryGetByPrimaryKeyAsync(int CjenikID)
        {
            return await TryGetByPrimaryKeyAsync<Cjenik>(CjenikID);
        }
		#endregion
    }
}