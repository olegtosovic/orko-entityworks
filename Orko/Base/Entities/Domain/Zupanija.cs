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

namespace Orko.Base
{
    /// <summary>
    /// Zupanija entity.
    /// </summary>
    public sealed partial class Zupanija : Entity
    {
		#region Members
		private Drzava m_FK_Zupanija_Drzava;
        #endregion
        
		#region Constructors
        static Zupanija()
        {
            // Cache field metadata.
            EntityMeta<Zupanija>.LoadColumnMetadata
			(
				new ColumnMetadata("ZupanijaZupanija", @"ZupanijaZupanija", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("ZupanijaDrzava", @"ZupanijaDrzava", SqlDbType.Char, isPrimaryKey: true),
                new ColumnMetadata("ZupanijaSjedisteGrad", @"ZupanijaSjedisteGrad", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ZupanijaSjedistePostanskiBroj", @"ZupanijaSjedistePostanskiBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("ZupanijaRegistarskiBroj", @"ZupanijaRegistarskiBroj", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ZupanijaJezik", @"ZupanijaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("ZupanijaNaziv", @"ZupanijaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Zupanija>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Zupanija_Drzava", "ZupanijaDrzava", "DrzavaDrzava")
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
		public Drzava FK_Zupanija_Drzava
        {
            get { return EntityContext<Drzava>.Get(ref m_FK_Zupanija_Drzava, this, "FK_Zupanija_Drzava"); }
            set { EntityContext<Drzava>.Set(ref m_FK_Zupanija_Drzava, this, value, "FK_Zupanija_Drzava"); }
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

        #region Public methods
		public static IEnumerable<Zupanija> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Zupanija>(queryConditions);
        }
        public static IEnumerable<Zupanija> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Zupanija>(columnName, queryOp, value);
        }
		public static Zupanija GetByPrimaryKey(string ZupanijaZupanija, string ZupanijaDrzava)
        {
            return GetByPrimaryKey<Zupanija>(ZupanijaZupanija, ZupanijaDrzava);
        }
		public static Zupanija TryGetByPrimaryKey(string ZupanijaZupanija, string ZupanijaDrzava)
        {
            return TryGetByPrimaryKey<Zupanija>(ZupanijaZupanija, ZupanijaDrzava);
        }
        #endregion
    }
}