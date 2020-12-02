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
    /// JahtaGalerija entity.
    /// </summary>
    public sealed partial class JahtaGalerija : Entity
    {
		#region Members
		private Jahta m_FK_JahtaGalerija_Jahta;
        #endregion
        
		#region Constructors
        static JahtaGalerija()
        {
            // Cache field metadata.
            EntityMeta<JahtaGalerija>.LoadColumnMetadata
			(
				new ColumnMetadata("JahtaGalerijaID", @"JahtaGalerijaID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("JahtaGalerijaJahta", @"JahtaGalerijaJahta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaGalerijaFilename", @"JahtaGalerijaFilename", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("JahtaGalerijaAktivnost", @"JahtaGalerijaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("JahtaGalerijaJezik", @"JahtaGalerijaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("JahtaGalerijaSlug", @"JahtaGalerijaSlug", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("JahtaGalerijaAlt", @"JahtaGalerijaAlt", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("JahtaGalerijaNaslov", @"JahtaGalerijaNaslov", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaGalerija>.LoadRelationMetadata
			(
				new RelationMetadata("FK_JahtaGalerija_Jahta", "JahtaGalerijaJahta", "JahtaJahta")
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
		public Jahta FK_JahtaGalerija_Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_FK_JahtaGalerija_Jahta, this, "FK_JahtaGalerija_Jahta"); }
            set { EntityContext<Jahta>.Set(ref m_FK_JahtaGalerija_Jahta, this, value, "FK_JahtaGalerija_Jahta"); }
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

        #region Public methods
		public static IEnumerable<JahtaGalerija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<JahtaGalerija>(queryConditions);
        }
        public static IEnumerable<JahtaGalerija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<JahtaGalerija>(columnName, queryOp, value);
        }
		public static JahtaGalerija GetByPrimaryKey(int JahtaGalerijaID, string JahtaGalerijaJahta)
        {
            return GetByPrimaryKey<JahtaGalerija>(JahtaGalerijaID, JahtaGalerijaJahta);
        }
		public static JahtaGalerija TryGetByPrimaryKey(int JahtaGalerijaID, string JahtaGalerijaJahta)
        {
            return TryGetByPrimaryKey<JahtaGalerija>(JahtaGalerijaID, JahtaGalerijaJahta);
        }
        #endregion
    }
}