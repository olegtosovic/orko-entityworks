// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    /// <summary>
    /// Document entity.
    /// </summary>
    public sealed partial class Document : Entity
    {
		#region Members
		private HumanResources.Employee m_e_Owner;
        #endregion
        
		#region Constructors
        static Document()
        {
            // Cache field metadata.
            EntityMeta<Document>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(DocumentNode), @"DocumentNode", DbType.Binary, isPrimaryKey: true),
                new ColumnMetadata(nameof(DocumentLevel), @"DocumentLevel", DbType.Int16, isRequired: false),
                new ColumnMetadata(nameof(Title), @"Title", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Owner), @"Owner", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(FolderFlag), @"FolderFlag", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(FileName), @"FileName", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(FileExtension), @"FileExtension", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(Revision), @"Revision", DbType.StringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(ChangeNumber), @"ChangeNumber", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(Status), @"Status", DbType.Byte, isRequired: true),
                new ColumnMetadata(nameof(DocumentSummary), @"DocumentSummary", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(c_Document), @"Document", DbType.Binary, isRequired: false),
                new ColumnMetadata(nameof(rowguid), @"rowguid", DbType.Guid, isRequired: true),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Document>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_Owner), nameof(Owner), nameof(AdventureWorks.HumanResources.Employee.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<Document>.HasLanguageTable = false;
            EntityMeta<Document>.TableSchema = @"Production";
            EntityMeta<Document>.TableName = @"Document";
            EntityMeta<Document>.LanguageTableSchema = null;
            EntityMeta<Document>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public Byte[] DocumentNode { get; set; }
        public short? DocumentLevel { get; set; }
        public string Title { get; set; }
        public int? Owner { get; set; }
        public bool? FolderFlag { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Revision { get; set; }
        public int? ChangeNumber { get; set; }
        public Byte? Status { get; set; }
        public string DocumentSummary { get; set; }
        public Byte[] c_Document { get; set; }
        public Guid? rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public HumanResources.Employee e_Owner
        {
            get { return EntityContext<HumanResources.Employee>.Get(ref m_e_Owner, this, nameof(e_Owner)); }
            set { EntityContext<HumanResources.Employee>.Set(ref m_e_Owner, this, value, nameof(e_Owner)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<Document>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Document>(queryConditions);
        }
        public static async Task<IEnumerable<Document>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Document>(columnName, queryOp, value);
        }
		public static async Task<Document> GetByPrimaryKeyAsync(Byte[] DocumentNode)
        {
            return await GetByPrimaryKeyAsync<Document>(DocumentNode);
        }
		public static async Task<Document> TryGetByPrimaryKeyAsync(Byte[] DocumentNode)
        {
            return await TryGetByPrimaryKeyAsync<Document>(DocumentNode);
        }
		#endregion
    }
}