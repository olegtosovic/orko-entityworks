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

namespace Orko.Turist
{
    /// <summary>
    /// Cjenik entity.
    /// </summary>
    public sealed partial class Cjenik : Entity
    {
		#region Members
		private Base.Protokol m_Protokol;
        private SmjestajniObjekt m_SmjestajniObjekt;
        private Base.Valuta m_Valuta;
        private VrstaCjenika m_VrstaCjenika;
        #endregion
        
		#region Constructors
        static Cjenik()
        {
            // Cache field metadata.
            EntityMeta<Cjenik>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(CjenikProtokolID), @"CjenikProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(CjenikSmjestajniObjekt), @"CjenikSmjestajniObjekt", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(CjenikVrstaCjenika), @"CjenikVrstaCjenika", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(CjenikValuta), @"CjenikValuta", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(CjenikDatumOd), @"CjenikDatumOd", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Cjenik>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Protokol), nameof(CjenikProtokolID), nameof(Orko.Base.Protokol.ProtokolID)),
                new RelationMetadata(nameof(SmjestajniObjekt), nameof(CjenikSmjestajniObjekt), nameof(Orko.Turist.SmjestajniObjekt.SmjestajniObjektSmjestajniObjekt)),
                new RelationMetadata(nameof(Valuta), nameof(CjenikValuta), nameof(Orko.Base.Valuta.ValutaValuta)),
                new RelationMetadata(nameof(VrstaCjenika), nameof(CjenikVrstaCjenika), nameof(Orko.Turist.VrstaCjenika.VrstaCjenikaVrstaCjenika))
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
		public Base.Protokol Protokol
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_Protokol, this, nameof(Protokol)); }
            set { EntityContext<Base.Protokol>.Set(ref m_Protokol, this, value, nameof(Protokol)); }
        }
        public SmjestajniObjekt SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_SmjestajniObjekt, this, nameof(SmjestajniObjekt)); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_SmjestajniObjekt, this, value, nameof(SmjestajniObjekt)); }
        }
        public Base.Valuta Valuta
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_Valuta, this, nameof(Valuta)); }
            set { EntityContext<Base.Valuta>.Set(ref m_Valuta, this, value, nameof(Valuta)); }
        }
        public VrstaCjenika VrstaCjenika
        {
            get { return EntityContext<VrstaCjenika>.Get(ref m_VrstaCjenika, this, nameof(VrstaCjenika)); }
            set { EntityContext<VrstaCjenika>.Set(ref m_VrstaCjenika, this, value, nameof(VrstaCjenika)); }
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
    }
}