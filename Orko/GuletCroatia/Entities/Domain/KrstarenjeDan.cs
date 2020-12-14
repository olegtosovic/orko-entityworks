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

namespace Orko.GuletCroatia
{
    /// <summary>
    /// KrstarenjeDan entity.
    /// </summary>
    public sealed partial class KrstarenjeDan : Entity
    {
		#region Members
		private Destinacija m_Destinacija;
        private Krstarenje m_Krstarenje;
        #endregion
        
		#region Constructors
        static KrstarenjeDan()
        {
            // Cache field metadata.
            EntityMeta<KrstarenjeDan>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(KrstarenjeDanID), @"KrstarenjeDanID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(KrstarenjeDanDestinacija), @"KrstarenjeDanDestinacija", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(KrstarenjeDanKrstarenje), @"KrstarenjeDanKrstarenje", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(KrstarenjeDanBrojDana), @"KrstarenjeDanBrojDana", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(KrstarenjeDanJezik), @"KrstarenjeDanJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(KrstarenjeDanTekst), @"KrstarenjeDanTekst", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(KrstarenjeDanNaslov), @"KrstarenjeDanNaslov", DbType.String, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<KrstarenjeDan>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Destinacija), nameof(KrstarenjeDanDestinacija), nameof(Orko.GuletCroatia.Destinacija.DestinacijaDestinacija)),
                new RelationMetadata(nameof(Krstarenje), nameof(KrstarenjeDanKrstarenje), nameof(Orko.GuletCroatia.Krstarenje.KrstarenjeKrstarenje))
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
		public Destinacija Destinacija
        {
            get { return EntityContext<Destinacija>.Get(ref m_Destinacija, this, nameof(Destinacija)); }
            set { EntityContext<Destinacija>.Set(ref m_Destinacija, this, value, nameof(Destinacija)); }
        }
        public Krstarenje Krstarenje
        {
            get { return EntityContext<Krstarenje>.Get(ref m_Krstarenje, this, nameof(Krstarenje)); }
            set { EntityContext<Krstarenje>.Set(ref m_Krstarenje, this, value, nameof(Krstarenje)); }
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
    }
}