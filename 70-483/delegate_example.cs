using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483
{
    public delegate void MyNewDelegate(string text);
    public class delegate_example
    {
        public MyNewDelegate mydelegatehandler;
        public delegate_example()
        {
            mydelegatehandler += MyNewMethod;
        }

        public void MyNewMethod(string text)
        {
            Console.WriteLine("This is written from a delegate");
        }
    }

    public abstract class test
    {
        public abstract int Property { get; set; }
    }

    public class test2 : test
    {
        public override int Property { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}