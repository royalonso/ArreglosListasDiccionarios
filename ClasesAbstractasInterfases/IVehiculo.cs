using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractasInterfaces
{
    public interface IVehiculo
    {
        public void encender();
        public void apagar();
        public void andar();
        public void acelerar();
        public void girar(string direccion);
        public void cargarCombustible();
        public bool estaEncendido();
        public int aniosdeAndiguedad();
    }
}
