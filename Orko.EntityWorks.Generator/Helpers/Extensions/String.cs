using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
    /// <summary>
    /// String object extensions.
    /// </summary>
    public static class StringExtensions
    {
        #region Static members
        private static bool[] _lookupPropertyName;
        private static bool[] _lookupNamespaceName;
        #endregion

        #region Static constructor
        static StringExtensions()
        {
            // Valid characters lookup.
            // Optimization taken from stack overflow.
            // https://stackoverflow.com/questions/1120198/most-efficient-way-to-remove-special-characters-from-string
            _lookupPropertyName = new bool[65536];
            for (char c = '0'; c <= '9'; c++) _lookupPropertyName[c] = true;
            for (char c = 'A'; c <= 'Z'; c++) _lookupPropertyName[c] = true;
            for (char c = 'a'; c <= 'z'; c++) _lookupPropertyName[c] = true;
            //_lookup['.'] = true;
            _lookupPropertyName['_'] = true;

            // Valid characters lookup.
            // Optimization taken from stack overflow.
            // https://stackoverflow.com/questions/1120198/most-efficient-way-to-remove-special-characters-from-string
            _lookupNamespaceName = new bool[65536];
            for (char c = '0'; c <= '9'; c++) _lookupNamespaceName[c] = true;
            for (char c = 'A'; c <= 'Z'; c++) _lookupNamespaceName[c] = true;
            for (char c = 'a'; c <= 'z'; c++) _lookupNamespaceName[c] = true;
            _lookupNamespaceName['.'] = true;
            //_lookupNamespaceName['_'] = true;
        }
		#endregion

		#region Extension methods
		/// <summary>
		/// Removes commas form beggining and end of segment.
		/// </summary>
		/// <returns>omma trimmed segment</returns>
		public static string TrimComma(this string stringValue)
        {
            // Return value.
            string returnValue = null;

            // Trim commas.
            if (string.IsNullOrWhiteSpace(stringValue) == false)
            {
                returnValue = stringValue.TrimStart(new char[] { ',' });
                returnValue = stringValue.TrimEnd(new char[] { ',' });
            }

            // Return.
            return returnValue;
        }
        /// <summary>
        /// Makes string upper camel case string.
        /// </summary>
        public static string ToUpperCamelCase(this string stringValue)
        {
            // Return value.
            string returnValue = string.Empty;

            // To upper camel case.
            if (string.IsNullOrWhiteSpace(stringValue) == false)
            {
                var parts = stringValue.Split(new char[] { '.' }).ToList();
                for (int i=0; i<parts.Count; i++)
                {
                    returnValue += char.ToUpper(parts[i][0]) + parts[i].Substring(1);
                    if (i < parts.Count - 1)
                        returnValue += ".";
                }
            }

            // Return.
            return returnValue;
        }
        /// <summary>
        /// Makes string valid net property name. Removes special characters except lower dash.
        /// </summary>
        public static string ToValidNetName(this string stringValue)
        {
            char[] buffer = new char[stringValue.Length];
            int index = 0;
            foreach (char c in stringValue)
            {
                if (_lookupPropertyName[c])
                {
                    buffer[index] = c;
                    index++;
                }
            }
            return new string(buffer, 0, index);
        }
        /// <summary>
        /// Makes string valid net namespace name. Removes special characters except dot.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToValidNamespaceName(this string stringValue)
		{
            char[] buffer = new char[stringValue.Length];
            int index = 0;
            foreach (char c in stringValue)
            {
                if (_lookupNamespaceName[c])
                {
                    buffer[index] = c;
                    index++;
                }
            }
            return new string(buffer, 0, index);
        }
        #endregion
    }
}
