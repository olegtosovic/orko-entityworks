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

namespace Orko.Base
{
    /// <summary>
    /// Firma entity.
    /// </summary>
    public sealed partial class Firma : Entity
    {
		#region Members
		private Drzava m_FK_Firma_Drzava;
        private Posta m_FK_Firma_Posta;
        #endregion
        
		#region Constructors
        static Firma()
        {
            // Cache field metadata.
            EntityMeta<Firma>.LoadColumnMetadata
			(
				new ColumnMetadata("FirmaFirma", @"FirmaFirma", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("FirmaMaticniBroj", @"FirmaMaticniBroj", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("FirmaOIB", @"FirmaOIB", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("FirmaAdresa", @"FirmaAdresa", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("FirmaDrzava", @"FirmaDrzava", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("FirmaPosta", @"FirmaPosta", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("FirmaTelefon", @"FirmaTelefon", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("FirmaFax", @"FirmaFax", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("FirmaMobitel", @"FirmaMobitel", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("FirmaEmail", @"FirmaEmail", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("FirmaBaza", @"FirmaBaza", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("FirmaBazaPrikaz", @"FirmaBazaPrikaz", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("FirmaJezik", @"FirmaJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("FirmaNaziv", @"FirmaNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Firma>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Firma_Drzava", "FirmaDrzava", "DrzavaDrzava"),
                new RelationMetadata("FK_Firma_Posta", "FirmaPosta", "PostaPosta"),
                new RelationMetadata("FK_Firma_Posta", "FirmaDrzava", "PostaDrzava")
			);

			// Cache table metadata.
			EntityMeta<Firma>.HasLanguageTable = true;
            EntityMeta<Firma>.TableSchema = @"Base";
            EntityMeta<Firma>.TableName = @"Firma";
            EntityMeta<Firma>.LanguageTableSchema = @"Base";
            EntityMeta<Firma>.LanguageTableName = @"Firma_jezik";
        }
        #endregion

        #region Columns
        public string FirmaFirma { get; set; }
        public string FirmaMaticniBroj { get; set; }
        public string FirmaOIB { get; set; }
        public string FirmaAdresa { get; set; }
        public string FirmaDrzava { get; set; }
        public int? FirmaPosta { get; set; }
        public string FirmaTelefon { get; set; }
        public string FirmaFax { get; set; }
        public string FirmaMobitel { get; set; }
        public string FirmaEmail { get; set; }
        public string FirmaBaza { get; set; }
        public string FirmaBazaPrikaz { get; set; }
        public string FirmaJezik { get; private set; }
        public string FirmaNaziv { get; set; }
        #endregion

        #region Entities
		public Drzava FK_Firma_Drzava
        {
            get { return EntityContext<Drzava>.Get(ref m_FK_Firma_Drzava, this, "FK_Firma_Drzava"); }
            set { EntityContext<Drzava>.Set(ref m_FK_Firma_Drzava, this, value, "FK_Firma_Drzava"); }
        }
        public Posta FK_Firma_Posta
        {
            get { return EntityContext<Posta>.Get(ref m_FK_Firma_Posta, this, "FK_Firma_Posta"); }
            set { EntityContext<Posta>.Set(ref m_FK_Firma_Posta, this, value, "FK_Firma_Posta"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Firma>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Firma>(queryConditions);
        }
        public static async Task<IEnumerable<Firma>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Firma>(columnName, queryOp, value);
        }
		public static async Task<Firma> GetByPrimaryKeyAsync(string FirmaFirma)
        {
            return await GetByPrimaryKeyAsync<Firma>(FirmaFirma);
        }
		public static async Task<Firma> TryGetByPrimaryKeyAsync(string FirmaFirma)
        {
            return await TryGetByPrimaryKeyAsync<Firma>(FirmaFirma);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Firma> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Firma>(queryConditions);
        }
        public static IEnumerable<Firma> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Firma>(columnName, queryOp, value);
        }
		public static Firma GetByPrimaryKey(string FirmaFirma)
        {
            return GetByPrimaryKey<Firma>(FirmaFirma);
        }
		public static Firma TryGetByPrimaryKey(string FirmaFirma)
        {
            return TryGetByPrimaryKey<Firma>(FirmaFirma);
        }
        #endregion
    }
}