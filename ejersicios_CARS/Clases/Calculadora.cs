using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicios_CARS.Clases
{
    internal class Calculadora
    {
        public int opciones {get; set;}
        public int numero1 { get; set;}
        public int numero2 { get; set;}
        public int respuesta { get; set; }


        public string Operaciones(int numero1,int numero2,int opciones)
        {
            if (opciones == 1)
            {
                respuesta = numero1 + numero2;
                return "sumado es: "+Convert.ToInt32(respuesta);
            }
            else if (opciones == 2)
            {
                respuesta = numero1 - numero2;
                return "restado es: " + Convert.ToInt32(respuesta);
            }
            else if (opciones == 3)
            {
                respuesta = numero1 * numero2;
                return "multiplicado es: " + Convert.ToInt32(respuesta);
            }
            else if (opciones == 4)
            {
                respuesta = numero1 / numero2;
                return "dividido es: " + Convert.ToInt32(respuesta);
            }
            else
            {
                
                //problemas al convertir del int al string 
                return "ingrese un numero del 1 al 4";
            }
            
        }


    }
}
