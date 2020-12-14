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

namespace Orko.Sistem
{
    /// <summary>
    /// Licenca entity.
    /// </summary>
    public sealed partial class Licenca : Entity
    {
		#region Members
		private Base.Firma m_Firma;
        private Sustav m_Sustav;
        private VrstaLicence m_VrstaLicence;
        #endregion
        
		#region Constructors
        static Licenca()
        {
            // Cache field metadata.
            EntityMeta<Licenca>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(LicencaID), @"LicencaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(LicencaFirma), @"LicencaFirma", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(LicencaSustav), @"LicencaSustav", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(LicencaVrstaLicence), @"LicencaVrstaLicence", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(LicencaOd), @"LicencaOd", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(LicencaDo), @"LicencaDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(LicencaAktivnost), @"LicencaAktivnost", DbType.Boolean, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Licenca>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Firma), nameof(LicencaFirma), nameof(Orko.Base.Firma.FirmaFirma)),
                new RelationMetadata(nameof(Sustav), nameof(LicencaSustav), nameof(Orko.Sistem.Sustav.SustavSustav)),
                new RelationMetadata(nameof(VrstaLicence), nameof(LicencaVrstaLicence), nameof(Orko.Sistem.VrstaLicence.VrstaLicenceVrstaLicence))
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
		public Base.Firma Firma
        {
            get { return EntityContext<Base.Firma>.Get(ref m_Firma, this, nameof(Firma)); }
            set { EntityContext<Base.Firma>.Set(ref m_Firma, this, value, nameof(Firma)); }
        }
        public Sustav Sustav
        {
            get { return EntityContext<Sustav>.Get(ref m_Sustav, this, nameof(Sustav)); }
            set { EntityContext<Sustav>.Set(ref m_Sustav, this, value, nameof(Sustav)); }
        }
        public VrstaLicence VrstaLicence
        {
            get { return EntityContext<VrstaLicence>.Get(ref m_VrstaLicence, this, nameof(VrstaLicence)); }
            set { EntityContext<VrstaLicence>.Set(ref m_VrstaLicence, this, value, nameof(VrstaLicence)); }
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
    }
}