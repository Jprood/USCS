using System;

namespace Lista1_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, som, sub, div, mul;

            Console.Write("Entre com o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            som = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;

            Console.WriteLine("A soma dos números é igual a: {0}", som);
            Console.WriteLine("A subtração dos números é igual a: {0}", sub);
            Console.WriteLine("A multiplicação dos números é igual a: {0}", mul);
            Console.WriteLine("A divisão dos números é igual a: {0}", div);
            Console.ReadKey();
        }
    }
}
