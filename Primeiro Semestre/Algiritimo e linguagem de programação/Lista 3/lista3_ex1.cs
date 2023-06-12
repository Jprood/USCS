using System.ComponentModel;
using System.Net;

namespace Lista3_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
			double soma = 0, media, x = 0;

            Console.WriteLine("Digite 10 valores inteiros");
            for (int i = 0; i < 10; i++)
{
                array[i] = int.Parse(Console.ReadLine());
               
                if (array[i] < 0)
{
                    soma = soma + array[i];
                    x++;
                }
            }
            media = soma / x;
            Console.WriteLine("Os números negativos digitados são: ");
            for (int i = 0; i < 10; i++)
{
                if (array[i] < 0)
{
                    Console.WriteLine("{0}", array[i]);
				}
			}
            Console.WriteLine("A media dos números negativos é igual a: {0}", media);

            Console.ReadKey();
        }
    }
}
