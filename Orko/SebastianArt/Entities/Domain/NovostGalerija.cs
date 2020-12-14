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

namespace Orko.SebastianArt
{
    /// <summary>
    /// NovostGalerija entity.
    /// </summary>
    public sealed partial class NovostGalerija : Entity
    {
		#region Members
		private Novost m_Novost;
        #endregion
        
		#region Constructors
        static NovostGalerija()
        {
            // Cache field metadata.
            EntityMeta<NovostGalerija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(NovostGalerijaID), @"NovostGalerijaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(NovostGalerijaNovostID), @"NovostGalerijaNovostID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(NovostGalerijaSlikaNaziv), @"NovostGalerijaSlikaNaziv", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(NovostGalerijaAktivnost), @"NovostGalerijaAktivnost", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(NovostGalerijaJezik), @"NovostGalerijaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(NovostGalerijaSlikaOpis), @"NovostGalerijaSlikaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<NovostGalerija>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Novost), nameof(NovostGalerijaNovostID), nameof(Orko.SebastianArt.Novost.NovostID))
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
		public Novost Novost
        {
            get { return EntityContext<Novost>.Get(ref m_Novost, this, nameof(Novost)); }
            set { EntityContext<Novost>.Set(ref m_Novost, this, value, nameof(Novost)); }
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
    }
}