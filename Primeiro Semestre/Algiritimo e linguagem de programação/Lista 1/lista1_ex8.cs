using System;

namespace Lista1_ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Informe sua idade");
            idade = int.Parse(Console.ReadLine());

            if(idade <= 13 && idade > 0)
            {
                Console.WriteLine("O jogador faz parte da liga infantil");
            }
            else if(idade <= 17 && idade > 13)
            {
                Console.WriteLine("O jogador faz parte da liga juvenil");
            }
            else if(idade > 17)
            {
                Console.WriteLine("O jogador faz parte da liga senior");
            }
            else
            {
                Console.WriteLine("idade invalida");
            }
            Console.ReadKey();
        }
    }
}
