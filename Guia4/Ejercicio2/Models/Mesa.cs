using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Mesa:Producto
    {
        private double ancho;
        private double grosor;

        public Mesa(double precioBase,double largo,double ancho, double grosor): base(precioBase,largo)
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
            return Peso() * precioBase * 1.25;
        }

        public override string ToString()
        {
            return $"{this.Codigo}: Mesa de {this.largo} x {this.ancho}";
        }
    }
}
