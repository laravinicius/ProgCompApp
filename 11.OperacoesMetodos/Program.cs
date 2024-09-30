using System;

namespace _11.OperacoesMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora();
            Console.ReadKey();
        }

        static double Somar(double n1, double n2)
        {
            double resultado = n1 + n2;
            return resultado;
        }
        static double Subtrair(double n1, double n2)
        {
            double resultado = n1 - n2;
            return resultado;
        }
        static double Dividir(double n1, double n2)
        {
            double resultado = n1 / n2;
            return resultado;
        }
        static double Multiplicar(double n1, double n2)
        {
            double resultado = n1 * n2;
            return resultado;
        }
        static void Calculadora()
        {
            int n1 = SolicitarNumero();
            int n2 = SolicitarNumero();
            string operacao = Solicitaroperacao();
            int resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    resultado = n1 / n2;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
        }

        static int SolicitarNumero()
        {
            Console.Write("Digite numero: ");
            string valorTexto = Console.ReadLine();
            int.TryParse(valorTexto, out int valor);
            return valor;
        }
        static string Solicitaroperacao()
        {
            Console.Write("Digite operacao (+ - / *): ");
            string valorTexto = Console.ReadLine();
            return valorTexto;
        }
    }
}
