using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char turma = ' ';
            string nomeAluno = string.Empty;
            int periodo = 0;
            float nota1Bim = 0;
            float nota2Bim = 0;
            float notaMinimaAprovacao = 7f;


            Console.Write("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();



            Console.Write("Selecione a turma (A/B): ");
            turma = char.Parse(Console.ReadLine());

            Console.Write("Digite o perídodo: ");

            //-----------------------------
            //Exemplo de validação

            //var periodoTexto = Console.ReadLine();
            //if (int.TryParse(periodoTexto, out int number))
            //{
            //    periodo = number;
            //}
            //else
            //{
            //    Console.WriteLine("Digite um valor válido");
            //}
            //-----------------------------

            periodo = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota do 1 bimestre: ");
            nota1Bim = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do 2 bimestre: ");
            nota2Bim = float.Parse(Console.ReadLine());



            double mediaSemestre = (nota1Bim + nota2Bim) / 2;

            Console.WriteLine("\n-------------------------------\n");
            Console.WriteLine($"Nome do aluno: {nomeAluno}");
            Console.WriteLine($"Período: {periodo}");
            Console.WriteLine($"Turma: {turma}");
            Console.WriteLine($"Nota 1 bimestre: {nota1Bim}, nota 2 bimestre: {nota2Bim}");
            Console.WriteLine($"Media: {mediaSemestre}");

            if (mediaSemestre < notaMinimaAprovacao)
            {
                Console.WriteLine("Situação: Reprovado");
            }
            else
            {
                Console.WriteLine("Situação: Aprovado");
            }
        }
    }
}