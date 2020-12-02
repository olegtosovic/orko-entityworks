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
    /// JahtaKabina entity.
    /// </summary>
    public sealed partial class JahtaKabina : Entity
    {
		#region Members
		private Jahta m_FK_JahtaKabina_Jahta;
        private VrstaKabine m_FK_JahtaKabina_VrstaKabine;
        #endregion
        
		#region Constructors
        static JahtaKabina()
        {
            // Cache field metadata.
            EntityMeta<JahtaKabina>.LoadColumnMetadata
			(
				new ColumnMetadata("JahtaKabinaJahta", @"JahtaKabinaJahta", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaKabinaVrstaKabine", @"JahtaKabinaVrstaKabine", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("JahtaKabinaBroj", @"JahtaKabinaBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("JahtaKabinaJezik", @"JahtaKabinaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("JahtaKabinaDodatno", @"JahtaKabinaDodatno", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaKabina>.LoadRelationMetadata
			(
				new RelationMetadata("FK_JahtaKabina_Jahta", "JahtaKabinaJahta", "JahtaJahta"),
                new RelationMetadata("FK_JahtaKabina_VrstaKabine", "JahtaKabinaVrstaKabine", "VrstaKabineVrstaKabine")
			);

			// Cache table metadata.
			EntityMeta<JahtaKabina>.HasLanguageTable = true;
            EntityMeta<JahtaKabina>.TableSchema = @"GuletCroatia";
            EntityMeta<JahtaKabina>.TableName = @"JahtaKabina";
            EntityMeta<JahtaKabina>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<JahtaKabina>.LanguageTableName = @"JahtaKabina_jezik";
        }
        #endregion

        #region Columns
        public string JahtaKabinaJahta { get; set; }
        public string JahtaKabinaVrstaKabine { get; set; }
        public int? JahtaKabinaBroj { get; set; }
        public string JahtaKabinaJezik { get; private set; }
        public string JahtaKabinaDodatno { get; set; }
        #endregion

        #region Entities
		public Jahta FK_JahtaKabina_Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_FK_JahtaKabina_Jahta, this, "FK_JahtaKabina_Jahta"); }
            set { EntityContext<Jahta>.Set(ref m_FK_JahtaKabina_Jahta, this, value, "FK_JahtaKabina_Jahta"); }
        }
        public VrstaKabine FK_JahtaKabina_VrstaKabine
        {
            get { return EntityContext<VrstaKabine>.Get(ref m_FK_JahtaKabina_VrstaKabine, this, "FK_JahtaKabina_VrstaKabine"); }
            set { EntityContext<VrstaKabine>.Set(ref m_FK_JahtaKabina_VrstaKabine, this, value, "FK_JahtaKabina_VrstaKabine"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<JahtaKabina>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<JahtaKabina>(queryConditions);
        }
        public static async Task<IEnumerable<JahtaKabina>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<JahtaKabina>(columnName, queryOp, value);
        }
		public static async Task<JahtaKabina> GetByPrimaryKeyAsync(string JahtaKabinaJahta, string JahtaKabinaVrstaKabine)
        {
            return await GetByPrimaryKeyAsync<JahtaKabina>(JahtaKabinaJahta, JahtaKabinaVrstaKabine);
        }
		public static async Task<JahtaKabina> TryGetByPrimaryKeyAsync(string JahtaKabinaJahta, string JahtaKabinaVrstaKabine)
        {
            return await TryGetByPrimaryKeyAsync<JahtaKabina>(JahtaKabinaJahta, JahtaKabinaVrstaKabine);
        }
		#endregion

        #region Public methods
		public static IEnumerable<JahtaKabina> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<JahtaKabina>(queryConditions);
        }
        public static IEnumerable<JahtaKabina> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<JahtaKabina>(columnName, queryOp, value);
        }
		public static JahtaKabina GetByPrimaryKey(string JahtaKabinaJahta, string JahtaKabinaVrstaKabine)
        {
            return GetByPrimaryKey<JahtaKabina>(JahtaKabinaJahta, JahtaKabinaVrstaKabine);
        }
		public static JahtaKabina TryGetByPrimaryKey(string JahtaKabinaJahta, string JahtaKabinaVrstaKabine)
        {
            return TryGetByPrimaryKey<JahtaKabina>(JahtaKabinaJahta, JahtaKabinaVrstaKabine);
        }
        #endregion
    }
}