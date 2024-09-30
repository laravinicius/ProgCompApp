using System;

namespace LacoRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int qtdNumeros = 2;
            //while (qtdNumeros < 100000000)
            //{
            //    Console.WriteLine(qtdNumeros);
            //    qtdNumeros = qtdNumeros * qtdNumeros;
            //}
            //Console.ReadKey();
            //----------------------------------------------------------------------------

            // solicitar 5 numeros
            // escrever os 5 numevos
            // se nao for numerico nao aceitar

            //int cont = 0;
            //double numeroValido = 0;
            //string resultado = string.Empty;
            //while (cont < 5)
            //{
            //    Console.Write("Digite um valor: ");
            //    var numeroEntradaTexto = Console.ReadLine();
            //    if (double.TryParse(numeroEntradaTexto, out numeroValido))
            //    {
            //        cont++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Valor inválido");
            //    }
            //    resultado = resultado + " " + numeroValido.ToString();
            //}
            //Console.Write($"{resultado}");
            //Console.ReadKey();

            //----------------------------------------------------------------------------

            //mesma coisa aceitando apenas par
            int cont = 0;
            double numeroValido = 0;
            while (cont < 5)
            {
                Console.Write("Digite um valor par: ");
                var numeroEntradaTexto = Console.ReadLine();
                if (double.TryParse(numeroEntradaTexto, out numeroValido))
                {
                    if (numeroValido % 2 == 0)
                    {
                        Console.WriteLine($"Numero par: {numeroValido}");
                        cont++;
                    }
                    else
                    {
                        Console.WriteLine("Valor ímpar");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido");
                }
            }
            Console.ReadKey();

        }
    }
}
