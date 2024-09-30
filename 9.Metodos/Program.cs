using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Metodos
{
    internal class Program //clase sempre com mesmo nome do arquivo program.cs
    {
        static void Main(string[] args) //métodos são como funções do JS
        {
            OlaMundo();
            EscreverTexto("Ola mundo por parametro");
            SomarNumeros(1, 2);
            Console.ReadKey();
        }

        static void OlaMundo()
        {
            Console.WriteLine("Olá mundo");
        }
        static void EscreverTexto(string texto)
        {
            Console.WriteLine(texto);
        }

        static void SomarNumeros(int n1, int n2)
        {
            int soma = n1 + n2;
            Console.WriteLine($"soma: {soma}");
        }

        







        // static > não posso instanciar mais de 1 vez - só pode chamar métodos static 

        //retornar o tipo
        //void não retorna nada
        //exemplos

        //() > visam receber parametros

        //    string OlaMundoString()
        //    {
        //        return "ola mundo";
        //    }

        //    int OlaMundoInt()
        //    {
        //        return 1;
        //    }
    }
}
