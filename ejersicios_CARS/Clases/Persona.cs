using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicios_CARS.Clases
{
    public class Persona
    {
        public int Edad { get; set ; }
        public string Nombre { get; set; }
        public string resultado { get; set; }

        public string InfoPersona(string Nombre, int Edad)
        {

            resultado = $"{Nombre} con edad de: { Edad}";
            return resultado;
        }
    }
}
