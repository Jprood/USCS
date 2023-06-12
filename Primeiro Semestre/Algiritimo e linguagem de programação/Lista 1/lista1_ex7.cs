using System;

namespace Lista1_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numc;
            double valor;

            Console.WriteLine("digite o numero de copias que deseja:");
            numc = int.Parse(Console.ReadLine());

            if (numc > 200)
            {
                valor = numc * 0.30;

                Console.WriteLine("O valor das copias é igual a: {0}", valor);
            }
            else
            {
                valor = numc * 0.50;

                Console.WriteLine("O valor das copias é igual a: {0}", valor);
            }
            Console.ReadKey();
        }
    }
}
