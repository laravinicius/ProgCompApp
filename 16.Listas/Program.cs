using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = new int[3];
            //numeros[0] = 10;
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //};

            List<int> ListaNumeros = new List<int>();
            //adicionar 100 numeros na lista
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                //crud create
                ListaNumeros.Add(random.Next(0, 999));
            }
            //crud read
            foreach (int i in ListaNumeros)
            {
                Console.WriteLine($" {i} ");
            }
            //crud update
            ListaNumeros[0] = 1234;

            //crud remove
            ListaNumeros.Remove(511); //remover item da lista
            ListaNumeros.RemoveAt(0); //remover indice

            int menorNum = ListaNumeros.Min();
            int maiorNum = ListaNumeros.Max();
            int somaNum = ListaNumeros.Sum();
            double mediaNum = ListaNumeros.Average();

            //filtrar - where
            //sintaxe lambda
            // => "tal que"
            // nomeVar => condição
            List<int> pares = ListaNumeros.Where(x => x%2 == 0).ToList(); //coloca os numeros pares em uma lista

            //todos os numeros impares entre 100 - 300 multiplos de 5
            List<int> impares = ListaNumeros.Where(x => x % 2 != 0 
                                                    && x %5 == 0 
                                                    && x > 100 
                                                    && x <= 300).ToList();
            foreach (int i in pares)
            {
                Console.WriteLine($"Pares: {i}");
            }
            foreach(int i in impares)
            {
                Console.WriteLine($"Impares divisiveis por 5: {i}");
            }



            Console.ReadKey();
        }
    }
}
