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

namespace Orko.Base
{
    /// <summary>
    /// VezaDokumenata entity.
    /// </summary>
    public sealed partial class VezaDokumenata : Entity
    {
		#region Members
		private Protokol m_FK_VezaDokumenata_ProtokolPrethodni;
        private Protokol m_FK_VezaDokumenata_ProtokolSlijedni;
        private VezaDokumenataUputa m_FK_VezaDokumenata_VezaDokumenataUputa;
        #endregion
        
		#region Constructors
        static VezaDokumenata()
        {
            // Cache field metadata.
            EntityMeta<VezaDokumenata>.LoadColumnMetadata
			(
				new ColumnMetadata("VezaDokumenataID", @"VezaDokumenataID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("VezaDokumenataPrethodniProtokolID", @"VezaDokumenataPrethodniProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("VezaDokumenataSlijedniProtokolID", @"VezaDokumenataSlijedniProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("VezaDokumenataVezaDokumenataUputaID", @"VezaDokumenataVezaDokumenataUputaID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("VezaDokumenataUradio", @"VezaDokumenataUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("VezaDokumenataDatumIzmjene", @"VezaDokumenataDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<VezaDokumenata>.LoadRelationMetadata
			(
				new RelationMetadata("FK_VezaDokumenata_ProtokolPrethodni", "VezaDokumenataPrethodniProtokolID", "ProtokolID"),
                new RelationMetadata("FK_VezaDokumenata_ProtokolSlijedni", "VezaDokumenataSlijedniProtokolID", "ProtokolID"),
                new RelationMetadata("FK_VezaDokumenata_VezaDokumenataUputa", "VezaDokumenataVezaDokumenataUputaID", "VezaDokumenataUputaID")
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
		public Protokol FK_VezaDokumenata_ProtokolPrethodni
        {
            get { return EntityContext<Protokol>.Get(ref m_FK_VezaDokumenata_ProtokolPrethodni, this, "FK_VezaDokumenata_ProtokolPrethodni"); }
            set { EntityContext<Protokol>.Set(ref m_FK_VezaDokumenata_ProtokolPrethodni, this, value, "FK_VezaDokumenata_ProtokolPrethodni"); }
        }
        public Protokol FK_VezaDokumenata_ProtokolSlijedni
        {
            get { return EntityContext<Protokol>.Get(ref m_FK_VezaDokumenata_ProtokolSlijedni, this, "FK_VezaDokumenata_ProtokolSlijedni"); }
            set { EntityContext<Protokol>.Set(ref m_FK_VezaDokumenata_ProtokolSlijedni, this, value, "FK_VezaDokumenata_ProtokolSlijedni"); }
        }
        public VezaDokumenataUputa FK_VezaDokumenata_VezaDokumenataUputa
        {
            get { return EntityContext<VezaDokumenataUputa>.Get(ref m_FK_VezaDokumenata_VezaDokumenataUputa, this, "FK_VezaDokumenata_VezaDokumenataUputa"); }
            set { EntityContext<VezaDokumenataUputa>.Set(ref m_FK_VezaDokumenata_VezaDokumenataUputa, this, value, "FK_VezaDokumenata_VezaDokumenataUputa"); }
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

        #region Public methods
		public static IEnumerable<VezaDokumenata> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VezaDokumenata>(queryConditions);
        }
        public static IEnumerable<VezaDokumenata> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VezaDokumenata>(columnName, queryOp, value);
        }
		public static VezaDokumenata GetByPrimaryKey(int VezaDokumenataID)
        {
            return GetByPrimaryKey<VezaDokumenata>(VezaDokumenataID);
        }
		public static VezaDokumenata TryGetByPrimaryKey(int VezaDokumenataID)
        {
            return TryGetByPrimaryKey<VezaDokumenata>(VezaDokumenataID);
        }
        #endregion
    }
}