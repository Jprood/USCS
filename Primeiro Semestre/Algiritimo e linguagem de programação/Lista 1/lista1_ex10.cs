using System;

namespace Lista1_ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;

            Console.WriteLine("Entre com o primeiro número");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o terceiro número");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 * 1 + n2 * 2 + n3 * 3) / 6;

            Console.WriteLine("A media dos três números é igual a: {0}", media);

            Console.ReadKey();
        }
    }
}
