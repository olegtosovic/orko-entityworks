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
    /// Autor entity.
    /// </summary>
    public sealed partial class Autor : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Autor()
        {
            // Cache field metadata.
            EntityMeta<Autor>.LoadColumnMetadata
			(
				new ColumnMetadata("AutorID", @"AutorID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("AutorIme", @"AutorIme", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("AutorPrezime", @"AutorPrezime", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("AutorNaziv", @"AutorNaziv", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("AutorDatumRodjenja", @"AutorDatumRodjenja", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("AutorEmail", @"AutorEmail", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("AutorTelefon", @"AutorTelefon", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("AutorMobitel", @"AutorMobitel", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("AutorJezik", @"AutorJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("AutorOpis", @"AutorOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Autor>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Autor>.HasLanguageTable = true;
            EntityMeta<Autor>.TableSchema = @"SebastianArt";
            EntityMeta<Autor>.TableName = @"Autor";
            EntityMeta<Autor>.LanguageTableSchema = @"SebastianArt";
            EntityMeta<Autor>.LanguageTableName = @"Autor_jezik";
        }
        #endregion

        #region Columns
        public int? AutorID { get; set; }
        public string AutorIme { get; set; }
        public string AutorPrezime { get; set; }
        public string AutorNaziv { get; set; }
        public DateTime? AutorDatumRodjenja { get; set; }
        public string AutorEmail { get; set; }
        public string AutorTelefon { get; set; }
        public string AutorMobitel { get; set; }
        public string AutorJezik { get; private set; }
        public string AutorOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Autor>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Autor>(queryConditions);
        }
        public static async Task<IEnumerable<Autor>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Autor>(columnName, queryOp, value);
        }
		public static async Task<Autor> GetByPrimaryKeyAsync(int AutorID)
        {
            return await GetByPrimaryKeyAsync<Autor>(AutorID);
        }
		public static async Task<Autor> TryGetByPrimaryKeyAsync(int AutorID)
        {
            return await TryGetByPrimaryKeyAsync<Autor>(AutorID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Autor> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Autor>(queryConditions);
        }
        public static IEnumerable<Autor> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Autor>(columnName, queryOp, value);
        }
		public static Autor GetByPrimaryKey(int AutorID)
        {
            return GetByPrimaryKey<Autor>(AutorID);
        }
		public static Autor TryGetByPrimaryKey(int AutorID)
        {
            return TryGetByPrimaryKey<Autor>(AutorID);
        }
        #endregion
    }
}