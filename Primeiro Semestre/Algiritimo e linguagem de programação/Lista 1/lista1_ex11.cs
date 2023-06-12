using System;

namespace Lista1_ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Entre com um número");
            n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("O número digitado é par");
            }
            else
            {
                Console.WriteLine("O número digitado é impar");
            }
            Console.ReadKey();
        }
    }
}
