using System;

namespace Extension_Methods_Example_1
{
    static class ExtensionClass
    {
        public static void Method2(this Program p)              //binding
        {
            Console.WriteLine("Extension Method2");
        }
        public static void Method3(this Program p)
        {
            Console.WriteLine("Method3");
        }
        public static long Factorial(this Int32 f)              //binding to structure int32
        {
            if (f == 1)
                return 1;
            else
            {
                return f * Factorial(f - 1);
            }
        }

        public static string ToProper(this String s)                //binding to sealed class String
        {
            if (s.Trim().Length > 0)
            {
                string temp = null;
                s = s.ToLower();
                string[] a = s.Split(' ');
                foreach (string str in a)
                {
                    char[] b = str.ToCharArray();
                    b[0] = char.ToUpper(b[0]);
                    if (temp == null)
                        temp = new string(b);
                    else
                        temp += " " + new string(b);
                }
                return temp;
            }
            return s;
        }

    }
}
