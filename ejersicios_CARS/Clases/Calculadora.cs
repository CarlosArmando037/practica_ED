using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicios_CARS.Clases
{
    internal class Calculadora
    {
        public int opciones;
        public int numero1;
        public int numero2;

        public int Operaciones(int numero1,int numero2,int opciones)
        {
            int respuesta;

            if (opciones == 1)
            {
                respuesta = numero1 + numero2;
                return respuesta;
            }
            else if (opciones == 2)
            {
                respuesta = numero1 - numero2;
                return respuesta;
            }
            else if (opciones == 3)
            {
                respuesta = numero1 * numero2;
                return respuesta;
            }
            else if (opciones == 4)
            {
                respuesta = numero1 / numero2;
                return respuesta;
            }
            else
            {
                
                //problemas al convertir del int al string 
                return respuesta= 666666;
            }
            
        }


    }
}
