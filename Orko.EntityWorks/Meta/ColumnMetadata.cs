using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// 
    /// </summary>
    public class ColumnMetadata
    {
        #region Constructors
        public ColumnMetadata(
            string fieldName,
            SqlDbType sqlDbType,
            bool isPrimaryKey = false, 
            bool isRequired = false, 
            bool isIdentity = false, 
            bool isLanguage = false,
			bool isTimestamp = false,
            bool isLanguageCode = false)
        {
            ColumnName = fieldName;
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
        public string ColumnName { get; private set; }
        public bool IsRequired { get; private set; }
        public bool IsIdentity { get; private set; }
		public bool IsTimestamp { get; private set; }
        public bool IsPrimaryKey { get; private set; }
        public bool IsLanguage { get; private set; }
        public bool IsLanguageCode { get; private set; }
        public SqlDbType SqlDbType { get; private set; }
        #endregion
    }
}
