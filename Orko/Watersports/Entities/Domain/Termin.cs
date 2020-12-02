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

namespace Orko.Watersports
{
    /// <summary>
    /// Termin entity.
    /// </summary>
    public sealed partial class Termin : Entity
    {
		#region Members
		private VrstaTermina m_FK_Termin_VrstaTermina;
        #endregion
        
		#region Constructors
        static Termin()
        {
            // Cache field metadata.
            EntityMeta<Termin>.LoadColumnMetadata
			(
				new ColumnMetadata("TerminID", @"TerminID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("TerminVrstaTermina", @"TerminVrstaTermina", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("TerminVrijemeOd", @"TerminVrijemeOd", SqlDbType.Time, isRequired: true),
                new ColumnMetadata("TerminVrijemeDo", @"TerminVrijemeDo", SqlDbType.Time, isRequired: true),
                new ColumnMetadata("TerminTrajanjeDana", @"TerminTrajanjeDana", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("TerminTrajanjeSati", @"TerminTrajanjeSati", SqlDbType.Time, isRequired: true),
                new ColumnMetadata("TerminAktivnost", @"TerminAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("TerminJezik", @"TerminJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("TerminNaziv", @"TerminNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("TerminOpis", @"TerminOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Termin>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Termin_VrstaTermina", "TerminVrstaTermina", "VrstaTerminaVrstaTermina")
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
		public VrstaTermina FK_Termin_VrstaTermina
        {
            get { return EntityContext<VrstaTermina>.Get(ref m_FK_Termin_VrstaTermina, this, "FK_Termin_VrstaTermina"); }
            set { EntityContext<VrstaTermina>.Set(ref m_FK_Termin_VrstaTermina, this, value, "FK_Termin_VrstaTermina"); }
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

        #region Public methods
		public static IEnumerable<Termin> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Termin>(queryConditions);
        }
        public static IEnumerable<Termin> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Termin>(columnName, queryOp, value);
        }
		public static Termin GetByPrimaryKey(int TerminID)
        {
            return GetByPrimaryKey<Termin>(TerminID);
        }
		public static Termin TryGetByPrimaryKey(int TerminID)
        {
            return TryGetByPrimaryKey<Termin>(TerminID);
        }
        public static Termin GetByUnique1(TimeSpan TerminVrijemeOd, TimeSpan TerminVrijemeDo, int TerminTrajanjeDana)
        {
            return GetByCallingParameters<Termin>(TerminVrijemeOd, TerminVrijemeDo, TerminTrajanjeDana);
        }
		public static Termin TryGetByUnique1(TimeSpan TerminVrijemeOd, TimeSpan TerminVrijemeDo, int TerminTrajanjeDana)
        {
            return TryGetByCallingParameters<Termin>(TerminVrijemeOd, TerminVrijemeDo, TerminTrajanjeDana);
        }
        #endregion
    }
}