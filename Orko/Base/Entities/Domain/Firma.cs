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

namespace Orko.Base
{
    /// <summary>
    /// Firma entity.
    /// </summary>
    public sealed partial class Firma : Entity
    {
		#region Members
		private Drzava m_Drzava;
        private Posta m_Posta;
        #endregion
        
		#region Constructors
        static Firma()
        {
            // Cache field metadata.
            EntityMeta<Firma>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(FirmaFirma), @"FirmaFirma", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(FirmaMaticniBroj), @"FirmaMaticniBroj", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(FirmaOIB), @"FirmaOIB", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(FirmaAdresa), @"FirmaAdresa", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(FirmaDrzava), @"FirmaDrzava", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(FirmaPosta), @"FirmaPosta", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(FirmaTelefon), @"FirmaTelefon", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(FirmaFax), @"FirmaFax", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(FirmaMobitel), @"FirmaMobitel", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(FirmaEmail), @"FirmaEmail", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(FirmaBaza), @"FirmaBaza", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(FirmaBazaPrikaz), @"FirmaBazaPrikaz", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(FirmaJezik), @"FirmaJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(FirmaNaziv), @"FirmaNaziv", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Firma>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Drzava), nameof(FirmaDrzava), nameof(Orko.Base.Drzava.DrzavaDrzava)),
                new RelationMetadata(nameof(Posta), nameof(FirmaPosta), nameof(Orko.Base.Posta.PostaPosta)),
                new RelationMetadata(nameof(Posta), nameof(FirmaDrzava), nameof(Orko.Base.Posta.PostaDrzava))
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
		public Drzava Drzava
        {
            get { return EntityContext<Drzava>.Get(ref m_Drzava, this, nameof(Drzava)); }
            set { EntityContext<Drzava>.Set(ref m_Drzava, this, value, nameof(Drzava)); }
        }
        public Posta Posta
        {
            get { return EntityContext<Posta>.Get(ref m_Posta, this, nameof(Posta)); }
            set { EntityContext<Posta>.Set(ref m_Posta, this, value, nameof(Posta)); }
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
    }
}