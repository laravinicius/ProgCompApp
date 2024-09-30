using System;

namespace _14.AulaMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alunos();
            Notas();
            Console.ReadKey();
        }

        static void ExemploMatriz()
        {
            int[] numeros = new int[3]
            {
                10,20,30
            };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            //linhas, colunas
            int[,] matriz = new int[3, 3]
            {
                { 10,20,30 },
                { 40,50,60 },
                { 70,80,90 }
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
            //matriz[0, 0] = 10;
            //matriz[0, 1] = 20;
            //matriz[0, 2] = 30;

            //matriz[1, 0] = 40;
            //matriz[1, 1] = 50;
            //matriz[1, 2] = 60;

            //matriz[2, 0] = 70;
            //matriz[2, 1] = 80;
            //matriz[2, 2] = 90;

        }
        static void MatrizBidimensional()
        {
            int[,] matriz = new int[3, 3]
            {
                { 10,20,30 },
                { 40,50,60 },
                { 70,80,90 }
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
        }

        // criar uma matriz strin 4x3
        // 4 linhas 3 colunas
        // primeira linha [ RA , nome, turma]
        //segunda linha [dados do aluno 1]
        // terceira [dados aluno 2]
        //....

        static void Alunos()
        {
            string[,] alunos = new string[4, 3]
            {
                {"RA", "NOME", "TURMA" },
                {"1","aluno 1","2esan" },
                {"2","aluno 2","2esan" },
                {"3","aluno 3","2esan" }
            };

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                for (int j = 0; j < alunos.GetLength(1); j++)
                {
                    Console.Write(alunos[i, j].PadLeft(10));
                }
                Console.WriteLine();

            }
            Console.WriteLine();

        }

        

        static double[,] Notas()
        {
            double[,] notas = new double[4, 2]
            {
                {0, 0},
                {0.3,0.3 },
                {0.3,0.3 },
                {0.3,0.3 }
            };
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.Write(notas[i, j].ToString().PadLeft(10));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return notas;

        }

    }
}
