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

namespace Orko.Base
{
    /// <summary>
    /// Zupanija entity.
    /// </summary>
    public sealed partial class Zupanija : Entity
    {
		#region Members
		private Drzava m_Drzava;
        #endregion
        
		#region Constructors
        static Zupanija()
        {
            // Cache field metadata.
            EntityMeta<Zupanija>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ZupanijaZupanija), @"ZupanijaZupanija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ZupanijaDrzava), @"ZupanijaDrzava", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(ZupanijaSjedisteGrad), @"ZupanijaSjedisteGrad", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ZupanijaSjedistePostanskiBroj), @"ZupanijaSjedistePostanskiBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(ZupanijaRegistarskiBroj), @"ZupanijaRegistarskiBroj", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ZupanijaJezik), @"ZupanijaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(ZupanijaNaziv), @"ZupanijaNaziv", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Zupanija>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Drzava), nameof(ZupanijaDrzava), nameof(Orko.Base.Drzava.DrzavaDrzava))
			);

			// Cache table metadata.
			EntityMeta<Zupanija>.HasLanguageTable = true;
            EntityMeta<Zupanija>.TableSchema = @"Base";
            EntityMeta<Zupanija>.TableName = @"Zupanija";
            EntityMeta<Zupanija>.LanguageTableSchema = @"Base";
            EntityMeta<Zupanija>.LanguageTableName = @"Zupanija_jezik";
        }
        #endregion

        #region Columns
        public string ZupanijaZupanija { get; set; }
        public string ZupanijaDrzava { get; set; }
        public string ZupanijaSjedisteGrad { get; set; }
        public int? ZupanijaSjedistePostanskiBroj { get; set; }
        public string ZupanijaRegistarskiBroj { get; set; }
        public string ZupanijaJezik { get; private set; }
        public string ZupanijaNaziv { get; set; }
        #endregion

        #region Entities
		public Drzava Drzava
        {
            get { return EntityContext<Drzava>.Get(ref m_Drzava, this, nameof(Drzava)); }
            set { EntityContext<Drzava>.Set(ref m_Drzava, this, value, nameof(Drzava)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Zupanija>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Zupanija>(queryConditions);
        }
        public static async Task<IEnumerable<Zupanija>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Zupanija>(columnName, queryOp, value);
        }
		public static async Task<Zupanija> GetByPrimaryKeyAsync(string ZupanijaZupanija, string ZupanijaDrzava)
        {
            return await GetByPrimaryKeyAsync<Zupanija>(ZupanijaZupanija, ZupanijaDrzava);
        }
		public static async Task<Zupanija> TryGetByPrimaryKeyAsync(string ZupanijaZupanija, string ZupanijaDrzava)
        {
            return await TryGetByPrimaryKeyAsync<Zupanija>(ZupanijaZupanija, ZupanijaDrzava);
        }
		#endregion
    }
}