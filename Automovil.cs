using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    class Automovil : Vehiculo //herencia
    //La herencia es una característica que permite definir una clase base
    //que proporciona funcionalidad datos y comportamiento
    //la clase Vehiculo es la clase base.
    //Las clases Avion, Moto y Automovil son clases derivadas de la clase
    //Vehiculo. Esto significa que heredan todos los atributos y métodos de la clase base.
    {
        public int Cilindrada { get; set; }

        public override void Conducir()
        {
            Console.WriteLine("El automóvil está circulando");
        }
    }
}
