using System;
using System.Collections.Generic;
namespace Listas
{
    internal class Program
    {
         static void Main(string[] args)
        {
            List<string> nombres = new List<string> { "lucas","Matias","Adrian"};
            Console.WriteLine("Escribe tu Nombre");
            string miNombre = Console.ReadLine();
            nombres.Add(miNombre);  
        }
    }

}
