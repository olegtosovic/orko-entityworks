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

namespace Orko.Sistem
{
    /// <summary>
    /// Licenca entity.
    /// </summary>
    public sealed partial class Licenca : Entity
    {
		#region Members
		private Base.Firma m_FK_Licenca_Firma;
        private Sustav m_FK_Licenca_Sustav;
        private VrstaLicence m_FK_Licenca_VrstaLicence;
        #endregion
        
		#region Constructors
        static Licenca()
        {
            // Cache field metadata.
            EntityMeta<Licenca>.LoadColumnMetadata
			(
				new ColumnMetadata("LicencaID", @"LicencaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("LicencaFirma", @"LicencaFirma", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("LicencaSustav", @"LicencaSustav", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("LicencaVrstaLicence", @"LicencaVrstaLicence", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("LicencaOd", @"LicencaOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("LicencaDo", @"LicencaDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("LicencaAktivnost", @"LicencaAktivnost", SqlDbType.Bit, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Licenca>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Licenca_Firma", "LicencaFirma", "FirmaFirma"),
                new RelationMetadata("FK_Licenca_Sustav", "LicencaSustav", "SustavSustav"),
                new RelationMetadata("FK_Licenca_VrstaLicence", "LicencaVrstaLicence", "VrstaLicenceVrstaLicence")
			);

			// Cache table metadata.
			EntityMeta<Licenca>.HasLanguageTable = false;
            EntityMeta<Licenca>.TableSchema = @"Sistem";
            EntityMeta<Licenca>.TableName = @"Licenca";
            EntityMeta<Licenca>.LanguageTableSchema = null;
            EntityMeta<Licenca>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? LicencaID { get; private set; }
        public string LicencaFirma { get; set; }
        public string LicencaSustav { get; set; }
        public string LicencaVrstaLicence { get; set; }
        public DateTime? LicencaOd { get; set; }
        public DateTime? LicencaDo { get; set; }
        public bool? LicencaAktivnost { get; set; }
        #endregion

        #region Entities
		public Base.Firma FK_Licenca_Firma
        {
            get { return EntityContext<Base.Firma>.Get(ref m_FK_Licenca_Firma, this, "FK_Licenca_Firma"); }
            set { EntityContext<Base.Firma>.Set(ref m_FK_Licenca_Firma, this, value, "FK_Licenca_Firma"); }
        }
        public Sustav FK_Licenca_Sustav
        {
            get { return EntityContext<Sustav>.Get(ref m_FK_Licenca_Sustav, this, "FK_Licenca_Sustav"); }
            set { EntityContext<Sustav>.Set(ref m_FK_Licenca_Sustav, this, value, "FK_Licenca_Sustav"); }
        }
        public VrstaLicence FK_Licenca_VrstaLicence
        {
            get { return EntityContext<VrstaLicence>.Get(ref m_FK_Licenca_VrstaLicence, this, "FK_Licenca_VrstaLicence"); }
            set { EntityContext<VrstaLicence>.Set(ref m_FK_Licenca_VrstaLicence, this, value, "FK_Licenca_VrstaLicence"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Licenca>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Licenca>(queryConditions);
        }
        public static async Task<IEnumerable<Licenca>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Licenca>(columnName, queryOp, value);
        }
		public static async Task<Licenca> GetByPrimaryKeyAsync(int LicencaID)
        {
            return await GetByPrimaryKeyAsync<Licenca>(LicencaID);
        }
		public static async Task<Licenca> TryGetByPrimaryKeyAsync(int LicencaID)
        {
            return await TryGetByPrimaryKeyAsync<Licenca>(LicencaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Licenca> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Licenca>(queryConditions);
        }
        public static IEnumerable<Licenca> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Licenca>(columnName, queryOp, value);
        }
		public static Licenca GetByPrimaryKey(int LicencaID)
        {
            return GetByPrimaryKey<Licenca>(LicencaID);
        }
		public static Licenca TryGetByPrimaryKey(int LicencaID)
        {
            return TryGetByPrimaryKey<Licenca>(LicencaID);
        }
        #endregion
    }
}