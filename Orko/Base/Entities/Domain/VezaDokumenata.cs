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

namespace Orko.Base
{
    /// <summary>
    /// VezaDokumenata entity.
    /// </summary>
    public sealed partial class VezaDokumenata : Entity
    {
		#region Members
		private Protokol m_ProtokolPrethodni;
        private Protokol m_ProtokolSlijedni;
        private VezaDokumenataUputa m_VezaDokumenataUputa;
        #endregion
        
		#region Constructors
        static VezaDokumenata()
        {
            // Cache field metadata.
            EntityMeta<VezaDokumenata>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VezaDokumenataID), @"VezaDokumenataID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(VezaDokumenataPrethodniProtokolID), @"VezaDokumenataPrethodniProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(VezaDokumenataSlijedniProtokolID), @"VezaDokumenataSlijedniProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(VezaDokumenataVezaDokumenataUputaID), @"VezaDokumenataVezaDokumenataUputaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(VezaDokumenataUradio), @"VezaDokumenataUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VezaDokumenataDatumIzmjene), @"VezaDokumenataDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<VezaDokumenata>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(ProtokolPrethodni), nameof(VezaDokumenataPrethodniProtokolID), nameof(Orko.Base.Protokol.ProtokolID)),
                new RelationMetadata(nameof(ProtokolSlijedni), nameof(VezaDokumenataSlijedniProtokolID), nameof(Orko.Base.Protokol.ProtokolID)),
                new RelationMetadata(nameof(VezaDokumenataUputa), nameof(VezaDokumenataVezaDokumenataUputaID), nameof(Orko.Base.VezaDokumenataUputa.VezaDokumenataUputaID))
			);

			// Cache table metadata.
			EntityMeta<VezaDokumenata>.HasLanguageTable = false;
            EntityMeta<VezaDokumenata>.TableSchema = @"Base";
            EntityMeta<VezaDokumenata>.TableName = @"VezaDokumenata";
            EntityMeta<VezaDokumenata>.LanguageTableSchema = null;
            EntityMeta<VezaDokumenata>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? VezaDokumenataID { get; private set; }
        public int? VezaDokumenataPrethodniProtokolID { get; set; }
        public int? VezaDokumenataSlijedniProtokolID { get; set; }
        public int? VezaDokumenataVezaDokumenataUputaID { get; set; }
        public string VezaDokumenataUradio { get; set; }
        public DateTime? VezaDokumenataDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public Protokol ProtokolPrethodni
        {
            get { return EntityContext<Protokol>.Get(ref m_ProtokolPrethodni, this, nameof(ProtokolPrethodni)); }
            set { EntityContext<Protokol>.Set(ref m_ProtokolPrethodni, this, value, nameof(ProtokolPrethodni)); }
        }
        public Protokol ProtokolSlijedni
        {
            get { return EntityContext<Protokol>.Get(ref m_ProtokolSlijedni, this, nameof(ProtokolSlijedni)); }
            set { EntityContext<Protokol>.Set(ref m_ProtokolSlijedni, this, value, nameof(ProtokolSlijedni)); }
        }
        public VezaDokumenataUputa VezaDokumenataUputa
        {
            get { return EntityContext<VezaDokumenataUputa>.Get(ref m_VezaDokumenataUputa, this, nameof(VezaDokumenataUputa)); }
            set { EntityContext<VezaDokumenataUputa>.Set(ref m_VezaDokumenataUputa, this, value, nameof(VezaDokumenataUputa)); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VezaDokumenata>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VezaDokumenata>(queryConditions);
        }
        public static async Task<IEnumerable<VezaDokumenata>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VezaDokumenata>(columnName, queryOp, value);
        }
		public static async Task<VezaDokumenata> GetByPrimaryKeyAsync(int VezaDokumenataID)
        {
            return await GetByPrimaryKeyAsync<VezaDokumenata>(VezaDokumenataID);
        }
		public static async Task<VezaDokumenata> TryGetByPrimaryKeyAsync(int VezaDokumenataID)
        {
            return await TryGetByPrimaryKeyAsync<VezaDokumenata>(VezaDokumenataID);
        }
		#endregion
    }
}