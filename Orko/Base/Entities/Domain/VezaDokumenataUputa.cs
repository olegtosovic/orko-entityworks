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
    /// VezaDokumenataUputa entity.
    /// </summary>
    public sealed partial class VezaDokumenataUputa : Entity
    {
		#region Members
		private VrstaDokumenta m_VrstaDokumentaPrethodni;
        private VrstaDokumenta m_VrstaDokumentaSljedni;
        private VrstaVeze m_VrstaVeze;
        #endregion
        
		#region Constructors
        static VezaDokumenataUputa()
        {
            // Cache field metadata.
            EntityMeta<VezaDokumenataUputa>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(VezaDokumenataUputaID), @"VezaDokumenataUputaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(VezaDokumenataUputaVrstaDokumentaPrethodni), @"VezaDokumenataUputaVrstaDokumentaPrethodni", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VezaDokumenataUputaVrstaDokumentaSljedni), @"VezaDokumenataUputaVrstaDokumentaSljedni", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(VezaDokumenataUputaVrstaVeze), @"VezaDokumenataUputaVrstaVeze", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(VezaDokumenataUputaIndikatorUnosa), @"VezaDokumenataUputaIndikatorUnosa", DbType.Boolean, isRequired: false),
                new ColumnMetadata(nameof(VezaDokumenataUputaUradio), @"VezaDokumenataUputaUradio", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(VezaDokumenataUputaDatumIzmjene), @"VezaDokumenataUputaDatumIzmjene", DbType.DateTime2, isRequired: false)
			);

            // Cache entites metadata.
            EntityMeta<VezaDokumenataUputa>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(VrstaDokumentaPrethodni), nameof(VezaDokumenataUputaVrstaDokumentaPrethodni), nameof(Orko.Base.VrstaDokumenta.VrstaDokumentaVrstaDokumenta)),
                new RelationMetadata(nameof(VrstaDokumentaSljedni), nameof(VezaDokumenataUputaVrstaDokumentaSljedni), nameof(Orko.Base.VrstaDokumenta.VrstaDokumentaVrstaDokumenta)),
                new RelationMetadata(nameof(VrstaVeze), nameof(VezaDokumenataUputaVrstaVeze), nameof(Orko.Base.VrstaVeze.VrstaVezeVrstaVeze))
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
		public VrstaDokumenta VrstaDokumentaPrethodni
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_VrstaDokumentaPrethodni, this, nameof(VrstaDokumentaPrethodni)); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_VrstaDokumentaPrethodni, this, value, nameof(VrstaDokumentaPrethodni)); }
        }
        public VrstaDokumenta VrstaDokumentaSljedni
        {
            get { return EntityContext<VrstaDokumenta>.Get(ref m_VrstaDokumentaSljedni, this, nameof(VrstaDokumentaSljedni)); }
            set { EntityContext<VrstaDokumenta>.Set(ref m_VrstaDokumentaSljedni, this, value, nameof(VrstaDokumentaSljedni)); }
        }
        public VrstaVeze VrstaVeze
        {
            get { return EntityContext<VrstaVeze>.Get(ref m_VrstaVeze, this, nameof(VrstaVeze)); }
            set { EntityContext<VrstaVeze>.Set(ref m_VrstaVeze, this, value, nameof(VrstaVeze)); }
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
    }
}