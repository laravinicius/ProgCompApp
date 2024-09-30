using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CalculaMediaMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var media = CalcularMedia(7.5,6.2);
            EscreverTela($"media: {media}");
            Console.ReadKey();
        }
        //criar um metodo para receber 2 parametros
        // nota 1 bimestre
        //nota 2 bimestre
        // calcular media
        // ecrever media

        static double CalcularMedia(double n1bim, double n2bim)
        {
            double media = (n1bim + n2bim)/2;
            return media;
        }

        static void EscreverTela(string texto)
        {
            Console.Write($"{DateTime.Now} - {texto}");
        }

        
    }
}
