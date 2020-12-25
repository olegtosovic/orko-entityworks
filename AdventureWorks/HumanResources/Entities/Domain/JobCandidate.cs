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

namespace AdventureWorks.HumanResources
{
    /// <summary>
    /// JobCandidate entity.
    /// </summary>
    public sealed partial class JobCandidate : Entity
    {
		#region Members
		private Employee m_e_BusinessEntityID;
        #endregion
        
		#region Constructors
        static JobCandidate()
        {
            // Cache field metadata.
            EntityMeta<JobCandidate>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(JobCandidateID), @"JobCandidateID", DbType.Int32, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata(nameof(BusinessEntityID), @"BusinessEntityID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(Resume), @"Resume", DbType.Xml, isRequired: false),
                new ColumnMetadata(nameof(ModifiedDate), @"ModifiedDate", DbType.DateTime, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<JobCandidate>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(e_BusinessEntityID), nameof(BusinessEntityID), nameof(AdventureWorks.HumanResources.Employee.BusinessEntityID))
			);

			// Cache table metadata.
			EntityMeta<JobCandidate>.HasLanguageTable = false;
            EntityMeta<JobCandidate>.TableSchema = @"HumanResources";
            EntityMeta<JobCandidate>.TableName = @"JobCandidate";
            EntityMeta<JobCandidate>.LanguageTableSchema = null;
            EntityMeta<JobCandidate>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? JobCandidateID { get; private set; }
        public int? BusinessEntityID { get; set; }
        public XElement Resume { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion

        #region Entities
		public Employee e_BusinessEntityID
        {
            get { return EntityContext<Employee>.Get(ref m_e_BusinessEntityID, this, nameof(e_BusinessEntityID)); }
            set { EntityContext<Employee>.Set(ref m_e_BusinessEntityID, this, value, nameof(e_BusinessEntityID)); }
        }
        #endregion

		#region Public methods
		public static async Task<IEnumerable<JobCandidate>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<JobCandidate>(queryConditions);
        }
        public static async Task<IEnumerable<JobCandidate>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<JobCandidate>(columnName, queryOp, value);
        }
		public static async Task<JobCandidate> GetByPrimaryKeyAsync(int JobCandidateID)
        {
            return await GetByPrimaryKeyAsync<JobCandidate>(JobCandidateID);
        }
		public static async Task<JobCandidate> TryGetByPrimaryKeyAsync(int JobCandidateID)
        {
            return await TryGetByPrimaryKeyAsync<JobCandidate>(JobCandidateID);
        }
		#endregion
    }
}