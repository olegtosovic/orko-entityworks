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
    /// JahtaOprema entity.
    /// </summary>
    public sealed partial class JahtaOprema : Entity
    {
		#region Members
		private Jahta m_Jahta1;
        private VrstaOpreme m_VrstaOpreme;
        #endregion
        
		#region Constructors
        static JahtaOprema()
        {
            // Cache field metadata.
            EntityMeta<JahtaOprema>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(JahtaOpremaJahta), @"JahtaOpremaJahta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaOpremaVrstaOpreme), @"JahtaOpremaVrstaOpreme", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(JahtaOpremaBroj), @"JahtaOpremaBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(JahtaOpremaAktivnost), @"JahtaOpremaAktivnost", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(JahtaOpremaJezik), @"JahtaOpremaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(JahtaOpremaDodatno), @"JahtaOpremaDodatno", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<JahtaOprema>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Jahta1), nameof(JahtaOpremaJahta), nameof(Orko.GuletCroatia.Jahta.JahtaJahta)),
                new RelationMetadata(nameof(VrstaOpreme), nameof(JahtaOpremaVrstaOpreme), nameof(Orko.GuletCroatia.VrstaOpreme.VrstaOpremeVrstaOpreme))
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
		public Jahta Jahta1
        {
            get { return EntityContext<Jahta>.Get(ref m_Jahta1, this, nameof(Jahta1)); }
            set { EntityContext<Jahta>.Set(ref m_Jahta1, this, value, nameof(Jahta1)); }
        }
        public VrstaOpreme VrstaOpreme
        {
            get { return EntityContext<VrstaOpreme>.Get(ref m_VrstaOpreme, this, nameof(VrstaOpreme)); }
            set { EntityContext<VrstaOpreme>.Set(ref m_VrstaOpreme, this, value, nameof(VrstaOpreme)); }
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
    }
}