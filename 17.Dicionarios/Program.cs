using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.Dicionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExemploArray();
            ExemploLista();
            ExemploDicionario();
            ExemploReal();

            Console.ReadKey();
        }
        static void ExemploArray()
        {
            //mostrando que ordenar um array quebra a ligação entre 2 arrays 
            Console.WriteLine("----------------------------- Exemplo array -----------------------------");

            string[] produtos = new string[3];
            produtos[0] = "teclado";
            produtos[1] = "mouse";
            produtos[2] = "Monitor";

            produtos.Contains("Teste"); //validar se item existe no list 

            double[] valores = new double[3];
            valores[0] = 20.00;
            valores[1] = 15.00;
            valores[2] = 100.00;

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"O Produto {produtos[i]} custa: {valores[i]}");
            }

            Console.WriteLine("----------------------------- ordenada");

            Array.Sort(produtos);
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"O Produto {produtos[i]} custa: {valores[i]}");
            }

        }
        static void ExemploLista()
        {
            //mostrando que ordenar uma lista quebra a ligação entre 2 listas 

            Console.WriteLine("----------------------------- Exemplo lista -----------------------------");

            List<string> produtos = new List<string>();
            produtos.Add("teclado");
            produtos.Add("mouse");
            produtos.Add("Monitor");

            List<double> valores = new List<double>();
            valores.Add(20.00);
            valores.Add(15.00);
            valores.Add(100.00);

            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"O Produto {produtos[i]} custa: {valores[i]}");
            }

            Console.WriteLine("----------------------------- ordenada");

            produtos.Sort();
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"O Produto {produtos[i]} custa: {valores[i]}");
            }


        }
        static void ExemploDicionario()
        {
            Console.WriteLine("----------------------------- Exemplo dicionario -----------------------------");

            Dictionary<int, string> produtos = new Dictionary<int, string>();
            produtos.Add(0,"teclado");
            produtos.Add(1,"mouse");
            produtos.Add(2,"Monitor");
            
            Dictionary<int, double> valores = new Dictionary<int, double>();
            valores.Add(0, 20.00);
            valores.Add(1, 15.00);
            valores.Add(2, 100.00);

            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"O Produto {produtos[i]} custa: {valores[i]}");
            }
        }

        static void ExemploReal()
        {
            Console.WriteLine("----------------------------- Exemplo real -----------------------------");

            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "ativo");
            status.Add("C", "cancelado");
            status.Add("M", "matriculado");

            if (status.ContainsKey("Z"))
            {

            }
            if (status.ContainsValue("Zero"))
            {

            }


            foreach (var item in status)
            {
                Console.WriteLine($"#{item.Key} -- {item.Value}");

            }

        }
    }
}
