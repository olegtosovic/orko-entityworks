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

namespace Orko.Sistem
{
    /// <summary>
    /// Instalacija entity.
    /// </summary>
    public sealed partial class Instalacija : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Instalacija()
        {
            // Cache field metadata.
            EntityMeta<Instalacija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(InstalacijaInstalacija), @"InstalacijaInstalacija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(InstalacijaNaziv), @"InstalacijaNaziv", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(InstalacijaAktivnost), @"InstalacijaAktivnost", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Instalacija>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Instalacija>.HasLanguageTable = false;
            EntityMeta<Instalacija>.TableSchema = @"Sistem";
            EntityMeta<Instalacija>.TableName = @"Instalacija";
            EntityMeta<Instalacija>.LanguageTableSchema = null;
            EntityMeta<Instalacija>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public string InstalacijaInstalacija { get; set; }
        public string InstalacijaNaziv { get; set; }
        public bool? InstalacijaAktivnost { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Instalacija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Instalacija>(queryConditions);
        }
        public static async Task<IEnumerable<Instalacija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Instalacija>(columnName, queryOp, value);
        }
		public static async Task<Instalacija> GetByPrimaryKeyAsync(string InstalacijaInstalacija)
        {
            return await GetByPrimaryKeyAsync<Instalacija>(InstalacijaInstalacija);
        }
		public static async Task<Instalacija> TryGetByPrimaryKeyAsync(string InstalacijaInstalacija)
        {
            return await TryGetByPrimaryKeyAsync<Instalacija>(InstalacijaInstalacija);
        }
		#endregion
    }
}