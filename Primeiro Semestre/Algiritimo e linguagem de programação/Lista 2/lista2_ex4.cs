
using System.ComponentModel;

namespace Lista2_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            double maior = double.NegativeInfinity, menor =

            double.PositiveInfinity, media = 0;

            Console.WriteLine("Digite 10 números: ");
            for (int i = 0; i < 10; i++)
{
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] >= maior)
{
                    maior = a[i];
                }
            }
            for (int i = 0; i < 10; i++)
{
                if (a[i] < menor)
{
                    menor = a[i];
                }
            }
            media = (maior + menor) / 2;

            Console.WriteLine(" A media do maior e menor número somados é igual a: {0}", media);

            Console.ReadKey();
        }
    }
}