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
            
            CRC A = new CRC(datos, polinomioGenerador);
            

            Console.Read();
        }
    }
}
