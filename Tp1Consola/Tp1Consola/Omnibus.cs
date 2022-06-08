using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Consola
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros, string nombre) : base (pasajeros, nombre)
        {

        }

        public override string Avanzar()
        {
            return "soy un omnibus que avanza";
        }

        public override string Detenerse()
        {
            return $"soy un {Nombre} deteniendome";
        }

        public override int Get()
        {
            return this.Pasajeros;
        }
    }
}
