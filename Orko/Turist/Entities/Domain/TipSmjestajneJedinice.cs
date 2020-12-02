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
    /// TipSmjestajneJedinice entity.
    /// </summary>
    public sealed partial class TipSmjestajneJedinice : Entity
    {
		#region Members
		private SmjestajniObjekt m_FK_TipSmjestajneJedinice_SmjestajniObjekt;
        #endregion
        
		#region Constructors
        static TipSmjestajneJedinice()
        {
            // Cache field metadata.
            EntityMeta<TipSmjestajneJedinice>.LoadColumnMetadata
			(
				new ColumnMetadata("TipSmjestajneJediniceTipSmjestajneJedinice", @"TipSmjestajneJediniceTipSmjestajneJedinice", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("TipSmjestajneJediniceSmjestajniObjekt", @"TipSmjestajneJediniceSmjestajniObjekt", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("TipSmjestajneJediniceAktivnost", @"TipSmjestajneJediniceAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("TipSmjestajneJediniceJezik", @"TipSmjestajneJediniceJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("TipSmjestajneJediniceNaziv", @"TipSmjestajneJediniceNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("TipSmjestajneJediniceOpis", @"TipSmjestajneJediniceOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<TipSmjestajneJedinice>.LoadRelationMetadata
			(
				new RelationMetadata("FK_TipSmjestajneJedinice_SmjestajniObjekt", "TipSmjestajneJediniceSmjestajniObjekt", "SmjestajniObjektSmjestajniObjekt")
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
		public SmjestajniObjekt FK_TipSmjestajneJedinice_SmjestajniObjekt
        {
            get { return EntityContext<SmjestajniObjekt>.Get(ref m_FK_TipSmjestajneJedinice_SmjestajniObjekt, this, "FK_TipSmjestajneJedinice_SmjestajniObjekt"); }
            set { EntityContext<SmjestajniObjekt>.Set(ref m_FK_TipSmjestajneJedinice_SmjestajniObjekt, this, value, "FK_TipSmjestajneJedinice_SmjestajniObjekt"); }
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

        #region Public methods
		public static IEnumerable<TipSmjestajneJedinice> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<TipSmjestajneJedinice>(queryConditions);
        }
        public static IEnumerable<TipSmjestajneJedinice> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<TipSmjestajneJedinice>(columnName, queryOp, value);
        }
		public static TipSmjestajneJedinice GetByPrimaryKey(int TipSmjestajneJediniceTipSmjestajneJedinice, int TipSmjestajneJediniceSmjestajniObjekt)
        {
            return GetByPrimaryKey<TipSmjestajneJedinice>(TipSmjestajneJediniceTipSmjestajneJedinice, TipSmjestajneJediniceSmjestajniObjekt);
        }
		public static TipSmjestajneJedinice TryGetByPrimaryKey(int TipSmjestajneJediniceTipSmjestajneJedinice, int TipSmjestajneJediniceSmjestajniObjekt)
        {
            return TryGetByPrimaryKey<TipSmjestajneJedinice>(TipSmjestajneJediniceTipSmjestajneJedinice, TipSmjestajneJediniceSmjestajniObjekt);
        }
        #endregion
    }
}