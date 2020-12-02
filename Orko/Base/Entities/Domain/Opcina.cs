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
    /// Opcina entity.
    /// </summary>
    public sealed partial class Opcina : Entity
    {
		#region Members
		private Drzava m_FK_Opcina_Drzava;
        private Zupanija m_FK_Opcina_Zupanija;
        #endregion
        
		#region Constructors
        static Opcina()
        {
            // Cache field metadata.
            EntityMeta<Opcina>.LoadColumnMetadata
			(
				new ColumnMetadata("OpcinaOpcina", @"OpcinaOpcina", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("OpcinaDrzava", @"OpcinaDrzava", SqlDbType.Char, isPrimaryKey: true),
                new ColumnMetadata("OpcinaZupanija", @"OpcinaZupanija", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("OpcinaStopaPrireza", @"OpcinaStopaPrireza", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("OpcinaZiroRacun", @"OpcinaZiroRacun", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("OpcinaIBAN", @"OpcinaIBAN", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("OpcinaJezik", @"OpcinaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("OpcinaNaziv", @"OpcinaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Opcina>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Opcina_Drzava", "OpcinaDrzava", "DrzavaDrzava"),
                new RelationMetadata("FK_Opcina_Zupanija", "OpcinaZupanija", "ZupanijaZupanija"),
                new RelationMetadata("FK_Opcina_Zupanija", "OpcinaDrzava", "ZupanijaDrzava")
			);

			// Cache table metadata.
			EntityMeta<Opcina>.HasLanguageTable = true;
            EntityMeta<Opcina>.TableSchema = @"Base";
            EntityMeta<Opcina>.TableName = @"Opcina";
            EntityMeta<Opcina>.LanguageTableSchema = @"Base";
            EntityMeta<Opcina>.LanguageTableName = @"Opcina_jezik";
        }
        #endregion

        #region Columns
        public string OpcinaOpcina { get; set; }
        public string OpcinaDrzava { get; set; }
        public string OpcinaZupanija { get; set; }
        public decimal? OpcinaStopaPrireza { get; set; }
        public string OpcinaZiroRacun { get; set; }
        public string OpcinaIBAN { get; set; }
        public string OpcinaJezik { get; private set; }
        public string OpcinaNaziv { get; set; }
        #endregion

        #region Entities
		public Drzava FK_Opcina_Drzava
        {
            get { return EntityContext<Drzava>.Get(ref m_FK_Opcina_Drzava, this, "FK_Opcina_Drzava"); }
            set { EntityContext<Drzava>.Set(ref m_FK_Opcina_Drzava, this, value, "FK_Opcina_Drzava"); }
        }
        public Zupanija FK_Opcina_Zupanija
        {
            get { return EntityContext<Zupanija>.Get(ref m_FK_Opcina_Zupanija, this, "FK_Opcina_Zupanija"); }
            set { EntityContext<Zupanija>.Set(ref m_FK_Opcina_Zupanija, this, value, "FK_Opcina_Zupanija"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Opcina>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Opcina>(queryConditions);
        }
        public static async Task<IEnumerable<Opcina>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Opcina>(columnName, queryOp, value);
        }
		public static async Task<Opcina> GetByPrimaryKeyAsync(string OpcinaOpcina, string OpcinaDrzava)
        {
            return await GetByPrimaryKeyAsync<Opcina>(OpcinaOpcina, OpcinaDrzava);
        }
		public static async Task<Opcina> TryGetByPrimaryKeyAsync(string OpcinaOpcina, string OpcinaDrzava)
        {
            return await TryGetByPrimaryKeyAsync<Opcina>(OpcinaOpcina, OpcinaDrzava);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Opcina> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Opcina>(queryConditions);
        }
        public static IEnumerable<Opcina> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Opcina>(columnName, queryOp, value);
        }
		public static Opcina GetByPrimaryKey(string OpcinaOpcina, string OpcinaDrzava)
        {
            return GetByPrimaryKey<Opcina>(OpcinaOpcina, OpcinaDrzava);
        }
		public static Opcina TryGetByPrimaryKey(string OpcinaOpcina, string OpcinaDrzava)
        {
            return TryGetByPrimaryKey<Opcina>(OpcinaOpcina, OpcinaDrzava);
        }
        #endregion
    }
}