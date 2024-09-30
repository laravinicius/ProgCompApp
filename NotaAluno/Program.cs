using System;

namespace NotaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            if (nomeAluno == string.Empty)
            {
                Console.Write("Nome inválido");
                Console.ReadKey();
                return;
            }

            Console.Write("Nota 1 bimestre: ");
            var nota1BimTexto = Console.ReadLine();

            if (double.TryParse(nota1BimTexto, out double nota1Bim) == false)
            {
                Console.Write("Nota inválida");
                Console.ReadKey();
                return;
            }
            else if (nota1Bim < 0 || nota1Bim > 10)
            {
                Console.Write("Nota inválida");
                Console.ReadKey();
                return;
            }

            Console.Write("Nota 2 bimestre: ");
            var nota2BimTexto = Console.ReadLine();

            if (double.TryParse(nota2BimTexto, out double nota2Bim) == false)
            {
                Console.Write("Nota inválida");
                Console.ReadKey();
                return;
            }
            else if (nota2Bim < 0 || nota2Bim > 10)
            {
                Console.Write("Nota inválida");
                Console.ReadKey();
                return;
            }

            Console.Write("Numero de faltas: ");
            var numFaltasTexto = Console.ReadLine();

            if (double.TryParse(numFaltasTexto, out double numFaltas) == false)
            {
                Console.Write("Inválido");
                Console.ReadKey();
                return;
            }
            else if (numFaltas < 0 || numFaltas > 40)
            {
                Console.Write("Inválido");
                Console.ReadKey();
                return;
            }

            double media = (nota1Bim + nota2Bim) / 2;

            double presenca = 100 - (numFaltas*100/40);


            //double presenca = (numFaltas*40)/100;

            if (media >= 7 && presenca >= 75)
            {
                Console.Write("Aprovado");
            }
            else if (presenca < 30)
            {
                Console.Write("Reprovado por falta");
            }
            else
            {
                Console.Write("Reprovado");
            }
            Console.ReadKey();
        }
    }
}
