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
        private static bool[] _lookup;
        #endregion

        #region Static constructor
        static StringExtensions()
        {
            // Valid characters lookup.
            // Optimization taken from stack overflow.
            // https://stackoverflow.com/questions/1120198/most-efficient-way-to-remove-special-characters-from-string
            _lookup = new bool[65536];
            for (char c = '0'; c <= '9'; c++) _lookup[c] = true;
            for (char c = 'A'; c <= 'Z'; c++) _lookup[c] = true;
            for (char c = 'a'; c <= 'z'; c++) _lookup[c] = true;
            //_lookup['.'] = true;
            _lookup['_'] = true;
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
                string[] parts = stringValue.Split(new char[] { '.' });
                foreach (var part in parts)
                {
                    returnValue += char.ToUpper(part[0]) + part.Substring(1);
                    if (parts.Last() != part)
                        returnValue += ".";
                }
            }

            // Return.
            return returnValue;                 
        }
        /// <summary>
        /// Makes string valid net property name. Removes spcial characters.
        /// </summary>
        public static string ToValidNetName(this string stringValue)
        {
            char[] buffer = new char[stringValue.Length];
            int index = 0;
            foreach (char c in stringValue)
            {
                if (_lookup[c])
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
