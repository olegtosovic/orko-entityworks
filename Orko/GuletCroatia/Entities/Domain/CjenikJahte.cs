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
    /// CjenikJahte entity.
    /// </summary>
    public sealed partial class CjenikJahte : Entity
    {
		#region Members
		private Jahta m_FK_CjenikJahte_Jahta;
        private Base.Valuta m_FK_JahtaCjenik_Valuta;
        private Base.Valuta m_FK_JahtaCjenik_Valuta1;
        #endregion
        
		#region Constructors
        static CjenikJahte()
        {
            // Cache field metadata.
            EntityMeta<CjenikJahte>.LoadColumnMetadata
			(
				new ColumnMetadata("CjenikJahteID", @"CjenikJahteID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("CjenikJahteJahta", @"CjenikJahteJahta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("CjenikJahteOd", @"CjenikJahteOd", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("CjenikJahteDo", @"CjenikJahteDo", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("CjenikJahteCijena", @"CjenikJahteCijena", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("CjenikJahteValuta", @"CjenikJahteValuta", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("CjenikJahteCijena2", @"CjenikJahteCijena2", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("CjenikJahteValuta2", @"CjenikJahteValuta2", SqlDbType.Char, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<CjenikJahte>.LoadRelationMetadata
			(
				new RelationMetadata("FK_CjenikJahte_Jahta", "CjenikJahteJahta", "JahtaJahta"),
                new RelationMetadata("FK_JahtaCjenik_Valuta", "CjenikJahteValuta", "ValutaValuta"),
                new RelationMetadata("FK_JahtaCjenik_Valuta1", "CjenikJahteValuta2", "ValutaValuta")
			);

			// Cache table metadata.
			EntityMeta<CjenikJahte>.HasLanguageTable = false;
            EntityMeta<CjenikJahte>.TableSchema = @"GuletCroatia";
            EntityMeta<CjenikJahte>.TableName = @"CjenikJahte";
            EntityMeta<CjenikJahte>.LanguageTableSchema = null;
            EntityMeta<CjenikJahte>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CjenikJahteID { get; private set; }
        public string CjenikJahteJahta { get; set; }
        public DateTime? CjenikJahteOd { get; set; }
        public DateTime? CjenikJahteDo { get; set; }
        public decimal? CjenikJahteCijena { get; set; }
        public string CjenikJahteValuta { get; set; }
        public decimal? CjenikJahteCijena2 { get; set; }
        public string CjenikJahteValuta2 { get; set; }
        #endregion

        #region Entities
		public Jahta FK_CjenikJahte_Jahta
        {
            get { return EntityContext<Jahta>.Get(ref m_FK_CjenikJahte_Jahta, this, "FK_CjenikJahte_Jahta"); }
            set { EntityContext<Jahta>.Set(ref m_FK_CjenikJahte_Jahta, this, value, "FK_CjenikJahte_Jahta"); }
        }
        public Base.Valuta FK_JahtaCjenik_Valuta
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_FK_JahtaCjenik_Valuta, this, "FK_JahtaCjenik_Valuta"); }
            set { EntityContext<Base.Valuta>.Set(ref m_FK_JahtaCjenik_Valuta, this, value, "FK_JahtaCjenik_Valuta"); }
        }
        public Base.Valuta FK_JahtaCjenik_Valuta1
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_FK_JahtaCjenik_Valuta1, this, "FK_JahtaCjenik_Valuta1"); }
            set { EntityContext<Base.Valuta>.Set(ref m_FK_JahtaCjenik_Valuta1, this, value, "FK_JahtaCjenik_Valuta1"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<CjenikJahte>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<CjenikJahte>(queryConditions);
        }
        public static async Task<IEnumerable<CjenikJahte>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<CjenikJahte>(columnName, queryOp, value);
        }
		public static async Task<CjenikJahte> GetByPrimaryKeyAsync(int CjenikJahteID)
        {
            return await GetByPrimaryKeyAsync<CjenikJahte>(CjenikJahteID);
        }
		public static async Task<CjenikJahte> TryGetByPrimaryKeyAsync(int CjenikJahteID)
        {
            return await TryGetByPrimaryKeyAsync<CjenikJahte>(CjenikJahteID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<CjenikJahte> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<CjenikJahte>(queryConditions);
        }
        public static IEnumerable<CjenikJahte> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<CjenikJahte>(columnName, queryOp, value);
        }
		public static CjenikJahte GetByPrimaryKey(int CjenikJahteID)
        {
            return GetByPrimaryKey<CjenikJahte>(CjenikJahteID);
        }
		public static CjenikJahte TryGetByPrimaryKey(int CjenikJahteID)
        {
            return TryGetByPrimaryKey<CjenikJahte>(CjenikJahteID);
        }
        #endregion
    }
}