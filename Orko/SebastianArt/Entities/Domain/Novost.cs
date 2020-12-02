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

namespace Orko.SebastianArt
{
    /// <summary>
    /// Novost entity.
    /// </summary>
    public sealed partial class Novost : Entity
    {
		#region Members
		private Autor m_FK_Novost_Autor;
        #endregion
        
		#region Constructors
        static Novost()
        {
            // Cache field metadata.
            EntityMeta<Novost>.LoadColumnMetadata
			(
				new ColumnMetadata("NovostID", @"NovostID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("NovostSlug", @"NovostSlug", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("NovostAutorID", @"NovostAutorID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("NovostDatumUnosa", @"NovostDatumUnosa", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("NovostDatumObjave", @"NovostDatumObjave", SqlDbType.DateTime2, isRequired: true),
                new ColumnMetadata("NovostKategorija", @"NovostKategorija", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("NovostEventOd", @"NovostEventOd", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("NovostEventDo", @"NovostEventDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("NovostOtvorenje", @"NovostOtvorenje", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("NovostAktivnost", @"NovostAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("NovostJezik", @"NovostJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("NovostNaslov", @"NovostNaslov", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("NovostPodnaslov", @"NovostPodnaslov", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("NovostTehnika", @"NovostTehnika", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("NovostLokalitet", @"NovostLokalitet", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("NovostOAutoru", @"NovostOAutoru", SqlDbType.NVarChar, isRequired: false, isLanguage: true),
                new ColumnMetadata("NovostOpis", @"NovostOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Novost>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Novost_Autor", "NovostAutorID", "AutorID")
			);

			// Cache table metadata.
			EntityMeta<Novost>.HasLanguageTable = true;
            EntityMeta<Novost>.TableSchema = @"SebastianArt";
            EntityMeta<Novost>.TableName = @"Novost";
            EntityMeta<Novost>.LanguageTableSchema = @"SebastianArt";
            EntityMeta<Novost>.LanguageTableName = @"Novost_jezik";
        }
        #endregion

        #region Columns
        public int? NovostID { get; private set; }
        public string NovostSlug { get; set; }
        public int? NovostAutorID { get; set; }
        public DateTime? NovostDatumUnosa { get; set; }
        public DateTime? NovostDatumObjave { get; set; }
        public string NovostKategorija { get; set; }
        public DateTime? NovostEventOd { get; set; }
        public DateTime? NovostEventDo { get; set; }
        public DateTime? NovostOtvorenje { get; set; }
        public bool? NovostAktivnost { get; set; }
        public string NovostJezik { get; private set; }
        public string NovostNaslov { get; set; }
        public string NovostPodnaslov { get; set; }
        public string NovostTehnika { get; set; }
        public string NovostLokalitet { get; set; }
        public string NovostOAutoru { get; set; }
        public string NovostOpis { get; set; }
        #endregion

        #region Entities
		public Autor FK_Novost_Autor
        {
            get { return EntityContext<Autor>.Get(ref m_FK_Novost_Autor, this, "FK_Novost_Autor"); }
            set { EntityContext<Autor>.Set(ref m_FK_Novost_Autor, this, value, "FK_Novost_Autor"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Novost>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Novost>(queryConditions);
        }
        public static async Task<IEnumerable<Novost>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Novost>(columnName, queryOp, value);
        }
		public static async Task<Novost> GetByPrimaryKeyAsync(int NovostID)
        {
            return await GetByPrimaryKeyAsync<Novost>(NovostID);
        }
		public static async Task<Novost> TryGetByPrimaryKeyAsync(int NovostID)
        {
            return await TryGetByPrimaryKeyAsync<Novost>(NovostID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Novost> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Novost>(queryConditions);
        }
        public static IEnumerable<Novost> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Novost>(columnName, queryOp, value);
        }
		public static Novost GetByPrimaryKey(int NovostID)
        {
            return GetByPrimaryKey<Novost>(NovostID);
        }
		public static Novost TryGetByPrimaryKey(int NovostID)
        {
            return TryGetByPrimaryKey<Novost>(NovostID);
        }
        public static Novost GetByUnique1(string NovostSlug)
        {
            return GetByCallingParameters<Novost>(NovostSlug);
        }
		public static Novost TryGetByUnique1(string NovostSlug)
        {
            return TryGetByCallingParameters<Novost>(NovostSlug);
        }
        #endregion
    }
}