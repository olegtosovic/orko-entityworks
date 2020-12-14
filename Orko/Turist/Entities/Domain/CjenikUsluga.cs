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
    /// CjenikUsluga entity.
    /// </summary>
    public sealed partial class CjenikUsluga : Entity
    {
		#region Members
		private Cjenik m_Cjenik;
        private VrstaUsluge m_VrstaUsluge;
        #endregion
        
		#region Constructors
        static CjenikUsluga()
        {
            // Cache field metadata.
            EntityMeta<CjenikUsluga>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CjenikUslugaID), @"CjenikUslugaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CjenikUslugaProtokolID), @"CjenikUslugaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(CjenikUslugaVrstaUsluge), @"CjenikUslugaVrstaUsluge", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(CjenikUslugaPredmetPopusta), @"CjenikUslugaPredmetPopusta", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(CjenikUslugaIznos), @"CjenikUslugaIznos", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(CjenikUslugaAlotmanskiIznos), @"CjenikUslugaAlotmanskiIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikUslugaVrijediOd), @"CjenikUslugaVrijediOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(CjenikUslugaUradio), @"CjenikUslugaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CjenikUslugaDatumIzmjene), @"CjenikUslugaDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<CjenikUsluga>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Cjenik), nameof(CjenikUslugaProtokolID), nameof(Orko.Turist.Cjenik.CjenikProtokolID)),
                new RelationMetadata(nameof(VrstaUsluge), nameof(CjenikUslugaVrstaUsluge), nameof(Orko.Turist.VrstaUsluge.VrstaUslugeVrstaUsluge))
			);

			// Cache table metadata.
			EntityMeta<CjenikUsluga>.HasLanguageTable = false;
            EntityMeta<CjenikUsluga>.TableSchema = @"Turist";
            EntityMeta<CjenikUsluga>.TableName = @"CjenikUsluga";
            EntityMeta<CjenikUsluga>.LanguageTableSchema = null;
            EntityMeta<CjenikUsluga>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CjenikUslugaID { get; private set; }
        public int? CjenikUslugaProtokolID { get; set; }
        public int? CjenikUslugaVrstaUsluge { get; set; }
        public bool? CjenikUslugaPredmetPopusta { get; set; }
        public decimal? CjenikUslugaIznos { get; set; }
        public decimal? CjenikUslugaAlotmanskiIznos { get; set; }
        public DateTime? CjenikUslugaVrijediOd { get; set; }
        public string CjenikUslugaUradio { get; set; }
        public DateTime? CjenikUslugaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public Cjenik Cjenik
        {
            get { return EntityContext<Cjenik>.Get(ref m_Cjenik, this, nameof(Cjenik)); }
            set { EntityContext<Cjenik>.Set(ref m_Cjenik, this, value, nameof(Cjenik)); }
        }
        public VrstaUsluge VrstaUsluge
        {
            get { return EntityContext<VrstaUsluge>.Get(ref m_VrstaUsluge, this, nameof(VrstaUsluge)); }
            set { EntityContext<VrstaUsluge>.Set(ref m_VrstaUsluge, this, value, nameof(VrstaUsluge)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CjenikUsluga>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CjenikUsluga>(queryConditions);
        }
        public static async Task<IEnumerable<CjenikUsluga>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CjenikUsluga>(columnName, queryOp, value);
        }
		public static async Task<CjenikUsluga> GetByPrimaryKeyAsync(int CjenikUslugaID)
        {
            return await GetByPrimaryKeyAsync<CjenikUsluga>(CjenikUslugaID);
        }
		public static async Task<CjenikUsluga> TryGetByPrimaryKeyAsync(int CjenikUslugaID)
        {
            return await TryGetByPrimaryKeyAsync<CjenikUsluga>(CjenikUslugaID);
        }
		#endregion
    }
}