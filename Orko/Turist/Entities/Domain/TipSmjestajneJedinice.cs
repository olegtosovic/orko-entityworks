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
    /// TipSmjestajneJedinice entity.
    /// </summary>
    public sealed partial class TipSmjestajneJedinice : Entity
    {
		#region Members
		private SmjestajniObjekt m_SmjestajniObjekt;
        #endregion
        
		#region Constructors
        static TipSmjestajneJedinice()
        {
            // Cache field metadata.
            EntityMeta<TipSmjestajneJedinice>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(TipSmjestajneJediniceTipSmjestajneJedinice), @"TipSmjestajneJediniceTipSmjestajneJedinice", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(TipSmjestajneJediniceSmjestajniObjekt), @"TipSmjestajneJediniceSmjestajniObjekt", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(TipSmjestajneJediniceAktivnost), @"TipSmjestajneJediniceAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(TipSmjestajneJediniceJezik), @"TipSmjestajneJediniceJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(TipSmjestajneJediniceNaziv), @"TipSmjestajneJediniceNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(TipSmjestajneJediniceOpis), @"TipSmjestajneJediniceOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<TipSmjestajneJedinice>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(SmjestajniObjekt), nameof(TipSmjestajneJediniceSmjestajniObjekt), nameof(Orko.Turist.SmjestajniObjekt.SmjestajniObjektSmjestajniObjekt))
			);

			// Cache table metadata.
			EntityMeta<TipSmjestajneJedinice>.HasLanguageTable = true;
            EntityMeta<TipSmjestajneJedinice>.TableSchema = @"Turist";
            EntityMeta<TipSmjestajneJedinice>.TableName = @"TipSmjestajneJedinice";
            EntityMeta<TipSmjestajneJedinice>.LanguageTableSchema = @"Turist";
            EntityMeta<TipSmjestajneJedinice>.LanguageTableName = @"TipSmjestajneJedinice_jezik";
        }
        #endregion

        #region Columns
        public int? TipSmjestajneJediniceTipSmjestajneJedinice { get; private set; }
        public int? TipSmjestajneJediniceSmjestajniObjekt { get; set; }
        public bool? TipSmjestajneJediniceAktivnost { get; set; }
        public string TipSmjestajneJediniceJezik { get; private set; }
        public string TipSmjestajneJediniceNaziv { get; set; }
        public string TipSmjestajneJediniceOpis { get; set; }
        #endregion

        #region Entities
		public SmjestajniObjekt SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_SmjestajniObjekt, this, nameof(SmjestajniObjekt)); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_SmjestajniObjekt, this, value, nameof(SmjestajniObjekt)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<TipSmjestajneJedinice>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<TipSmjestajneJedinice>(queryConditions);
        }
        public static async Task<IEnumerable<TipSmjestajneJedinice>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<TipSmjestajneJedinice>(columnName, queryOp, value);
        }
		public static async Task<TipSmjestajneJedinice> GetByPrimaryKeyAsync(int TipSmjestajneJediniceTipSmjestajneJedinice, int TipSmjestajneJediniceSmjestajniObjekt)
        {
            return await GetByPrimaryKeyAsync<TipSmjestajneJedinice>(TipSmjestajneJediniceTipSmjestajneJedinice, TipSmjestajneJediniceSmjestajniObjekt);
        }
		public static async Task<TipSmjestajneJedinice> TryGetByPrimaryKeyAsync(int TipSmjestajneJediniceTipSmjestajneJedinice, int TipSmjestajneJediniceSmjestajniObjekt)
        {
            return await TryGetByPrimaryKeyAsync<TipSmjestajneJedinice>(TipSmjestajneJediniceTipSmjestajneJedinice, TipSmjestajneJediniceSmjestajniObjekt);
        }
		#endregion
    }
}