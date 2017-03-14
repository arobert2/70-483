using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownIndexParser
{
    public static class StaticExtension
    {
        /// <summary>
        /// Filter out characters that are not in the filter string
        /// </summary>
        /// <param name="input">string to filter</param>
        /// <param name="filterstring">string to check against.</param>
        /// <returns>filtered string</returns>
        public static string Filter(this string input, string filterstring)
        {
            string newstring = "";
            foreach (char c in input)
                if (filterstring.Contains(c.ToString()))
                    newstring += c;
            return newstring;
        }
        /// <summary>
        /// Multiply a string into sets of itself.
        /// </summary>
        /// <param name="input">string to multiply</param>
        /// <param name="multiply">number of times to duplicate</param>
        /// <returns>multiplied string.</returns>
        public static string Multiply(this string input, int multiply)
        {
            string newstring = input;
            for (int i = 0; i < multiply; i++)
                newstring += newstring;
            return newstring;
        }
    }
}
