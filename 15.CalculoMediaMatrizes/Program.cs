using System;

//criar uma matriz float 2x2
//oara armazenar notas
//indicie do aluno é o mesmo indicie das notas
//calcular a media de cada aluno

//0: {"RA", "NOME", "TURMA" },
//1: {"1","aluno 1","2esan" },
//2: { "2","aluno 2","2esan" },
//3: { "3","aluno 3","2esan" }

// 0:
// 1: nota1 | n2
// 2: n1 | n2
// 3: n1 | n2


namespace _15.CalculoMediaMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matrizAlunos = Alunos();
            double[,] matrizNotas = Notas();

            //CalcularMedia(matrizNotas);

            EscreverTela(matrizAlunos, matrizNotas);

            Console.ReadKey();
        }

        static string[,] Alunos()
        {
            string[,] alunos = new string[4, 3]
            {
                {"RA", "NOME", "TURMA" },
                {"1","aluno 1","2esan" },
                {"2","aluno 2","2esan" },
                {"3","aluno 3","2esan" }
            };
            return alunos;
        }

        static double[,] Notas()
        {
            double[,] notas = new double[4, 2]
            {
                {0, 0},
                {7.0,10  },
                {4.5,9.0 },
                {7.0,6.0 }
            };
            return notas;

        }

        static void CalcularMedia(double[,] notas)
        {
            double media = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    
                }
                
            }
            
        }

        static void EscreverTela(string[,] matrizAlunos, double[,] matrizNotas)
        {
            for (int i = 0; i < matrizAlunos.GetLength(0); i++)
            {
                for (int j = 0; j < matrizAlunos.GetLength(1); j++)
                {
                    Console.Write(matrizAlunos[i, j].PadLeft(10));
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            for (int i = 0; i < matrizNotas.GetLength(0); i++)
            {
                for (int j = 0; j < matrizNotas.GetLength(1); j++)
                {
                    Console.Write(matrizNotas[i, j].ToString().PadLeft(10));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
