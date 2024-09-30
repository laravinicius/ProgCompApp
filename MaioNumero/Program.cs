using System;

namespace MaioNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicitar 5 numeros
            //mostrar apenas o maior numero
            double numeroValido = 0;
            double maiorNum = 0;
            int cont = 0;

            Console.WriteLine("Maior Valor");
            while (cont < 5)
            {
                Console.Write("Digite um número: ");
                var numeroEntradaTxt = Console.ReadLine();
                if (double.TryParse(numeroEntradaTxt, out numeroValido))
                {
                    if (numeroValido > maiorNum)
                    {
                        maiorNum = numeroValido;
                        cont++;
                    }
                    else
                    {
                        cont++;
                    }                                       
                }
            }
            Console.WriteLine($"Maior número digitado: {maiorNum}");
            Console.ReadKey();
        }
    }
}
