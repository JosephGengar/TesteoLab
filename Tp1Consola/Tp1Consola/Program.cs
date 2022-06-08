using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 2 };
            Console.WriteLine(array[0]);
            List<int> arrayOmnibus = new List<int>();

            Console.WriteLine("Ingrese una Cantidad de Pasajeros para omnibus comprendida entre 0 y 100: ");
            Console.WriteLine("\n");
            arrayOmnibus.Add(Corroborar1("ingrese cantidad de pasajeros para Omnibus 1: "));        
            arrayOmnibus.Add(Corroborar1("ingrese cantidad de pasajeros para Omnibus 2: "));          
            arrayOmnibus.Add(Corroborar1("ingrese cantidad de pasajeros para Omnibus 3: "));           
            arrayOmnibus.Add(Corroborar1("ingrese cantidad de pasajeros para Omnibus 4: "));         
            arrayOmnibus.Add(Corroborar1("ingrese cantidad de pasajeros para Omnibus 5: "));
            Console.WriteLine("\n");
            Console.WriteLine("Ahora vamos a ingresar una cantidad de pasajeros para taxis comprendida entre 0 y 4: ");
            Console.WriteLine("\n");
            List<int> arrayTaxi = new List<int>();           
            arrayTaxi.Add(Corroborar2("ingrese cantidad de pasajeros para Taxi 1: "));           
            arrayTaxi.Add(Corroborar2("ingrese cantidad de pasajeros para Taxi 2: "));        
            arrayTaxi.Add(Corroborar2("ingrese cantidad de pasajeros para Taxi 3: "));
            arrayTaxi.Add(Corroborar2("ingrese cantidad de pasajeros para Taxi 4: "));        
            arrayTaxi.Add(Corroborar2("ingrese cantidad de pasajeros para Taxi 5: "));


            List<TransportePublico> oTransPublico = new List<TransportePublico>();
            for (int i = 0; i < arrayOmnibus.Count; i++)
            {
                oTransPublico.Add(new Omnibus(arrayOmnibus[i], $"omnibus {i+1}"));
            }
            for (int i = 0; i < arrayTaxi.Count; i++)
            {
                oTransPublico.Add(new Taxi(arrayTaxi[i], $"taxi {i+1}"));
            }
            Console.WriteLine("\n");
            Console.WriteLine("Lista final de Transporte:");
            Console.WriteLine("\n");
            foreach (var item in oTransPublico)
            {
                Console.WriteLine(item.Nombre + " contiene: " + item.Get() + " pasajeros." + item.Detenerse());
                Console.WriteLine("----------------------------------");
            }
            Console.ReadKey();
        }
        //comentario1
        public static int Corroborar1(string comando)
        {
            int valor;
            Console.WriteLine(comando);
            var numero = Console.ReadLine();
           
            while (!int.TryParse(numero, out valor) || int.Parse(numero) > 100 || int.Parse(numero) < 0)
            {             
                Console.WriteLine("Error!!! Configure correctamente los datos de entrada, intente de nuevo");
                Console.WriteLine(comando);
                numero = Console.ReadLine();             
            }
          
            return Int32.Parse(numero);
        }
       //comentario2
        public static int Corroborar2(string comando)
        {
            int valor;
            Console.WriteLine(comando);
            var numero = Console.ReadLine();          

            while (!int.TryParse(numero, out valor) || int.Parse(numero) < 0 || int.Parse(numero) > 4)
            {
                Console.WriteLine("Error!!! Configure correctamente los datos de entrada, intente de nuevo");
                Console.WriteLine(comando);
                numero = Console.ReadLine();
            }
            return Int32.Parse(numero);
        }
    }
}
