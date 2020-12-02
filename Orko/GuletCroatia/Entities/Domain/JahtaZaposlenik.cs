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

namespace Orko.GuletCroatia
{
    /// <summary>
    /// JahtaZaposlenik entity.
    /// </summary>
    public sealed partial class JahtaZaposlenik : Entity
    {
		#region Members
		private Jahta m_FK_JahtaZaposlenik_Jahta;
        private VrstaZaposlenika m_FK_JahtaZaposlenik_VrstaZaposlenika;
        #endregion
        
		#region Constructors
        static JahtaZaposlenik()
        {
            // Cache field metadata.
            EntityMeta<JahtaZaposlenik>.LoadColumnMetadata
			(
				new ColumnMetadata("JahtaZaposlenikJahta", @"JahtaZaposlenikJahta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaZaposlenikVrstaZaposlenika", @"JahtaZaposlenikVrstaZaposlenika", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaZaposlenikBroj", @"JahtaZaposlenikBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("JahtaZaposlenikJezik", @"JahtaZaposlenikJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("JahtaZaposlenikDodatno", @"JahtaZaposlenikDodatno", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaZaposlenik>.LoadRelationMetadata
			(
				new RelationMetadata("FK_JahtaZaposlenik_Jahta", "JahtaZaposlenikJahta", "JahtaJahta"),
                new RelationMetadata("FK_JahtaZaposlenik_VrstaZaposlenika", "JahtaZaposlenikVrstaZaposlenika", "VrstaZaposlenikaVrstaZaposlenika")
			);

			// Cache table metadata.
			EntityMeta<JahtaZaposlenik>.HasLanguageTable = true;
            EntityMeta<JahtaZaposlenik>.TableSchema = @"GuletCroatia";
            EntityMeta<JahtaZaposlenik>.TableName = @"JahtaZaposlenik";
            EntityMeta<JahtaZaposlenik>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<JahtaZaposlenik>.LanguageTableName = @"JahtaZaposlenik_jezik";
        }
        #endregion

        #region Columns
        public string JahtaZaposlenikJahta { get; set; }
        public string JahtaZaposlenikVrstaZaposlenika { get; set; }
        public int? JahtaZaposlenikBroj { get; set; }
        public string JahtaZaposlenikJezik { get; private set; }
        public string JahtaZaposlenikDodatno { get; set; }
        #endregion

        #region Entities
		public Jahta FK_JahtaZaposlenik_Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_FK_JahtaZaposlenik_Jahta, this, "FK_JahtaZaposlenik_Jahta"); }
            set { EntityContext<Jahta>.Set(ref m_FK_JahtaZaposlenik_Jahta, this, value, "FK_JahtaZaposlenik_Jahta"); }
        }
        public VrstaZaposlenika FK_JahtaZaposlenik_VrstaZaposlenika
        {
            get { return EntityContext<VrstaZaposlenika>.Get(ref m_FK_JahtaZaposlenik_VrstaZaposlenika, this, "FK_JahtaZaposlenik_VrstaZaposlenika"); }
            set { EntityContext<VrstaZaposlenika>.Set(ref m_FK_JahtaZaposlenik_VrstaZaposlenika, this, value, "FK_JahtaZaposlenik_VrstaZaposlenika"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<JahtaZaposlenik>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<JahtaZaposlenik>(queryConditions);
        }
        public static async Task<IEnumerable<JahtaZaposlenik>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<JahtaZaposlenik>(columnName, queryOp, value);
        }
		public static async Task<JahtaZaposlenik> GetByPrimaryKeyAsync(string JahtaZaposlenikJahta, string JahtaZaposlenikVrstaZaposlenika)
        {
            return await GetByPrimaryKeyAsync<JahtaZaposlenik>(JahtaZaposlenikJahta, JahtaZaposlenikVrstaZaposlenika);
        }
		public static async Task<JahtaZaposlenik> TryGetByPrimaryKeyAsync(string JahtaZaposlenikJahta, string JahtaZaposlenikVrstaZaposlenika)
        {
            return await TryGetByPrimaryKeyAsync<JahtaZaposlenik>(JahtaZaposlenikJahta, JahtaZaposlenikVrstaZaposlenika);
        }
		#endregion

        #region Public methods
		public static IEnumerable<JahtaZaposlenik> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<JahtaZaposlenik>(queryConditions);
        }
        public static IEnumerable<JahtaZaposlenik> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<JahtaZaposlenik>(columnName, queryOp, value);
        }
		public static JahtaZaposlenik GetByPrimaryKey(string JahtaZaposlenikJahta, string JahtaZaposlenikVrstaZaposlenika)
        {
            return GetByPrimaryKey<JahtaZaposlenik>(JahtaZaposlenikJahta, JahtaZaposlenikVrstaZaposlenika);
        }
		public static JahtaZaposlenik TryGetByPrimaryKey(string JahtaZaposlenikJahta, string JahtaZaposlenikVrstaZaposlenika)
        {
            return TryGetByPrimaryKey<JahtaZaposlenik>(JahtaZaposlenikJahta, JahtaZaposlenikVrstaZaposlenika);
        }
        #endregion
    }
}