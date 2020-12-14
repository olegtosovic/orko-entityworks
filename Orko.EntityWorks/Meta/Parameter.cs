using System.Data;
using System.Reflection;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represents entity / table field that acts as parameter for sql command object.
    /// </summary>
    public sealed class Parameter
    {
        #region Constructors
        /// <summary>
        /// Creates instance of parameter object.
        /// </summary>
        public Parameter(
            string sqlParameterName,
            ParameterInfo ParameterInfo,
            DbType sqlDbType, 
            string SqlPath, 
            string SqlLanguagePath = null, 
            bool isLanguage = false,
            bool isLanguageCode = false,
            bool isIdentity = false,
			bool isTimestamp = false,
            bool isPrimary = false)
        {
            ParameterName = ParameterInfo.Name;
            SqlParameterName = SqlPath + "." + sqlParameterName;
            SqlLangParameterName = SqlLanguagePath + "." + sqlParameterName;
            ParameterNameWithMonkey = "@" + ParameterName;
            SqlDbType = sqlDbType;
            IsLanguage = isLanguage;
            IsLanguageCode = isLanguageCode;
			IsIdentity = isIdentity;
			IsTimestamp = isTimestamp;
            IsPrimary = isPrimary;
        }
        /// <summary>
        /// Creates instance of parameter object.
        /// </summary>
        public Parameter(
            string sqlParameterName,
            PropertyInfo PropertyInfo,
            DbType sqlDbType,
            string SqlPath, 
            string SqlLanguagePath = null, 
            bool isLanguage = false, 
            bool isLanguageCode = false,
            bool isIdentity = false,
			bool isTimestamp = false,
            bool isPrimary = false)
        {
            ParameterName = PropertyInfo.Name;
            SqlParameterName = SqlPath + "." + "[" + sqlParameterName + "]";
            SqlLangParameterName = SqlLanguagePath + "." + "[" + sqlParameterName + "]";
            ParameterNameWithMonkey = "@" + ParameterName;
            SqlDbType = sqlDbType;
            IsLanguage = isLanguage;
            IsLanguageCode = isLanguageCode;
            IsIdentity = isIdentity;
			IsTimestamp = isTimestamp;
            IsPrimary = isPrimary;
        }
        #endregion

        #region Properties
        public string ParameterName { get; private set; }
        public string SqlParameterName { get; private set; }
        public string SqlLangParameterName { get; private set; }
        public string ParameterNameWithMonkey { get; private set; }
        public DbType SqlDbType { get; private set; }
        public bool IsLanguage { get; private set; }
        public bool IsLanguageCode { get; set; }
		public bool IsTimestamp { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsPrimary { get; set; }
        #endregion
    }
}
