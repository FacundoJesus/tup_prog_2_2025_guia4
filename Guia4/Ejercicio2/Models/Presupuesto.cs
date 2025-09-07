using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Presupuesto
    {

        public double Precio
        {
            get
            {
                double total = 0;
                foreach (Producto p in listaProductos)
                {
                    total += p.Precio();//polimorfismo
                }
                return total;
            }
            private set { Precio = value; }
            
        }

        private Cliente solicitante;
        private ArrayList listaProductos = new ArrayList();

        public Presupuesto(string nombre, string direccion) {

            solicitante = new Cliente(nombre, direccion);
        }

        public void AgregarProducto(Producto unProducto)
        { 
            listaProductos.Add(unProducto);
            //Precio += unProducto.Precio();
        }

        public bool QuitarProducto(int codigo)
        {
            Producto producto = BuscarProducto(codigo);

            bool ret = false;
            if (producto != null) {
                listaProductos.Remove(producto);
                //Precio-= producto.Precio();
                ret = true;
            }
            return ret;
        }

        private Producto BuscarProducto(int codigo)
        {
            listaProductos.Sort(); // Ordeno

            Producto p = new Banco(0, 0); // Defino e Instancio un producto ya sea Mesa o Banco.
            p.Codigo = codigo; // Le asigno el código a buscar

            int idx = listaProductos.BinarySearch(p); // Obtengo el índice del producto. (-1 si no existe)

            
            if (idx > -1)
            {
                return (Producto)listaProductos[idx];
            }
            return null;
        }

        public string[] Resumen()
        {
            string[] resumen = new string[listaProductos.Count+2];

            int i = 0;
            resumen[i++] = solicitante.ToString();
            foreach(Producto producto in listaProductos)
            {
                resumen[i++] = $"Código: {producto.Codigo} - Peso: {producto.Peso():f2}kg - Precio: ${producto.Precio():f2}";
            }
            resumen[i++] = $"Precio Final: ${Precio:f2}";
            return resumen;
        }


    }
}
