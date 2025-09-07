using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Banco:Producto
    {
        public Banco(double precioBase,double largo):base(precioBase,largo) { }

        public override double Peso()
        {
            return (largo * 0.25) * 0.42;
        }

        public override double Precio()
        {
            return Peso() * precioBase * 1.15;
        }

        public override string ToString()
        {
            return $"Código:{this.Codigo} - Banco de {this.largo}";
        }

    }
}
