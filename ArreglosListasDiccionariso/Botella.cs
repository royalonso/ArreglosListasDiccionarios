using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosListasDiccionarios
{
    public class Botella
    {
        public string nombre { get; set; }
        public string color { get; set; }
        public double capacidad { get; set; }

        public Botella()
        {

        }
        public Botella(string nombre)
        {
            this.nombre = nombre;

        }
        public Botella(string nombre, string color, double capacidad)
        {
            this.nombre = nombre;
            this.color = color;
            this.capacidad = capacidad;
        }
        public override string ToString()
        {
            return nombre;
        }
       
    }
    public class Botellita : Botella
    {
        public string material { get; set; }

        public Botellita() : base()
        {

        }
        public Botellita(string material)
        {
            this.material = material;   
        }
        public Botellita(string material, string nombre, string color, double capacidad) : base(nombre, color, capacidad)
        {
            this.material = material;

        }


    }
    public class Persona
    {
        public string nombre;
        public Persona(){

        }

        public Persona(string nombre)
        {
         this.nombre= nombre;    
        }
        public override string ToString()
        {
            return nombre;
        }
    }

}
