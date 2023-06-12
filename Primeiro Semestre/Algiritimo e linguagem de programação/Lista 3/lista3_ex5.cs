using System.ComponentModel;
using System.Net;

namespace Lista3_ex5
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ar1 = new int[10];
			int[] ar2 = new int[10];
			Console.WriteLine("Digite 10 valores inteiros: ");
			for (int i = 0; i < 10; i++)
{
				ar1[i] = int.Parse(Console.ReadLine());
				ar2[i] = ar1[i] * ar1[i];
			}
			Console.WriteLine("Os valores digitados são: ");
			for (int i = 0; i < 10; i++)
{
				Console.WriteLine(ar1[i]);
			}
			Console.WriteLine("O quadrado dos valores digitados são: ");
			for (int i = 0; i < 10; i++)
{
				Console.WriteLine(ar2[i]);
			}
			Console.ReadKey();
		}
	}
}