using System.Net;

namespace Lista2_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            double soma = 0, media = 0;

            Console.WriteLine("Digite 10 números:");
            for (int i = 0; i < 10; i++)
{
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] % 2 == 1)
                {
                    soma = soma + a[i];
                }
            }
			media = soma / 10;
            Console.WriteLine("A média dos números impares é igual a:{0}", media);

            Console.ReadKey();
        }
    }
}
