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
    /// JahtaZaposlenik entity.
    /// </summary>
    public sealed partial class JahtaZaposlenik : Entity
    {
		#region Members
		private Jahta m_Jahta;
        private VrstaZaposlenika m_VrstaZaposlenika;
        #endregion
        
		#region Constructors
        static JahtaZaposlenik()
        {
            // Cache field metadata.
            EntityMeta<JahtaZaposlenik>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(JahtaZaposlenikJahta), @"JahtaZaposlenikJahta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaZaposlenikVrstaZaposlenika), @"JahtaZaposlenikVrstaZaposlenika", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaZaposlenikBroj), @"JahtaZaposlenikBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(JahtaZaposlenikJezik), @"JahtaZaposlenikJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(JahtaZaposlenikDodatno), @"JahtaZaposlenikDodatno", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaZaposlenik>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Jahta), nameof(JahtaZaposlenikJahta), nameof(Orko.GuletCroatia.Jahta.JahtaJahta)),
                new RelationMetadata(nameof(VrstaZaposlenika), nameof(JahtaZaposlenikVrstaZaposlenika), nameof(Orko.GuletCroatia.VrstaZaposlenika.VrstaZaposlenikaVrstaZaposlenika))
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
		public Jahta Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_Jahta, this, nameof(Jahta)); }
            set { EntityContext<Jahta>.Set(ref m_Jahta, this, value, nameof(Jahta)); }
        }
        public VrstaZaposlenika VrstaZaposlenika
        {
            get { return EntityContext<VrstaZaposlenika>.Get(ref m_VrstaZaposlenika, this, nameof(VrstaZaposlenika)); }
            set { EntityContext<VrstaZaposlenika>.Set(ref m_VrstaZaposlenika, this, value, nameof(VrstaZaposlenika)); }
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
    }
}