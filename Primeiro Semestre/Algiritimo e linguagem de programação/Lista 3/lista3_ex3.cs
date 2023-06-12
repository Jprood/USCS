using System.ComponentModel;

namespace Lista3_ex3
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, x, c1 = 0, c2 = 0, b = 0, nu = 0, t, n_elei;
			Console.WriteLine("Digite o número de eleitores: ");
			n_elei = int.Parse(Console.ReadLine());
			for (int i = 0; i < n_elei; i++)
{
				Console.WriteLine(" Digite a opção desejada:");
				Console.WriteLine(" 1 - Voto Para o candidato 1");
				Console.WriteLine(" 2 - Voto Para o candidato 2");
				Console.WriteLine(" 3 - Voto em branco");
				Console.WriteLine(" 4 - Voto nulo");
				n = int.Parse(Console.ReadLine());
				switch (n)
				{
					case 1:
						c1++;
						break;
					case 2:
						c2++;
						break;
					case 3:
						b++;
						break;
					case 4:
						nu++;
						break;

				}
			}
			t = c1 + c2;
			Console.WriteLine("Total de votos para o candidato 1: {0}",c1);

			Console.WriteLine("Total de votos para o candidato 1: {0}",c2);

			Console.WriteLine("Total de votos em branco: {0}", b);
			Console.WriteLine("Total de votos nulos: {0}", nu);
			Console.WriteLine("Total de votos lidos: {0}", t);
			if (c1 > c2)
{
				Console.WriteLine("O candidato vencedor é o numero 1");

			}
else
			{
				Console.WriteLine("O candidato vencedor é o numero 2");

			}

			Console.ReadKey();
		}
	}
}