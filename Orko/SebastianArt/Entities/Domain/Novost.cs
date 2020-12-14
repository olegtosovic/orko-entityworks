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

namespace Orko.SebastianArt
{
    /// <summary>
    /// Novost entity.
    /// </summary>
    public sealed partial class Novost : Entity
    {
		#region Members
		private Autor m_Autor;
        #endregion
        
		#region Constructors
        static Novost()
        {
            // Cache field metadata.
            EntityMeta<Novost>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(NovostID), @"NovostID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(NovostSlug), @"NovostSlug", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(NovostAutorID), @"NovostAutorID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(NovostDatumUnosa), @"NovostDatumUnosa", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(NovostDatumObjave), @"NovostDatumObjave", DbType.DateTime2, isRequired: true),
                new ColumnMetadata(nameof(NovostKategorija), @"NovostKategorija", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(NovostEventOd), @"NovostEventOd", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(NovostEventDo), @"NovostEventDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(NovostOtvorenje), @"NovostOtvorenje", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(NovostAktivnost), @"NovostAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(NovostJezik), @"NovostJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(NovostNaslov), @"NovostNaslov", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(NovostPodnaslov), @"NovostPodnaslov", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(NovostTehnika), @"NovostTehnika", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(NovostLokalitet), @"NovostLokalitet", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(NovostOAutoru), @"NovostOAutoru", DbType.String, isRequired: false, isLanguage: true),
                new ColumnMetadata(nameof(NovostOpis), @"NovostOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Novost>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Autor), nameof(NovostAutorID), nameof(Orko.SebastianArt.Autor.AutorID))
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
		public Autor Autor
        {
            get { return EntityContext<Autor>.Get(ref m_Autor, this, nameof(Autor)); }
            set { EntityContext<Autor>.Set(ref m_Autor, this, value, nameof(Autor)); }
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
    }
}