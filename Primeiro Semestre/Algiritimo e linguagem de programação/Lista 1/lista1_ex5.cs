using System;

namespace Lista1_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o primeiro número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Os numeros tem o mesmo valor");
            }
            else if(n1 > n2)
            {
                Console.WriteLine("O numero {0} é maior que {1}", n1, n2);
            }
            else
            {
                Console.WriteLine("O número {0} é maior que {1}", n2, n1);
            }
            Console.ReadKey();
        }
    }
}
