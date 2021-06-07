using System;

namespace Extension_Methods_Example_1
{
    class Testing
    {
        static void Main(String[] args)
        {
            Program p = new Program();
            p.Method1();
            p.Method2();
            p.Method3();

            int i = 5;
            Console.WriteLine(i.Factorial());

            string s = "HAI hoW arE YoU";
            Console.WriteLine(s.ToProper());
        }
    }
}
