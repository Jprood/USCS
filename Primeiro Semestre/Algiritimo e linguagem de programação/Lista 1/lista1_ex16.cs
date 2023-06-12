using System;

namespace Lista_ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Console.WriteLine("Entre com um número:");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com outro número:");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com outro número:");
            C = double.Parse(Console.ReadLine());

            if(A < B && B < C)
            {
                Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", A, B, C);
            }
            else if(A < C && C < B)
            {
                Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", A, C, B);
            }
            else if(B < A && A < C)
            {
                Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", B, A, C);
            }
            else if(B < C && C < A)
            {
                Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", B, C, A);
            }
            else if(C < A && A < B)
            {
                Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", C, A, B);
            }
            else if(C < B && B < A)
            {
                Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", C, B, A);
            }
            else
            {
                Console.WriteLine("Números invalidos");
            }
            Console.ReadKey();
        }
    }
}
