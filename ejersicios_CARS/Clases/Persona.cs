using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicios_CARS.Clases
{
    public class Persona
    {
        public int Edad;
        public string Nombre;
        public string resultado;

        public string InfoPersona(string Nombre, int Edad)
        {

            resultado = Nombre + Edad;
            return resultado;
        }
    }
}
