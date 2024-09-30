using System;

namespace _13.AulaForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LerValores();
        }
        static void LerValores()
        {
            int soma = 0;
            string pares = string.Empty;
            string multi3 = string.Empty;
            double media = 0;
            int maiorNum = int.MinValue;
            int menorNum = int.MaxValue;

            int[] valores = new int[5];
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite um valor: ");
                int.TryParse(Console.ReadLine(), out int valor);
                valores[i] = valor;
            }

            foreach (int numero in valores)
            {
                if (numero % 2 == 0)
                {
                    pares += $"{numero.ToString()}; ";
                }
                if (numero % 3 == 0)
                {
                    multi3 += $"{numero.ToString()}; ";
                }
                soma += numero;

                if (numero > maiorNum)
                {
                    maiorNum = numero;
                }
                if (numero < menorNum)
                {
                    menorNum = numero;
                }
            }
            media = soma / valores.Length;

            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Pares digitados: {pares}");
            Console.WriteLine($"Multiplos de 3: {multi3}");
            Console.WriteLine($"Media: {media}");
            Console.WriteLine($"Maior numero: {maiorNum}");
            Console.WriteLine($"Menor numero: {menorNum}");

            Console.ReadKey();
        }
    }
}
