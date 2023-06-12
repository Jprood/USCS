using System;

namespace Lista1_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double n1, n2, n3, media;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o valor da primeira nota:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda nota:");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da terceira nota:");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 * 2 + n2 * 4 + n3 * 6) / 12;

            Console.WriteLine("O aluno {0} tem a media de {1}", nome, media);
        }
    }
}
