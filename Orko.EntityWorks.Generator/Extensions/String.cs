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
    }
}
