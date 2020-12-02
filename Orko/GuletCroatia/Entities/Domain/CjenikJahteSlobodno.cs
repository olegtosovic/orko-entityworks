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
    /// CjenikJahteSlobodno entity.
    /// </summary>
    public sealed partial class CjenikJahteSlobodno : Entity
    {
		#region Members
		private Jahta m_FK_CjenikJahtaSlobodno_Jahta;
        private Base.Valuta m_FK_CjenikJahteSlobodno_Valuta;
        #endregion
        
		#region Constructors
        static CjenikJahteSlobodno()
        {
            // Cache field metadata.
            EntityMeta<CjenikJahteSlobodno>.LoadColumnMetadata
			(
				new ColumnMetadata("CjenikJahteSlobodnoID", @"CjenikJahteSlobodnoID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("CjenikJahteSlobodnoJahta", @"CjenikJahteSlobodnoJahta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("CjenikJahteSlobodnoCijena2", @"CjenikJahteSlobodnoCijena2", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikJahteSlobodnoValuta2", @"CjenikJahteSlobodnoValuta2", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("CjenikJahteSlobodnoAktivnost", @"CjenikJahteSlobodnoAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("CjenikJahteSlobodnoJezik", @"CjenikJahteSlobodnoJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("CjenikJahteSlobodnoLijevo", @"CjenikJahteSlobodnoLijevo", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("CjenikJahteSlobodnoDesno", @"CjenikJahteSlobodnoDesno", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<CjenikJahteSlobodno>.LoadRelationMetadata
			(
				new RelationMetadata("FK_CjenikJahtaSlobodno_Jahta", "CjenikJahteSlobodnoJahta", "JahtaJahta"),
                new RelationMetadata("FK_CjenikJahteSlobodno_Valuta", "CjenikJahteSlobodnoValuta2", "ValutaValuta")
			);

			// Cache table metadata.
			EntityMeta<CjenikJahteSlobodno>.HasLanguageTable = true;
            EntityMeta<CjenikJahteSlobodno>.TableSchema = @"GuletCroatia";
            EntityMeta<CjenikJahteSlobodno>.TableName = @"CjenikJahteSlobodno";
            EntityMeta<CjenikJahteSlobodno>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<CjenikJahteSlobodno>.LanguageTableName = @"CjenikJahteSlobodno_jezik";
        }
        #endregion

        #region Columns
        public int? CjenikJahteSlobodnoID { get; private set; }
        public string CjenikJahteSlobodnoJahta { get; set; }
        public decimal? CjenikJahteSlobodnoCijena2 { get; set; }
        public string CjenikJahteSlobodnoValuta2 { get; set; }
        public bool? CjenikJahteSlobodnoAktivnost { get; set; }
        public string CjenikJahteSlobodnoJezik { get; private set; }
        public string CjenikJahteSlobodnoLijevo { get; set; }
        public string CjenikJahteSlobodnoDesno { get; set; }
        #endregion

        #region Entities
		public Jahta FK_CjenikJahtaSlobodno_Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_FK_CjenikJahtaSlobodno_Jahta, this, "FK_CjenikJahtaSlobodno_Jahta"); }
            set { EntityContext<Jahta>.Set(ref m_FK_CjenikJahtaSlobodno_Jahta, this, value, "FK_CjenikJahtaSlobodno_Jahta"); }
        }
        public Base.Valuta FK_CjenikJahteSlobodno_Valuta
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_FK_CjenikJahteSlobodno_Valuta, this, "FK_CjenikJahteSlobodno_Valuta"); }
            set { EntityContext<Base.Valuta>.Set(ref m_FK_CjenikJahteSlobodno_Valuta, this, value, "FK_CjenikJahteSlobodno_Valuta"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CjenikJahteSlobodno>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CjenikJahteSlobodno>(queryConditions);
        }
        public static async Task<IEnumerable<CjenikJahteSlobodno>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CjenikJahteSlobodno>(columnName, queryOp, value);
        }
		public static async Task<CjenikJahteSlobodno> GetByPrimaryKeyAsync(int CjenikJahteSlobodnoID)
        {
            return await GetByPrimaryKeyAsync<CjenikJahteSlobodno>(CjenikJahteSlobodnoID);
        }
		public static async Task<CjenikJahteSlobodno> TryGetByPrimaryKeyAsync(int CjenikJahteSlobodnoID)
        {
            return await TryGetByPrimaryKeyAsync<CjenikJahteSlobodno>(CjenikJahteSlobodnoID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<CjenikJahteSlobodno> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<CjenikJahteSlobodno>(queryConditions);
        }
        public static IEnumerable<CjenikJahteSlobodno> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<CjenikJahteSlobodno>(columnName, queryOp, value);
        }
		public static CjenikJahteSlobodno GetByPrimaryKey(int CjenikJahteSlobodnoID)
        {
            return GetByPrimaryKey<CjenikJahteSlobodno>(CjenikJahteSlobodnoID);
        }
		public static CjenikJahteSlobodno TryGetByPrimaryKey(int CjenikJahteSlobodnoID)
        {
            return TryGetByPrimaryKey<CjenikJahteSlobodno>(CjenikJahteSlobodnoID);
        }
        #endregion
    }
}