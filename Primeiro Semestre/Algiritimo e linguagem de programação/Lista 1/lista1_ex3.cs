using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, comissao, fimdomes;

            Console.WriteLine("Entre com o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Entre com o seu salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor das vendas");
            vendas = double.Parse(Console.ReadLine());

            comissao = 20.00 / 100.00 * vendas;
            fimdomes = salario + comissao;

            Console.WriteLine("Nome do vende dor: {0}", nome);
            Console.WriteLine("O seu Salario fixo é: {0}", salario);
            Console.WriteLine(" A comissao é {0}", fimdomes);
            Console.ReadKey();
        }
    }
}
