using System;

namespace DescontoProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeProduto = string.Empty;
            double valorProduto = 0;
            double porcentagemDesconto = 0;
            double valorDesconto = 0;
            double valorFinal = 0;
            bool verificaNome;
            bool convertValorProduto;
            bool convertDesconto;

            Console.Write("Digite o nome do produto: ");
            do
            {
                var nomeProdutoTexto = Console.ReadLine();
                if (nomeProdutoTexto == string.Empty)
                {
                    Console.Write("INVÁLIDO, digite um nome para o produto: ");
                    verificaNome = false;                
                }
                else
                {
                    nomeProduto = nomeProdutoTexto;
                    verificaNome = true;
                }
            } while (!verificaNome);         


            Console.Write("Digite o valor do produto: R$ ");
            do
            {
                var valorProdutoTexto = Console.ReadLine();
                convertValorProduto = double.TryParse(valorProdutoTexto, out valorProduto);

                if (!convertValorProduto)
                {
                    Console.Write("INVÁLIDO, digite um valor: ");
                }
                else if (valorProduto <= 0)
                {
                    Console.Write("Valor precisa ser maior que 0, digite novamente: ");
                    convertValorProduto = false;
                    valorProduto = 0;
                }

            } while (!convertValorProduto);

            Console.Write("Digite o valor do desconto (em %): ");
            do
            {
                var descontoTexto = Console.ReadLine();
                convertDesconto = double.TryParse(descontoTexto, out porcentagemDesconto);

                if (!convertDesconto)
                {
                    Console.Write("INVÁLIDO, digite um valor: ");
                }
                if (porcentagemDesconto < 0 || porcentagemDesconto > 100)
                {
                    Console.Write("Valor de desconto precisa estar entre 0% e 100%, digite novamente: ");
                    convertDesconto = false;
                    porcentagemDesconto = 0;
                }

            } while (!convertDesconto);

            valorDesconto = (porcentagemDesconto / 100) * valorProduto;

            valorFinal = valorProduto - valorDesconto;

            Console.WriteLine($"\nNome do produto: {nomeProduto}");
            Console.WriteLine($"Valor inicial do produto: R$ {valorProduto:F2}");
            Console.WriteLine($"Valor de desconto: R$ {valorDesconto:F2}");
            Console.WriteLine($"Valor após o desconto: R$ {valorFinal:F2}");
            Console.ReadKey();

        }
    }
}
