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
    /// NarudzbaStavka entity.
    /// </summary>
    public sealed partial class NarudzbaStavka : Entity
    {
		#region Members
		private Artikal m_FK_NarudzbaStavka_Artikal;
        private Narudzba m_FK_NarudzbaStavka_Narudzba;
        #endregion
        
		#region Constructors
        static NarudzbaStavka()
        {
            // Cache field metadata.
            EntityMeta<NarudzbaStavka>.LoadColumnMetadata
			(
				new ColumnMetadata("NarudzbaStavkaID", @"NarudzbaStavkaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("NarudzbaStavkaNarudzbaID", @"NarudzbaStavkaNarudzbaID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("NarudzbaStavkaArtikalID", @"NarudzbaStavkaArtikalID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("NarudzbaStavkaRedniBroj", @"NarudzbaStavkaRedniBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("NarudzbaStavkaCijena", @"NarudzbaStavkaCijena", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("NarudzbaStavkaKolicina", @"NarudzbaStavkaKolicina", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("NarudzbaStavkaVrijednost", @"NarudzbaStavkaVrijednost", SqlDbType.Decimal, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<NarudzbaStavka>.LoadRelationMetadata
			(
				new RelationMetadata("FK_NarudzbaStavka_Artikal", "NarudzbaStavkaArtikalID", "ArtikalID"),
                new RelationMetadata("FK_NarudzbaStavka_Narudzba", "NarudzbaStavkaNarudzbaID", "NarudzbaID")
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
		public Artikal FK_NarudzbaStavka_Artikal
        {
            get { return EntityContext<Artikal>.Get(ref m_FK_NarudzbaStavka_Artikal, this, "FK_NarudzbaStavka_Artikal"); }
            set { EntityContext<Artikal>.Set(ref m_FK_NarudzbaStavka_Artikal, this, value, "FK_NarudzbaStavka_Artikal"); }
        }
        public Narudzba FK_NarudzbaStavka_Narudzba
        {
            get { return EntityContext<Narudzba>.Get(ref m_FK_NarudzbaStavka_Narudzba, this, "FK_NarudzbaStavka_Narudzba"); }
            set { EntityContext<Narudzba>.Set(ref m_FK_NarudzbaStavka_Narudzba, this, value, "FK_NarudzbaStavka_Narudzba"); }
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

        #region Public methods
		public static IEnumerable<NarudzbaStavka> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<NarudzbaStavka>(queryConditions);
        }
        public static IEnumerable<NarudzbaStavka> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<NarudzbaStavka>(columnName, queryOp, value);
        }
		public static NarudzbaStavka GetByPrimaryKey(int NarudzbaStavkaID)
        {
            return GetByPrimaryKey<NarudzbaStavka>(NarudzbaStavkaID);
        }
		public static NarudzbaStavka TryGetByPrimaryKey(int NarudzbaStavkaID)
        {
            return TryGetByPrimaryKey<NarudzbaStavka>(NarudzbaStavkaID);
        }
        public static NarudzbaStavka GetByUnique1(int NarudzbaStavkaID)
        {
            return GetByCallingParameters<NarudzbaStavka>(NarudzbaStavkaID);
        }
		public static NarudzbaStavka TryGetByUnique1(int NarudzbaStavkaID)
        {
            return TryGetByCallingParameters<NarudzbaStavka>(NarudzbaStavkaID);
        }
        public static NarudzbaStavka GetByUnique2(int NarudzbaStavkaID)
        {
            return GetByCallingParameters<NarudzbaStavka>(NarudzbaStavkaID);
        }
		public static NarudzbaStavka TryGetByUnique2(int NarudzbaStavkaID)
        {
            return TryGetByCallingParameters<NarudzbaStavka>(NarudzbaStavkaID);
        }
        #endregion
    }
}