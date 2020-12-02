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

namespace Orko.Sistem
{
    /// <summary>
    /// Objekt entity.
    /// </summary>
    public sealed partial class Objekt : Entity
    {
		#region Members
		private Sustav m_FK_Objekt_Sustav;
        private TipObjekta m_FK_Objekt_TipObjekta;
        #endregion
        
		#region Constructors
        static Objekt()
        {
            // Cache field metadata.
            EntityMeta<Objekt>.LoadColumnMetadata
			(
				new ColumnMetadata("ObjektObjekt", @"ObjektObjekt", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("ObjektTipObjekta", @"ObjektTipObjekta", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ObjektSustav", @"ObjektSustav", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("ObjektIkona", @"ObjektIkona", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("ObjektJezik", @"ObjektJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("ObjektNaziv", @"ObjektNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("ObjektOpis", @"ObjektOpis", SqlDbType.NVarChar, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Objekt>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Objekt_Sustav", "ObjektSustav", "SustavSustav"),
                new RelationMetadata("FK_Objekt_TipObjekta", "ObjektTipObjekta", "TipObjektaTipObjekta")
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
		public Sustav FK_Objekt_Sustav
        {
            get { return EntityContext<Sustav>.Get(ref m_FK_Objekt_Sustav, this, "FK_Objekt_Sustav"); }
            set { EntityContext<Sustav>.Set(ref m_FK_Objekt_Sustav, this, value, "FK_Objekt_Sustav"); }
        }
        public TipObjekta FK_Objekt_TipObjekta
        {
            get { return EntityContext<TipObjekta>.Get(ref m_FK_Objekt_TipObjekta, this, "FK_Objekt_TipObjekta"); }
            set { EntityContext<TipObjekta>.Set(ref m_FK_Objekt_TipObjekta, this, value, "FK_Objekt_TipObjekta"); }
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

        #region Public methods
		public static IEnumerable<Objekt> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Objekt>(queryConditions);
        }
        public static IEnumerable<Objekt> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Objekt>(columnName, queryOp, value);
        }
		public static Objekt GetByPrimaryKey(string ObjektObjekt)
        {
            return GetByPrimaryKey<Objekt>(ObjektObjekt);
        }
		public static Objekt TryGetByPrimaryKey(string ObjektObjekt)
        {
            return TryGetByPrimaryKey<Objekt>(ObjektObjekt);
        }
        #endregion
    }
}