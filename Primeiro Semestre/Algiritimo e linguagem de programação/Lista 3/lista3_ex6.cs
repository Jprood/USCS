using System.ComponentModel;

namespace Lista3_ex6
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ar1 = new int[8];
			int x, y, soma;
			Console.WriteLine("Digite 6 valores: ");
			for (int i = 1; i < 7; i++)
{
				ar1[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Digite o valore de x: ");
			x = int.Parse(Console.ReadLine());
			ar1[0] = x;
			Console.WriteLine("Digite o valore de x: ");
			y = int.Parse(Console.ReadLine());
			ar1[7] = y;
			soma = ar1[0] + ar1[7];
			Console.WriteLine("A soma da primeira e ultima posição equivalentes a x e y é igual a: {0}", soma);
			Console.ReadKey();
		}
	}
}