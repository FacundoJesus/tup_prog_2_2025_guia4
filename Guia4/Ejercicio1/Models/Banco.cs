using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Banco : Producto
    {
        public Banco(double precioBase, double largo):base(precioBase, largo) {}

        public override double Peso()
        {
            
            return (this.largo * 0.25) * 0.42;
        }

        public override double Precio()
        {      
            return Peso() * this.precioBase * 1.15;
        }

    }
}
