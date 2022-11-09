using ArreglosListasDiccionarios;
using System;
namespace ArreglosListasDiccionaros  // Listas Basicos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            string[] razaDeperros = new string[5];
            int[] edades = {3,4,5,6,7,8,9}; 
            int indice = 0;
            foreach (string raza in razaDeperros)
            {
                razaDeperros[indice] = Console.ReadLine();
                Console.Write(raza);
                indice++;
            }
            Console.WriteLine("Imprimo las Razas ");
            for (int i = 0; i < razaDeperros.Length; i++)
            {
                Console.Write(" " + razaDeperros[i]);
            }
            
            Console.WriteLine("  Total: " + razaDeperros.Length);

            foreach(int j in edades)
            {
                Console.WriteLine("Edades :" + j);
            }
            */
            /*
            Botella[] botellas = new Botella[3];
            Botella[] botellas1 =
            {
                new Botella("CocaCola"),
                new Botella("Pepsi"),
                new Botella("Sprite"),
            };
            foreach (Botella botella in botellas1)
            {
                Console.WriteLine(botella);
            }
            */
            /*
            Dictionary<string, string> persona = new Dictionary<string, string>();
            persona.Add("1", "pepe");
            Console.WriteLine(persona.Count);
            Console.WriteLine(persona.Count);
            */
            /*
            Botellita[] botellitas = 
            {
                new Botellita("Vidrio"),
                new Botellita("Plastico"),
                new Botellita("Aluminio"),
            };
            */
            // Diccionario
            /*
            Dictionary<string, string> personas = new Dictionary<string, string>();
            personas.Add("4321", "Pirulo");
            personas.Add("1234", "Mengano");
            personas.Add("6789", "Perengano");
            personas.Add("1", "Sutano");
            Console.WriteLine("Count :");
            Console.WriteLine(personas.Count);
            string value = "";
            string clave = "";
            personas.TryGetValue(clave, out value);
            Console.WriteLine("Variable de Salida");
            Console.WriteLine(value);
            Console.WriteLine("Claves :");
            Console.WriteLine(personas.Keys);
            Console.WriteLine("Valores :");
            Console.WriteLine(personas.Values);
            personas.Remove("1");
            Console.WriteLine(personas.Count);
            personas.Clear();
            Console.WriteLine("Variable de Salida");
            Console.WriteLine(personas.Count);
            */
            // Diccionario con objetos.
            Dictionary<string, Persona> personas = new Dictionary<string, Persona>();
            personas.Add("4321", new Persona("Pirulo"));
            personas.Add("1234", new Persona("Mengano"));
            personas.Add("6789", new Persona("Perengano"));
            personas.Add("1", new Persona("Sutano"));
            Console.WriteLine("Count :");
            Console.WriteLine(personas.Count);
            foreach(string key in personas.Keys) // Imprimo las claves 
            {
                Console.WriteLine(personas[key]);
            }

            Persona value = new Persona();
            string clave = "";
            Console.WriteLine("Ingrese la clave :");
            clave = Console.ReadLine();
            personas.TryGetValue(clave, out value );
            Console.WriteLine("Claves :");
            Console.WriteLine(personas.Keys);
            Console.WriteLine("Valores :");
            Console.WriteLine(personas.Values);
            personas.Remove("1");
            Console.WriteLine(personas.Count);
            personas.Clear();
            Console.WriteLine("Variable de Salida");
            Console.WriteLine(personas.Count);


        }
    }
}
