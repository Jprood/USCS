
    namespace Lista2_ex1
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] ar1 = new int[10];
                Console.WriteLine("Insira 10 valores:");
                for (int i = 0; i < 10; i++)
                {
                    ar1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Os números pares informados são: &quot");
                for (int i = 0; i < 10; i++)
                {
                    if (ar1[i] % 2 == 0)
                    {
                        Console.Write("{0}, ", ar1[i]);
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine("Os números ímpares iformados são:");
                for (int i = 0; i < 10; i++)
                {
                    if (ar1[i] % 2 == 1)
                    {
                        Console.Write("{0}, ", ar1[i]);
                    }
                }
                Console.ReadKey();
            }
        }
    }