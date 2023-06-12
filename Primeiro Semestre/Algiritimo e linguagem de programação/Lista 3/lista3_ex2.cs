using System.ComponentModel;

namespace Lista3_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, n_cli;
            double sd = 0, sch = 0, sc = 0, t;
            Console.WriteLine("Digite o número de clientes: ");
            n_cli = int.Parse(Console.ReadLine());
            for (int i = 0; i < n_cli; i++)
{
                Console.WriteLine(" Digite a opção desejada: ");
                Console.WriteLine(" 1 - Pagamento em dinheiro ");
                Console.WriteLine(" 2 - Pagamento em cartão ");
                Console.WriteLine(" 3 - Pagamento em cheque ");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
						double x;
                        Console.WriteLine("Digite a quantia a pagar: ");

                        x = double.Parse(Console.ReadLine());
                        sd = sd + x;
                        break;
                    case 2:
						double w;
                        Console.WriteLine("Digite a quantia a pagar: ");

                        w = double.Parse(Console.ReadLine());
                        sc = sc + w;
                        break;
                    case 3:
                        double q;
						Console.WriteLine("Digite a quantia a pagar: ");

                        q = double.Parse(Console.ReadLine());
                        sch = sch + q;
                        break;

                }
            }
            t = sd + sc + sch;
            Console.WriteLine("Total pago em dinheiro: {0}", sd);
            Console.WriteLine("Total pago em cartão: {0}", sc);
            Console.WriteLine("Total pago em cheque: {0}", sch);

            Console.WriteLine("Total ganho: {0}", t);
            Console.ReadKey();
        }
    }
}
