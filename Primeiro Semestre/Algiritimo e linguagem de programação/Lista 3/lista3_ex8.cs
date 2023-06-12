using System.ComponentModel;

namespace Lista3_ex8
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] nota = new double[15];
			double soma = 0, media;
			Console.WriteLine("Digite a nota dos alunos: ");
			for (int i = 0; i < 15; i++)
{
				nota[i] = double.Parse(Console.ReadLine());
				soma = soma + nota[i];
			}
			media = soma / 15;
			Console.WriteLine("A media dos alnos é igual a: {0}", media);
			Console.ReadKey();
		}
	}
}
