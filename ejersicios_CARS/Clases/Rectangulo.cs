using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicios_CARS.Clases
{
    internal class Rectangulo
    {

        public double rectanguloAltura;
        public double rectanguloBase;

        public double AreaTriangulo(double rectanguloAltura, double rectanguloBase)
        {
            double respuesta;

            respuesta = rectanguloAltura * rectanguloBase;

            return respuesta;
        }
    }
}
