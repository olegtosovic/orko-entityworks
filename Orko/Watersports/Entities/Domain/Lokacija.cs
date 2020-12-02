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

namespace Orko.Watersports
{
    /// <summary>
    /// Lokacija entity.
    /// </summary>
    public sealed partial class Lokacija : Entity
    {
		#region Members
		private Base.Drzava m_FK_Lokacija_Drzava;
        private Hotel m_FK_Lokacija_Hotel;
        private Base.Opcina m_FK_Lokacija_Opcina;
        private TipLokacije m_FK_Lokacija_TipLokacije;
        #endregion
        
		#region Constructors
        static Lokacija()
        {
            // Cache field metadata.
            EntityMeta<Lokacija>.LoadColumnMetadata
			(
				new ColumnMetadata("LokacijaLokacija", @"LokacijaLokacija", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("LokacijaTipLokacije", @"LokacijaTipLokacije", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("LokacijaDrzava", @"LokacijaDrzava", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("LokacijaOpcina", @"LokacijaOpcina", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("LokacijaHotel", @"LokacijaHotel", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("LokacijaAdresa", @"LokacijaAdresa", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("LokacijaAktivnost", @"LokacijaAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("LokacijaJezik", @"LokacijaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("LokacijaPozicija", @"LokacijaPozicija", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("LokacijaOpis", @"LokacijaOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Lokacija>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Lokacija_Drzava", "LokacijaDrzava", "DrzavaDrzava"),
                new RelationMetadata("FK_Lokacija_Hotel", "LokacijaHotel", "HotelHotel"),
                new RelationMetadata("FK_Lokacija_Opcina", "LokacijaOpcina", "OpcinaOpcina"),
                new RelationMetadata("FK_Lokacija_Opcina", "LokacijaDrzava", "OpcinaDrzava"),
                new RelationMetadata("FK_Lokacija_TipLokacije", "LokacijaTipLokacije", "TipLokacijeTipLokacije")
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
		public Base.Drzava FK_Lokacija_Drzava
        {
            get { return EntityContext<Base.Drzava>.Get(ref m_FK_Lokacija_Drzava, this, "FK_Lokacija_Drzava"); }
            set { EntityContext<Base.Drzava>.Set(ref m_FK_Lokacija_Drzava, this, value, "FK_Lokacija_Drzava"); }
        }
        public Hotel FK_Lokacija_Hotel
        {
            get { return EntityContext<Hotel>.Get(ref m_FK_Lokacija_Hotel, this, "FK_Lokacija_Hotel"); }
            set { EntityContext<Hotel>.Set(ref m_FK_Lokacija_Hotel, this, value, "FK_Lokacija_Hotel"); }
        }
        public Base.Opcina FK_Lokacija_Opcina
        {
            get { return EntityContext<Base.Opcina>.Get(ref m_FK_Lokacija_Opcina, this, "FK_Lokacija_Opcina"); }
            set { EntityContext<Base.Opcina>.Set(ref m_FK_Lokacija_Opcina, this, value, "FK_Lokacija_Opcina"); }
        }
        public TipLokacije FK_Lokacija_TipLokacije
        {
            get { return EntityContext<TipLokacije>.Get(ref m_FK_Lokacija_TipLokacije, this, "FK_Lokacija_TipLokacije"); }
            set { EntityContext<TipLokacije>.Set(ref m_FK_Lokacija_TipLokacije, this, value, "FK_Lokacija_TipLokacije"); }
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

        #region Public methods
		public static IEnumerable<Lokacija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Lokacija>(queryConditions);
        }
        public static IEnumerable<Lokacija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Lokacija>(columnName, queryOp, value);
        }
		public static Lokacija GetByPrimaryKey(int LokacijaLokacija)
        {
            return GetByPrimaryKey<Lokacija>(LokacijaLokacija);
        }
		public static Lokacija TryGetByPrimaryKey(int LokacijaLokacija)
        {
            return TryGetByPrimaryKey<Lokacija>(LokacijaLokacija);
        }
        #endregion
    }
}