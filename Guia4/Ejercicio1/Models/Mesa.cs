using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Mesa : Producto
    {
        private double ancho;
        private double grosor;

        public Mesa(double ancho, double grosor, double precioBase, double largo):base(precioBase, largo)
        {
            this.ancho = ancho;
            this.grosor = grosor;
        }
        public override double Peso()
        {
            
            return (this.largo * this.ancho * this.grosor) * 0.3;
        }

        public override double Precio()
        {
            
            return Peso() * this.precioBase * 1.25;
        }
    }
}
