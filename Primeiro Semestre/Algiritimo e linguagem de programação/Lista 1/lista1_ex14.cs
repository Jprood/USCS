using System;

namespace Lista1_ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("Escreva  a temperatura em graus Celsius: ");
            c = double.Parse(Console.ReadLine());

            f = (9 * c + 160) / 5;

            Console.WriteLine("A temperatura em Fahrenheit é de : {0}", f);
            Console.ReadKey();
        }
    }
}
