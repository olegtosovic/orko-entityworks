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
    /// CjenikJahteSlobodno entity.
    /// </summary>
    public sealed partial class CjenikJahteSlobodno : Entity
    {
		#region Members
		private Jahta m_Jahta;
        private Base.Valuta m_Valuta;
        #endregion
        
		#region Constructors
        static CjenikJahteSlobodno()
        {
            // Cache field metadata.
            EntityMeta<CjenikJahteSlobodno>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CjenikJahteSlobodnoID), @"CjenikJahteSlobodnoID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(CjenikJahteSlobodnoJahta), @"CjenikJahteSlobodnoJahta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CjenikJahteSlobodnoCijena2), @"CjenikJahteSlobodnoCijena2", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(CjenikJahteSlobodnoValuta2), @"CjenikJahteSlobodnoValuta2", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(CjenikJahteSlobodnoAktivnost), @"CjenikJahteSlobodnoAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(CjenikJahteSlobodnoJezik), @"CjenikJahteSlobodnoJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(CjenikJahteSlobodnoLijevo), @"CjenikJahteSlobodnoLijevo", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(CjenikJahteSlobodnoDesno), @"CjenikJahteSlobodnoDesno", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<CjenikJahteSlobodno>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Jahta), nameof(CjenikJahteSlobodnoJahta), nameof(Orko.GuletCroatia.Jahta.JahtaJahta)),
                new RelationMetadata(nameof(Valuta), nameof(CjenikJahteSlobodnoValuta2), nameof(Orko.Base.Valuta.ValutaValuta))
			);

			// Cache table metadata.
			EntityMeta<CjenikJahteSlobodno>.HasLanguageTable = true;
            EntityMeta<CjenikJahteSlobodno>.TableSchema = @"GuletCroatia";
            EntityMeta<CjenikJahteSlobodno>.TableName = @"CjenikJahteSlobodno";
            EntityMeta<CjenikJahteSlobodno>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<CjenikJahteSlobodno>.LanguageTableName = @"CjenikJahteSlobodno_jezik";
        }
        #endregion

        #region Columns
        public int? CjenikJahteSlobodnoID { get; private set; }
        public string CjenikJahteSlobodnoJahta { get; set; }
        public decimal? CjenikJahteSlobodnoCijena2 { get; set; }
        public string CjenikJahteSlobodnoValuta2 { get; set; }
        public bool? CjenikJahteSlobodnoAktivnost { get; set; }
        public string CjenikJahteSlobodnoJezik { get; private set; }
        public string CjenikJahteSlobodnoLijevo { get; set; }
        public string CjenikJahteSlobodnoDesno { get; set; }
        #endregion

        #region Entities
		public Jahta Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_Jahta, this, nameof(Jahta)); }
            set { EntityContext<Jahta>.Set(ref m_Jahta, this, value, nameof(Jahta)); }
        }
        public Base.Valuta Valuta
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_Valuta, this, nameof(Valuta)); }
            set { EntityContext<Base.Valuta>.Set(ref m_Valuta, this, value, nameof(Valuta)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CjenikJahteSlobodno>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CjenikJahteSlobodno>(queryConditions);
        }
        public static async Task<IEnumerable<CjenikJahteSlobodno>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CjenikJahteSlobodno>(columnName, queryOp, value);
        }
		public static async Task<CjenikJahteSlobodno> GetByPrimaryKeyAsync(int CjenikJahteSlobodnoID)
        {
            return await GetByPrimaryKeyAsync<CjenikJahteSlobodno>(CjenikJahteSlobodnoID);
        }
		public static async Task<CjenikJahteSlobodno> TryGetByPrimaryKeyAsync(int CjenikJahteSlobodnoID)
        {
            return await TryGetByPrimaryKeyAsync<CjenikJahteSlobodno>(CjenikJahteSlobodnoID);
        }
		#endregion
    }
}