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

namespace Orko.GuletCroatia
{
    /// <summary>
    /// KrstarenjeDan entity.
    /// </summary>
    public sealed partial class KrstarenjeDan : Entity
    {
		#region Members
		private Destinacija m_FK_KrstarenjeDan_Destinacija;
        private Krstarenje m_FK_KrstarenjeDan_Krstarenje;
        #endregion
        
		#region Constructors
        static KrstarenjeDan()
        {
            // Cache field metadata.
            EntityMeta<KrstarenjeDan>.LoadColumnMetadata
			(
				new ColumnMetadata("KrstarenjeDanID", @"KrstarenjeDanID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("KrstarenjeDanDestinacija", @"KrstarenjeDanDestinacija", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("KrstarenjeDanKrstarenje", @"KrstarenjeDanKrstarenje", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("KrstarenjeDanBrojDana", @"KrstarenjeDanBrojDana", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("KrstarenjeDanJezik", @"KrstarenjeDanJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("KrstarenjeDanTekst", @"KrstarenjeDanTekst", SqlDbType.NVarChar, isRequired: true, isLanguage: true),
                new ColumnMetadata("KrstarenjeDanNaslov", @"KrstarenjeDanNaslov", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<KrstarenjeDan>.LoadRelationMetadata
			(
				new RelationMetadata("FK_KrstarenjeDan_Destinacija", "KrstarenjeDanDestinacija", "DestinacijaDestinacija"),
                new RelationMetadata("FK_KrstarenjeDan_Krstarenje", "KrstarenjeDanKrstarenje", "KrstarenjeKrstarenje")
			);

			// Cache table metadata.
			EntityMeta<KrstarenjeDan>.HasLanguageTable = true;
            EntityMeta<KrstarenjeDan>.TableSchema = @"GuletCroatia";
            EntityMeta<KrstarenjeDan>.TableName = @"KrstarenjeDan";
            EntityMeta<KrstarenjeDan>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<KrstarenjeDan>.LanguageTableName = @"KrstarenjeDan_jezik";
        }
        #endregion

        #region Columns
        public int? KrstarenjeDanID { get; private set; }
        public string KrstarenjeDanDestinacija { get; set; }
        public string KrstarenjeDanKrstarenje { get; set; }
        public int? KrstarenjeDanBrojDana { get; set; }
        public string KrstarenjeDanJezik { get; private set; }
        public string KrstarenjeDanTekst { get; set; }
        public string KrstarenjeDanNaslov { get; set; }
        #endregion

        #region Entities
		public Destinacija FK_KrstarenjeDan_Destinacija
        {
            get { return EntityContext<Destinacija>.Get(ref m_FK_KrstarenjeDan_Destinacija, this, "FK_KrstarenjeDan_Destinacija"); }
            set { EntityContext<Destinacija>.Set(ref m_FK_KrstarenjeDan_Destinacija, this, value, "FK_KrstarenjeDan_Destinacija"); }
        }
        public Krstarenje FK_KrstarenjeDan_Krstarenje
        {
            get { return EntityContext<Krstarenje>.Get(ref m_FK_KrstarenjeDan_Krstarenje, this, "FK_KrstarenjeDan_Krstarenje"); }
            set { EntityContext<Krstarenje>.Set(ref m_FK_KrstarenjeDan_Krstarenje, this, value, "FK_KrstarenjeDan_Krstarenje"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<KrstarenjeDan>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<KrstarenjeDan>(queryConditions);
        }
        public static async Task<IEnumerable<KrstarenjeDan>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<KrstarenjeDan>(columnName, queryOp, value);
        }
		public static async Task<KrstarenjeDan> GetByPrimaryKeyAsync(int KrstarenjeDanID)
        {
            return await GetByPrimaryKeyAsync<KrstarenjeDan>(KrstarenjeDanID);
        }
		public static async Task<KrstarenjeDan> TryGetByPrimaryKeyAsync(int KrstarenjeDanID)
        {
            return await TryGetByPrimaryKeyAsync<KrstarenjeDan>(KrstarenjeDanID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<KrstarenjeDan> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<KrstarenjeDan>(queryConditions);
        }
        public static IEnumerable<KrstarenjeDan> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<KrstarenjeDan>(columnName, queryOp, value);
        }
		public static KrstarenjeDan GetByPrimaryKey(int KrstarenjeDanID)
        {
            return GetByPrimaryKey<KrstarenjeDan>(KrstarenjeDanID);
        }
		public static KrstarenjeDan TryGetByPrimaryKey(int KrstarenjeDanID)
        {
            return TryGetByPrimaryKey<KrstarenjeDan>(KrstarenjeDanID);
        }
        #endregion
    }
}