using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Producto
    {
        protected double precioBase;
        protected double largo;

        
        private int codigo;

        public int Codigo { 
            get { return codigo; } 
            set { codigo = value;}
        }
        

        //public int Codigo { get; set; }

        public Producto(double precioBase, double largo)
        {
            this.precioBase = precioBase;
            this.largo = largo;
        }

        public abstract double Peso();

        public abstract double Precio();
    }
}
