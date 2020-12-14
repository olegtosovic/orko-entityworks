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
    /// CjenikHrane entity.
    /// </summary>
    public sealed partial class CjenikHrane : Entity
    {
		#region Members
		private Jahta m_Jahta;
        #endregion
        
		#region Constructors
        static CjenikHrane()
        {
            // Cache field metadata.
            EntityMeta<CjenikHrane>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CjenikHraneJahta), @"CjenikHraneJahta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CjenikHraneTipUslugeHrane), @"CjenikHraneTipUslugeHrane", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CjenikHraneCijena), @"CjenikHraneCijena", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(CjenikHraneValuta), @"CjenikHraneValuta", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(CjenikHraneCijena2), @"CjenikHraneCijena2", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikHraneValuta2), @"CjenikHraneValuta2", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(CjenikHraneAktivnost), @"CjenikHraneAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(CjenikHraneJezik), @"CjenikHraneJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(CjenikHraneDodatno), @"CjenikHraneDodatno", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<CjenikHrane>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Jahta), nameof(CjenikHraneJahta), nameof(Orko.GuletCroatia.Jahta.JahtaJahta))
			);

			// Cache table metadata.
			EntityMeta<CjenikHrane>.HasLanguageTable = true;
            EntityMeta<CjenikHrane>.TableSchema = @"GuletCroatia";
            EntityMeta<CjenikHrane>.TableName = @"CjenikHrane";
            EntityMeta<CjenikHrane>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<CjenikHrane>.LanguageTableName = @"CjenikHrane_jezik";
        }
        #endregion

        #region Columns
        public string CjenikHraneJahta { get; set; }
        public string CjenikHraneTipUslugeHrane { get; set; }
        public decimal? CjenikHraneCijena { get; set; }
        public string CjenikHraneValuta { get; set; }
        public decimal? CjenikHraneCijena2 { get; set; }
        public string CjenikHraneValuta2 { get; set; }
        public bool? CjenikHraneAktivnost { get; set; }
        public string CjenikHraneJezik { get; private set; }
        public string CjenikHraneDodatno { get; set; }
        #endregion

        #region Entities
		public Jahta Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_Jahta, this, nameof(Jahta)); }
            set { EntityContext<Jahta>.Set(ref m_Jahta, this, value, nameof(Jahta)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CjenikHrane>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CjenikHrane>(queryConditions);
        }
        public static async Task<IEnumerable<CjenikHrane>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CjenikHrane>(columnName, queryOp, value);
        }
		public static async Task<CjenikHrane> GetByPrimaryKeyAsync(string CjenikHraneJahta, string CjenikHraneTipUslugeHrane)
        {
            return await GetByPrimaryKeyAsync<CjenikHrane>(CjenikHraneJahta, CjenikHraneTipUslugeHrane);
        }
		public static async Task<CjenikHrane> TryGetByPrimaryKeyAsync(string CjenikHraneJahta, string CjenikHraneTipUslugeHrane)
        {
            return await TryGetByPrimaryKeyAsync<CjenikHrane>(CjenikHraneJahta, CjenikHraneTipUslugeHrane);
        }
		#endregion
    }
}