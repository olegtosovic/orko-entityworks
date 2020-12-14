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
    /// Meni entity.
    /// </summary>
    public sealed partial class Meni : Entity
    {
		#region Members
		private Objekt m_NadredjeniObjekt;
        private Objekt m_Objekt;
        #endregion
        
		#region Constructors
        static Meni()
        {
            // Cache field metadata.
            EntityMeta<Meni>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(MeniID), @"MeniID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(MeniObjektNadredjeni), @"MeniObjektNadredjeni", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(MeniObjekt), @"MeniObjekt", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(MeniRedniBroj), @"MeniRedniBroj", DbType.Int32, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Meni>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(NadredjeniObjekt), nameof(MeniObjektNadredjeni), nameof(Orko.Sistem.Objekt.ObjektObjekt)),
                new RelationMetadata(nameof(Objekt), nameof(MeniObjekt), nameof(Orko.Sistem.Objekt.ObjektObjekt))
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
		public Objekt NadredjeniObjekt
        {
            get { return EntityContext<Objekt>.Get(ref m_NadredjeniObjekt, this, nameof(NadredjeniObjekt)); }
            set { EntityContext<Objekt>.Set(ref m_NadredjeniObjekt, this, value, nameof(NadredjeniObjekt)); }
        }
        public Objekt Objekt
        {
            get { return EntityContext<Objekt>.Get(ref m_Objekt, this, nameof(Objekt)); }
            set { EntityContext<Objekt>.Set(ref m_Objekt, this, value, nameof(Objekt)); }
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
    }
}