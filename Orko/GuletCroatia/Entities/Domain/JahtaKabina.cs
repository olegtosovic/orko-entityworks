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
    /// JahtaKabina entity.
    /// </summary>
    public sealed partial class JahtaKabina : Entity
    {
		#region Members
		private Jahta m_Jahta;
        private VrstaKabine m_VrstaKabine;
        #endregion
        
		#region Constructors
        static JahtaKabina()
        {
            // Cache field metadata.
            EntityMeta<JahtaKabina>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(JahtaKabinaJahta), @"JahtaKabinaJahta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaKabinaVrstaKabine), @"JahtaKabinaVrstaKabine", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaKabinaBroj), @"JahtaKabinaBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(JahtaKabinaJezik), @"JahtaKabinaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(JahtaKabinaDodatno), @"JahtaKabinaDodatno", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaKabina>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Jahta), nameof(JahtaKabinaJahta), nameof(Orko.GuletCroatia.Jahta.JahtaJahta)),
                new RelationMetadata(nameof(VrstaKabine), nameof(JahtaKabinaVrstaKabine), nameof(Orko.GuletCroatia.VrstaKabine.VrstaKabineVrstaKabine))
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
		public Jahta Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_Jahta, this, nameof(Jahta)); }
            set { EntityContext<Jahta>.Set(ref m_Jahta, this, value, nameof(Jahta)); }
        }
        public VrstaKabine VrstaKabine
        {
            get { return EntityContext<VrstaKabine>.Get(ref m_VrstaKabine, this, nameof(VrstaKabine)); }
            set { EntityContext<VrstaKabine>.Set(ref m_VrstaKabine, this, value, nameof(VrstaKabine)); }
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
    }
}