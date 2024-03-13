using System;

namespace DescontoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = new string('-', 40);
            Console.WriteLine("Informe o nome do produto:");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto:");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            double precoTotal = CalcularPrecoTotal(precoProduto, quantidadeProduto);
            double desconto = CalcularDesconto(quantidadeProduto);
            Console.WriteLine(sep);
            Console.WriteLine($"Valor total: {precoTotal.ToString("C")}");
            Console.WriteLine(sep);
            Console.WriteLine($"Desconto: {precoProduto * quantidadeProduto - precoTotal}");
            Console.WriteLine(sep);
        }

        public static double CalcularPrecoTotal(double preco, int quantidade)
        {
            double desconto = CalcularDesconto(quantidade);
            return preco * quantidade * (1 - desconto);
        }

       public static double CalcularDesconto(int quantidade)
        {
            if (quantidade > 50)
                return 0.25;
            else if (quantidade > 20)
                return 0.2;
            else if (quantidade > 10)
                return 0.1;
            else
                return 0;
        }
    }
}
