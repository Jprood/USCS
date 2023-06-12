using System;

namespace Lista1_ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.WriteLine("Digite um número");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            n2 = double.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                Console.WriteLine("O número {0} é maior que {1}", n1, n2);
            }
            else if(n2 > n1)
            {
                Console.WriteLine("O número {0} é maior que {1}", n2, n1);
            }
            else
            {
                Console.WriteLine("Os números são invalidos");
            }
            Console.ReadKey();
        }
    }
}
