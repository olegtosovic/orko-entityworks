using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represents column information used to generate cached crud queries.
    /// </summary>
    public class ColumnMetadata
    {
        #region Constructors
        /// <summary>
        /// Create column metadata instance.
        /// </summary>
        /// <param name="columnSqlName">Real field name in database</param>
        /// <param name="columnNetName">C# column name. Unfortunately because of bad tehnical allowance to allow spaces in column names we have to map field/column name relation</param>
        /// <param name="sqlDbType">Sql server data type</param>
        /// <param name="isPrimaryKey">Indicated if field is part of primary key</param>
        /// <param name="isRequired">Indicates if filed allows null values</param>
        /// <param name="isIdentity">Indicates if filed is auto increment</param>
        /// <param name="isLanguage">Indicates if field part of language table</param>
        /// <param name="isTimestamp">Indicates if field is sql timestamp data type</param>
        /// <param name="isLanguageCode"></param>
        public ColumnMetadata(
            string columnNetName,
            string columnSqlName,
            DbType sqlDbType,
            bool isPrimaryKey = false, 
            bool isRequired = false, 
            bool isIdentity = false, 
            bool isLanguage = false,
			bool isTimestamp = false,
            bool isLanguageCode = false)
        {
            ColumnNetName = columnNetName;
            ColumnSqlName = columnSqlName;
            IsRequired = isRequired;
            IsPrimaryKey = isPrimaryKey;
            IsIdentity = isIdentity;
			IsTimestamp = isTimestamp;
            IsLanguage = isLanguage;
            IsLanguageCode = isLanguageCode;
            SqlDbType = sqlDbType;
        }
        #endregion

        #region Properties
        public string ColumnNetName { get; private set; }
        public string ColumnSqlName { get; private set; }
        public bool IsRequired { get; private set; }
        public bool IsIdentity { get; private set; }
		public bool IsTimestamp { get; private set; }
        public bool IsPrimaryKey { get; private set; }
        public bool IsLanguage { get; private set; }
        public bool IsLanguageCode { get; private set; }
        public DbType SqlDbType { get; private set; }
        #endregion
    }
}
