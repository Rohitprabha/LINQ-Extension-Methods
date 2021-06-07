using System;

namespace Extension_Methods_Example_1
{
    class Program
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Method2");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Method1();
            p.Method2();
        }
    }
}
