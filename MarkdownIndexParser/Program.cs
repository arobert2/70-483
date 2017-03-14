using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarkdownIndexParser
{
    class Program
    {
        static void Main(string[] args)
        {
            MDHeaders mdh = new MDHeaders("#this is a test");
            MDHeaders mdh2 = new MDHeaders("##Another test/trial.");
            MDHeaders mdh3 = new MDHeaders("### We are 3 deep. Trying this now?");
            MDHeaders mdh4 = new MDHeaders("####LastTeirBelow");
            MDHeaders mdh5 = new MDHeaders("##### Finally Here!");

            Console.WriteLine(mdh.Tier);
            Console.WriteLine(mdh.Title);
            Console.WriteLine(mdh.Anchor);

            Console.WriteLine(mdh2.Tier);
            Console.WriteLine(mdh2.Title);
            Console.WriteLine(mdh2.Anchor);

            Console.WriteLine(mdh3.Tier);
            Console.WriteLine(mdh3.Title);
            Console.WriteLine(mdh3.Anchor);

            Console.WriteLine(mdh4.Tier);
            Console.WriteLine(mdh4.Title);
            Console.WriteLine(mdh4.Anchor);

            Console.WriteLine(mdh5.Tier);
            Console.WriteLine(mdh5.Title);
            Console.WriteLine(mdh5.Anchor);

        }
    }
}
