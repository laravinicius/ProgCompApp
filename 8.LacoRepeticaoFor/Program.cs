using System;

namespace _8.LacoRepeticaoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicitar numero
            //escrever a tabuada 1 a 10

            //Console.Write("Digite um valor: ");

            //var n1Texto = Console.ReadLine();

            //if (double.TryParse(n1Texto, out double n1))
            //{
            //    for (int i = 1; i < 11; i++)
            //    {
            //        Console.WriteLine($"{n1} x {i} = {n1 * i}");
            //    }
            //}
            //else
            //{
            //    return;
            //}

            //criar um laco for
            // ler numeros entre 1 e 100
            //escrever apenas pares
            //separados por ponto e virgula
            //exibir no final numero de pares
            //exibir soma dos impares
            string pares = string.Empty;
            int qtdPares = 0;
            int impares = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pares = pares + i.ToString() + ";";
                    qtdPares++;
                }
                else
                {
                    impares += i;
                }
            }
            Console.WriteLine($"Quantidade de pares: {qtdPares}");
            Console.WriteLine($"{pares}");
            Console.WriteLine($"Soma dos impares: {impares}");
            Console.ReadKey();
        }
    }
}
