using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    class Moto : Vehiculo //herencia
    {
        public string TipoMotocicleta { get; set; }

        public override void Conducir()
        {
            Console.WriteLine("La moto está circulando");
        }
    }
}