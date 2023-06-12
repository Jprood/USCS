using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

namespace Lista3_ex7
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ar = new int[6];
			Console.WriteLine("Digite 6 valores: ");
			for (int i = 0; i < 6; i++)
{
				ar[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Os valores lidos em ordem inversa são: ");
			for (int i = 5; i >= 0; i--)
{
				Console.WriteLine(ar[i]);
			}
			Console.ReadKey();
		}
	}
}