using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Consola
{
    public abstract class TransportePublico
    {
        public int Pasajeros { get; set; }
        public string Nombre { get; set; }
        public TransportePublico(int pasajeros, string nombre)
        {
            this.Pasajeros = pasajeros;
            this.Nombre = nombre;
        }
        public abstract int Get();
        public abstract string Avanzar();
        public abstract string Detenerse();

    }
}
