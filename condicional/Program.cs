using System;

namespace condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno:");
            var nomeAluno = Console.ReadLine();
            if (nomeAluno == string.Empty)
            {
                return;
            }
            // sempre validar as exessoes antes
            // regra de negócio
            // salvar no banco



            //exemplo

            Console.Write("Digite nota 1: ");
            string nota1Texto = Console.ReadLine();
            if (double.TryParse(nota1Texto, out double nota1) == false)
            {
                Console.WriteLine("Nota invalida");
            }

            Console.Write("Digite nota 2: ");
            string nota2Texto = Console.ReadLine();
            if (double.TryParse(nota2Texto, out double nota2) == false)
            {
                Console.WriteLine("Nota invalida");
            }

            var media = (nota1 + nota2)/2;
            Console.WriteLine($"Media das notas = {media}");
            Console.ReadKey();
        }
    }
}
