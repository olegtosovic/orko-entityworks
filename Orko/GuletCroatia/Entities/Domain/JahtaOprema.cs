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
    /// JahtaOprema entity.
    /// </summary>
    public sealed partial class JahtaOprema : Entity
    {
		#region Members
		private Jahta m_FK_JahtaOprema_Jahta1;
        private VrstaOpreme m_FK_JahtaOprema_VrstaOpreme;
        #endregion
        
		#region Constructors
        static JahtaOprema()
        {
            // Cache field metadata.
            EntityMeta<JahtaOprema>.LoadColumnMetadata
			(
				new ColumnMetadata("JahtaOpremaJahta", @"JahtaOpremaJahta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaOpremaVrstaOpreme", @"JahtaOpremaVrstaOpreme", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaOpremaBroj", @"JahtaOpremaBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("JahtaOpremaAktivnost", @"JahtaOpremaAktivnost", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("JahtaOpremaJezik", @"JahtaOpremaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("JahtaOpremaDodatno", @"JahtaOpremaDodatno", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaOprema>.LoadRelationMetadata
			(
				new RelationMetadata("FK_JahtaOprema_Jahta1", "JahtaOpremaJahta", "JahtaJahta"),
                new RelationMetadata("FK_JahtaOprema_VrstaOpreme", "JahtaOpremaVrstaOpreme", "VrstaOpremeVrstaOpreme")
			);

			// Cache table metadata.
			EntityMeta<JahtaOprema>.HasLanguageTable = true;
            EntityMeta<JahtaOprema>.TableSchema = @"GuletCroatia";
            EntityMeta<JahtaOprema>.TableName = @"JahtaOprema";
            EntityMeta<JahtaOprema>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<JahtaOprema>.LanguageTableName = @"JahtaOprema_jezik";
        }
        #endregion

        #region Columns
        public string JahtaOpremaJahta { get; set; }
        public string JahtaOpremaVrstaOpreme { get; set; }
        public int? JahtaOpremaBroj { get; set; }
        public bool? JahtaOpremaAktivnost { get; set; }
        public string JahtaOpremaJezik { get; private set; }
        public string JahtaOpremaDodatno { get; set; }
        #endregion

        #region Entities
		public Jahta FK_JahtaOprema_Jahta1
        {
            get { return EntityContext<Jahta>.Get(ref m_FK_JahtaOprema_Jahta1, this, "FK_JahtaOprema_Jahta1"); }
            set { EntityContext<Jahta>.Set(ref m_FK_JahtaOprema_Jahta1, this, value, "FK_JahtaOprema_Jahta1"); }
        }
        public VrstaOpreme FK_JahtaOprema_VrstaOpreme
        {
            get { return EntityContext<VrstaOpreme>.Get(ref m_FK_JahtaOprema_VrstaOpreme, this, "FK_JahtaOprema_VrstaOpreme"); }
            set { EntityContext<VrstaOpreme>.Set(ref m_FK_JahtaOprema_VrstaOpreme, this, value, "FK_JahtaOprema_VrstaOpreme"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<JahtaOprema>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<JahtaOprema>(queryConditions);
        }
        public static async Task<IEnumerable<JahtaOprema>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<JahtaOprema>(columnName, queryOp, value);
        }
		public static async Task<JahtaOprema> GetByPrimaryKeyAsync(string JahtaOpremaJahta, string JahtaOpremaVrstaOpreme)
        {
            return await GetByPrimaryKeyAsync<JahtaOprema>(JahtaOpremaJahta, JahtaOpremaVrstaOpreme);
        }
		public static async Task<JahtaOprema> TryGetByPrimaryKeyAsync(string JahtaOpremaJahta, string JahtaOpremaVrstaOpreme)
        {
            return await TryGetByPrimaryKeyAsync<JahtaOprema>(JahtaOpremaJahta, JahtaOpremaVrstaOpreme);
        }
		#endregion

        #region Public methods
		public static IEnumerable<JahtaOprema> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<JahtaOprema>(queryConditions);
        }
        public static IEnumerable<JahtaOprema> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<JahtaOprema>(columnName, queryOp, value);
        }
		public static JahtaOprema GetByPrimaryKey(string JahtaOpremaJahta, string JahtaOpremaVrstaOpreme)
        {
            return GetByPrimaryKey<JahtaOprema>(JahtaOpremaJahta, JahtaOpremaVrstaOpreme);
        }
		public static JahtaOprema TryGetByPrimaryKey(string JahtaOpremaJahta, string JahtaOpremaVrstaOpreme)
        {
            return TryGetByPrimaryKey<JahtaOprema>(JahtaOpremaJahta, JahtaOpremaVrstaOpreme);
        }
        #endregion
    }
}