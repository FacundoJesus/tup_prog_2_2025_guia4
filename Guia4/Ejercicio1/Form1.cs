using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnImportar.Enabled = false;
            btnExportar.Enabled = false;
        }


        Presupuesto presupuesto;

        private void btnIniciarPresupuesto_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;

            presupuesto = new Presupuesto(nombre, direccion);

            tbNombre.Enabled = false;
            tbDireccion.Enabled = false;
            lbNombre.Enabled = false;
            lbDireccion.Enabled = false;
        }

        private void btnCerrarPresupuesto_Click(object sender, EventArgs e)
        {
            if (presupuesto != null)
            {
                string[] lista = presupuesto.Resumen();

                FPresupuesto fPresupuesto = new FPresupuesto();

                fPresupuesto.lsbPresupuesto.Items.AddRange(lista);

                fPresupuesto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe crear un presupuesto.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precioBase = Convert.ToDouble(tbpBase.Text);
            double largo = Convert.ToDouble(tbLargo.Text);
            int codigo = Convert.ToInt32(tbCodigo.Text);

            Producto producto = null;
            if (rbBanco.Checked == true)
            {
                producto = new Banco(precioBase, largo);
                producto.Codigo = codigo;
                
            }
            else if (rbMesa.Checked == true)
            {
                double grosor = Convert.ToDouble(tbGrosor.Text);
                double ancho = Convert.ToDouble(tbAncho.Text);

                producto = new Mesa(ancho, grosor, precioBase, largo);
                producto.Codigo = codigo;
                              
            }
            
            presupuesto.AgregarProducto(producto);
            cmbProductos.Items.Add($"{producto.Codigo}");

            //Limpio campos
            rbBanco.Checked = false;
            rbMesa.Checked = false;
            tbpBase.Clear();
            tbLargo.Clear();
            tbCodigo.Clear();
            tbGrosor.Clear();
            tbAncho.Clear();
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {

            int idxSeleccionado = cmbProductos.SelectedIndex;

            if (idxSeleccionado != null)
            {
                int codigo = Convert.ToInt32(idxSeleccionado);
                presupuesto.QuitarProducto(codigo);

                cmbProductos.Items.Remove(cmbProductos.SelectedItem);
                cmbProductos.Text = "";

                MessageBox.Show("Producto borrado!");
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para borrar.");
            }
        }
    }
}
