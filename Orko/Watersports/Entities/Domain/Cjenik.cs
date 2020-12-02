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
    /// Cjenik entity.
    /// </summary>
    public sealed partial class Cjenik : Entity
    {
		#region Members
		private Base.Protokol m_FK_Cjenik_Protokol;
        private Base.Valuta m_FK_Cjenik_Valuta;
        #endregion
        
		#region Constructors
        static Cjenik()
        {
            // Cache field metadata.
            EntityMeta<Cjenik>.LoadColumnMetadata
			(
				new ColumnMetadata("CjenikProtokolID", @"CjenikProtokolID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("CjenikValuta", @"CjenikValuta", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("CjenikDatumOd", @"CjenikDatumOd", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Cjenik>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Cjenik_Protokol", "CjenikProtokolID", "ProtokolID"),
                new RelationMetadata("FK_Cjenik_Valuta", "CjenikValuta", "ValutaValuta")
			);

			// Cache table metadata.
			EntityMeta<Cjenik>.HasLanguageTable = false;
            EntityMeta<Cjenik>.TableSchema = @"Watersports";
            EntityMeta<Cjenik>.TableName = @"Cjenik";
            EntityMeta<Cjenik>.LanguageTableSchema = null;
            EntityMeta<Cjenik>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CjenikProtokolID { get; set; }
        public string CjenikValuta { get; set; }
        public DateTime? CjenikDatumOd { get; set; }
        #endregion

        #region Entities
		public Base.Protokol FK_Cjenik_Protokol
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_FK_Cjenik_Protokol, this, "FK_Cjenik_Protokol"); }
            set { EntityContext<Base.Protokol>.Set(ref m_FK_Cjenik_Protokol, this, value, "FK_Cjenik_Protokol"); }
        }
        public Base.Valuta FK_Cjenik_Valuta
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_FK_Cjenik_Valuta, this, "FK_Cjenik_Valuta"); }
            set { EntityContext<Base.Valuta>.Set(ref m_FK_Cjenik_Valuta, this, value, "FK_Cjenik_Valuta"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Cjenik>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Cjenik>(queryConditions);
        }
        public static async Task<IEnumerable<Cjenik>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Cjenik>(columnName, queryOp, value);
        }
		public static async Task<Cjenik> GetByPrimaryKeyAsync(int CjenikProtokolID)
        {
            return await GetByPrimaryKeyAsync<Cjenik>(CjenikProtokolID);
        }
		public static async Task<Cjenik> TryGetByPrimaryKeyAsync(int CjenikProtokolID)
        {
            return await TryGetByPrimaryKeyAsync<Cjenik>(CjenikProtokolID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Cjenik> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Cjenik>(queryConditions);
        }
        public static IEnumerable<Cjenik> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Cjenik>(columnName, queryOp, value);
        }
		public static Cjenik GetByPrimaryKey(int CjenikProtokolID)
        {
            return GetByPrimaryKey<Cjenik>(CjenikProtokolID);
        }
		public static Cjenik TryGetByPrimaryKey(int CjenikProtokolID)
        {
            return TryGetByPrimaryKey<Cjenik>(CjenikProtokolID);
        }
        #endregion
    }
}