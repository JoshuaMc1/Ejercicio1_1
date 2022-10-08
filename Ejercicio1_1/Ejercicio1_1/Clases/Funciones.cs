using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_1.Clases
{
    public class Funciones
    {
        public double n1 { get; set; }
        public double n2 { get; set; }
        public string resultado { get; set; }

        public Funciones(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public double sumar()
        {
            return n1 + n2;
        }

        public double restar()
        {
            return n1 - n2;
        }

        public double dividir()
        {
            return n1 / n2;
        }

        public double multiplicar()
        {
            return n1 * n2;
        }
    }
}
