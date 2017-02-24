﻿using System;
using System.Threading;

namespace _70_483
{
    public static class program
    {
        public static void Main(string[] args)
        {
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
    }
}
