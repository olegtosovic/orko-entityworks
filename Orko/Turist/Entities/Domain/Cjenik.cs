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

namespace Orko.Turist
{
    /// <summary>
    /// Cjenik entity.
    /// </summary>
    public sealed partial class Cjenik : Entity
    {
		#region Members
		private Base.Protokol m_FK_Cjenik_Protokol;
        private SmjestajniObjekt m_FK_Cjenik_SmjestajniObjekt;
        private Base.Valuta m_FK_Cjenik_Valuta;
        private VrstaCjenika m_FK_Cjenik_VrstaCjenika;
        #endregion
        
		#region Constructors
        static Cjenik()
        {
            // Cache field metadata.
            EntityMeta<Cjenik>.LoadColumnMetadata
			(
				new ColumnMetadata("CjenikProtokolID", @"CjenikProtokolID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("CjenikSmjestajniObjekt", @"CjenikSmjestajniObjekt", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("CjenikVrstaCjenika", @"CjenikVrstaCjenika", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("CjenikValuta", @"CjenikValuta", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("CjenikDatumOd", @"CjenikDatumOd", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Cjenik>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Cjenik_Protokol", "CjenikProtokolID", "ProtokolID"),
                new RelationMetadata("FK_Cjenik_SmjestajniObjekt", "CjenikSmjestajniObjekt", "SmjestajniObjektSmjestajniObjekt"),
                new RelationMetadata("FK_Cjenik_Valuta", "CjenikValuta", "ValutaValuta"),
                new RelationMetadata("FK_Cjenik_VrstaCjenika", "CjenikVrstaCjenika", "VrstaCjenikaVrstaCjenika")
			);

			// Cache table metadata.
			EntityMeta<Cjenik>.HasLanguageTable = false;
            EntityMeta<Cjenik>.TableSchema = @"Turist";
            EntityMeta<Cjenik>.TableName = @"Cjenik";
            EntityMeta<Cjenik>.LanguageTableSchema = null;
            EntityMeta<Cjenik>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? CjenikProtokolID { get; set; }
        public int? CjenikSmjestajniObjekt { get; set; }
        public string CjenikVrstaCjenika { get; set; }
        public string CjenikValuta { get; set; }
        public DateTime? CjenikDatumOd { get; set; }
        #endregion

        #region Entities
		public Base.Protokol FK_Cjenik_Protokol
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_FK_Cjenik_Protokol, this, "FK_Cjenik_Protokol"); }
            set { EntityContext<Base.Protokol>.Set(ref m_FK_Cjenik_Protokol, this, value, "FK_Cjenik_Protokol"); }
        }
        public SmjestajniObjekt FK_Cjenik_SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_FK_Cjenik_SmjestajniObjekt, this, "FK_Cjenik_SmjestajniObjekt"); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_FK_Cjenik_SmjestajniObjekt, this, value, "FK_Cjenik_SmjestajniObjekt"); }
        }
        public Base.Valuta FK_Cjenik_Valuta
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_FK_Cjenik_Valuta, this, "FK_Cjenik_Valuta"); }
            set { EntityContext<Base.Valuta>.Set(ref m_FK_Cjenik_Valuta, this, value, "FK_Cjenik_Valuta"); }
        }
        public VrstaCjenika FK_Cjenik_VrstaCjenika
        {
            get { return EntityContext<VrstaCjenika>.Get(ref m_FK_Cjenik_VrstaCjenika, this, "FK_Cjenik_VrstaCjenika"); }
            set { EntityContext<VrstaCjenika>.Set(ref m_FK_Cjenik_VrstaCjenika, this, value, "FK_Cjenik_VrstaCjenika"); }
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
        public static Cjenik GetByUnique1(int CjenikSmjestajniObjekt, DateTime CjenikDatumOd)
        {
            return GetByCallingParameters<Cjenik>(CjenikSmjestajniObjekt, CjenikDatumOd);
        }
		public static Cjenik TryGetByUnique1(int CjenikSmjestajniObjekt, DateTime CjenikDatumOd)
        {
            return TryGetByCallingParameters<Cjenik>(CjenikSmjestajniObjekt, CjenikDatumOd);
        }
        #endregion
    }
}