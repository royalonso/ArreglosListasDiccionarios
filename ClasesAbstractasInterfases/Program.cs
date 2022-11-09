using System.IO;
namespace ClasesAbstractasInterfaces
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Motocicleta motoMami = new Motocicleta(color: "Azul", marca: "Suzuky", modelo: "AW", aniodeLiberacion: 2016, cantidadPuertas: 0, tipoGasolina: "Nafta",
            placa: "111-111", casco: 10, rodado: "26", tiporueda: "Mediana", tamanio: "B", maximoocupantes: 2);
            motoMami.encender();
            motoMami.acelerar();
            motoMami.andar();
        }


    }
}
