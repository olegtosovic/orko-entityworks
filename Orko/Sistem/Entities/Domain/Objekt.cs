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

namespace Orko.Sistem
{
    /// <summary>
    /// Objekt entity.
    /// </summary>
    public sealed partial class Objekt : Entity
    {
		#region Members
		private Sustav m_Sustav;
        private TipObjekta m_TipObjekta;
        #endregion
        
		#region Constructors
        static Objekt()
        {
            // Cache field metadata.
            EntityMeta<Objekt>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(ObjektObjekt), @"ObjektObjekt", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ObjektTipObjekta), @"ObjektTipObjekta", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ObjektSustav), @"ObjektSustav", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(ObjektIkona), @"ObjektIkona", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(ObjektJezik), @"ObjektJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(ObjektNaziv), @"ObjektNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(ObjektOpis), @"ObjektOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Objekt>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Sustav), nameof(ObjektSustav), nameof(Orko.Sistem.Sustav.SustavSustav)),
                new RelationMetadata(nameof(TipObjekta), nameof(ObjektTipObjekta), nameof(Orko.Sistem.TipObjekta.TipObjektaTipObjekta))
			);

			// Cache table metadata.
			EntityMeta<Objekt>.HasLanguageTable = true;
            EntityMeta<Objekt>.TableSchema = @"Sistem";
            EntityMeta<Objekt>.TableName = @"Objekt";
            EntityMeta<Objekt>.LanguageTableSchema = @"Sistem";
            EntityMeta<Objekt>.LanguageTableName = @"Objekt_jezik";
        }
        #endregion

        #region Columns
        public string ObjektObjekt { get; set; }
        public string ObjektTipObjekta { get; set; }
        public string ObjektSustav { get; set; }
        public string ObjektIkona { get; set; }
        public string ObjektJezik { get; private set; }
        public string ObjektNaziv { get; set; }
        public string ObjektOpis { get; set; }
        #endregion

        #region Entities
		public Sustav Sustav
        {
            get { return EntityContext<Sustav>.Get(ref m_Sustav, this, nameof(Sustav)); }
            set { EntityContext<Sustav>.Set(ref m_Sustav, this, value, nameof(Sustav)); }
        }
        public TipObjekta TipObjekta
        {
            get { return EntityContext<TipObjekta>.Get(ref m_TipObjekta, this, nameof(TipObjekta)); }
            set { EntityContext<TipObjekta>.Set(ref m_TipObjekta, this, value, nameof(TipObjekta)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Objekt>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Objekt>(queryConditions);
        }
        public static async Task<IEnumerable<Objekt>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Objekt>(columnName, queryOp, value);
        }
		public static async Task<Objekt> GetByPrimaryKeyAsync(string ObjektObjekt)
        {
            return await GetByPrimaryKeyAsync<Objekt>(ObjektObjekt);
        }
		public static async Task<Objekt> TryGetByPrimaryKeyAsync(string ObjektObjekt)
        {
            return await TryGetByPrimaryKeyAsync<Objekt>(ObjektObjekt);
        }
		#endregion
    }
}