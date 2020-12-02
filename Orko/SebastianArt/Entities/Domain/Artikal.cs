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
    /// Artikal entity.
    /// </summary>
    public sealed partial class Artikal : Entity
    {
		#region Members
		private Orijentacija m_FK_Artikal_Orijentacija;
        private VrstaArtikla m_FK_Artikal_VrstaArtikla;
        #endregion
        
		#region Constructors
        static Artikal()
        {
            // Cache field metadata.
            EntityMeta<Artikal>.LoadColumnMetadata
			(
				new ColumnMetadata("ArtikalID", @"ArtikalID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("ArtikalSifra", @"ArtikalSifra", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ArtikalVrstaArtikla", @"ArtikalVrstaArtikla", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ArtikalAutor", @"ArtikalAutor", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ArtikalDimenzije", @"ArtikalDimenzije", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ArtikalKolicina", @"ArtikalKolicina", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("ArtikalOrijentacija", @"ArtikalOrijentacija", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("ArtikalCijena", @"ArtikalCijena", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("ArtikalDobavljivo", @"ArtikalDobavljivo", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("ArtikalGrupa", @"ArtikalGrupa", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ArtikalBrojNaziv", @"ArtikalBrojNaziv", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ArtikalAktivnost", @"ArtikalAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("ArtikalJezik", @"ArtikalJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("ArtikalNaziv", @"ArtikalNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("ArtikalOpis", @"ArtikalOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Artikal>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Artikal_Orijentacija", "ArtikalOrijentacija", "OrijentacijaOrijentacija"),
                new RelationMetadata("FK_Artikal_VrstaArtikla", "ArtikalVrstaArtikla", "VrstaArtiklaVrstaArtikla")
			);

			// Cache table metadata.
			EntityMeta<Artikal>.HasLanguageTable = true;
            EntityMeta<Artikal>.TableSchema = @"SebastianArt";
            EntityMeta<Artikal>.TableName = @"Artikal";
            EntityMeta<Artikal>.LanguageTableSchema = @"SebastianArt";
            EntityMeta<Artikal>.LanguageTableName = @"Artikal_jezik";
        }
        #endregion

        #region Columns
        public int? ArtikalID { get; set; }
        public string ArtikalSifra { get; set; }
        public string ArtikalVrstaArtikla { get; set; }
        public string ArtikalAutor { get; set; }
        public string ArtikalDimenzije { get; set; }
        public decimal? ArtikalKolicina { get; set; }
        public string ArtikalOrijentacija { get; set; }
        public decimal? ArtikalCijena { get; set; }
        public bool? ArtikalDobavljivo { get; set; }
        public string ArtikalGrupa { get; set; }
        public string ArtikalBrojNaziv { get; set; }
        public bool? ArtikalAktivnost { get; set; }
        public string ArtikalJezik { get; private set; }
        public string ArtikalNaziv { get; set; }
        public string ArtikalOpis { get; set; }
        #endregion

        #region Entities
		public Orijentacija FK_Artikal_Orijentacija
        {
            get { return EntityContext<Orijentacija>.Get(ref m_FK_Artikal_Orijentacija, this, "FK_Artikal_Orijentacija"); }
            set { EntityContext<Orijentacija>.Set(ref m_FK_Artikal_Orijentacija, this, value, "FK_Artikal_Orijentacija"); }
        }
        public VrstaArtikla FK_Artikal_VrstaArtikla
        {
            get { return EntityContext<VrstaArtikla>.Get(ref m_FK_Artikal_VrstaArtikla, this, "FK_Artikal_VrstaArtikla"); }
            set { EntityContext<VrstaArtikla>.Set(ref m_FK_Artikal_VrstaArtikla, this, value, "FK_Artikal_VrstaArtikla"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Artikal>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Artikal>(queryConditions);
        }
        public static async Task<IEnumerable<Artikal>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Artikal>(columnName, queryOp, value);
        }
		public static async Task<Artikal> GetByPrimaryKeyAsync(int ArtikalID)
        {
            return await GetByPrimaryKeyAsync<Artikal>(ArtikalID);
        }
		public static async Task<Artikal> TryGetByPrimaryKeyAsync(int ArtikalID)
        {
            return await TryGetByPrimaryKeyAsync<Artikal>(ArtikalID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Artikal> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Artikal>(queryConditions);
        }
        public static IEnumerable<Artikal> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Artikal>(columnName, queryOp, value);
        }
		public static Artikal GetByPrimaryKey(int ArtikalID)
        {
            return GetByPrimaryKey<Artikal>(ArtikalID);
        }
		public static Artikal TryGetByPrimaryKey(int ArtikalID)
        {
            return TryGetByPrimaryKey<Artikal>(ArtikalID);
        }
        #endregion
    }
}