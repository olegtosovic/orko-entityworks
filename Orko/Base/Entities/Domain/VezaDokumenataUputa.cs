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
    /// VezaDokumenataUputa entity.
    /// </summary>
    public sealed partial class VezaDokumenataUputa : Entity
    {
		#region Members
		private VrstaDokumenta m_FK_VezaDokumenataUputa_VrstaDokumentaPrethodni;
        private VrstaDokumenta m_FK_VezaDokumenataUputa_VrstaDokumentaSljedni;
        private VrstaVeze m_FK_VezaDokumenataUputa_VrstaVeze;
        #endregion
        
		#region Constructors
        static VezaDokumenataUputa()
        {
            // Cache field metadata.
            EntityMeta<VezaDokumenataUputa>.LoadColumnMetadata
			(
				new ColumnMetadata("VezaDokumenataUputaID", @"VezaDokumenataUputaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("VezaDokumenataUputaVrstaDokumentaPrethodni", @"VezaDokumenataUputaVrstaDokumentaPrethodni", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("VezaDokumenataUputaVrstaDokumentaSljedni", @"VezaDokumenataUputaVrstaDokumentaSljedni", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("VezaDokumenataUputaVrstaVeze", @"VezaDokumenataUputaVrstaVeze", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("VezaDokumenataUputaIndikatorUnosa", @"VezaDokumenataUputaIndikatorUnosa", SqlDbType.Bit, isRequired: false),
                new ColumnMetadata("VezaDokumenataUputaUradio", @"VezaDokumenataUputaUradio", SqlDbType.NVarChar, isRequired: false),
                new ColumnMetadata("VezaDokumenataUputaDatumIzmjene", @"VezaDokumenataUputaDatumIzmjene", SqlDbType.DateTime2, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<VezaDokumenataUputa>.LoadRelationMetadata
			(
				new RelationMetadata("FK_VezaDokumenataUputa_VrstaDokumentaPrethodni", "VezaDokumenataUputaVrstaDokumentaPrethodni", "VrstaDokumentaVrstaDokumenta"),
                new RelationMetadata("FK_VezaDokumenataUputa_VrstaDokumentaSljedni", "VezaDokumenataUputaVrstaDokumentaSljedni", "VrstaDokumentaVrstaDokumenta"),
                new RelationMetadata("FK_VezaDokumenataUputa_VrstaVeze", "VezaDokumenataUputaVrstaVeze", "VrstaVezeVrstaVeze")
			);

			// Cache table metadata.
			EntityMeta<VezaDokumenataUputa>.HasLanguageTable = false;
            EntityMeta<VezaDokumenataUputa>.TableSchema = @"Base";
            EntityMeta<VezaDokumenataUputa>.TableName = @"VezaDokumenataUputa";
            EntityMeta<VezaDokumenataUputa>.LanguageTableSchema = null;
            EntityMeta<VezaDokumenataUputa>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? VezaDokumenataUputaID { get; private set; }
        public string VezaDokumenataUputaVrstaDokumentaPrethodni { get; set; }
        public string VezaDokumenataUputaVrstaDokumentaSljedni { get; set; }
        public int? VezaDokumenataUputaVrstaVeze { get; set; }
        public bool? VezaDokumenataUputaIndikatorUnosa { get; set; }
        public string VezaDokumenataUputaUradio { get; set; }
        public DateTime? VezaDokumenataUputaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public VrstaDokumenta FK_VezaDokumenataUputa_VrstaDokumentaPrethodni
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_FK_VezaDokumenataUputa_VrstaDokumentaPrethodni, this, "FK_VezaDokumenataUputa_VrstaDokumentaPrethodni"); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_FK_VezaDokumenataUputa_VrstaDokumentaPrethodni, this, value, "FK_VezaDokumenataUputa_VrstaDokumentaPrethodni"); }
        }
        public VrstaDokumenta FK_VezaDokumenataUputa_VrstaDokumentaSljedni
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_FK_VezaDokumenataUputa_VrstaDokumentaSljedni, this, "FK_VezaDokumenataUputa_VrstaDokumentaSljedni"); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_FK_VezaDokumenataUputa_VrstaDokumentaSljedni, this, value, "FK_VezaDokumenataUputa_VrstaDokumentaSljedni"); }
        }
        public VrstaVeze FK_VezaDokumenataUputa_VrstaVeze
        {
            get { return EntityContext<VrstaVeze>.Get(ref m_FK_VezaDokumenataUputa_VrstaVeze, this, "FK_VezaDokumenataUputa_VrstaVeze"); }
            set { EntityContext<VrstaVeze>.Set(ref m_FK_VezaDokumenataUputa_VrstaVeze, this, value, "FK_VezaDokumenataUputa_VrstaVeze"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VezaDokumenataUputa>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VezaDokumenataUputa>(queryConditions);
        }
        public static async Task<IEnumerable<VezaDokumenataUputa>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VezaDokumenataUputa>(columnName, queryOp, value);
        }
		public static async Task<VezaDokumenataUputa> GetByPrimaryKeyAsync(int VezaDokumenataUputaID)
        {
            return await GetByPrimaryKeyAsync<VezaDokumenataUputa>(VezaDokumenataUputaID);
        }
		public static async Task<VezaDokumenataUputa> TryGetByPrimaryKeyAsync(int VezaDokumenataUputaID)
        {
            return await TryGetByPrimaryKeyAsync<VezaDokumenataUputa>(VezaDokumenataUputaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VezaDokumenataUputa> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VezaDokumenataUputa>(queryConditions);
        }
        public static IEnumerable<VezaDokumenataUputa> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VezaDokumenataUputa>(columnName, queryOp, value);
        }
		public static VezaDokumenataUputa GetByPrimaryKey(int VezaDokumenataUputaID)
        {
            return GetByPrimaryKey<VezaDokumenataUputa>(VezaDokumenataUputaID);
        }
		public static VezaDokumenataUputa TryGetByPrimaryKey(int VezaDokumenataUputaID)
        {
            return TryGetByPrimaryKey<VezaDokumenataUputa>(VezaDokumenataUputaID);
        }
        #endregion
    }
}