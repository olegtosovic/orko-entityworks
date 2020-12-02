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
				new ColumnMetadata("NarudzbaID", @"NarudzbaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("NarudzbaNarudzba", @"NarudzbaNarudzba", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NarudzbaBroj", @"NarudzbaBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("NarudzbaMjesec", @"NarudzbaMjesec", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("NarudzbaGodina", @"NarudzbaGodina", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("NarudzbaDatumNarudjbe", @"NarudzbaDatumNarudjbe", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("NarudzbaIznos", @"NarudzbaIznos", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("NarudzbaNaziv", @"NarudzbaNaziv", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("NarudzbaEmail", @"NarudzbaEmail", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("NarudzbaAdresa", @"NarudzbaAdresa", SqlDbType.NVarChar, isRequired: true)
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

        #region Public methods
		public static IEnumerable<Narudzba> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Narudzba>(queryConditions);
        }
        public static IEnumerable<Narudzba> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Narudzba>(columnName, queryOp, value);
        }
		public static Narudzba GetByPrimaryKey(int NarudzbaID)
        {
            return GetByPrimaryKey<Narudzba>(NarudzbaID);
        }
		public static Narudzba TryGetByPrimaryKey(int NarudzbaID)
        {
            return TryGetByPrimaryKey<Narudzba>(NarudzbaID);
        }
        public static Narudzba GetByUnique1(int NarudzbaBroj)
        {
            return GetByCallingParameters<Narudzba>(NarudzbaBroj);
        }
		public static Narudzba TryGetByUnique1(int NarudzbaBroj)
        {
            return TryGetByCallingParameters<Narudzba>(NarudzbaBroj);
        }
        #endregion
    }
}