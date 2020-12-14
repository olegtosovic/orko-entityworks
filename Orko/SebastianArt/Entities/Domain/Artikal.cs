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
    /// Artikal entity.
    /// </summary>
    public sealed partial class Artikal : Entity
    {
		#region Members
		private Orijentacija m_Orijentacija;
        private VrstaArtikla m_VrstaArtikla;
        #endregion
        
		#region Constructors
        static Artikal()
        {
            // Cache field metadata.
            EntityMeta<Artikal>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ArtikalID), @"ArtikalID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ArtikalSifra), @"ArtikalSifra", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ArtikalVrstaArtikla), @"ArtikalVrstaArtikla", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ArtikalAutor), @"ArtikalAutor", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ArtikalDimenzije), @"ArtikalDimenzije", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ArtikalKolicina), @"ArtikalKolicina", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(ArtikalOrijentacija), @"ArtikalOrijentacija", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(ArtikalCijena), @"ArtikalCijena", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(ArtikalDobavljivo), @"ArtikalDobavljivo", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(ArtikalGrupa), @"ArtikalGrupa", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ArtikalBrojNaziv), @"ArtikalBrojNaziv", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ArtikalAktivnost), @"ArtikalAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(ArtikalJezik), @"ArtikalJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(ArtikalNaziv), @"ArtikalNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(ArtikalOpis), @"ArtikalOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Artikal>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Orijentacija), nameof(ArtikalOrijentacija), nameof(Orko.SebastianArt.Orijentacija.OrijentacijaOrijentacija)),
                new RelationMetadata(nameof(VrstaArtikla), nameof(ArtikalVrstaArtikla), nameof(Orko.SebastianArt.VrstaArtikla.VrstaArtiklaVrstaArtikla))
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
		public Orijentacija Orijentacija
        {
            get { return EntityContext<Orijentacija>.Get(ref m_Orijentacija, this, nameof(Orijentacija)); }
            set { EntityContext<Orijentacija>.Set(ref m_Orijentacija, this, value, nameof(Orijentacija)); }
        }
        public VrstaArtikla VrstaArtikla
        {
            get { return EntityContext<VrstaArtikla>.Get(ref m_VrstaArtikla, this, nameof(VrstaArtikla)); }
            set { EntityContext<VrstaArtikla>.Set(ref m_VrstaArtikla, this, value, nameof(VrstaArtikla)); }
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
    }
}