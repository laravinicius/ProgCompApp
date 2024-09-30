using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa em C# que solicite ao usuário um número inteiro positivo.
            //Em seguida, o programa deve calcular e exibir a soma
            //de todos os números pares entre 1 e o número informado pelo usuário.
            

            Console.WriteLine("Digite um número inteiro e positivo: ");
            var numEntradaTxt = Console.ReadLine();

            if (int.TryParse(numEntradaTxt, out int numEntrada))
            {
                if (numEntrada < 0)
                {

                }else if()
                {

                }
            }
        }
    }
}
