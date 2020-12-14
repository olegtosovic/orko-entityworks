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
				new ColumnMetadata(nameof(AutorID), @"AutorID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(AutorIme), @"AutorIme", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(AutorPrezime), @"AutorPrezime", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(AutorNaziv), @"AutorNaziv", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(AutorDatumRodjenja), @"AutorDatumRodjenja", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(AutorEmail), @"AutorEmail", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(AutorTelefon), @"AutorTelefon", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(AutorMobitel), @"AutorMobitel", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(AutorJezik), @"AutorJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(AutorOpis), @"AutorOpis", DbType.String, isRequired: false, isLanguage: true)
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
    }
}