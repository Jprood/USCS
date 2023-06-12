namespace Lista2_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[10];
            int[] a2 = new int[10];
            Console.WriteLine("Entre com 10 valores: ");
            for (int i = 0; i < 10; i++)
{
                a1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Entre com mais 10 valores: ");
            for (int i = 0; i < 10; i++)
{
                a2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
{

                if (a1[i] != a2[0] && a1[i] != a2[1] && a1[i] != a2[2] && a1[i] != a2[3] && a1[i] != a2[4] && a1[i] != a2[5] && a1[i] != a2[6]
                && a1[i] != a2[7] && a1[i] != a2[8] && a1[i] != a2[9])

{
                    Console.Write("{0},", a1[i]);
                }

            }
            for (int i = 0; i < 10; i++)
{
                if (a2[i] != a1[0] && a2[i] != a1[1] && a2[i] != a1[2] && a2[i] != a1[3] && a2[i] != a1[4] && a2[i] != a1[5]
                && a2[i] != a1[6] && a2[i] != a1[7] && a2[i] != a1[8] && a2[i] != a1[9])

{
                    Console.Write("{ 0}," , a2[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
