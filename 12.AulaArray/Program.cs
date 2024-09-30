using System;

namespace _12.AulaArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExemploArray();
            LerValores();
        }

        //static void ExemploArray()
        //{
        //    int[] numeros = new int[3];

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        numeros[i] = i * 10;
        //    }

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        Console.WriteLine(numeros[i]);
        //    }

        //    Console.ReadKey();
        //}
        //----------------------------------------------------------------------
        //dois laços de repeticao
        //um para carregar outro para ler
        //criar um array 5 posicoes, solicitar 5 valores 
        //mostrar valores na tela utilizando for

        //static void LerValores()
        //{
        //    int[] valores = new int[5];
        //    for (int i = 0; i < valores.Length; i++)
        //    {
        //        Console.Write("Digite um valor: ");
        //        int.TryParse(Console.ReadLine(), out int valor);
        //        valores[i] = valor;
        //    }

        //    for (int i = 0; i < valores.Length; i++)
        //    {
        //        Console.WriteLine($"Valor {i}: {valores[i]} ");
        //    }
        //    Console.ReadKey();
        //}
        //----------------------------------------------------------------------

        //dos numeros informados: mostar os pares separados por ;
        //soma dos numeros
        //media dos numeros
        //maior numero

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

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] % 2 == 0)
                {
                    pares += $"{valores[i].ToString()}; ";
                }
                if (valores[i] % 3 == 0)
                {
                    multi3 += $"{valores[i].ToString()}; ";
                }
                soma += valores[i];

                if (valores[i] > maiorNum)
                {
                    maiorNum = valores[i];
                }
                if (valores[i] < menorNum)
                {
                    menorNum = valores[i];
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