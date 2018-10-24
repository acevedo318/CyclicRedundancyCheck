using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CyclicRedundancyCheck
{
    class Program
    {
        private static string polinomioGenerador = "1001";
        private static string datos = "101110";

        static void Main(string[] args)
        {
            Console.Title = "CRC";

            CRC A = new CRC(datos, polinomioGenerador);

            Console.WriteLine("datos: "+A.Datos);
            Console.WriteLine("Polinomio Generador: "+A.PolinomioGenerador);
            Console.WriteLine("Datos emitidos: "+A.DatosEmisor);
            Console.WriteLine("Datos Correctos en Receptor: "+ A.Receptor);


            Console.Read();
        }
    }
}
