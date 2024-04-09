using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    class Avion : Vehiculo //herencia
    {
        public int CantidadPasajeros { get; set; }

        public override void Conducir()
        {
            Console.WriteLine("El avión está volando");
        }
    }
}