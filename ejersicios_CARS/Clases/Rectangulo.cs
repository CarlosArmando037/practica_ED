using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicios_CARS.Clases
{
    internal class Rectangulo
    {

        public double rectanguloAltura { get; set; }
        public double rectanguloBase { get; set; }
        public double respuesta { get; set; }

        public double AreaTriangulo(double rectanguloAltura, double rectanguloBase)
        {

            respuesta = rectanguloAltura * rectanguloBase;

            return respuesta;
        }
    }
}
