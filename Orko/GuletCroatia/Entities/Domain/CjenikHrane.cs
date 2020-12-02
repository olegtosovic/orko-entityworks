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

namespace Orko.GuletCroatia
{
    /// <summary>
    /// CjenikHrane entity.
    /// </summary>
    public sealed partial class CjenikHrane : Entity
    {
		#region Members
		private Jahta m_FK_CjenikHrane_Jahta;
        #endregion
        
		#region Constructors
        static CjenikHrane()
        {
            // Cache field metadata.
            EntityMeta<CjenikHrane>.LoadColumnMetadata
			(
				new ColumnMetadata("CjenikHraneJahta", @"CjenikHraneJahta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("CjenikHraneTipUslugeHrane", @"CjenikHraneTipUslugeHrane", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("CjenikHraneCijena", @"CjenikHraneCijena", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("CjenikHraneValuta", @"CjenikHraneValuta", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("CjenikHraneCijena2", @"CjenikHraneCijena2", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikHraneValuta2", @"CjenikHraneValuta2", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("CjenikHraneAktivnost", @"CjenikHraneAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("CjenikHraneJezik", @"CjenikHraneJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("CjenikHraneDodatno", @"CjenikHraneDodatno", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<CjenikHrane>.LoadRelationMetadata
			(
				new RelationMetadata("FK_CjenikHrane_Jahta", "CjenikHraneJahta", "JahtaJahta")
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
		public Jahta FK_CjenikHrane_Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_FK_CjenikHrane_Jahta, this, "FK_CjenikHrane_Jahta"); }
            set { EntityContext<Jahta>.Set(ref m_FK_CjenikHrane_Jahta, this, value, "FK_CjenikHrane_Jahta"); }
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

        #region Public methods
		public static IEnumerable<CjenikHrane> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<CjenikHrane>(queryConditions);
        }
        public static IEnumerable<CjenikHrane> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<CjenikHrane>(columnName, queryOp, value);
        }
		public static CjenikHrane GetByPrimaryKey(string CjenikHraneJahta, string CjenikHraneTipUslugeHrane)
        {
            return GetByPrimaryKey<CjenikHrane>(CjenikHraneJahta, CjenikHraneTipUslugeHrane);
        }
		public static CjenikHrane TryGetByPrimaryKey(string CjenikHraneJahta, string CjenikHraneTipUslugeHrane)
        {
            return TryGetByPrimaryKey<CjenikHrane>(CjenikHraneJahta, CjenikHraneTipUslugeHrane);
        }
        #endregion
    }
}