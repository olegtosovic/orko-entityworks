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
    /// Hotel entity.
    /// </summary>
    public sealed partial class Hotel : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Hotel()
        {
            // Cache field metadata.
            EntityMeta<Hotel>.LoadColumnMetadata
			(
				new ColumnMetadata("HotelHotel", @"HotelHotel", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("HotelAdresa", @"HotelAdresa", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("HotelTelefon", @"HotelTelefon", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("HotelEmail", @"HotelEmail", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("HotelWeb", @"HotelWeb", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("HotelAktivnost", @"HotelAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("HotelJezik", @"HotelJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("HotelNaziv", @"HotelNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("HotelOpis", @"HotelOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Hotel>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Hotel>.HasLanguageTable = true;
            EntityMeta<Hotel>.TableSchema = @"Watersports";
            EntityMeta<Hotel>.TableName = @"Hotel";
            EntityMeta<Hotel>.LanguageTableSchema = @"Watersports";
            EntityMeta<Hotel>.LanguageTableName = @"Hotel_jezik";
        }
        #endregion

        #region Columns
        public int? HotelHotel { get; set; }
        public string HotelAdresa { get; set; }
        public string HotelTelefon { get; set; }
        public string HotelEmail { get; set; }
        public string HotelWeb { get; set; }
        public bool? HotelAktivnost { get; set; }
        public string HotelJezik { get; private set; }
        public string HotelNaziv { get; set; }
        public string HotelOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Hotel>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Hotel>(queryConditions);
        }
        public static async Task<IEnumerable<Hotel>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Hotel>(columnName, queryOp, value);
        }
		public static async Task<Hotel> GetByPrimaryKeyAsync(int HotelHotel)
        {
            return await GetByPrimaryKeyAsync<Hotel>(HotelHotel);
        }
		public static async Task<Hotel> TryGetByPrimaryKeyAsync(int HotelHotel)
        {
            return await TryGetByPrimaryKeyAsync<Hotel>(HotelHotel);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Hotel> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Hotel>(queryConditions);
        }
        public static IEnumerable<Hotel> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Hotel>(columnName, queryOp, value);
        }
		public static Hotel GetByPrimaryKey(int HotelHotel)
        {
            return GetByPrimaryKey<Hotel>(HotelHotel);
        }
		public static Hotel TryGetByPrimaryKey(int HotelHotel)
        {
            return TryGetByPrimaryKey<Hotel>(HotelHotel);
        }
        #endregion
    }
}