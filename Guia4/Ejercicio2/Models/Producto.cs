using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public abstract class Producto:IComparable
    {
        protected double precioBase;
        protected double largo;

        private int codigo;
        public int Codigo {
            get { 
                return codigo; 
            } set {
                codigo = value; 
            } 
        }

        public Producto(double precioBase, double largo)
        {
            this.precioBase = precioBase;
            this.largo = largo;
        }

        public abstract double Peso();
        public abstract double Precio();

        public int CompareTo(object obj)
        {
            Producto nuevoProducto = obj as Producto;
            if(nuevoProducto != null) {
                return this.codigo.CompareTo(nuevoProducto.Codigo);
            }
            return -1;
        }
    }
}
