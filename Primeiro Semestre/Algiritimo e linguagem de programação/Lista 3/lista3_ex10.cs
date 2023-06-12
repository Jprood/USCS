namespace Lista3_ex10
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ar = new int[10];
			Console.WriteLine("Digote 10 valores: ");
			for (int i = 0; i < 10; i++)
{
				ar[i] = int.Parse(Console.ReadLine());
				if (ar[i] < 0)
{
					ar[i] = 0;
				}
			}
			for (int i = 0; i < 10; i++)
{
				Console.WriteLine(ar[i]);
			}
			Console.ReadKey();
		}
	}
}
