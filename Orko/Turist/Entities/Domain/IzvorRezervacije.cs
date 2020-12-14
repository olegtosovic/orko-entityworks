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

namespace Orko.Turist
{
    /// <summary>
    /// IzvorRezervacije entity.
    /// </summary>
    public sealed partial class IzvorRezervacije : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static IzvorRezervacije()
        {
            // Cache field metadata.
            EntityMeta<IzvorRezervacije>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(IzvorRezervacijeIzvorRezervacije), @"IzvorRezervacijeIzvorRezervacije", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(IzvorRezervacijeWebLink), @"IzvorRezervacijeWebLink", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(IzvorRezervacijeAktivnost), @"IzvorRezervacijeAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(IzvorRezervacijeJezik), @"IzvorRezervacijeJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(IzvorRezervacijeNaziv), @"IzvorRezervacijeNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(IzvorRezervacijeOpis), @"IzvorRezervacijeOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<IzvorRezervacije>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<IzvorRezervacije>.HasLanguageTable = true;
            EntityMeta<IzvorRezervacije>.TableSchema = @"Turist";
            EntityMeta<IzvorRezervacije>.TableName = @"IzvorRezervacije";
            EntityMeta<IzvorRezervacije>.LanguageTableSchema = @"Turist";
            EntityMeta<IzvorRezervacije>.LanguageTableName = @"IzvorRezervacije_jezik";
        }
        #endregion

        #region Columns
        public string IzvorRezervacijeIzvorRezervacije { get; set; }
        public string IzvorRezervacijeWebLink { get; set; }
        public bool? IzvorRezervacijeAktivnost { get; set; }
        public string IzvorRezervacijeJezik { get; private set; }
        public string IzvorRezervacijeNaziv { get; set; }
        public string IzvorRezervacijeOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<IzvorRezervacije>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<IzvorRezervacije>(queryConditions);
        }
        public static async Task<IEnumerable<IzvorRezervacije>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<IzvorRezervacije>(columnName, queryOp, value);
        }
		public static async Task<IzvorRezervacije> GetByPrimaryKeyAsync(string IzvorRezervacijeIzvorRezervacije)
        {
            return await GetByPrimaryKeyAsync<IzvorRezervacije>(IzvorRezervacijeIzvorRezervacije);
        }
		public static async Task<IzvorRezervacije> TryGetByPrimaryKeyAsync(string IzvorRezervacijeIzvorRezervacije)
        {
            return await TryGetByPrimaryKeyAsync<IzvorRezervacije>(IzvorRezervacijeIzvorRezervacije);
        }
		#endregion
    }
}