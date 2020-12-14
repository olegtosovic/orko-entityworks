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
    /// Opcina entity.
    /// </summary>
    public sealed partial class Opcina : Entity
    {
		#region Members
		private Drzava m_Drzava;
        private Zupanija m_Zupanija;
        #endregion
        
		#region Constructors
        static Opcina()
        {
            // Cache field metadata.
            EntityMeta<Opcina>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(OpcinaOpcina), @"OpcinaOpcina", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(OpcinaDrzava), @"OpcinaDrzava", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(OpcinaZupanija), @"OpcinaZupanija", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(OpcinaStopaPrireza), @"OpcinaStopaPrireza", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(OpcinaZiroRacun), @"OpcinaZiroRacun", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(OpcinaIBAN), @"OpcinaIBAN", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(OpcinaJezik), @"OpcinaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(OpcinaNaziv), @"OpcinaNaziv", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Opcina>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Drzava), nameof(OpcinaDrzava), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(Zupanija), nameof(OpcinaZupanija), nameof(Orko.Base.Zupanija.ZupanijaZupanija)),
                new RelationMetadata(nameof(Zupanija), nameof(OpcinaDrzava), nameof(Orko.Base.Zupanija.ZupanijaDrzava))
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
		public Drzava Drzava
        {
            get { return EntityContext<Drzava>.Get(ref m_Drzava, this, nameof(Drzava)); }
            set { EntityContext<Drzava>.Set(ref m_Drzava, this, value, nameof(Drzava)); }
        }
        public Zupanija Zupanija
        {
            get { return EntityContext<Zupanija>.Get(ref m_Zupanija, this, nameof(Zupanija)); }
            set { EntityContext<Zupanija>.Set(ref m_Zupanija, this, value, nameof(Zupanija)); }
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
    }
}