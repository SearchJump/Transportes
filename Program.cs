using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto de la clase Avion
            Avion avion = new Avion();
            avion.Marca = "Boeing";
            avion.Modelo = "787 Dreamliner";
            avion.NumeroPuertas = 2;
            avion.CantidadPasajeros = 250;

            // Arrancamos el motor del avión
            avion.ArrancarMotor();

            // Conducimos el avión
            avion.Conducir();

            // Creamos un objeto de la clase Moto
            Moto moto = new Moto();
            moto.Marca = "Honda";
            moto.Modelo = "CBR1000RR";
            moto.NumeroPuertas = 0;
            moto.TipoMotocicleta = "Deportiva";

            // Arrancamos el motor de la moto
            moto.ArrancarMotor();

            // Conducimos la moto
            moto.Conducir();

            // Creamos un objeto de la clase Automovil
            Automovil automovil = new Automovil();
            automovil.Marca = "Volkswagen";
            automovil.Modelo = "Golf";
            automovil.NumeroPuertas = 5;
            automovil.Cilindrada = 1;

            // Arrancamos el motor del automóvil
            automovil.ArrancarMotor();

            // Conducimos el automóvil
            automovil.Conducir();

        }
    }
}
