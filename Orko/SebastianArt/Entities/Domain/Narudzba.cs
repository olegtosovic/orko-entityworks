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
    /// Narudzba entity.
    /// </summary>
    public sealed partial class Narudzba : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Narudzba()
        {
            // Cache field metadata.
            EntityMeta<Narudzba>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(NarudzbaID), @"NarudzbaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaNarudzba), @"NarudzbaNarudzba", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NarudzbaBroj), @"NarudzbaBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaMjesec), @"NarudzbaMjesec", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(NarudzbaGodina), @"NarudzbaGodina", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaDatumNarudjbe), @"NarudzbaDatumNarudjbe", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(NarudzbaIznos), @"NarudzbaIznos", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(NarudzbaNaziv), @"NarudzbaNaziv", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaEmail), @"NarudzbaEmail", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(NarudzbaAdresa), @"NarudzbaAdresa", DbType.String, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Narudzba>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Narudzba>.HasLanguageTable = false;
            EntityMeta<Narudzba>.TableSchema = @"SebastianArt";
            EntityMeta<Narudzba>.TableName = @"Narudzba";
            EntityMeta<Narudzba>.LanguageTableSchema = null;
            EntityMeta<Narudzba>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? NarudzbaID { get; private set; }
        public string NarudzbaNarudzba { get; set; }
        public int? NarudzbaBroj { get; set; }
        public int? NarudzbaMjesec { get; set; }
        public int? NarudzbaGodina { get; set; }
        public DateTime? NarudzbaDatumNarudjbe { get; set; }
        public decimal? NarudzbaIznos { get; set; }
        public string NarudzbaNaziv { get; set; }
        public string NarudzbaEmail { get; set; }
        public string NarudzbaAdresa { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Narudzba>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Narudzba>(queryConditions);
        }
        public static async Task<IEnumerable<Narudzba>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Narudzba>(columnName, queryOp, value);
        }
		public static async Task<Narudzba> GetByPrimaryKeyAsync(int NarudzbaID)
        {
            return await GetByPrimaryKeyAsync<Narudzba>(NarudzbaID);
        }
		public static async Task<Narudzba> TryGetByPrimaryKeyAsync(int NarudzbaID)
        {
            return await TryGetByPrimaryKeyAsync<Narudzba>(NarudzbaID);
        }
		#endregion
    }
}