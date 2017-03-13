using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace _70_483
{
    public static class program
    {

        public static void Main(string[] args)
        {
            Random rand = new Random();

            lambdatest lt = new lambdatest();

            nameparametertest(j : 1, x : 5, i : 1);

            int[] vara = new int[2] { 0, 1 };
            var numQuery = from num in vara
                           where num != 2
                           select num;

            foreach (int num in numQuery)
                Console.WriteLine(num);

            var result = Parallel.For(0, 10, (i) =>
                 {
                     Thread.Sleep(rand.Next(1000));
                     Console.WriteLine(i);
                 });

            lt.trigger();

            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }

        public static void ThreadMethod(object o)
        {
            for(int i = 0;i < (int)o;i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void nameparametertest(int i, int j, int x)
        {

        }
    }

    public class lambdatest
    {
        public event Action lambdatestevent;

        public lambdatest()
        {
            lambdatestevent = () =>
            {
                Console.WriteLine("This is from the lambda event.");
            };
        }

        public void trigger()
        {
            lambdatestevent?.Invoke();
        }
    }

    public class indexertest
    {
        private string[] indexedobject;

        public string this [int i]
        {
            get { return indexedobject[i]; }
            set { indexedobject[i] = value; }
        }
    }
}
