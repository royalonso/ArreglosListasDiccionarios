using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractasInterfaces
{
    public class Motocicleta : VehiculoAutomotor
    {
        public short casco { get; set; }
        public string rodado { get; set; }
        public string tiporueda { get; set; }
        public string tamanio { get; set; }
        public short maximoocupantes { get; set; }

        public Motocicleta(string color, 
            string marca, 
            string modelo, 
            int aniodeLiberacion, 
            short cantidadPuertas, 
            string tipoGasolina, 
            string placa, 
            short casco, 
            string rodado, 
            string tiporueda, 
            string tamanio, 
            short maximoocupantes):base(color, marca, modelo, aniodeLiberacion,cantidadPuertas,tipoGasolina,placa)
        {
            this.casco = casco;
            this.rodado = rodado;
            this.tiporueda = tiporueda;
            this.tamanio = tamanio;
            this.maximoocupantes = maximoocupantes;
        }
        public Motocicleta() : base()
        {

        }
        
        
        
       

    }
    
}
