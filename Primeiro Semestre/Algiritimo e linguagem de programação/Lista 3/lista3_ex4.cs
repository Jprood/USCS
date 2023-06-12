using System.ComponentModel;
using System.Net;

namespace Lista3_ex4
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, n_hab, x, m = 0, h = 0;
			double alt_f = 0, alt_h = 0, media_ig, media_am, media_ih,
			porc, y, z = 0, id_f = 0, id_h = 0;

			Console.WriteLine("Digite o número de habitantes: ");
			n_hab = int.Parse(Console.ReadLine());
			for (int i = 0; i < n_hab; i++)
{
				Console.WriteLine("Digite seu sexo: ");
				Console.WriteLine("0 - feminino");
				Console.WriteLine("1 - masculino");
				n = int.Parse(Console.ReadLine());
				switch (n)
				{
					case 0:
						Console.WriteLine("Digite sua idade: ");
						x = int.Parse(Console.ReadLine());
						if (x >= 18 && x <= 35)
{
							z++;
						}
						id_f = id_f + x;
						Console.WriteLine("Digite sua altura: ");
						y = double.Parse(Console.ReadLine());
						alt_f = alt_f + y;
						m++;
						break;
					case 1:
						Console.WriteLine("Digite sua idade: ");
						x = int.Parse(Console.ReadLine());
						if (x >= 18 && x <= 35)
{
							z++;
						}
						id_h = id_h + x;
						Console.WriteLine("Digite sua altura: ");
						y = double.Parse(Console.ReadLine());
						alt_h = alt_h + y;
						h++;
						break;

				}
			}
			media_ig = (id_f + id_h) / n_hab;
			media_am = alt_f / m;

			media_ih = id_h / h;
			porc = z / n_hab;
			Console.WriteLine("A media de idade do grupo: {0}", media_ig);

			Console.WriteLine("A media de altura das mulheres:{0}", media_am);

			Console.WriteLine("A medida de idade dos homem: {0}", media_ih);

			Console.WriteLine("Porcentagem de pessoas com idade entre 18 e 35 anos: {0}", porc);

			Console.ReadKey();
		}
	}
}