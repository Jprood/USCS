namespace Lista3_ex9
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a1 = new int[10];
			Console.WriteLine("Entre com 10 valores: ");
			for (int i = 0; i < 10; i++)
{
				a1[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < 10; i++)
{
				for (int x = i + 1; x < 10; x++)
{
					if (a1[i] == a1[x])
					{
						Console.Write("{0}, ", a1[i]);
					}
				}
			}
			Console.ReadKey();
		}
	}
}
