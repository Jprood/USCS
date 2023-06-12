using System;

namespace Lista1_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;

            Console.WriteLine("Digite um número");
            n1 = double.Parse(Console.ReadLine());

            if( n1 > 200 && n1 < 300)
            {
                Console.WriteLine("O número ésta entre o entervalo dos números de 200 e 300");
            }
            else
            {
                Console.WriteLine("O número não ésta entre o entervalo dos números de 200 e 300");
            }
            Console.ReadKey();

        }
    }
}
