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

namespace Orko.Accomodation
{
    /// <summary>
    /// Cjenik entity.
    /// </summary>
    public sealed partial class Cjenik : Entity
    {
		#region Members
		private SmjestajnaJedinica m_FK_Cjenik_SmjestajnaJedinica;
        #endregion
        
		#region Constructors
        static Cjenik()
        {
            // Cache field metadata.
            EntityMeta<Cjenik>.LoadColumnMetadata
			(
				new ColumnMetadata("CjenikID", @"CjenikID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("CjenikSmjestajnaJedinicaID", @"CjenikSmjestajnaJedinicaID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("CjenikPeriodOd", @"CjenikPeriodOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("CjenikPeriodDo", @"CjenikPeriodDo", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("CjenikIznosHRK", @"CjenikIznosHRK", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikIznosEUR", @"CjenikIznosEUR", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikIznosGBP", @"CjenikIznosGBP", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikIznosUSD", @"CjenikIznosUSD", SqlDbType.Decimal, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Cjenik>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Cjenik_SmjestajnaJedinica", "CjenikSmjestajnaJedinicaID", "SmjestajnaJedinicaID")
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
		public SmjestajnaJedinica FK_Cjenik_SmjestajnaJedinica
        {
            get { return EntityContext<SmjestajnaJedinica>.Get(ref m_FK_Cjenik_SmjestajnaJedinica, this, "FK_Cjenik_SmjestajnaJedinica"); }
            set { EntityContext<SmjestajnaJedinica>.Set(ref m_FK_Cjenik_SmjestajnaJedinica, this, value, "FK_Cjenik_SmjestajnaJedinica"); }
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

        #region Public methods
		public static IEnumerable<Cjenik> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Cjenik>(queryConditions);
        }
        public static IEnumerable<Cjenik> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Cjenik>(columnName, queryOp, value);
        }
		public static Cjenik GetByPrimaryKey(int CjenikID)
        {
            return GetByPrimaryKey<Cjenik>(CjenikID);
        }
		public static Cjenik TryGetByPrimaryKey(int CjenikID)
        {
            return TryGetByPrimaryKey<Cjenik>(CjenikID);
        }
        public static Cjenik GetByUnique1(int CjenikSmjestajnaJedinicaID, DateTime CjenikPeriodOd, DateTime CjenikPeriodDo)
        {
            return GetByCallingParameters<Cjenik>(CjenikSmjestajnaJedinicaID, CjenikPeriodOd, CjenikPeriodDo);
        }
		public static Cjenik TryGetByUnique1(int CjenikSmjestajnaJedinicaID, DateTime CjenikPeriodOd, DateTime CjenikPeriodDo)
        {
            return TryGetByCallingParameters<Cjenik>(CjenikSmjestajnaJedinicaID, CjenikPeriodOd, CjenikPeriodDo);
        }
        #endregion
    }
}