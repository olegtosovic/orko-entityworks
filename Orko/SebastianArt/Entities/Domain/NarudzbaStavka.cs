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
    /// NarudzbaStavka entity.
    /// </summary>
    public sealed partial class NarudzbaStavka : Entity
    {
		#region Members
		private Artikal m_Artikal;
        private Narudzba m_Narudzba;
        #endregion
        
		#region Constructors
        static NarudzbaStavka()
        {
            // Cache field metadata.
            EntityMeta<NarudzbaStavka>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(NarudzbaStavkaID), @"NarudzbaStavkaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaStavkaNarudzbaID), @"NarudzbaStavkaNarudzbaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaStavkaArtikalID), @"NarudzbaStavkaArtikalID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaStavkaRedniBroj), @"NarudzbaStavkaRedniBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaStavkaCijena), @"NarudzbaStavkaCijena", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(NarudzbaStavkaKolicina), @"NarudzbaStavkaKolicina", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaStavkaVrijednost), @"NarudzbaStavkaVrijednost", DbType.Decimal, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<NarudzbaStavka>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Artikal), nameof(NarudzbaStavkaArtikalID), nameof(Orko.SebastianArt.Artikal.ArtikalID)),
                new RelationMetadata(nameof(Narudzba), nameof(NarudzbaStavkaNarudzbaID), nameof(Orko.SebastianArt.Narudzba.NarudzbaID))
			);

			// Cache table metadata.
			EntityMeta<NarudzbaStavka>.HasLanguageTable = false;
            EntityMeta<NarudzbaStavka>.TableSchema = @"SebastianArt";
            EntityMeta<NarudzbaStavka>.TableName = @"NarudzbaStavka";
            EntityMeta<NarudzbaStavka>.LanguageTableSchema = null;
            EntityMeta<NarudzbaStavka>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? NarudzbaStavkaID { get; private set; }
        public int? NarudzbaStavkaNarudzbaID { get; set; }
        public int? NarudzbaStavkaArtikalID { get; set; }
        public int? NarudzbaStavkaRedniBroj { get; set; }
        public decimal? NarudzbaStavkaCijena { get; set; }
        public decimal? NarudzbaStavkaKolicina { get; set; }
        public decimal? NarudzbaStavkaVrijednost { get; set; }
        #endregion

        #region Entities
		public Artikal Artikal
        {
            get { return EntityContext<Artikal>.Get(ref m_Artikal, this, nameof(Artikal)); }
            set { EntityContext<Artikal>.Set(ref m_Artikal, this, value, nameof(Artikal)); }
        }
        public Narudzba Narudzba
        {
            get { return EntityContext<Narudzba>.Get(ref m_Narudzba, this, nameof(Narudzba)); }
            set { EntityContext<Narudzba>.Set(ref m_Narudzba, this, value, nameof(Narudzba)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<NarudzbaStavka>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<NarudzbaStavka>(queryConditions);
        }
        public static async Task<IEnumerable<NarudzbaStavka>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<NarudzbaStavka>(columnName, queryOp, value);
        }
		public static async Task<NarudzbaStavka> GetByPrimaryKeyAsync(int NarudzbaStavkaID)
        {
            return await GetByPrimaryKeyAsync<NarudzbaStavka>(NarudzbaStavkaID);
        }
		public static async Task<NarudzbaStavka> TryGetByPrimaryKeyAsync(int NarudzbaStavkaID)
        {
            return await TryGetByPrimaryKeyAsync<NarudzbaStavka>(NarudzbaStavkaID);
        }
		#endregion
    }
}