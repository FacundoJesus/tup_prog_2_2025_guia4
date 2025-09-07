using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Presupuesto
    {
        public double Precio {  get; set; }

        private ArrayList listaProductos = new ArrayList();
        private Cliente cliente;
        
        public Presupuesto(string nombre, string direccion)
        {
            cliente = new Cliente(nombre, direccion);
        }

        public void AgregarProducto(Producto producto)
        {
            listaProductos.Add(producto);
            Precio += producto.Precio();
        }

        public bool QuitarProducto(int codigo)
        {
            //Verificar si existe
            Producto productoBuscado = BuscarProducto(codigo);

            bool ret = false;
            //Quitar
            if(productoBuscado != null) {
                listaProductos.Remove(productoBuscado);
                Precio -= productoBuscado.Precio();
                ret = true;
            }
            return ret;
        }

        private Producto BuscarProducto(int codigo)
        {
            Producto producto = null;
            int i = 0;
            int pos = -1;
            while(pos == -1 &&  i < listaProductos.Count) {
                if (((Producto)listaProductos[i]).Codigo == codigo) //Casteo del tipo Producto xq es un ArrayList.
                {
                    pos = i;
                }
                i++;
            }
            if(pos !=-1)
            {
                producto = listaProductos[pos] as Producto;
            }
            return producto;
        }

        public string[] Resumen()
        {
            string[] resumen = new string[listaProductos.Count + 2];

            int n = 0;
            resumen[n++] = cliente.ToString();
            foreach (Producto p in listaProductos)
            {
                resumen[n++] = $"Código:{p.Codigo} - Peso: {p.Peso():f2}kg - Precio: ${p.Precio():f2}";
            }
            resumen[n++] = $"Total: ${Precio:f2}";
            return resumen;
        }



    }
}
