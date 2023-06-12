namespace Lista2_ex2

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int soma = 0;

            Console.WriteLine("Digite 10 numeros:");




            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

                if (a[i] % 2 == 0)
                {
                    soma = soma + a[i];
                }
            }

            Console.WriteLine("A soma dos numeros pares é igual a: {0}", soma);

            Console.ReadKey();
        }
    }
}

