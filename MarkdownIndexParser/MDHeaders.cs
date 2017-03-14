using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownIndexParser
{
    public class MDHeaders
    {
        public int Tier { get; set; } = 0;
        public string Title { get; set; }
        public string Anchor { get; set; }

        public MDHeaders(string titleheader)
        {
            Tier = GetTier(titleheader);
            Title = titleheader.Substring(titleheader.LastIndexOf("#") + 1);
            Anchor = GetAnchor(titleheader);
        }

        /// <summary>
        /// Get the tier level
        /// </summary>
        /// <param name="titleheader">Title header MD file input.</param>
        /// <returns>tier number. 1 to 5 in theory.</returns>
        private int GetTier(string titleheader)
        {
            return titleheader.Filter("#").Length - 1;
        }
        /// <summary>
        /// Creates an anchor for a link.
        /// </summary>
        /// <param name="titleheader">Titl header from the MD file.</param>
        /// <returns>anchor string.</returns>
        private string GetAnchor(string titleheader)
        {
            //new string, convert to lower case and filter for all letters, numbers and - and ' '
            string newstring = titleheader.ToLower().Filter("abcdefghijklmnopqrstuvwxyz- 1234567890");  
            //clip space between MD hashtag and newstring if there.
            if (newstring[0] == ' ')
                newstring = newstring.Substring(1);        
            newstring = newstring.Replace(' ', '-');        //change spaces to dashes
            return "#" + newstring;
        }
    }
}
