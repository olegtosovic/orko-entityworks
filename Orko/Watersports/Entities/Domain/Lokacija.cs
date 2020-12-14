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

namespace Orko.Watersports
{
    /// <summary>
    /// Lokacija entity.
    /// </summary>
    public sealed partial class Lokacija : Entity
    {
		#region Members
		private Base.Drzava m_Drzava;
        private Hotel m_Hotel;
        private Base.Opcina m_Opcina;
        private TipLokacije m_TipLokacije;
        #endregion
        
		#region Constructors
        static Lokacija()
        {
            // Cache field metadata.
            EntityMeta<Lokacija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(LokacijaLokacija), @"LokacijaLokacija", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(LokacijaTipLokacije), @"LokacijaTipLokacije", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(LokacijaDrzava), @"LokacijaDrzava", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(LokacijaOpcina), @"LokacijaOpcina", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(LokacijaHotel), @"LokacijaHotel", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(LokacijaAdresa), @"LokacijaAdresa", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(LokacijaAktivnost), @"LokacijaAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(LokacijaJezik), @"LokacijaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(LokacijaPozicija), @"LokacijaPozicija", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(LokacijaOpis), @"LokacijaOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Lokacija>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Drzava), nameof(LokacijaDrzava), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(Hotel), nameof(LokacijaHotel), nameof(Orko.Watersports.Hotel.HotelHotel)),
                new RelationMetadata(nameof(Opcina), nameof(LokacijaOpcina), nameof(Orko.Base.Opcina.OpcinaOpcina)),
                new RelationMetadata(nameof(Opcina), nameof(LokacijaDrzava), nameof(Orko.Base.Opcina.OpcinaDrzava)),
                new RelationMetadata(nameof(TipLokacije), nameof(LokacijaTipLokacije), nameof(Orko.Watersports.TipLokacije.TipLokacijeTipLokacije))
			);

			// Cache table metadata.
			EntityMeta<Lokacija>.HasLanguageTable = true;
            EntityMeta<Lokacija>.TableSchema = @"Watersports";
            EntityMeta<Lokacija>.TableName = @"Lokacija";
            EntityMeta<Lokacija>.LanguageTableSchema = @"Watersports";
            EntityMeta<Lokacija>.LanguageTableName = @"Lokacija_jezik";
        }
        #endregion

        #region Columns
        public int? LokacijaLokacija { get; private set; }
        public string LokacijaTipLokacije { get; set; }
        public string LokacijaDrzava { get; set; }
        public string LokacijaOpcina { get; set; }
        public int? LokacijaHotel { get; set; }
        public string LokacijaAdresa { get; set; }
        public bool? LokacijaAktivnost { get; set; }
        public string LokacijaJezik { get; private set; }
        public string LokacijaPozicija { get; set; }
        public string LokacijaOpis { get; set; }
        #endregion

        #region Entities
		public Base.Drzava Drzava
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_Drzava, this, nameof(Drzava)); }
            set { EntityContext<Base.Drzava>.Set(ref m_Drzava, this, value, nameof(Drzava)); }
        }
        public Hotel Hotel
        {
            get { return EntityContext<Hotel>.Get(ref m_Hotel, this, nameof(Hotel)); }
            set { EntityContext<Hotel>.Set(ref m_Hotel, this, value, nameof(Hotel)); }
        }
        public Base.Opcina Opcina
        {
            get { return EntityContext<Base.Opcina>.Get(ref m_Opcina, this, nameof(Opcina)); }
            set { EntityContext<Base.Opcina>.Set(ref m_Opcina, this, value, nameof(Opcina)); }
        }
        public TipLokacije TipLokacije
        {
            get { return EntityContext<TipLokacije>.Get(ref m_TipLokacije, this, nameof(TipLokacije)); }
            set { EntityContext<TipLokacije>.Set(ref m_TipLokacije, this, value, nameof(TipLokacije)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Lokacija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Lokacija>(queryConditions);
        }
        public static async Task<IEnumerable<Lokacija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Lokacija>(columnName, queryOp, value);
        }
		public static async Task<Lokacija> GetByPrimaryKeyAsync(int LokacijaLokacija)
        {
            return await GetByPrimaryKeyAsync<Lokacija>(LokacijaLokacija);
        }
		public static async Task<Lokacija> TryGetByPrimaryKeyAsync(int LokacijaLokacija)
        {
            return await TryGetByPrimaryKeyAsync<Lokacija>(LokacijaLokacija);
        }
		#endregion
    }
}