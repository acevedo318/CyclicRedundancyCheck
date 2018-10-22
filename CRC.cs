using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRedundancyCheck
{
    /// <summary>
    /// Detectar cambios accidentales en el canal de comunicacion
    /// </summary>
   class CRC
    {
    
        public String Datos { get; }
        public int longitudDatos { get; }
        public String PolinomioGenerador { get; }
        public int longitudPolinomioGenerador { get; }
        private int r = 0;
        public String DatosEmisor { get; set; }

        public CRC(String Datos,String PolinomioGenerador)
        {
            this.Datos = Datos;
            this.PolinomioGenerador = PolinomioGenerador;
            this.longitudDatos = this.Datos.Length;
            this.longitudPolinomioGenerador = PolinomioGenerador.Length;
            this.r = this.longitudPolinomioGenerador - 1;
            Emisor();
        }

        private string Emisor()
        {
            string datos = this.Datos;
            string emitido = "";
            

            for (int i = 0; i < this.r; i++)
            {
                datos = string.Concat(datos, "0");
            }

            emitido = Division(datos);

            Console.WriteLine(Xor('1', '0').ToString());
            

            return emitido;
        }

        /// <summary>
        /// XOR
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns></returns>
        private char Xor(char valor1,char valor2)
        {
            if (valor1.Equals(valor2))
            {
                return '0';
            }
            else
            {
                return '1';
            }

            
        }

        private string Division(string datos)
        {
            string residuo = "";

            for (int i = 0; i < datos.Length; i++)
            {
                residuo = string.Concat(residuo, datos[i]);

                if (residuo.Length == PolinomioGenerador.Length)
                {
                    string resultados = "";
                    for (int j = 0; j < residuo.Length; j++)
                    {
                        resultados = string.Concat(resultados, Xor(residuo[j], PolinomioGenerador[j]));

                    }
                    
                    resultados = Cortar(resultados);
                    
                    
                    residuo = resultados;
                    
                }
                
            }

            return residuo;
        }

        private string Cortar(string datos)
        {
            string data = string.Copy(datos);
            string valor = "";
            int j = 0;
            
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] == '0')
                {
                    
                    data = data.Substring(j+1);
                    
                }
                else
                {
                    
                    break;
                }
            }
            valor = data;

            return valor;
        }
     
    }

    
}
