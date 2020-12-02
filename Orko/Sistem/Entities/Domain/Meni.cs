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
    /// Meni entity.
    /// </summary>
    public sealed partial class Meni : Entity
    {
		#region Members
		private Objekt m_FK_Meni_NadredjeniObjekt;
        private Objekt m_FK_Meni_Objekt;
        #endregion
        
		#region Constructors
        static Meni()
        {
            // Cache field metadata.
            EntityMeta<Meni>.LoadColumnMetadata
			(
				new ColumnMetadata("MeniID", @"MeniID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("MeniObjektNadredjeni", @"MeniObjektNadredjeni", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("MeniObjekt", @"MeniObjekt", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("MeniRedniBroj", @"MeniRedniBroj", SqlDbType.Int, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Meni>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Meni_NadredjeniObjekt", "MeniObjektNadredjeni", "ObjektObjekt"),
                new RelationMetadata("FK_Meni_Objekt", "MeniObjekt", "ObjektObjekt")
			);

			// Cache table metadata.
			EntityMeta<Meni>.HasLanguageTable = false;
            EntityMeta<Meni>.TableSchema = @"Sistem";
            EntityMeta<Meni>.TableName = @"Meni";
            EntityMeta<Meni>.LanguageTableSchema = null;
            EntityMeta<Meni>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? MeniID { get; set; }
        public string MeniObjektNadredjeni { get; set; }
        public string MeniObjekt { get; set; }
        public int? MeniRedniBroj { get; set; }
        #endregion

        #region Entities
		public Objekt FK_Meni_NadredjeniObjekt
        {
            get { return EntityContext<Objekt>.Get(ref m_FK_Meni_NadredjeniObjekt, this, "FK_Meni_NadredjeniObjekt"); }
            set { EntityContext<Objekt>.Set(ref m_FK_Meni_NadredjeniObjekt, this, value, "FK_Meni_NadredjeniObjekt"); }
        }
        public Objekt FK_Meni_Objekt
        {
            get { return EntityContext<Objekt>.Get(ref m_FK_Meni_Objekt, this, "FK_Meni_Objekt"); }
            set { EntityContext<Objekt>.Set(ref m_FK_Meni_Objekt, this, value, "FK_Meni_Objekt"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Meni>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Meni>(queryConditions);
        }
        public static async Task<IEnumerable<Meni>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Meni>(columnName, queryOp, value);
        }
		public static async Task<Meni> GetByPrimaryKeyAsync(int MeniID)
        {
            return await GetByPrimaryKeyAsync<Meni>(MeniID);
        }
		public static async Task<Meni> TryGetByPrimaryKeyAsync(int MeniID)
        {
            return await TryGetByPrimaryKeyAsync<Meni>(MeniID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Meni> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Meni>(queryConditions);
        }
        public static IEnumerable<Meni> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Meni>(columnName, queryOp, value);
        }
		public static Meni GetByPrimaryKey(int MeniID)
        {
            return GetByPrimaryKey<Meni>(MeniID);
        }
		public static Meni TryGetByPrimaryKey(int MeniID)
        {
            return TryGetByPrimaryKey<Meni>(MeniID);
        }
        #endregion
    }
}