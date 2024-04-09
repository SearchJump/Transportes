using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace Transportes
{
    abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int NumeroPuertas { get; set; }

        public void ArrancarMotor()
        {
            Console.WriteLine("El motor del vehículo se ha encendido");
        }

        public void PararMotor()
        {
            Console.WriteLine("El motor del vehículo se ha apagado");
        }

        public abstract void Conducir();
        //el método Conducir() es virtual. Esto significa que puede ser redefinido por las clases derivadas.
        //Las clases derivadas Avion, Moto y Automovil redefinen el método Conducir() para proporcionar
        //un comportamiento específico para cada tipo de vehículo.
        //Por ejemplo, el método Conducir() de la clase Avion imprime el mensaje "El avión está volando"
        //, mientras que el método Conducir() de la clase Moto imprime el mensaje "La moto está circulando".

        //el polimorfismo nos permite escribir código que puede funcionar con diferentes tipos de objetos de manera uniforme.
    }
}
