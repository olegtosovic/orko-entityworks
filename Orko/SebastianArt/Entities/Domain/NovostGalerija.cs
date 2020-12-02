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

namespace Orko.SebastianArt
{
    /// <summary>
    /// NovostGalerija entity.
    /// </summary>
    public sealed partial class NovostGalerija : Entity
    {
		#region Members
		private Novost m_FK_NovostGalerija_Novost;
        #endregion
        
		#region Constructors
        static NovostGalerija()
        {
            // Cache field metadata.
            EntityMeta<NovostGalerija>.LoadColumnMetadata
			(
				new ColumnMetadata("NovostGalerijaID", @"NovostGalerijaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("NovostGalerijaNovostID", @"NovostGalerijaNovostID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("NovostGalerijaSlikaNaziv", @"NovostGalerijaSlikaNaziv", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("NovostGalerijaAktivnost", @"NovostGalerijaAktivnost", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("NovostGalerijaJezik", @"NovostGalerijaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("NovostGalerijaSlikaOpis", @"NovostGalerijaSlikaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<NovostGalerija>.LoadRelationMetadata
			(
				new RelationMetadata("FK_NovostGalerija_Novost", "NovostGalerijaNovostID", "NovostID")
			);

			// Cache table metadata.
			EntityMeta<NovostGalerija>.HasLanguageTable = true;
            EntityMeta<NovostGalerija>.TableSchema = @"SebastianArt";
            EntityMeta<NovostGalerija>.TableName = @"NovostGalerija";
            EntityMeta<NovostGalerija>.LanguageTableSchema = @"SebastianArt";
            EntityMeta<NovostGalerija>.LanguageTableName = @"NovostGalerija_jezik";
        }
        #endregion

        #region Columns
        public int? NovostGalerijaID { get; private set; }
        public int? NovostGalerijaNovostID { get; set; }
        public string NovostGalerijaSlikaNaziv { get; set; }
        public bool? NovostGalerijaAktivnost { get; set; }
        public string NovostGalerijaJezik { get; private set; }
        public string NovostGalerijaSlikaOpis { get; set; }
        #endregion

        #region Entities
		public Novost FK_NovostGalerija_Novost
        {
            get { return EntityContext<Novost>.Get(ref m_FK_NovostGalerija_Novost, this, "FK_NovostGalerija_Novost"); }
            set { EntityContext<Novost>.Set(ref m_FK_NovostGalerija_Novost, this, value, "FK_NovostGalerija_Novost"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<NovostGalerija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<NovostGalerija>(queryConditions);
        }
        public static async Task<IEnumerable<NovostGalerija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<NovostGalerija>(columnName, queryOp, value);
        }
		public static async Task<NovostGalerija> GetByPrimaryKeyAsync(int NovostGalerijaID)
        {
            return await GetByPrimaryKeyAsync<NovostGalerija>(NovostGalerijaID);
        }
		public static async Task<NovostGalerija> TryGetByPrimaryKeyAsync(int NovostGalerijaID)
        {
            return await TryGetByPrimaryKeyAsync<NovostGalerija>(NovostGalerijaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<NovostGalerija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<NovostGalerija>(queryConditions);
        }
        public static IEnumerable<NovostGalerija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<NovostGalerija>(columnName, queryOp, value);
        }
		public static NovostGalerija GetByPrimaryKey(int NovostGalerijaID)
        {
            return GetByPrimaryKey<NovostGalerija>(NovostGalerijaID);
        }
		public static NovostGalerija TryGetByPrimaryKey(int NovostGalerijaID)
        {
            return TryGetByPrimaryKey<NovostGalerija>(NovostGalerijaID);
        }
        #endregion
    }
}