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

namespace Orko.Watersports
{
    /// <summary>
    /// Lokacija2 entity.
    /// </summary>
    public sealed partial class Lokacija2 : Entity
    {
		#region Members
		private TipLokacije m_TipLokacije;
        #endregion
        
		#region Constructors
        static Lokacija2()
        {
            // Cache field metadata.
            EntityMeta<Lokacija2>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(LokacijaID), @"LokacijaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(LokacijaTipLokacije), @"LokacijaTipLokacije", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(LokacijaNaziv), @"LokacijaNaziv", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(LokacijaAdresa), @"LokacijaAdresa", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(LokacijaLatitude), @"LokacijaLatitude", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(LokacijaLongitude), @"LokacijaLongitude", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(LokacijaZoomLevel), @"LokacijaZoomLevel", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(LokacijaAktivnost), @"LokacijaAktivnost", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Lokacija2>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(TipLokacije), nameof(LokacijaTipLokacije), nameof(Orko.Watersports.TipLokacije.TipLokacijeTipLokacije))
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
		public TipLokacije TipLokacije
        {
            get { return EntityContext<TipLokacije>.Get(ref m_TipLokacije, this, nameof(TipLokacije)); }
            set { EntityContext<TipLokacije>.Set(ref m_TipLokacije, this, value, nameof(TipLokacije)); }
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
    }
}