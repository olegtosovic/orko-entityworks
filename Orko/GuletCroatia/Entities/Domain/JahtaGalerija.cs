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
    /// JahtaGalerija entity.
    /// </summary>
    public sealed partial class JahtaGalerija : Entity
    {
		#region Members
		private Jahta m_Jahta;
        #endregion
        
		#region Constructors
        static JahtaGalerija()
        {
            // Cache field metadata.
            EntityMeta<JahtaGalerija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(JahtaGalerijaID), @"JahtaGalerijaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(JahtaGalerijaJahta), @"JahtaGalerijaJahta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaGalerijaFilename), @"JahtaGalerijaFilename", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaGalerijaAktivnost), @"JahtaGalerijaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(JahtaGalerijaJezik), @"JahtaGalerijaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(JahtaGalerijaSlug), @"JahtaGalerijaSlug", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(JahtaGalerijaAlt), @"JahtaGalerijaAlt", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(JahtaGalerijaNaslov), @"JahtaGalerijaNaslov", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaGalerija>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Jahta), nameof(JahtaGalerijaJahta), nameof(Orko.GuletCroatia.Jahta.JahtaJahta))
			);

			// Cache table metadata.
			EntityMeta<JahtaGalerija>.HasLanguageTable = true;
            EntityMeta<JahtaGalerija>.TableSchema = @"GuletCroatia";
            EntityMeta<JahtaGalerija>.TableName = @"JahtaGalerija";
            EntityMeta<JahtaGalerija>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<JahtaGalerija>.LanguageTableName = @"JahtaGalerija_jezik";
        }
        #endregion

        #region Columns
        public int? JahtaGalerijaID { get; set; }
        public string JahtaGalerijaJahta { get; set; }
        public string JahtaGalerijaFilename { get; set; }
        public bool? JahtaGalerijaAktivnost { get; set; }
        public string JahtaGalerijaJezik { get; private set; }
        public string JahtaGalerijaSlug { get; set; }
        public string JahtaGalerijaAlt { get; set; }
        public string JahtaGalerijaNaslov { get; set; }
        #endregion

        #region Entities
		public Jahta Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_Jahta, this, nameof(Jahta)); }
            set { EntityContext<Jahta>.Set(ref m_Jahta, this, value, nameof(Jahta)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<JahtaGalerija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<JahtaGalerija>(queryConditions);
        }
        public static async Task<IEnumerable<JahtaGalerija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<JahtaGalerija>(columnName, queryOp, value);
        }
		public static async Task<JahtaGalerija> GetByPrimaryKeyAsync(int JahtaGalerijaID, string JahtaGalerijaJahta)
        {
            return await GetByPrimaryKeyAsync<JahtaGalerija>(JahtaGalerijaID, JahtaGalerijaJahta);
        }
		public static async Task<JahtaGalerija> TryGetByPrimaryKeyAsync(int JahtaGalerijaID, string JahtaGalerijaJahta)
        {
            return await TryGetByPrimaryKeyAsync<JahtaGalerija>(JahtaGalerijaID, JahtaGalerijaJahta);
        }
		#endregion
    }
}