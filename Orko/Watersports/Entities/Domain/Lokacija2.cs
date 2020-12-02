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

namespace Orko.Watersports
{
    /// <summary>
    /// Lokacija2 entity.
    /// </summary>
    public sealed partial class Lokacija2 : Entity
    {
		#region Members
		private TipLokacije m_FK_Lokacija2_TipLokacije;
        #endregion
        
		#region Constructors
        static Lokacija2()
        {
            // Cache field metadata.
            EntityMeta<Lokacija2>.LoadColumnMetadata
			(
				new ColumnMetadata("LokacijaID", @"LokacijaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("LokacijaTipLokacije", @"LokacijaTipLokacije", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("LokacijaNaziv", @"LokacijaNaziv", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("LokacijaAdresa", @"LokacijaAdresa", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("LokacijaLatitude", @"LokacijaLatitude", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("LokacijaLongitude", @"LokacijaLongitude", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("LokacijaZoomLevel", @"LokacijaZoomLevel", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("LokacijaAktivnost", @"LokacijaAktivnost", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Lokacija2>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Lokacija2_TipLokacije", "LokacijaTipLokacije", "TipLokacijeTipLokacije")
			);

			// Cache table metadata.
			EntityMeta<Lokacija2>.HasLanguageTable = false;
            EntityMeta<Lokacija2>.TableSchema = @"Watersports";
            EntityMeta<Lokacija2>.TableName = @"Lokacija2";
            EntityMeta<Lokacija2>.LanguageTableSchema = null;
            EntityMeta<Lokacija2>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? LokacijaID { get; private set; }
        public string LokacijaTipLokacije { get; set; }
        public string LokacijaNaziv { get; set; }
        public string LokacijaAdresa { get; set; }
        public decimal? LokacijaLatitude { get; set; }
        public decimal? LokacijaLongitude { get; set; }
        public int? LokacijaZoomLevel { get; set; }
        public bool? LokacijaAktivnost { get; set; }
        #endregion

        #region Entities
		public TipLokacije FK_Lokacija2_TipLokacije
        {
            get { return EntityContext<TipLokacije>.Get(ref m_FK_Lokacija2_TipLokacije, this, "FK_Lokacija2_TipLokacije"); }
            set { EntityContext<TipLokacije>.Set(ref m_FK_Lokacija2_TipLokacije, this, value, "FK_Lokacija2_TipLokacije"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Lokacija2>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Lokacija2>(queryConditions);
        }
        public static async Task<IEnumerable<Lokacija2>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Lokacija2>(columnName, queryOp, value);
        }
		public static async Task<Lokacija2> GetByPrimaryKeyAsync(int LokacijaID)
        {
            return await GetByPrimaryKeyAsync<Lokacija2>(LokacijaID);
        }
		public static async Task<Lokacija2> TryGetByPrimaryKeyAsync(int LokacijaID)
        {
            return await TryGetByPrimaryKeyAsync<Lokacija2>(LokacijaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Lokacija2> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Lokacija2>(queryConditions);
        }
        public static IEnumerable<Lokacija2> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Lokacija2>(columnName, queryOp, value);
        }
		public static Lokacija2 GetByPrimaryKey(int LokacijaID)
        {
            return GetByPrimaryKey<Lokacija2>(LokacijaID);
        }
		public static Lokacija2 TryGetByPrimaryKey(int LokacijaID)
        {
            return TryGetByPrimaryKey<Lokacija2>(LokacijaID);
        }
        #endregion
    }
}