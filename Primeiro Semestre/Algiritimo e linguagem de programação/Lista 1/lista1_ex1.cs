using System;

namespace Lista1_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, area;

            Console.WriteLine("Digite o valor da base do triangulo");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do triangulo");
            h = double.Parse(Console.ReadLine());

            area = b * h / 2;

            Console.WriteLine("A área do quadrado é {0}", area);
            Console.ReadKey();
        }
    }
}
