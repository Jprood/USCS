using System;

namespace Lista1_ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.WriteLine("Digite um número");
            n = double.Parse(Console.ReadLine());

            if (n > 100 && n < 200)
            {
                Console.WriteLine("O número está no intervalo entre 100 e 200");
            }
            else
            {
                Console.WriteLine("O número não está entre o entrevalo de 100 e 200");
            }
            Console.ReadKey();
        }
    }
}
