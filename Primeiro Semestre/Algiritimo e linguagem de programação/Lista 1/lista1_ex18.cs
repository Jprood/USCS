using System;

namespace Lista1_ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, d;

            Console.WriteLine("Entre com o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o primeiro número:");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                d = n1 - n2;

                Console.WriteLine("A diferença entre os números é igual a: {0}", d);
            }
            else
            {
                d = n2 - n1;

                Console.WriteLine("A diferença entre os números é igual a: {0}", d);
            }
            Console.ReadKey();
        }
    }
}
