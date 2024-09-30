using System;

namespace ConversaoMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeMoeda = string.Empty;
            double valorCotacao = 0;

            Console.Write("Digite o valor a ser convertido: R$");
            var valorRealTexto = Console.ReadLine();

            if (double.TryParse(valorRealTexto, out double valorReal) == false)
            {
                Console.Write("Valor inválido");
                Console.ReadKey();
                return;
            }
            else if (valorReal < 0)
            {
                Console.Write("Valor inválido");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Deseja converter para qual moeda?\n(1) para Dólar \n(2) para Euro");
            var selecionaOpcaoTexto = Console.ReadLine();

            if (int.TryParse(selecionaOpcaoTexto, out int selecionaOpcao) == false)
            {
                Console.Write("Valor inválido");
                Console.ReadKey();
                return;
            }

            switch (selecionaOpcao)
            {
                case 1:
                    valorCotacao = 5.57; nomeMoeda = "USD";
                    break;
                case 2:
                    valorCotacao = 6.19; nomeMoeda = "EUR";
                    break;
                default: Console.Write("Valor inválido");Console.ReadKey(); 
                    return;

            }

            double valorConvertido = valorReal * valorCotacao;

            Console.Write($"Conversão de R${valorReal:F2} para {nomeMoeda} {valorConvertido:F2}");
            Console.ReadKey();
        }
    }
}
