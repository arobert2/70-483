using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownIndexParser
{
    public class MDHeaders
    {
        public int Tier { get; set; } = 1;
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
            int count = 0;
            foreach (char c in titleheader)
            {
                if (c == '#')
                    count++;
                else
                    break;
            }
            return count;
        }
        /// <summary>
        /// Creates an anchor for a link.
        /// </summary>
        /// <param name="titleheader">Titl header from the MD file.</param>
        /// <returns>anchor string.</returns>
        private string GetAnchor(string titleheader)
        {
            string newstring = "#";         //start string
            string title = titleheader.Substring(titleheader.LastIndexOf("#") + 1); //remove the MD format header.
            //clip space between MD hashtag and title if there.
            if (title[0] == ' ')
                title = title.Substring(1);        
            title = title.Replace(' ', '-');        //change spaces to dashes
            //filter for characters a-z and -
            char[] filter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            //filter and build.
            foreach (char c in title.ToLower())
                if (filter.Contains<char>(c))
                    newstring += c;
            return newstring;
        }
    }
}
