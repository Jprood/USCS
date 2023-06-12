using System;

namespace Lista1_ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;

            Console.WriteLine("Digite a pimeira nota:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota:");
            n4 = double.Parse(Console.ReadLine());

            media = (n1 * 1.0 + n2 * 2.0 + n3 * 3.0 + n4 * 4.0) / 10;

            if(media >= 5.0)
            {
                Console.WriteLine("Parabens você está aprovado. Sua media é de: {0}", media);
            }
            else
            {
                Console.WriteLine("Você está reprovado. Sua media é de: {0}", media);
            }
            Console.ReadKey();
        }
    }
}
