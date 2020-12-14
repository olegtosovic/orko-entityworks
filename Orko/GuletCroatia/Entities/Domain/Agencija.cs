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

namespace Orko.GuletCroatia
{
    /// <summary>
    /// Agencija entity.
    /// </summary>
    public sealed partial class Agencija : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Agencija()
        {
            // Cache field metadata.
            EntityMeta<Agencija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(AgencijaAgencija), @"AgencijaAgencija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(AgencijaNaziv), @"AgencijaNaziv", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(AgencijaOIB), @"AgencijaOIB", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(AgencijaEmail1), @"AgencijaEmail1", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(AgencijaEmail2), @"AgencijaEmail2", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(AgencijaTelefon), @"AgencijaTelefon", DbType.String, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<Agencija>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Agencija>.HasLanguageTable = false;
            EntityMeta<Agencija>.TableSchema = @"GuletCroatia";
            EntityMeta<Agencija>.TableName = @"Agencija";
            EntityMeta<Agencija>.LanguageTableSchema = null;
            EntityMeta<Agencija>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string AgencijaAgencija { get; set; }
        public string AgencijaNaziv { get; set; }
        public string AgencijaOIB { get; set; }
        public string AgencijaEmail1 { get; set; }
        public string AgencijaEmail2 { get; set; }
        public string AgencijaTelefon { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Agencija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Agencija>(queryConditions);
        }
        public static async Task<IEnumerable<Agencija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Agencija>(columnName, queryOp, value);
        }
		public static async Task<Agencija> GetByPrimaryKeyAsync(string AgencijaAgencija)
        {
            return await GetByPrimaryKeyAsync<Agencija>(AgencijaAgencija);
        }
		public static async Task<Agencija> TryGetByPrimaryKeyAsync(string AgencijaAgencija)
        {
            return await TryGetByPrimaryKeyAsync<Agencija>(AgencijaAgencija);
        }
		#endregion
    }
}