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

namespace Orko.Watersports
{
    /// <summary>
    /// Termin entity.
    /// </summary>
    public sealed partial class Termin : Entity
    {
		#region Members
		private VrstaTermina m_VrstaTermina;
        #endregion
        
		#region Constructors
        static Termin()
        {
            // Cache field metadata.
            EntityMeta<Termin>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TerminID), @"TerminID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(TerminVrstaTermina), @"TerminVrstaTermina", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(TerminVrijemeOd), @"TerminVrijemeOd", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(TerminVrijemeDo), @"TerminVrijemeDo", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(TerminTrajanjeDana), @"TerminTrajanjeDana", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TerminTrajanjeSati), @"TerminTrajanjeSati", DbType.Time, isRequired: true),
                new ColumnMetadata(nameof(TerminAktivnost), @"TerminAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(TerminJezik), @"TerminJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(TerminNaziv), @"TerminNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(TerminOpis), @"TerminOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Termin>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(VrstaTermina), nameof(TerminVrstaTermina), nameof(Orko.Watersports.VrstaTermina.VrstaTerminaVrstaTermina))
			);

			// Cache table metadata.
			EntityMeta<Termin>.HasLanguageTable = true;
            EntityMeta<Termin>.TableSchema = @"Watersports";
            EntityMeta<Termin>.TableName = @"Termin";
            EntityMeta<Termin>.LanguageTableSchema = @"Watersports";
            EntityMeta<Termin>.LanguageTableName = @"Termin_jezik";
        }
        #endregion

        #region Columns
        public int? TerminID { get; private set; }
        public string TerminVrstaTermina { get; set; }
        public TimeSpan? TerminVrijemeOd { get; set; }
        public TimeSpan? TerminVrijemeDo { get; set; }
        public int? TerminTrajanjeDana { get; set; }
        public TimeSpan? TerminTrajanjeSati { get; set; }
        public bool? TerminAktivnost { get; set; }
        public string TerminJezik { get; private set; }
        public string TerminNaziv { get; set; }
        public string TerminOpis { get; set; }
        #endregion

        #region Entities
		public VrstaTermina VrstaTermina
        {
            get { return EntityContext<VrstaTermina>.Get(ref m_VrstaTermina, this, nameof(VrstaTermina)); }
            set { EntityContext<VrstaTermina>.Set(ref m_VrstaTermina, this, value, nameof(VrstaTermina)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Termin>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Termin>(queryConditions);
        }
        public static async Task<IEnumerable<Termin>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Termin>(columnName, queryOp, value);
        }
		public static async Task<Termin> GetByPrimaryKeyAsync(int TerminID)
        {
            return await GetByPrimaryKeyAsync<Termin>(TerminID);
        }
		public static async Task<Termin> TryGetByPrimaryKeyAsync(int TerminID)
        {
            return await TryGetByPrimaryKeyAsync<Termin>(TerminID);
        }
		#endregion
    }
}