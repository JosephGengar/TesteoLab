using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Consola
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros, string nombre) : base(pasajeros, nombre)
        {

        }

        public override string Avanzar()
        {
            return "soy un taxi avanzando";
        }

        public override string Detenerse()
        {
            return "soy un taxi deteniendome";
        }

        public override int Get()
        {
            return this.Pasajeros;
        }
    }
}
