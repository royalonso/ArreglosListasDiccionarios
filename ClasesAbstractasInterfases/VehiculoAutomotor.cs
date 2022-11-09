using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractasInterfaces
{
    public class VehiculoAutomotor :IVehiculo
    {
        public string color { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int aniodeLiberacion { get; set; }
        public short cantidadPuertas { get; set; }
        public string tipoGasolina { get; set; }
        public string placa {get; set; }
        public bool encendido { get; set; }

        public VehiculoAutomotor()
        {
                 encendido = false;  
        }
        public VehiculoAutomotor(string color, string marca, string modelo, int aniodeLiberacion, short cantidadPuertas, string tipoGasolina, string placa)
        {
            this.color = color; 
            this.marca = marca; 
            this.modelo = modelo;   
            this.aniodeLiberacion = aniodeLiberacion;   
            this.cantidadPuertas = cantidadPuertas;
            this.tipoGasolina = tipoGasolina;
            this.placa = placa;
            encendido = false;
        }

        public void encender()
        {
            Console.WriteLine("Esta encendido");
            encendido = true;

        }

        public void apagar()
        {
            Console.WriteLine("Apagado");
           
        }
        public void andar()
        {
            Console.WriteLine("Andando");
            
        }
        public void acelerar()
        {
            Console.WriteLine("Acelerando");
            
        }

        public void girar(string direccion)
        {
            if (direccion.ToLower() != "derecha" && direccion.ToLower() != "izquierda")
            {
                throw new Exception("Direccion errronea");
            }
            Console.WriteLine("Giro hacia :{0}" + direccion);
        }

        public void cargarCombustible()
        {
            Console.WriteLine("Cargando gas");
        }

        public bool estaEncendido()
        {
            throw new NotImplementedException();
        }

        public int aniosdeAndiguedad()
        {
            return DateTime.Now.Year - aniodeLiberacion;
        }
    }
}
