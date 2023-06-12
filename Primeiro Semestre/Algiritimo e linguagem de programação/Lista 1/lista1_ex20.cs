using System;

namespace Lista1_ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;

            while(n >= 1)
            {
                Console.WriteLine("{0}", n);

                --n;
            }
            Console.ReadKey();
        }
    }
}
