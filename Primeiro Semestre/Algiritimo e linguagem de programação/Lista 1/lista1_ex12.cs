using System;

namespace Lista1_ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double n1, n2, n3, media;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 * 1.0 + n2 * 2.0 + n3 * 3.0)/6.0;

            Console.WriteLine("O aluno {0} tem a media de: {1}", nome, media);
        }
    }
}
