using Microsoft.SqlServer.Server;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ComprobarCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condicion = true;
            Check check = new Check();

            while (condicion)
            {
                Console.WriteLine("Escribe la primera palabra");
                string input1 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input1))
                {
                    Console.WriteLine("No se permiten palabras vacías");
                    continue;
                }

                Console.WriteLine("Escribe la segunda palabra");
                string input2 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input2))
                {
                    Console.WriteLine("No se permiten palabras vacías");
                    continue;
                }

                condicion = false;
                Console.WriteLine(check.Comprobar(input1, input2));
                Console.ReadLine();
            }
        }
    }
}