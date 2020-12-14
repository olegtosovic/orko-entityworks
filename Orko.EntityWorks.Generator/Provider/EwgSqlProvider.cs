using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Provides raw sql queries for getting database metadata.
	/// </summary>
	public class EwgSqlProvider
	{
		#region Constructors
		/// <summary>
		/// Creates instance of entity works generator DbSqlProvider object.
		/// </summary>
		public EwgSqlProvider()
		{
			// Set table names query.
			SetTableNamesQuery();

			// Set query for column names.
			SetColumnsQuery();

			// Sets query for primary keys.
			SetPrimaryKeysQuery();

			// Set query for unique keys.
			SetUniqueKeysQuery();

			// Set query for foreign keys.
			SetForeignKeysQuery();

			// Set query for foreign key realtions.
			SetForeignKeyRelationsQuery();
		}
		#endregion

		#region Methods
		/// <summary>
		/// Sets table names query.
		/// </summary>
		protected virtual void SetTableNamesQuery()
		{
			throw new EntityWorksGeneratorException("Table names query not set");
		}
		/// <summary>
		/// Sets query for column names.
		/// </summary>
		protected virtual void SetColumnsQuery()
		{
			throw new EntityWorksGeneratorException("Columns query not set");
		}
		/// <summary>
		/// Sets query for primary keys.
		/// </summary>
		protected virtual void SetPrimaryKeysQuery()
		{
			throw new EntityWorksGeneratorException("Primary keys query not set");
		}
		/// <summary>
		/// Sets query for foreign keys.
		/// </summary>
		protected virtual void SetForeignKeysQuery()
		{
			throw new EntityWorksGeneratorException("Foreign keys query not set");
		}
		/// <summary>
		/// Sets query for unique keys.
		/// </summary>
		protected virtual void SetUniqueKeysQuery()
		{
			throw new EntityWorksGeneratorException("Unique keys query not set");
		}
		/// <summary>
		/// Sets query for foreign key realtions.
		/// </summary>
		protected virtual void SetForeignKeyRelationsQuery()
		{
			throw new EntityWorksGeneratorException("Foreign key relations query not set");
		}
		#endregion

		#region Properties
		/// <summary>
		/// Table names query.
		/// </summary>
		public string TableNamesQuery { get; protected set; }
		/// <summary>
		/// Columns query.
		/// </summary>
		public string ColumnsQuery { get; protected set; }
		/// <summary>
		/// Primary keys query.
		/// </summary>
		public string PrimaryKeysQuery { get; protected set; }
		/// <summary>
		/// Foreign keys query.
		/// </summary>
		public string ForeignKeysQuery { get; protected set; }
		/// <summary>
		/// Unique keys query.
		/// </summary>
		public string UniqueKeysQuery { get; protected set; }
		/// <summary>
		/// Foreign key relations query.
		/// </summary>
		public string ForeignKeyRelationsQuery { get; protected set; }
		#endregion
	}
}
