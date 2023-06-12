using System;

namespace Lista1_ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("Escreva  a temperatura em Fahrenheit: ");
            f = double.Parse(Console.ReadLine());

            c = ((f - 32) * 5) / 9;

            Console.WriteLine("A temperatura em Celsius é de : {0}", c);
            Console.ReadKey();
        }
    }
}
